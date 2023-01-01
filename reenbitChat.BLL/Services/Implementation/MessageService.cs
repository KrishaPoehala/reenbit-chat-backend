using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Hubs;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities.Messages;
using reenbitChat.Domain.Abstraction;
using System.Diagnostics;

namespace reenbitChat.BLL.Services.Implementation;

public class MessageService : BaseService, IMessageService
{
    public MessageService(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub) : base(context, mapper, hub)
    {
    }

    public async Task DeleteMessage(int id, bool isDeleteOnlyForSender)
    {
        var messageToDelete = await _context.Messages
            .FirstAsync(x => x.Id == id);
        if (isDeleteOnlyForSender)
        {
            messageToDelete.IsDeletedOnlyForSender = true;
        }
        else
        {
            _context.Messages.Remove(messageToDelete);
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
        var messageToEdit = await _context.Messages
            .FirstAsync(x => x.Id == dto.MessageId);

        messageToEdit.Text = dto.EditedText;
        await _context.SaveChangesAsync();
        await _hub.Clients
            .Group(messageToEdit.ChatId.ToString())
            .SendAsync("MessageEdited", _mapper.Map<MessageDto>(messageToEdit));
    }

    public async Task SendMessage(NewMessageDto dto)
    {
        dto.Sender.Contacts = null;
        var message = _mapper.Map<GroupMessage>(dto);
        var sender = message.Sender;
        message.Sender = null;
        await _context.Messages.AddAsync(message);
        await _context.SaveChangesAsync();

        message.Sender = sender;
        var messageDto = _mapper.Map<MessageDto>(message);
        await _hub.Clients
            .Group(message.ChatId.ToString())
            .SendAsync("MessageSent", messageDto);
    }

    public async Task SendPrivateMessage(NewPrivateMessageDto messageDto)
    {
        var senderDto = messageDto.Sender;
        var receiverDto = messageDto.Receiver;
        messageDto.Sender = null;
        messageDto.Receiver = null;
        var message = _mapper.Map<PrivateMessage>(messageDto);
        _context.Set<PrivateMessage>().Add(message);
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }   
        var privateMessageDto = _mapper.Map<PrivateMessageDto>(message);
        privateMessageDto.Sender = senderDto;
        privateMessageDto.Reveiver = receiverDto;
        await _hub.Clients.Group(GetGroupName(message.SenderId, message.ReceiverId))
            .SendAsync("PrivateMessageSent", privateMessageDto);
    }

    private string GetGroupName(int leftId, int rightId)
    {
        if (leftId < rightId)
        {
            return leftId.ToString() + "/" + rightId.ToString();
        }

        return rightId.ToString() + "/" + leftId.ToString();
    }

}
