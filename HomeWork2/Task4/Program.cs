using System.Security.Cryptography.X509Certificates;

namespace Task4
{
    internal class Program
    {
        public delegate void MyAction();
        static void Main(string[] args)
        {
            MyAction x = Hello;
            MyAction y = World;

            var res = x + y;
            res.Invoke();
        }

        public static void Hello()
        {
            Console.Write("Hello");
        }

        public static void World()
        {
            Console.Write("World");
        }
    }
}
