﻿using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryManagementSystemWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
