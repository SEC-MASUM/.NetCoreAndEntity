﻿using Microsoft.AspNetCore.Mvc;
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
        public ActionResult SaveStudent()
        {
            ViewBag.Department = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            string msg = "";
            SqlConnection con = new SqlConnection("Data Source=WHATEVER\\SQLEXPRESS; Initial Catalog=UniversityDBbatch49;Integrated Security=true");
            con.Open();
            string quary = "INSERT INTO Student_tb (StudentName, RegNo, Email, Address, Department) VALUES('" + student.StudentName + "', '" + student.RegNo + "', '" + student.Email + "', '" + student.Address + "', '" + student.Department + "' )";
            SqlCommand cmd = new SqlCommand(quary,con);
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                msg = "Saved data successfully";
            }
            else
            {
                msg = "Save faild";
            }
            ViewBag.Department = GetDepartments();
            ViewBag.Message = msg;
            return View();
        }

        public List<string> GetDepartments()
        {
            return new List<string> { "CSE", "EEE", "ME", "CE" };
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
            //ViewBag.StudentData = Students();
            return View(Students());
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

