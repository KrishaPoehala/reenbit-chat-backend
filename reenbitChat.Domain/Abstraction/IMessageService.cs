using reenbitChat.Common.Dtos.MessageDtos;
namespace reenbitChat.Domain.Abstraction;
public interface IMessageService
{
    Task SendMessage(NewMessageDto message);
    Task EditMessage(EditMessageDto dto);
    Task DeleteMessage(int id, bool isDeleteOnlyForSender);
    Task SendPrivateMessage(NewPrivateMessageDto message);
}
