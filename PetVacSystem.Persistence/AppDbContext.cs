using Microsoft.EntityFrameworkCore;
using PetVacSystem.Domain.Entities;

namespace PetVacSystem.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Pet> Pets { get; set; } = default!;
        public DbSet<Vaccine> Vaccines { get; set; } = default!;
        public DbSet<RecordVaccine> RecordsVaccine { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //User
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(i => i.Id);
                entity.Property(i => i.Nome).IsRequired().HasMaxLength(100);
                entity.Property(i => i.Email).IsRequired().HasMaxLength(150);
                entity.Property(i => i.Tel).IsRequired().HasMaxLength(12);
                entity.Property(i => i.password).IsRequired().HasMaxLength(32);
            });

            //Pet
            modelBuilder.Entity<Pet>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.NomePet).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Raca).IsRequired().HasMaxLength(25);

                //Relacionamento Dono - Pet;

                entity.HasOne(p => p.Dono)
                    .WithMany(u => u.Pets)
                    .HasForeignKey(p => p.DonoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            //Vaccine
            modelBuilder.Entity<Vaccine>(entity =>
            {
                entity.HasKey(v => v.Id);
                entity.Property(v => v.NomeVacina).IsRequired().HasMaxLength(100);
                entity.Property(v => v.DescricaoVacina).IsRequired().HasMaxLength(300);
                entity.Property(v => v.NovaAplicacao).IsRequired();

            });

            //RecordVaccine
            modelBuilder.Entity<RecordVaccine>(entity =>
            {
                entity.HasKey(vr => vr.Id);
                entity.Property(vr => vr.DataAplicacao).IsRequired();
                entity.Property(vr => vr.NomeVet).IsRequired().HasMaxLength(100);

                entity.HasOne(vr => vr.Pet)
                    .WithMany(p => p.RecordsVaccine)
                    .HasForeignKey(vr => vr.PetId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(vr => vr.Vaccine)
                    .WithMany(v => v.RecordsVaccine)
                    .HasForeignKey(vr => vr.VacinaId)
                    .OnDelete(DeleteBehavior.Cascade);

            });

        }
        
    }
}