using AutoMapper;
using SwiftBank.Application.Features.User.Commands.CreateUser;
using SwiftBank.Application.Features.User.Commands.UpdateUser;
using SwiftBank.Application.Features.User.Queries.GetAllUsers;
using SwiftBank.Domain.Entities;

namespace SwiftBank.Application.MappingProfiles;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        // user mapping
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<CreateUserDto, User>().ReverseMap();
        CreateMap<UpdateUserDto, User>();
    }
}
