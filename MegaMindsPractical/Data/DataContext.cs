using MegaMindsPractical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MegaMindsPractical.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        [NotMapped]
        public DbSet<StudentList> StudentLists { get; set; }
    }
}
