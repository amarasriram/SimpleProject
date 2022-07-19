namespace SimpleProject.Models
{
    public interface ITeamBRepository
    {
        public IEnumerable<Student> GetAllStudentsB();
        public int UpdateStudent(Student student);
    }
}
