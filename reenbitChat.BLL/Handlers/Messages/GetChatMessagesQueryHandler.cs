using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Queries;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.DAL.Context;

namespace reenbitChat.BLL.Handlers;

public class GetChatMessagesQueryHandler : IRequestHandler<GetChatMessagesQuery, IEnumerable<MessageDto>>
{
    private readonly ChatContext _context;
    private readonly IMapper _mapper;
    public GetChatMessagesQueryHandler(ChatContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<MessageDto>> Handle(GetChatMessagesQuery request, CancellationToken cancellationToken)
    {
        var chat = await _context.Chats
        .Include(x => x.Messages)
            .ThenInclude(x => x.Sender)
        .FirstAsync(x => x.Id == request.ChatId, cancellationToken);

        var messages = chat.Messages;
        var messagesToSkip = request.MessagesInPage * request.PageNumber;
        if (messages.Count <= messagesToSkip)
        {
            return Enumerable.Empty<MessageDto>();
        }

        return messages
            .Where(x => x.SenderId != request.UserId || x.IsDeletedOnlyForSender == false)
            .OrderBy(x => x.SentAt)
            .Skip(messagesToSkip)
            .Take(request.MessagesInPage)
            .Select(x => _mapper.Map<MessageDto>(x));
    }
}
