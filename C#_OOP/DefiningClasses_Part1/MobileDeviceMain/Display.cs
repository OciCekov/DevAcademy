

namespace MobileDevice
{
    using System;
    public class Display
    {
        private double displaySize;
        private int numberOfColors;

        public Display( double size,int colors)
        {
            this.DisplaySize = size;
            this.NumberOfColors = colors;
        }

        public Display()
        {
            
        }
        public double DisplaySize
        {
            get {return this.displaySize; }
            set
            {
                if (value < 2.5)
                {
                    throw  new ArgumentException("There should be bigger display size");
                }
                this.displaySize = value;
            }
        }

        public int NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if (value < 64000)
                {
                    throw  new ArgumentException("Why not black and white");
                }
                numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Display size: {0:F1}\nNumber of colors: {1}", DisplaySize, NumberOfColors);
        }
    }
}
