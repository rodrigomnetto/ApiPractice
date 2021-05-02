using ApiPractice.DTOs.Favorite;
using ApiPractice.Entities.Favorite;
using ApiPractice.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ApiPractice.Maps.Favorite.PropertyResolver
{
    public class UserResolver : IValueResolver<CreateFavoriteCharacterDTO, FavoriteCharacter, Entities.User.User>
    {
        private IUserService _userService;
        private IHttpContextAccessor _httpContextAccessor;

        public UserResolver(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        public Entities.User.User Resolve(CreateFavoriteCharacterDTO source, FavoriteCharacter destination, Entities.User.User destMember, ResolutionContext context)
        {
            return _userService.FindByEmail(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value);
        }
    }
}
