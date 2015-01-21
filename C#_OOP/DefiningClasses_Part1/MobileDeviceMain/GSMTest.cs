using System;
using System.Collections.Generic;

namespace MobileDevice
{
    class GSMTest
    {
        static void Main()
        {
          
            var gsmArray = new GSM[]
            {
                new GSM("HTC","Explorer"),  
                new GSM("Samsung","S2",new Battery("Samsung",BatteryType.NiCd,500,200), new Display(4,70000)),
                new GSM("Google","Nexus5",new Battery("LG",BatteryType.LiIon), new Display(5,250000000), "Pesho",299) 
            };
            foreach (var phone in gsmArray)
            {
                Console.WriteLine(); 
                Console.WriteLine(phone);
                Console.WriteLine("-");
            }
            Console.WriteLine(GSM.IPhone5S);
            var testPhone = new GSM("Xiaomi", "MI3");
            testPhone.AddCall(new Call("14:15",25.01,"0888-8888-8888-8",25.15));
            testPhone.AddCall(new Call("14:19",01.02,"0888-5654-5464-4",15.155));
            testPhone.AddCall(new Call("15:65",02.05,"0999-9898-5656-4",465));
            testPhone.ShowCalls();
            double cost = testPhone.CallsPrice();
            Console.WriteLine("The price of the calls is: {0:f2}",cost);
            

        }
    }
}
