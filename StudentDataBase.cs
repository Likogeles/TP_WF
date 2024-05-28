using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Models
{
    internal class StudentDataBase : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server={localdb}\\mssqllocaldb;Initial Catalog=Database");
        }
    }
}
