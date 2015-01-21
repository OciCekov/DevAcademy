using System;

/*A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, BIC code
 * and 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank account
 * using the appropriate data types and descriptive names.
 */

class BankAccount
{
    static void Main()
    {
        object firstName = "Pesho";
        object secondName = "Geogriev";
        object lastName = "Tsonov";
        string names = (string)firstName + " " + secondName + " " + lastName;
        Console.WriteLine("Hello mr/mrs {0}.", names);
        string bankName = "First International Empty Bank";
        object iban = "BG 37 RZBB 0000 1111 2222 33";
        string bicCode = "RZKJLOIU";
        Console.WriteLine("In \"{0}\", you have account with current:\nIBAN: {1}\nBIC code: {2}\n", bankName, iban, bicCode);
        decimal balance = 5371.24m;
        ulong firstCard = 357313246354;
        ulong secondCard = 234866546544;
        ulong thirdCard = 568965465757;
        Console.WriteLine("Your current balance is: {0:C}\n", balance);
        Console.WriteLine("You also have 3 credit cards to your name, the numbers are\n First: {0}\n Second: {1}\n Third: {2}", firstCard, secondCard,thirdCard);
    }
}

