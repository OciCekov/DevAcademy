namespace StudentsSort
{
    using System;
    using System.Linq;

    public static class Sort
    {
        private static readonly Student[] AllStudents =
        { new Student("Joro", "Dimitrov"), new Student("Someone", "Georgiev"),
            new Student("Unufri","Peshov")};

        public static void ExecuteTest()
        {
            var selectedStudents = AllStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            Console.WriteLine("Lambda and extension methods: ");
            Student.Print(selectedStudents);

            var selectedStudentsLinq =
                from student in AllStudents
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("LINQ: ");
            Student.Print(selectedStudentsLinq);
        }
    }
}
