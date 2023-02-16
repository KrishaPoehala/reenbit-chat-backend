using AutoMapper;
using reenbitChat.Common.Dtos.AuthorizationDtos;
using reenbitChat.Common.Dtos.ChatDtos;
using reenbitChat.Common.Dtos.MessageDtos;
using reenbitChat.Common.Dtos.UserDtos;
using reenbitChat.DAL.Entities;

namespace reenbitChat.DAL.Profiles;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(x => x.Email, opt => opt.MapFrom(x => x.NormalizedEmail))
            .ForMember(x => x.Name, opt => opt.MapFrom(x => x.UserName));

        CreateMap<UserDto, User>().ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Name));

        CreateMap<RegisterUserDto, User>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.FirstName))
            .ForMember(x => x.NormalizedEmail, opt => opt.MapFrom(x => x.Email));

        CreateMap<NewMessageDto, Message>()
            .ForMember(x => x.Sender, opt => opt.MapFrom(x => x.Sender))
            .ForMember(x => x.SenderId, opt => opt.MapFrom(x => x.Sender.Id));
        CreateMap<Message, MessageDto>().ReverseMap();
        CreateMap<NewChatDto, Chat>().ReverseMap();
        CreateMap<Chat, ChatDto>().ReverseMap();
        CreateMap<Role, RoleDto>().ReverseMap();
        CreateMap<Permission, PermissionDto>().ReverseMap();
        CreateMap<ChatMember, ChatMemberDto>().ReverseMap()
            .ForMember(x => x.UserId, opt => opt.MapFrom(x => x.User.Id));
    }

}
