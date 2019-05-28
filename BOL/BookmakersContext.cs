using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;
using Microsoft.EntityFrameworkCore;

namespace BOL
{
    public sealed class BookmakersContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public BookmakersContext(DbContextOptions<BookmakersContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
