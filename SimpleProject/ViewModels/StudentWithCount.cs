using SimpleProject.Models;

namespace SimpleProject.ViewModels
{
    public class StudentWithCount
    {
        public IEnumerable<Student> students { get; set; }
        public int count { get; set; }
        
    }
}
