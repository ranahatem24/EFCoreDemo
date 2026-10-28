using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string? CrsName { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}
