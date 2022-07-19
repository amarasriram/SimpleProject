namespace SimpleProject.Models
{
    public class TeamDRepository : ITeamDRepository
    {

        private readonly AppDbContext appDbContext;

        public TeamDRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Student> GetAllStudentsD()
        {

            var students = appDbContext.Students;

            var stud = students.Where(x => x.TeamName == "D");
            return stud;
        }
        public int UpdateStudent(Student student)
        {
            appDbContext.Students.Update(student);
            return appDbContext.SaveChanges();
        }
    }
}
