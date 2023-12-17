using AutoMapper;
using SwiftBankApi.Application.Features.User.Commands.User;
using SwiftBankApi.Application.Features.User.Queries.User.GetAllUsers;
using SwiftBankApi.Domain;

namespace SwiftBankApi.Application.MappingProfiles;

public class AutomapperProfiles: Profile
{
    public AutomapperProfiles()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<CreateUserDto, User>().ReverseMap();
        CreateMap<UpdateUserDto, User>();
    }
}