namespace SimpleProject.Models
{
    public class TeamARepository : ITeamARepository

    {
        private readonly AppDbContext appDbContext;

        public TeamARepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Student> GetAllStudentsA()
        {
           
                var students = appDbContext.Students;

            var stud = students.Where(x => x.TeamName == "A");
                return stud;          
        }
        public int UpdateStudent(Student student)
        {
            appDbContext.Students.Update(student);
            return appDbContext.SaveChanges();
        }

    }
}

