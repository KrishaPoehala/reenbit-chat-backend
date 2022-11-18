using MediatR;
using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.BLL.Queries;

public record GetChatMessagesQuery(int ChatId, int UserId, int PageNumber, int MessagesInPage) : 
    IRequest<IEnumerable<MessageDto>>;