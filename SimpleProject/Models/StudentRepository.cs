namespace SimpleProject.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext appDbContext;
        public StudentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }


        public IEnumerable<Student> GetAllStudents()
        {
            var students = appDbContext.Students;
            return students;
        }

        public IEnumerable<Student> GetSStudents()
        {
            return GetAllStudents();
        }

        public int UpdateStudent(Student student)
        {
            appDbContext.Students.Update(student);
            return appDbContext.SaveChanges();
        }
    }
}
/*
            var students = new List<Student> {
               new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
               new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
               new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
               new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
               new Student{FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F" },

               new Student{FirstName="Shreya",LastName="Kanoajia",Age=20, Gender="F", TeamName="B" },
               new Student{FirstName="Nandhita",LastName="Rayapati",Age=20, Gender="F", TeamName="B" },
               new Student{FirstName="Shashwat",LastName="Sukla",Age=20, Gender="M", TeamName="B" },
               new Student{FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
               new Student{FirstName="Shriya",LastName="Porwal",Age=20, Gender="F", TeamName="B" },

               new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
               new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
               new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
               new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },
               new Student{FirstName="SriRam", LastName="",Age=22, Gender="M", TeamName="C" },

                new Student{FirstName="Vaibhav", LastName="Bhatnagar",Age=22, Gender="M", TeamName="D" },
               new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
               new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
               new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
               new Student{FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
               new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
               };
           */
