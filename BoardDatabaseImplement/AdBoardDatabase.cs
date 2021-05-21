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
                optionsBuilder.UseNpgsql("Host=192.168.0.1;Database=db_board;Username=postgres;Password=12345678");
            }
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Favorites> Favorites { get; set; }
        public virtual DbSet<Balance> Balance { get; set; }
    }
}
