namespace ExtensionMethods
{
    /* Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder
     * and has the same functionality as Substring in the class String.
     */
    using System;
    using System.Text;

    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int lenght)
        {
            if (index < 0 || index >= sb.Length || index + lenght > sb.Length)
            {
                throw new IndexOutOfRangeException("Index or lenght is invalid!");
            }
            var subResult = new StringBuilder();
            for (int i = index; i < lenght + index; i++)
            {
                subResult.Append(sb[i]);
            }

            return subResult;
        }
    }
}
