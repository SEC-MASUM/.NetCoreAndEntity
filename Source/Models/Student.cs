using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDotNetCoreAndEntity.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please provide student name"),MaxLength(4)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Display(Name = "Reg No")]
        public int RegNo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        //public int DepartmentId { get; set; }
        //[NotMapped]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}
