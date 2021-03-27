using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAppDotNetCoreAndEntity.Models;

namespace WebAppDotNetCoreAndEntity.Controllers
{
    public class StudentController : Controller
    {
        public string SaveStudent(Student student)
        {
            SqlConnection con = new SqlConnection("Data Source=HP; Initial Catalog=UniversityDBbatch49;Integrated Security=true");
            con.Open();
            string quary = "INSERT INTO Student_tb (StudentName, RegNo, Email, Address, Department) VALUES('" + student.StudentName + "', '" + student.RegNo + "', '" + student.Email + "', '" + student.Address + "', '" + student.Department + "' )";
            SqlCommand cmd = new SqlCommand(quary,con);
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                return "Saved data successfully";
            }

            return "Save faild";
        }

        public ActionResult Index()
        {
            Student student = new Student();
            student.StudentName = "Masum";
            student.RegNo = 2013331;
            student.Email = "masum@gmail.com";
            student.Address = "Dhaka";
            student.Department = "CSE";

            //ViewBag.StudentData = student;
            return View(student);
        }

        public ActionResult GetAll()
        {
            ViewBag.StudentData = Students();
            return View();
        }

        public List<Student> Students()
        {
            return new List<Student>
            {
                new Student
                {
                    StudentName = "Arif",
                    RegNo = 2012331,
                    Email = "arif@gmail.com",
                    Address = "Rajshahi",
                    Department = "CSE"
                },
                new Student
                {
                    StudentName = "Saif",
                    RegNo = 2011331,
                    Email = "saif@gmail.com",
                    Address = "Rajshahi",
                    Department = "CSE"
                }
            };

        }
    }
}

