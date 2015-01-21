namespace StudentsTasks
{
    using System;
    public class StudentsMain
    {
        static void Main()
        {
            // Test ToString();
            var pesho = new Student("Pesho", "Petrov", "Petrovich", 345354, "In the middle of nowhere", "0899-99-99-99",
               "somemail@gmail.com", 2, UniversityEnum.NewBulgarianUniversity, FacultyEnum.ChemicalFaculty, SpecialityEnum.Philosophy);
            Console.WriteLine(pesho);
            Console.WriteLine();

            //Test deep clone
            var gosho = (Student)pesho.Clone();
            Console.WriteLine(gosho);
            gosho.FirstName = "Joro";
            Console.WriteLine(gosho.FirstName);
            Console.WriteLine(pesho.FirstName);
            Console.WriteLine();

            //Testing CompareTo
            Console.WriteLine(pesho.CompareTo(gosho));
            gosho.FirstName = "Peter";
            Console.WriteLine(pesho.CompareTo(gosho));
        }
    }
}
