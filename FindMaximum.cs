using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class FindMaximum<T> where T : IComparable
    {
        public void MaximumIntNumber(T FV, T SV, T TV)
        {
            if (FV.CompareTo(SV) > 0 && FV.CompareTo(TV) > 0 || FV.CompareTo(SV) >= 0 && FV.CompareTo(TV) > 0 || FV.CompareTo(SV) > 0 && FV.CompareTo(TV) >= 0)
            {
                Console.WriteLine("First value is Greater");
                //return FV;
            }
            else if (SV.CompareTo(FV) > 0 && SV.CompareTo(TV) > 0 || SV.CompareTo(FV) >= 0 && SV.CompareTo(TV) > 0 || SV.CompareTo(FV) > 0 && SV.CompareTo(TV) >= 0)
            {
                Console.WriteLine("Second value is Greater");
                //return SV;
            }
            else if (TV.CompareTo(FV) > 0 && TV.CompareTo(SV) > 0 || TV.CompareTo(FV) >= 0 && TV.CompareTo(SV) > 0 || TV.CompareTo(FV) > 0 && TV.CompareTo(SV) >= 0)
            {

                Console.WriteLine("Third value is Greater");
                //return TV;
            }
            else
            {
                Console.WriteLine("enter Valid Numbers");

            }
        }
        public  void FindMaxExtended(int n)
        {

            int[] array = new int[n];
            Console.WriteLine("Enter the elements: ");
            for(int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("Maximum Number from entered elements is: " + array[n-1]);


        }
         

    }

}
