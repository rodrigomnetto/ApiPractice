using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPractice.Entities.User
{
    [Table("users")]
    public class User
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("email")]
        [Required]
        public string Email { get; set; }

        [Column("password")]
        [Required]
        public string Password { get; set; }
    }
}
