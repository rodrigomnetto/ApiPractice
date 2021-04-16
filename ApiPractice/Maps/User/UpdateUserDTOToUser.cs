using ApiPractice.DTOs.User;
using AutoMapper;

namespace ApiPractice.Maps.User
{
    public class UpdateUserDTOToUser : Profile
    {
        public UpdateUserDTOToUser()
        {
            CreateMap<UpdateUserDTO, Entities.User.User>();
        }
    }
}
