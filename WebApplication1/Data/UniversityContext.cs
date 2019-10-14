using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Student> Student { get; set; }

        public DbSet<WebApplication1.Models.Course> Course { get; set; }

        public DbSet<WebApplication1.Models.Enrollment> Enrollment { get; set; }
    }
}
