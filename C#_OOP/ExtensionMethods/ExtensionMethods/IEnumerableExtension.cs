namespace ExtensionMethods
{
    // Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtension
    {
        public static T Min<T>(this IEnumerable<T> enumerable) where T : IComparable<T>
        {
            if (!enumerable.Any())
            {
                throw new ArgumentException("Collection should not be empty");
            }
            var smallest = enumerable.First();
            foreach (var item in enumerable.Where(item => smallest.CompareTo(item) == 1))
            {
                smallest = item;
            }
            return smallest;
        }

        public static T Max<T>(this IEnumerable<T> enumerable) where T : IComparable<T>
        {
            if (!enumerable.Any())
            {
                throw new ArgumentException("Collection should not be empty");
            }
            var biggest = enumerable.First();
            foreach (var item in enumerable.Where(item => biggest.CompareTo(item) == -1))
            {
                biggest = item;
            }
            return biggest;
        }

        public static T Sum<T>(this IEnumerable<T> enumerable)
            where T : IComparable<T>
        {
            if (!enumerable.Any())
            {
                throw new ArgumentException("Collection should not be empty");
            }
            // Yes it is a shity way to do it like this, probably Kenov will kill me but I don't have time now for more detailed aproach, sorry.
            // We can be pretty safe becouse of this:  where T : IComparable<T>   but still....
            dynamic sum = default(T);

            foreach (var item in enumerable)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumerable) where T : IComparable<T>
        {
            if (!enumerable.Any())
            {
                throw new ArgumentException("Collection should not be empty");
            }
            //Why it wasn't working with "dynamic product = default(T)", that's one of the reasons why this sucks.
            dynamic product = 1;
            foreach (var item in enumerable)
            {
                product *= (dynamic)item;
            }
            return product;
        }

        public static T Average<T>(this IEnumerable<T> enumerable) where T : IComparable<T>
        {
            if (!enumerable.Any())
            {
                throw new ArgumentException("Collection should not be empty");
            }
            dynamic average = enumerable.Sum();
            average /= enumerable.Count();
            return average;
        }
    }
}
