﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Persistance.Contexts;

namespace Persistance
{
    public class DesignTimeDbContext : IDesignTimeDbContextFactory<ProjectDbContext>
    {

        public ProjectDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ProjectDbContext> dbContextOptions = new();
            dbContextOptions.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=VillaDb;");
            return new(dbContextOptions.Options);
        }
    }
}

