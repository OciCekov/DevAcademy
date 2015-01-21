namespace StudentsSort
{
    using System;
    using System.Linq;

    //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    public static class Age
    {
        private static readonly Student[] AllStudents = new Student[] { new Student("John", "Lehnon"){Age=45}, 
            new Student("Pesho", "Georgiev",21), new Student("Adam","Peshov",15)};

        public static void ExecuteTest()
        {
            var selectedStudents =
                from student in AllStudents
                where student.Age > 18 && student.Age < 24
                select student;

            Student.Print(selectedStudents);
        }
    }
}
