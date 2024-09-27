namespace Task3
{
    internal class Program
    {
        public delegate double MyAction(double x);
        static void Main(string[] args)
        {
            MyAction action = (num) => num * num;
            var x = action(2);
            var y = action(10);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
