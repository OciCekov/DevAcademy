namespace BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray : IEnumerable<int>
    {

        private ulong number;

       

    
        public BitArray(ulong initialNumber)
        {
            this.Number = initialNumber;
        }
        public ulong Number
        {
            get { return this.number; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number must be positive");
                }
                this.number = value;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        
        public override bool Equals(object param)
        {
            BitArray bitArray = param as BitArray;

            if ((object)bitArray == null)
            {
                return false;
            }

            if (this.number !=bitArray.number)
            {
                return false;
            }

            return true;
        }
        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                return (int)((this.number >> index) & 1);
            }
        }

        public static bool operator ==(BitArray bitArray1, BitArray bitArray2)
        {
            return BitArray.Equals(bitArray1, bitArray2);
        }

        public static bool operator !=(BitArray bitArray1, BitArray bitArray2)
        {
            return !(BitArray.Equals(bitArray1, bitArray2));
        }

        //Override ToString() method
        public override string ToString()
        {
            var sb = new StringBuilder(64);
            for (int i = 63; i >= 0; i--)
            {
                sb.Append(this[i]);
            }
            return sb.ToString();

        }
    }
}
