using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Learning_Platform.Models
{
    public class eLearningDBContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Sclass> sclasses { get; set; }

    }
}