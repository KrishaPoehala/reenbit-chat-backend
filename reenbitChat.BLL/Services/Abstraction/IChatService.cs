using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Context;
using reenbitChat.DAL.Entities;

namespace reenbitChat.BLL.Services.Abstraction;

public interface IChatService
{
    Task<UserDto> GetRandomUser();
    Task SendMessage(NewMessageDto message);
    IAsyncEnumerable<ChatDto> GetUserChats(int userId);
    Task<IEnumerable<MessageDto>> GetChatMessages(int chatId,int userId,
        int pageNumber, int messagesInPage);
    Task EditMessage(EditMessageDto dto);
    Task DeleteMessage(int id, bool isDeleteOnlyForSender);
    Task<IEnumerable<Chat>> DeleteAll();
}
