using reenbitChat.Common.Dtos.MessageDtos;

namespace reenbitChat.BLL.Services.Abstraction;

public interface IMessageService
{
    Task SendMessage(NewMessageDto message);
    Task EditMessage(EditMessageDto dto);
    Task DeleteMessage(int id, bool isDeleteOnlyForSender);
}
