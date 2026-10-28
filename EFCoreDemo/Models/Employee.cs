using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Salary { get; set; }
        public int? SupervisorId { get; set; }
        public Employee? Supervisor { get; set; }
    }
}
