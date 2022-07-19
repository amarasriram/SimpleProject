namespace SimpleProject.Models
{
    public class TeamCRepository : ITeamCRepository

    {

        private readonly AppDbContext appDbContext;

        public TeamCRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Student> GetAllStudentsC()
        {

            var students = appDbContext.Students;

            var stud = students.Where(x => x.TeamName == "C");
            return stud;
        }
        public int UpdateStudent(Student student)
        {
            appDbContext.Students.Update(student);
            return appDbContext.SaveChanges();
        }
    }
}
