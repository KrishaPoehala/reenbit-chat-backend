using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Factories;

public interface IMemberFactory
{
    ChatMember CreateGroupMember(User user, int chatId);
    ChatMember CreateGroupAdmin(User user, int chatId);
    ChatMember CreateGroupOwner(User user, int chatId);
    ChatMember CreatePrivateChatMember(User user, int chatId);
}
