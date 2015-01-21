namespace StudentsSort
{
    using System.Linq;

    /*Write a method that from a given array of students finds all students 
     * whose first name is before its last name alphabetically. Use LINQ query operators.*/

    public static class Names
    {
        private static readonly Student[] AllStudents =
        { new Student("Joro", "Morov"), new Student("Pesho", "Todorov"),
            new Student("Aleks","Georgiev")};

        public static void ExecuteTest()
        {
            var neededStudents =
                from student in AllStudents
                where System.String.Compare(student.FirstName, student.LastName, System.StringComparison.Ordinal) < 0
                select student;

            Student.Print(neededStudents);
        }
    }
}