namespace Task2
{
    internal class Program
    {
        public delegate void DisplayString(string str);
        static void Main(string[] args)
        {
            DisplayString x = delegate (string s )
            {
                Console.WriteLine(s);
            };

            x("Hello");
            x("World");
        }
    }
}
