
using System;

namespace MobileDevice
{
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
       
    }
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType typeOfBattery;

        public Battery(string model, BatteryType type, int idle = 0, int talk = 0)
        {
            this.model = model;
            this.HoursIdle = idle;
            this.HoursTalk = talk;
            this.typeOfBattery = type;
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery parameters incorrect");
                }
                this.hoursTalk = value;
            }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (hoursIdle < 0)
                {
                    throw  new ArgumentException("Battery parameters incorrect");
                }
                this.hoursIdle = value;
            }
        }
        public BatteryType TypeOfBattery
        {
            get { return this.typeOfBattery; }
            set { typeOfBattery = value; }
        }

        public override string ToString()
        {
            return string.Format("Battery model: {0}\nBattery type: {1}\nHours idle: {2}\nTalk hours: {3}", model, typeOfBattery, HoursIdle, HoursTalk);
        }
    }
}
