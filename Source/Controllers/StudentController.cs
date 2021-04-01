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
        public ActionResult SaveStudent()
        {
            ViewBag.Department = GetDepartments();
            ViewBag.Students = GetStudents();
            return View();
        }

        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            string msg = "";
            SqlConnection con = new SqlConnection("Data Source=HP; Initial Catalog=UniversityDBbatch49;Integrated Security=true");
            con.Open();
            string quary = "INSERT INTO Student_tb (StudentName, RegNo, Email, Address, DepartmentId) VALUES('" + student.StudentName + "', '" + student.RegNo + "', '" + student.Email + "', '" + student.Address + "', '" + student.DepartmentId + "' )";
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
            ViewBag.Students = GetStudents();
            ViewBag.Message = msg;
            return View();
        }

        public List<Department> GetDepartments()
        {
            SqlConnection con = new SqlConnection("Data Source=HP; Initial Catalog=UniversityDBbatch49;Integrated Security=true");
            String query = "SELECT * FROM Department_tb";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Department> departments = new List<Department>();
            while (reader.Read())
            {
                Department department = new Department();
                department.Id = (int)reader["Id"];
                department.DepartmentName = reader["DepartmentName"].ToString();
                department.ShortName = reader["DepartmentName"].ToString() + "("+reader["ShortName"].ToString()+")";
                departments.Add(department);
            }
            con.Close();
            return departments;
        }

        public List<Student> GetStudents()
        {
            SqlConnection con = new SqlConnection("Data Source=HP; Initial Catalog=UniversityDBbatch49;Integrated Security=true");
            String query = "SELECT * FROM Student_tb";
            SqlCommand cmd = new SqlCommand(query, con);
            String queryDept = "SELECT * FROM Department_tb WHERE Id=";
            SqlCommand cmdDept = new SqlCommand(queryDept, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.StudentName = reader["StudentName"].ToString();
                student.RegNo = (int)reader["RegNo"];
                student.Email = reader["Email"].ToString();
                student.Address = reader["Address"].ToString();
                student.DepartmentId = (int)reader["DepartmentId"];
                student.DepartmentName = 
                students.Add(student);
            }
            con.Close();
            return students;
        }

        //public ActionResult GetAll()
        //{
        //    //ViewBag.StudentData = Students();
        //    return View(GetStudents());
        //}

        //public ActionResult Index()
        //{
        //    Student student = new Student();
        //    student.StudentName = "Masum";
        //    student.RegNo = 2013331;
        //    student.Email = "masum@gmail.com";
        //    student.Address = "Dhaka";
        //    student.Department = "CSE";

        //    //ViewBag.StudentData = student;
        //    return View(student);
        //}
    }
}

