using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDotNetCoreAndEntity.Models
{
    public class Student
    {
        public string StudentName { get; set; }
        public int RegNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        [NotMapped]
        public string DepartmentName { get; set; }
    }
}
