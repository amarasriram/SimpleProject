namespace SimpleProject.Models
{
    public interface ITeamDRepository
    {
        public IEnumerable<Student> GetAllStudentsD();
        public int UpdateStudent(Student student);
    }
}
