using EFCoreDemo.Configurations;
using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    internal class APPDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;DataBase=APPDb;Trusted_Connection=true;TrustServerCertificate=true");
        }
        #region DbSets
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public  DbSet <Department> Departments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<StudentCourse>(new StudentCourseConfigurations());
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
        }
    }
}
