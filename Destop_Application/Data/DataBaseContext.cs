using Destop_Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destop_Application.Data
{
    public class DataBaseContext : DbContext
    {
        private readonly string _path = @"C:\Users\ASUS\Desktop\Destop_Application\Destop_Application\user.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={_path}");
                          
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
