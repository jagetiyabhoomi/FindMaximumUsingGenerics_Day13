namespace GenericsDemo
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
           
            int a = 10, b = 20, c = 40;
            int MaximumNumberTestCase1, MaximumNumberTestCase2, MaximumNumberTestCase3;
            FindMaximum findMaximum = new FindMaximum();
            MaximumNumberTestCase1 = findMaximum.MaximumIntNumber(50,20,40);
            Console.WriteLine(MaximumNumberTestCase1);
            FindMaximum findMaximum2 = new FindMaximum();
            MaximumNumberTestCase2 = findMaximum2.MaximumIntNumber(10, 100, 60);
            Console.WriteLine(MaximumNumberTestCase2);
            FindMaximum findMaximum3 = new FindMaximum();
            MaximumNumberTestCase3 = findMaximum3.MaximumIntNumber(20, 67, 220);
            Console.WriteLine(MaximumNumberTestCase3);
        }
    }
}