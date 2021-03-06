﻿using System;
using AppTaxi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppTaxi
{
    public partial class TaxiContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Taxista> Taxistas { get; set; }
        public DbSet<Corrida> Corridas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=poilkj;Database=taxi");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
