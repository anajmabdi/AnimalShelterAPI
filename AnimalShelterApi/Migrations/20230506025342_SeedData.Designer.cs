﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230506025342_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Breed = "Tuxedo",
                            Gender = "Female",
                            Name = "Oreo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 5,
                            Breed = "Tabby",
                            Gender = "Male",
                            Name = "Mr.Mittens",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 6,
                            Breed = "Calico",
                            Gender = "Female",
                            Name = "Patchouli",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Great Pyrenees",
                            Gender = "Male",
                            Name = "Electra",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 12,
                            Breed = "German Shepherd",
                            Gender = "Male",
                            Name = "Bentley",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 7,
                            Breed = "Beagle",
                            Gender = "Female",
                            Name = "KitKat",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
