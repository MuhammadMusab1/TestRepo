#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject.Data
{
    public class TestProjectContext : DbContext
    {
        public TestProjectContext (DbContextOptions<TestProjectContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Journal> Journal { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
