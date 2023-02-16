using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;
using reenbitChat.Domain.Abstraction;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.AuthorizationDtos;

namespace reenbitChat.BLL.Services.Implementation;

public class MessagesService : BaseService, IMessagesService
{
    public MessagesService(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub) : base(context, mapper, hub)
    {
    }

    public async Task DeleteMessage(int id, bool isDeleteOnlyForSender)
    {
        var messageToDelete = await _context.Set<Message>()
            .FirstAsync(x => x.Id == id);
        if (isDeleteOnlyForSender)
        {
            messageToDelete.IsDeletedOnlyForSender = true;
        }
        else
        {
            _context.Set<Message>().Remove(messageToDelete);
        }

        await _context.SaveChangesAsync();
        if (isDeleteOnlyForSender == false)
        {
            await _hub.Clients
                .Group(messageToDelete.ChatId.ToString())
                .SendAsync("MessageDeleted", _mapper.Map<MessageDto>(messageToDelete));
        }
    }

    public async Task EditMessage(EditMessageDto dto)
    {
        var messageToEdit = await _context.Set<Message>()
            .FirstAsync(x => x.Id == dto.MessageId);

        messageToEdit.Text = dto.EditedText;
        messageToEdit.IsEdited = true;
        await _hub.Clients
            .Group(messageToEdit.ChatId.ToString())
            .SendAsync("MessageEdited", _mapper.Map<MessageDto>(messageToEdit));
        await _context.SaveChangesAsync();
    }

    public async Task SendMessage(NewMessageDto dto)
    {
        try
        {
            var replyMessage = dto.ReplyMessage;
            var message = _mapper.Map<Message>(dto);
            message.ReplyMessage = null!;
            var sender = message.Sender;
            message.Sender = null;
            await _context.Set<Message>().AddAsync(message);
            await _context.SaveChangesAsync();

            message.Sender = sender;
            var messageDto = _mapper.Map<MessageDto>(message);
            messageDto.ReplyMessage = replyMessage;
            await _hub.Clients
                .Group(message.ChatId.ToString())
                .SendAsync("MessageSent", messageDto);
        }
        catch (Exception ex)
        {
            var me = ex.Message;
            throw;
        }
    }
}
