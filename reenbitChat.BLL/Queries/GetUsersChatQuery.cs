using MediatR;
using reenbitChat.Common.Dtos.ChatDtos;

namespace reenbitChat.BLL.Queries;

public record GetUsersChatQuery(int UserId) : IRequest<IEnumerable<ChatDto>>;
