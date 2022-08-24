using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Entities;

namespace reenbitChat.BLL.Services.Abstraction;

public interface IPrivateChatService
{
    bool DoesPrivateChatExist(int firstUserId, int secondUserId);
    Task CreatePrivateChat(User firstUser, User secondUser);
    Task CreateEveryPrivateChat(int userId);
    Task<ChatDto> CreatePrivatChat(int firstUserId, int secondUserId);
    ChatDto GetPrivateChat(int firstUserId, int secondUserId);
}
