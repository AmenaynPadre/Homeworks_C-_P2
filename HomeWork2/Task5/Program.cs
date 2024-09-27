namespace Task5
{
    internal class Program
    {
        public delegate bool MyAction (int i);
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 6, 7 };
            var res = MyMethod(arr, IsOdd);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------------");

            var res1 = MyMethod(arr, IsEven);

            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> MyMethod(List<int> list,MyAction x)
        {
            List<int> result = new List<int>();

            foreach (var item in list)
            {
                if (x(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static bool IsOdd(int i) 
        {
            return i % 2 == 0;
        }

        public static bool IsEven(int i)
        {
            return i % 2 != 0;

        }
    }
}
