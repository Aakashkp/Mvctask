using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> StudentDemo { get; set;}
    }
}