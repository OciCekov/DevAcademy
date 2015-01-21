using System;

/*A marketing firm wants to keep record of its employees. 
 * Each record would have the following characteristics – 
 * first name, family name, age, gender (m or f), ID number,
 * unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information for a single employee
 * using appropriate data types and descriptive names.
 */

class MarketingFirmRecords
{
    static void Main()
    {
        Console.Write("Please enter first name: ");
        string firstName = (Console.ReadLine());
        Console.Write("And now your family name: ");
        string lastName = (Console.ReadLine());
        Console.Write("Your age please: ");
        byte age = byte.Parse(Console.ReadLine());
            if (age < 16 | age > 80)
            {
                Console.Write("You shouldn't work for this firm!!!");
            }
            else
            {
                Console.Write("Your gender please: ");
                string gender = (Console.ReadLine());
                Console.Write("Now your ubique ID number Please: ");
                int idNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Your personal data");
                Console.WriteLine("Name:    {0} {1}",firstName, lastName);
                Console.WriteLine("Age:     {0} yaears old",age);
                Console.WriteLine("Gender:  {0}",gender);
                Console.WriteLine("Your ID: {0}",idNumber); 
            }
    }
}

