using MediatR;
using reenbitChat.Common.Dtos.ChatDtos;

namespace reenbitChat.BLL.Queries;

public record GetPrivateChatQuery(int FirstUserId, int SecondUserId) : IRequest<ChatDto>;
