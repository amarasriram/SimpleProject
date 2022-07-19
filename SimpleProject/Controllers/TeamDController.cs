using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;
using SimpleProject.ViewModels;

namespace SimpleProject.Controllers
{
    public class TeamDController : Controller
    {

        private readonly ITeamDRepository _teamDRepository;
        public TeamDController(ITeamDRepository teamDRepository)
        {
           this._teamDRepository = teamDRepository;
        }

        public ViewResult List4()
        {
            var students = _teamDRepository.GetAllStudentsD();
           
            StudentWithCount stud = new StudentWithCount();
            stud.students = students;
            stud.count = students.Count();
            return View(stud);         
        }
        public ViewResult Details(int id)
        {
            var student = _teamDRepository.GetAllStudentsD().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public ViewResult Edit(int id)
        {
            var student = _teamDRepository.GetAllStudentsD().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public IActionResult UpdateStudent(Student student)
        {
            _teamDRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }
    }
}
