using BoardDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardDatabaseImplement
{
    public class AdBoardDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=192.168.1.72;Database=taskManager;Username=postgres;Password=123456");
            }
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Favorites> Favorites { get; set; }
        public virtual DbSet<Balance> Balance { get; set; }
    }
}
