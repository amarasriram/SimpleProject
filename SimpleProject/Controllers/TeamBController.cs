
using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;
using SimpleProject.ViewModels;

namespace SimpleProject.Controllers
{
    public class TeamBController : Controller
    {
        private readonly ITeamBRepository _teamBRepository;
        public TeamBController(ITeamBRepository teamBRepository)
        {
           this._teamBRepository = teamBRepository;
        }

        public ViewResult List2()
        {
           var students = _teamBRepository.GetAllStudentsB();
            StudentWithCount stud = new StudentWithCount();
            stud.students = students;
            stud.count = students.Count();
            return View(stud);
        }
        public ViewResult Details(int id)
        {
            var student = _teamBRepository.GetAllStudentsB().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public ViewResult Edit(int id)
        {
            var student = _teamBRepository.GetAllStudentsB().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public IActionResult UpdateStudent(Student student)
        {
            _teamBRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }
    }
}
