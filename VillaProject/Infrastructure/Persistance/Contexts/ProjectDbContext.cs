using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Contexts
{
	public class ProjectDbContext : DbContext
	{
        public ProjectDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}

