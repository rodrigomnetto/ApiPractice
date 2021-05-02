using System.ComponentModel.DataAnnotations;

namespace ApiPractice.Entities.Favorite
{
    public class FavoriteCharacter
    {
        public long Id { get; set; }

        [Required]
        public User.User User { get; set; }

        [Required]
        public Character.Character Character { get; set; }
    }
}
