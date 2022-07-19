using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;

namespace SimpleProject.Controllers
{
    public class MaleFemaleController : Controller
    {
        private readonly IMaleFemaleRepository maleFemaleRepository;
       
        public MaleFemaleController(IMaleFemaleRepository maleFemaleRepository)
        {
            this.maleFemaleRepository = maleFemaleRepository;
           
        }

        public ViewResult Male()
            {


            var male = maleFemaleRepository.GetMaleStudents();
            ViewBag.MaleCount = male.Count();
            return View(male);
            }


        public ViewResult Female()
        {

            var female = maleFemaleRepository.GetFemaleStudents();
            ViewBag.FemaleCount= female.Count();
            return View(female);
        }

        public ViewResult Details(int id)
        {
            var student = maleFemaleRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(student);


        }

    }
    
}
