namespace SimpleProject.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetSStudents();

        int UpdateStudent(Student student);


    }
}
