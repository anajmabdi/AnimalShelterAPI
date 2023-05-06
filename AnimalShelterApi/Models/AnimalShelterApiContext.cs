using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Oreo", Species = "Cat", Breed = "Tuxedo", Age = 2, Gender = "Female"},
          new Animal { AnimalId = 2, Name = "Mr.Mittens", Species = "Cat", Breed = "Tabby", Age = 5, Gender = "Male"},
          new Animal { AnimalId = 3, Name = "Patchouli", Species = "Cat", Breed = "Calico", Age = 6, Gender = "Female"},
          new Animal { AnimalId = 4, Name = "Electra", Species = "Dog", Breed = "Great Pyrenees", Age = 4, Gender = "Male"},
          new Animal { AnimalId = 5, Name = "Bentley", Species = "Dog", Breed = "German Shepherd", Age = 12, Gender = "Male"},
          new Animal { AnimalId = 6, Name = "KitKat", Species = "Dog", Breed = "Beagle", Age = 7, Gender = "Female"}
        );
    }

  }
}