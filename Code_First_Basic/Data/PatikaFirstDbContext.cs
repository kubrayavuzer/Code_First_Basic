using Code_First_Basic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {

        }

        public List<GameEntity> Games { get; set; }

        public List<MovieEntity> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameEntity>(entity =>
            {
                entity.ToTable("Games");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
                entity.Property(x => x.Platform).IsRequired();
                entity.Property(x => x.Rating).IsRequired();

            });

            modelBuilder.Entity<MovieEntity>(entity =>
            {
                entity.ToTable("Movies");
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Title).IsRequired().HasMaxLength(50);
                entity.Property(x => x.Genre).IsRequired().HasMaxLength(50);
            });
        }

    }
}