﻿using EiSys.CleanArchitecture.DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EiSys.CleanArchitecture.InfrastructureLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
