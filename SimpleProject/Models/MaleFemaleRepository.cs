namespace SimpleProject.Models
{
    public class MaleFemaleRepository : IMaleFemaleRepository
    {
        private readonly AppDbContext appDbContext;

        public MaleFemaleRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Student> GetMaleStudents()
        {

            return GetAllStudents().Where(x => x.Gender=="M").OrderBy(x => x.FirstName);
        }

        public IEnumerable<Student> GetFemaleStudents()
        {

            return GetAllStudents().Where(x => x.Gender == "F").OrderByDescending(x=>x.FirstName);


        }

       


        public IEnumerable<Student> GetAllStudents()
        {

            var students = appDbContext.Students;

           

            return students;

        }
    }
}
