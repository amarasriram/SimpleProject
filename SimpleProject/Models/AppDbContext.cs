using Microsoft.EntityFrameworkCore;

namespace SimpleProject.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed students

            modelBuilder.Entity<Student>().HasData(
                new List<Student> {
                new Student{StudentID=1, FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
                new Student{StudentID=2, FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
                new Student{StudentID=3, FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
                new Student{StudentID=4, FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
                new Student{StudentID=5, FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

                new Student{StudentID=6, FirstName="Shreya",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{StudentID=7, FirstName="Nandhita",LastName="",Age=20, Gender="F", TeamName="B" },
                new Student{StudentID=8, FirstName="Shashwat",LastName="",Age=20, Gender="M", TeamName="B" },
                new Student{StudentID=9, FirstName="Siddarth",LastName="",Age=21, Gender="M", TeamName="B" },
                new Student{StudentID=10, FirstName="Shriya",LastName="",Age=20, Gender="F", TeamName="B" },

                new Student{StudentID=11, FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                new Student{StudentID=12, FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                new Student{StudentID=13, FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                new Student{StudentID=14, FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                new Student{StudentID=15, FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

                new Student{StudentID=17, FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                new Student{StudentID=18, FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                new Student{StudentID=19, FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                new Student{StudentID=20, FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
                new Student{StudentID=21, FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" },
                 new Student{StudentID=22, FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" }

                });

        }

    }
}
