using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;

namespace reenbitChat.BLL.Services.Abstraction;

public interface IChatService
{
    Task<UserDto> GetRandomUser();
    IAsyncEnumerable<ChatDto> GetUserChats(int userId);
    Task<IEnumerable<MessageDto>> GetChatMessages(int chatId,int userId,
        int pageNumber, int messagesInPage);
    ChatDto GetPrivateChat(int firstUserId, int secondUserId);
}
