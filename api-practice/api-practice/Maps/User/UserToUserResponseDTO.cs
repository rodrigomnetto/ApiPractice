using ApiPractice.DTOs.User;
using AutoMapper;

namespace ApiPractice.Maps.User
{
    public class UserToUserResponseDTO : Profile
    {
        public UserToUserResponseDTO()
        {
            CreateMap<Entities.User.User, UserResponseDTO>();
        }
    }
}
