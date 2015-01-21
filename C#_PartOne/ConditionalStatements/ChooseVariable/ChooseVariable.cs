using System;
/* Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.
*/ 



class ChooseVariable
{
    static void Main()
    {
        Console.WriteLine("Choose one of the following: \n1 for int; \n2 for double; \n3 for string;");
        int selection = int.Parse(Console.ReadLine());

        switch (selection)
        {
            case 1:
               // int chooseInt = int.Parse(Console.ReadLine());
                Console.WriteLine("Your choice: {0}", selection + 1);
                break;

            case 2:
               // double chooseDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("Your choice: {0}", selection + 1);
                break;
            
            case 3:
             //   string chooseString = Console.ReadLine();
                Console.WriteLine(selection + "*");
                break;
          
            default:
                Console.WriteLine("Error! Sorry this program knows only 1, 2 and 3");
                break;
        }
    }
}

