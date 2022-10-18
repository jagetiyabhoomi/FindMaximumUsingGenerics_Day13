namespace GenericsDemo
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
           
            float a = 10, b = 20, c = 40;
            double MaximumNumberTestCase1, MaximumNumberTestCase2, MaximumNumberTestCase3;
            FindMaximum findMaximum = new FindMaximum();
            MaximumNumberTestCase1 = findMaximum.MaximumIntNumber(7.9,1.6,2.0);
            Console.WriteLine(MaximumNumberTestCase1);
            FindMaximum findMaximum2 = new FindMaximum();
            MaximumNumberTestCase2 = findMaximum2.MaximumIntNumber(1.4,28.4,4.6);
            Console.WriteLine(MaximumNumberTestCase2);
            FindMaximum findMaximum3 = new FindMaximum();
            MaximumNumberTestCase3 = findMaximum3.MaximumIntNumber(5.3,2.7,55.7);
            Console.WriteLine(MaximumNumberTestCase3);
        }
    }
}