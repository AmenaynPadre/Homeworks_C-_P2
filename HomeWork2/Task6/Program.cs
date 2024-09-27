namespace Task6
{
    internal class Program
    {
        public delegate bool MyDel(int x);
        static void Main(string[] args)
        {
            List<int> list = new List<int> {1,2,3,4,5,5,6,7,6,5,4,3,2,2,23,432,532,346,34 };

            var x = MyWhere(list, i => i % 2 == 0);

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> MyWhere(IEnumerable<int> source,MyDel fun)
        {
            foreach (var item in source)
            {
                if (fun(item))
                {
                    yield return item;
                }   
            }
        }
    }
}
