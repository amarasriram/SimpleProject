using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;
using SimpleProject.ViewModels;

namespace SimpleProject.Controllers
{
    public class TeamCController : Controller
    {
        private readonly ITeamCRepository _teamCRepository;

        public TeamCController(ITeamCRepository teamCRepository)
        {
            this._teamCRepository = teamCRepository;
        }

        public ViewResult List3()
        {
            var students = _teamCRepository.GetAllStudentsC();
           
            StudentWithCount stud = new StudentWithCount();
            stud.students = students;
            stud.count = students.Count();
            return View(stud);
        }
        public ViewResult Details(int id)
        {
            var student = _teamCRepository.GetAllStudentsC().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public ViewResult Edit(int id)
        {
            var student = _teamCRepository.GetAllStudentsC().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public IActionResult UpdateStudent(Student student)
        {
            _teamCRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }
    }
}
