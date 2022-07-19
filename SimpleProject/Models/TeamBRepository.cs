namespace SimpleProject.Models
{
    public class TeamBRepository : ITeamBRepository

    {
        private readonly AppDbContext appDbContext;

        public TeamBRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Student> GetAllStudentsB()
        {

            var students = appDbContext.Students;

            var stud = students.Where(x => x.TeamName == "B");
            return stud;
        }
        public int UpdateStudent(Student student)
        {
            appDbContext.Students.Update(student);
            return appDbContext.SaveChanges();
        }
    }
}
