using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;

namespace reenbitChat.Domain.Abstraction;

public interface IUsersService
{
    Task<UserDto> GetUserById(int userId);
    Task SaveReadMessages(MessagesReadDto dto);
}
