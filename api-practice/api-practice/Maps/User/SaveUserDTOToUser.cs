using ApiPractice.DTOs.User;
using AutoMapper;

namespace ApiPractice.Maps.User
{
    public class SaveUserDTOToUser : Profile
    {
        public SaveUserDTOToUser()
        {
            CreateMap<SaveUserDTO, Entities.User.User>();
        }
    }
}
