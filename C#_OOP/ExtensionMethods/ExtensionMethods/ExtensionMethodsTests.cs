namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ExtensionMethodsTests
    {
        static void Main()
        {
            var testList = new List<int> {5, 6, 75, 1, 65, 2, 4, 3, 8};
            var test = testList.Min();
            Console.WriteLine("Minimal value in collection is: " + test);

            test = testList.Max();
            Console.WriteLine("Maximal element in colection is: " + test);

            test = testList.Average();
            Console.WriteLine("Average element in colection is: " + test);

            test = testList.Sum();
            Console.WriteLine("Sum of elements in collection is: " + test);

            test = testList.Product();
            Console.WriteLine("Product of elements in collection is: " + test);

            var sb = new StringBuilder();
            sb.Append("Something interesting should be here, sorry at the moment I'm boring");

            StringBuilder substringTest = sb.Substring(0, 10);
            Console.WriteLine(substringTest.ToString());
        }
    }
}
