namespace SimpleProject.Models
{
    public interface IMaleFemaleRepository
    {
        public IEnumerable<Student> GetAllStudents();
        public IEnumerable<Student> GetMaleStudents();

        public IEnumerable<Student> GetFemaleStudents();
    }
}
