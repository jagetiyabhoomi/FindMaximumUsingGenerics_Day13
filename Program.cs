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
            FindMaximum<int> findMaximum = new FindMaximum<int>();
            //findMaximum.MaximumIntNumber(200,80,40);
            //FindMaximum<double> findMaximumdouble = new FindMaximum<double>();
            //findMaximumdouble.MaximumIntNumber(2.4, 8.3, 4.7);
            //FindMaximum<String> findMaximumstring = new FindMaximum<string>();
            //findMaximumstring.MaximumIntNumber("Bhumi", "Bhoomi", "Bhumiiiii");

            //Console.WriteLine(MaximumNumberTestCase1);
            //FindMaximum findMaximum2 = new FindMaximum();
            //findMaximum2.MaximumIntNumber("Apple", "Banana", "Peach");
            //Console.WriteLine(MaximumNumberTestCase2);
            //FindMaximum findMaximum3 = new FindMaximum();
            //findMaximum3.MaximumIntNumber("Apple", "Peach", "Banana");
            //Console.WriteLine(MaximumNumberTestCase3);
            findMaximum.FindMaxExtended(5);

        }
    }
}