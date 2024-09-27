namespace Task7
{
    internal class Program
    {
        public delegate bool MyDel(int x, int y);
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 5, 10, 23, 100, 1, 2, 3, 4, 123, 35214, 56, 4234, 31564357, 462324 };

            Sort(ints, Ajman);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");

            Sort(ints, Nvazman);

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        static void Sort(List<int> list,MyDel del)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (del(list[j], list[j + 1]))
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static bool Ajman(int x, int y)
        {
            return x > y; 
        }

        static bool Nvazman(int x, int y)
        {
            return x < y; 
        }

    }
}
