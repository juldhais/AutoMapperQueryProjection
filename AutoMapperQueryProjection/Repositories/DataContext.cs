using AutoMapperQueryProjection.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperQueryProjection.Repositories;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData
        (
            new Country
            {
                Id = 1,
                Code = "INA",
                Name = "Indonesia"
            },
            new Country
            {
                Id = 2,
                Code = "JPN",
                Name = "Japan"
            }
        );

        modelBuilder.Entity<Job>().HasData
        (
            new Job
            {
                Id = 1,
                Name = "Programmer"
            },
            new Job
            {
                Id = 2,
                Name = "Ninja"
            }
        );

        modelBuilder.Entity<Person>().HasData
        (
            new Person
            {
                Id = 1,
                Name = "Juldhais Hengkyawan",
                CountryId = 1,
                JobId = 1
            },
            new Person
            {
                Id = 2,
                Name = "Naruto Uzumaki",
                CountryId = 2,
                JobId = 2
            }
        );
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Person> Person { get; set; }
    public DbSet<Country> Country { get; set; }
    public DbSet<Job> Job { get; set; }
}