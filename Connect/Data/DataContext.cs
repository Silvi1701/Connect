using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect.Entities;
using Microsoft.EntityFrameworkCore;

namespace Connect.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}