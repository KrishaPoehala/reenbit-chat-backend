using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.ChatDtos;

namespace reenbitChat.Domain.Abstraction;

public interface IChatsService
{
    Task<IEnumerable<ChatDto>> GetUserChats(int userId);
    Task<IEnumerable<MessageDto>> GetChatMessages(int chatId, int userId,
        int pageNumber, int messagesInPage);
    Task<ChatDto> CreateGroup(NewChatDto dto);
    Task<ChatDto> CreatePrivateChat(NewPrivateChatDto dto);
    Task<IEnumerable<ChatDto>> GetPublicGroups(int userId);
}
