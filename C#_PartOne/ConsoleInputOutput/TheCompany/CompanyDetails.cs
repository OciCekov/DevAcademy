using System;
/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints them on the console.
 */


class CompanyDetails
{
    static void Main()
    {
        Console.WriteLine("Please enter company details below");
        string companyDetails = "Company Details";
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        long companyNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter Company fax number: ");
        long companyFax = long.Parse(Console.ReadLine());
        Console.Write("Enter company web site: ");
        string webSite = Console.ReadLine();

        Console.WriteLine(("").PadRight(40,'*'));

        string managerDetails = "Manager Details";
        Console.WriteLine("Please enter manager details below");
        Console.Write("Enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager family name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter age of manager: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number: ");
        long managerNumber = long.Parse(Console.ReadLine());
       
        Console.WriteLine(("").PadRight(40, '*'));
        Console.WriteLine("{0,-25} {1,25}", companyDetails, managerDetails);
        Console.WriteLine("name:    {0, -15} | {1, 15} {2}",companyName, managerFirstName, managerLastName);
        Console.WriteLine("phone:   {0, -15} | {1, 15}",companyNumber, managerNumber);
        Console.WriteLine("fax:     {0, -15} | ", companyFax);
        Console.WriteLine("address: {0, -15} | ",companyAddress);
        Console.WriteLine("Web:     {0, -15} |",webSite);
        Console.WriteLine("Age:                     |{0, 15}",managerAge);
        Console.WriteLine();
        Console.WriteLine(("").PadRight(40, '*'));

    }
}

