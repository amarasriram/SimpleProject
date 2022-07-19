namespace SimpleProject.Models
{
    public interface ITeamCRepository
    {
        public IEnumerable<Student> GetAllStudentsC();
        public int UpdateStudent(Student student);
    }
}
