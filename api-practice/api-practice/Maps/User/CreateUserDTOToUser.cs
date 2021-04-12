using ApiPractice.DTOs.User;
using AutoMapper;

namespace ApiPractice.Maps.User
{
    public class CreateUserDTOToUser : Profile
    {
        public CreateUserDTOToUser()
        {
            CreateMap<CreateUserDTO, Entities.User.User>();
        }
    }
}
