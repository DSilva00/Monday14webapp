using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        //Relationships (Navigation properties)
        public virtual ICollection<Enrollment> Enrollments { get; set; }



    }
}
