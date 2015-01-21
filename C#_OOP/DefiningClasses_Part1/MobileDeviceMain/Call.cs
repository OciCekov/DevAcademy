
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MobileDevice
{
    public class Call
    {
        public const double perMInute = 0.37;
        private double callDate;
        private string callNumber;

        public Call(string timeOfCall, double dateOfCall, string callNumber, double callDuration)
        {
            this.CallTime = timeOfCall;
            this.CallDate = dateOfCall;
            this.CallNumber = callNumber;
            this.CallDuration = callDuration;
        }

        public string CallTime { get; set; }
        public double CallDate
        {
            get { return this.callDate; }
            set
            {
                if (value > 31 || value < +1)
                {
                    throw new ArgumentException("Wrong date");
                }
                this.callDate = value;
            }
        }

        public string CallNumber
        {
            get { return this.callNumber; }
            set
            {
                this.callNumber = value;
            }
        }

        public double CallDuration { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}",CallDate,CallTime,callNumber,CallDuration);
        }
    }
}
