namespace SimpleProject.Models
{
    public interface ITeamARepository
    {
        public IEnumerable<Student> GetAllStudentsA();
        public int UpdateStudent(Student student);
    }
}
