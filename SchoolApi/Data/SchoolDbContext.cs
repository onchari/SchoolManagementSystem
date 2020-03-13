using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;
using School_Web_Api.Models;

namespace SchoolApi.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
                
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Student> Student { get; set; }
       
    }
}
