namespace Task1
{
    internal class Program
    {
        public delegate int MyDelegate(int x, int y);

        static void Main(string[] args)
        {
            static int Plus(int a, int b)
            {
                return a + b;
            }

            static int Minus(int a, int b)
            {
                return a - b;
            }

            var action1 = new MyDelegate(Plus);
            var action2 = new MyDelegate(Minus);

            var x =  action1.Invoke(5, 10);
            var y =  action2.Invoke(115, 10);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
