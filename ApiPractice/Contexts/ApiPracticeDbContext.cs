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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnCreateUsersModel(modelBuilder);
            OnCreateCharactersModel(modelBuilder);
            OnCreateFavoriteCharactersModel(modelBuilder);
        }

        private void OnCreateUsersModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("users");

            modelBuilder.Entity<User>()
                .Property(p => p.Id)
                .HasColumnName("id");

            modelBuilder.Entity<User>()
                .Property(p => p.Email)
                .HasColumnName("email");

            modelBuilder.Entity<User>()
                .Property(p => p.Name)
                .HasColumnName("name");

            modelBuilder.Entity<User>()
                .Property(p => p.Password)
                .HasColumnName("password");
        }

        private void OnCreateCharactersModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .ToTable("characters");

            modelBuilder.Entity<Character>()
                .Property(p => p.Id)
                .HasColumnName("id");

            modelBuilder.Entity<Character>()
                .Property(p => p.Name)
                .HasColumnName("name");

            modelBuilder.Entity<Character>()
                .Property(p => p.Description)
                .HasColumnName("description");
        }

        private void OnCreateFavoriteCharactersModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FavoriteCharacter>()
                .ToTable("favorite_characters");

            modelBuilder.Entity<FavoriteCharacter>()
                .Property(p => p.Id)
                .HasColumnName("id");

            modelBuilder.Entity<FavoriteCharacter>()
                .Navigation(f => f.User)
                .AutoInclude()
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<FavoriteCharacter>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey("user_id");

            modelBuilder.Entity<FavoriteCharacter>()
                .Navigation(f => f.Character)
                .AutoInclude()
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<FavoriteCharacter>()
                .HasOne(f => f.Character)
                .WithMany()
                .HasForeignKey("character_id");
        }
    }
}
