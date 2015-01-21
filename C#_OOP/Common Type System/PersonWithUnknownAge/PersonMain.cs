namespace PersonWithUnknownAge
{
    using System;

    public class PersonMain
    {
        static void Main()
        {
            //Person with age
            var human = new Person("Gosho", 15);
            Console.WriteLine(human);

            // Person without not specified age
            var noAgeHuman = new Person("Pesho");
            Console.WriteLine(noAgeHuman);
        }
    }
}
