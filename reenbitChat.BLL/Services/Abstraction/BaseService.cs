using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using reenbitChat.BLL.Hubs;
using reenbitChat.DAL.Context;

namespace reenbitChat.BLL.Services.Abstraction;

public abstract class BaseService
{
    protected readonly ChatContext _context;
    protected readonly IMapper _mapper;
    protected readonly IHubContext<ChatHub> _hub;

    protected BaseService(ChatContext context, IMapper mapper, IHubContext<ChatHub> hub)
    {
        _context = context;
        _mapper = mapper;
        _hub = hub;
    }
}
