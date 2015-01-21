using System;

/*Declare five variables choosing for each of them the most appropriate of the types
 *byte, sbyte, short, ushort, int, uint, long, ulong to 
 *represent the following values: 52130, -115, 4825932, 97, -10000.
 */

class DeclareVariables
{
    static void Main()
    {
        byte paperCost = 97;
        sbyte randomCosts = -115;
        short employeesPayment = -10000;
        ushort rent = 52130;
        uint budget = 4825932;
        long total = budget - (paperCost + (-randomCosts) + (-employeesPayment) + rent);
        bool fine = (total > 0);
        if (fine)
        {
            Console.WriteLine("We are doing fine. \n");
        }
        else
        {
            Console.WriteLine("We got to lower the costs! \n");
        }

    }
}

