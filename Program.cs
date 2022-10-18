using System.IO;
using System;

namespace GenericsDemo
{
    public class Program
    {
        public static string Apple { get; private set; }
        public static string Peach { get; private set; }
        public static string Banana { get; private set; }

        public static void Main(string[] args)
        {
           
            //float a = 10, b = 20, c = 40;
           // string MaximumNumberTestCase1, MaximumNumberTestCase2, MaximumNumberTestCase3;
            FindMaximum findMaximum = new FindMaximum();
            findMaximum.MaximumIntNumber("Banana", "Apple", "Peach");
            //Console.WriteLine(MaximumNumberTestCase1);
            //FindMaximum findMaximum2 = new FindMaximum();
            //findMaximum2.MaximumIntNumber("Apple", "Banana", "Peach");
            //Console.WriteLine(MaximumNumberTestCase2);
            //FindMaximum findMaximum3 = new FindMaximum();
            //findMaximum3.MaximumIntNumber("Apple", "Peach", "Banana");
            //Console.WriteLine(MaximumNumberTestCase3);
        }
    }
}