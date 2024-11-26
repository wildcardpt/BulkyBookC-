﻿using BulkyBookC_.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookC_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
          
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Drama", DisplayOrder = 1 },
                new Category { Id = 3, Name = "Horror", DisplayOrder = 1 },
                new Category { Id = 4, Name = "Fiction", DisplayOrder = 1 }
                );
        }
    }
}
