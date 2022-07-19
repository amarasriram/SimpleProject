using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;
using SimpleProject.ViewModels;

namespace SimpleProject.Controllers
{
    public class TeamAController : Controller
    {
        private readonly ITeamARepository _teamARepository;
        public TeamAController(ITeamARepository teamARepository)
        {
            this._teamARepository = teamARepository;
        }
    
        public ViewResult List1()
        {
            var students = _teamARepository.GetAllStudentsA();
            StudentWithCount stud = new StudentWithCount();
            stud.students = students;
            stud.count = students.Count();

            
            return View(stud);

            }
        public ViewResult Details(int id)
        {
            var student = _teamARepository.GetAllStudentsA().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }

        public ViewResult Edit(int id)
        {
            var student = _teamARepository.GetAllStudentsA().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public IActionResult UpdateStudent(Student student)
        {
            _teamARepository.UpdateStudent(student);
            return RedirectToAction("List");
        }
    }
}
