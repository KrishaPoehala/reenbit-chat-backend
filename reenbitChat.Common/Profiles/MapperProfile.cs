using AutoMapper;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Entities;
using reenbitChat.DAL.Entities.Messages;

namespace reenbitChat.Common.Profiles;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(x => x.Email, opt => opt.MapFrom(x => x.NormalizedEmail))
            .ForMember(x => x.Contacts, opt => opt.MapFrom(x => x.Contacts.Select(x =>
            x.ContactUser)));

        CreateMap<UserDto, User>();
        CreateMap<User, ContactDto>().ForMember(x => x.Receiver, opt => opt.MapFrom(x => x));

        CreateMap<RegisterUserDto, User>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.FirstName));

        CreateMap<NewMessageDto, GroupMessage>();
        CreateMap<GroupMessage, MessageDto>().ReverseMap();


        CreateMap<NewPrivateMessageDto, PrivateMessage>();
        CreateMap<PrivateMessageDto, PrivateMessage>().ReverseMap();
        CreateMap<Chat, ChatDto>();
    }
}
