using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        //Darabase attributes
        public int StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        // Navigation Properties (relationships)
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
