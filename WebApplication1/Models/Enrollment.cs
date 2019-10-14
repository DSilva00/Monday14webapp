using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }

        public Grades? Grade { get; set; }

        //relationships
        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }


    }
    public enum Grades
    {
        A,
        B,
        C,
        D,
        E,
        F
    }


}
