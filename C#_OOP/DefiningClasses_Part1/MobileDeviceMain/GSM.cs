using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;


namespace MobileDevice
{
    using System;
    public class GSM
    {
        private readonly static GSM iPhone;
        private readonly string manufacturer;
        private readonly string modelName;
        private decimal price;
        private Battery batteryCharacteristics;
        private Display displayCharacteristics;
      
        public List<Call> callList = new List<Call>();

        public GSM(string creator, string model, Battery battery = null, Display display = null, string owner = null,
            decimal price = 0)
        {
            this.modelName = model;
            this.manufacturer = creator;
            this.Owner = owner;
            this.Price = price;
            this.batteryCharacteristics = battery;
            this.displayCharacteristics = display;
            this.callList = new List<Call>();
        }
       static GSM()
        {
            //Yes it was 4S, but now is 2013, so 5S is more interesting
         iPhone = new GSM("iPhone","Apple",new Battery("Magic battery",BatteryType.LiIon,255,15),new Display(3.4,256000000),"Pehso",199);
        }
        public string Owner { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sorry, no fribies here");
                }
                this.price = value;
            }
        }
        public static GSM IPhone5S
        {
            get { return GSM.iPhone; }
        }

        public List<Call> Calls
        {
            get {return this.callList; }
            set { this.callList = value; }
        } 
        public  void AddCall(Call call)
        {
           this.Calls.Add(call);
        }

        public void RemoveFromList(Call call, List<Call> callHistory)
        {
            callHistory.Remove(call);
        }

        public  void DeleteCallHistory(List<Call> callHistory)
        {
            callHistory.Clear();
        }

        public  double CallsPrice()
        {
            double sum = 0;
            foreach (var call in Calls)
            {

                sum += call.CallDuration;
            }
            return sum*Call.perMInute;
        }

        public  void ShowCalls()
        {
            foreach (var call in Calls)
            {
                Console.WriteLine(call);
            }
        }
        public override string ToString()
        {
            return string.Format("Manufacturer: {0}\nModel: {1}\nOwner: {2}\nBattery: {3}\nDisplay{4}\nPrice: {5}"
                , manufacturer, modelName, Owner, batteryCharacteristics, displayCharacteristics, Price);
        }
    }
}
