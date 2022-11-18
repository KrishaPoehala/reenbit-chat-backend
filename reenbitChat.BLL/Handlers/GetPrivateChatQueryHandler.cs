
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Queries;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.DAL.Context;

namespace reenbitChat.BLL.Handlers;

public class GetPrivateChatQueryHandler : IRequestHandler<GetPrivateChatQuery, ChatDto>
{
    private readonly ChatContext _context;
    private readonly IMapper _mapper;
    public GetPrivateChatQueryHandler(ChatContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ChatDto> Handle(GetPrivateChatQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Users
                    .FirstAsync(x => x.Id == request.FirstUserId);
        var privateChats = user.Chats.Where(x => x.IsGroup == false);
        var chat = privateChats.First(x => x.Members.Any(x => x.Id == request.SecondUserId));
        return _mapper.Map<ChatDto>(chat);
    }
}
