using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Entities;

namespace reenbitChat.BLL.Services.Abstraction;

public interface IPrivateChatService
{
    bool DoesPrivateChatExist(int firstUserId, int secondUserId);
    Task CreatePrivateChat(User firstUser, User secondUser);
    Task CreateEveryPrivateChat(int userId); // I know this is stupid and uneffective
                                            // but that's just a demo, so don't judge me(
}
