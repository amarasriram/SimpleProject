using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;
using SimpleProject.ViewModels;

namespace SimpleProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult List()
        {
           var students= studentRepository.GetAllStudents().OrderBy(x=>x.FirstName);

            ViewBag.CountAll = students.Count();

            StudentWithCount stud = new StudentWithCount();
            stud.students = students;
            stud.count = students.Count();
            return View(stud);
        }

        public ViewResult SList()
        {
            var students = studentRepository.GetAllStudents().Where(x => x.FirstName.ToUpper().StartsWith("S")).OrderBy(x => x.FirstName);
            
            ViewBag.CountS = students.Count();

            StudentWithCount stud1 = new StudentWithCount();
            stud1.students = students;
            stud1.count = students.Count();
            return View(stud1);
        }

        public ViewResult Details(int id)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }

        public ViewResult Edit(int studentId)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == studentId);
            return View(student);
        }
        public IActionResult UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }


    }
}
