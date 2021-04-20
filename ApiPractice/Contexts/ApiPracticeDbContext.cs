using ApiPractice.Entities.Character;
using ApiPractice.Entities.Favorite;
using ApiPractice.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace ApiPractice.Contexts
{
    public class ApiPracticeDbContext : DbContext
    {
        public ApiPracticeDbContext(DbContextOptions<ApiPracticeDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<FavoriteCharacter> FavoriteCharacters { get; set; }
    }
}
