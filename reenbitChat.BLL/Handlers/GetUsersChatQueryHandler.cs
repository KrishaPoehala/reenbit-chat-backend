using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using reenbitChat.BLL.Queries;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.DAL.Context;

namespace reenbitChat.BLL.Handlers;

public class GetUsersChatQueryHandler : IRequestHandler<GetUsersChatQuery, IEnumerable<ChatDto>>
{
    private readonly ChatContext _context;
    private readonly IMapper _mapper;
    public GetUsersChatQueryHandler(ChatContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ChatDto>> Handle(GetUsersChatQuery request, CancellationToken cancellationToken)
    {
        var chats = await _context.Chats
            .Include(x => x.Members)
            .Where(x => x.Members.Any(x => x.Id == request.UserId))
            .ToListAsync(cancellationToken);

        return chats.Select(x => _mapper.Map<ChatDto>(x));
    }
}
