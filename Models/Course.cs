using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-10-hinert-dykstra1] - created class, props, and created Enrollment class to deal with Enrollments property. 
    //DatabaseGeneratedOption.None ensures that values are not generated automatically by the database when they would otherwise be created elsewhere.
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
