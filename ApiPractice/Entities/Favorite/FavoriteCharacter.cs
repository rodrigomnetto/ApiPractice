using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPractice.Entities.Favorite
{
    [Table("favorite_characters")]
    public class FavoriteCharacter
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        public User.User User { get; set; }

        public Character.Character Character { get; set; }

        [Column("character_id")]
        public long CharacterId { get; set; }
    }
}
