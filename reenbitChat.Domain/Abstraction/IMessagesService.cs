using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.Domain.Abstraction;
public interface IMessagesService
{
    Task SendMessage(NewMessageDto message);
    Task EditMessage(EditMessageDto dto);
    Task DeleteMessage(int id, bool isDeletedOnlyForSender);
}
