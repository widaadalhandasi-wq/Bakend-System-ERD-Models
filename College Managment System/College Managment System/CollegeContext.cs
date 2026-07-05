using College_Managment_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Managment_System
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Exams> Exams { get; set; }
        public DbSet<Enrols> Enrollments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-C2LUNMA;Database=CollegeManagmentSystemDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
