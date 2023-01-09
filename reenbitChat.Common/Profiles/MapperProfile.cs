using AutoMapper;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Entities;

namespace reenbitChat.Common.Profiles;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(x => x.Email, opt => opt.MapFrom(x => x.NormalizedEmail))
            .ForMember(x => x.Name, opt => opt.MapFrom(x => x.UserName));

        CreateMap<UserDto, User>().ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Name));

        CreateMap<RegisterUserDto, User>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.FirstName));

        CreateMap<NewMessageDto, Message>();
        CreateMap<Message, MessageDto>().ReverseMap();
        CreateMap<NewChatDto, Chat>();

        CreateMap<Chat, ChatDto>();
    }
}
