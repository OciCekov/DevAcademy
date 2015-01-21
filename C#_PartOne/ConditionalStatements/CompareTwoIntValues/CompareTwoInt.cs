using System;

/*Write an if statement that examines two integer variables and exchanges their values 
 * if the first one is greater than the second one.*/



class CompareTwoInt
{
    static void Main()
    {
        Console.Write("Eneter value for the first integer a= ");
        int firstV;
                while (!int.TryParse(Console.ReadLine(), out firstV))
        {
            Console.Write("Please enter valid integer value, try again: ");            
        }
        
        Console.Write("Enter value for the second integer b= ");       
        int secondV;        
        while (!int.TryParse(Console.ReadLine(), out secondV))
        {
            Console.Write("This also should be valid number, try again: ");
        }
        
        if (firstV > secondV)
        {
            int exchange = firstV;
            firstV = secondV;
            secondV = exchange;
            Console.WriteLine("New assignments: \na= {0}; \nb= {1};", firstV, secondV);
        }
        
        else if (firstV <= secondV)
        {
            Console.WriteLine("Your second value was greater, so no exchange will be needed.");
        }
    }
}

