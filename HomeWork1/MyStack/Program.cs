namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var y = new MyStack<int>();

            y.Push(1);
            y.Push(2);
            y.Push(3);
            y.Push(4);
            y.Push(5);

            //Console.WriteLine(y.Peek());

            Console.WriteLine(y.Count);
            Console.WriteLine(y.Capacity);

            //foreach (var item in y)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
