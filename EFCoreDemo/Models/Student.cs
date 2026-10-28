using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    internal class Student
    {
        public int  StudentId { get; set; }
        public string? Name { get; set; }
        public ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
    }
}
