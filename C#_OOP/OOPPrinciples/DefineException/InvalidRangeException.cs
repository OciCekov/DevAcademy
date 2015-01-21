namespace DefineException
{
    using System;

    public class InvalidRangeExeption<T> : ApplicationException
    {
        public T Min { get; set; }

        public T Max { get; set; }


        public InvalidRangeExeption(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public override string Message
        {
            get
            {
                string result = string.Format("Value is not in the range: {0} - {1}", this.Min, this.Max);
                return result;
            }
        }
    }

}
