using System.ComponentModel.DataAnnotations;

namespace ApiPractice.Entities.Character
{
    public class Character
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
