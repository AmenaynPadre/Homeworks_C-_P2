namespace Task8
{
    public delegate bool MyDel(Person x, Person y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("abc", 20);
            Person person2 = new Person("efg", 10);
            Person person3 = new Person("hij", 30);
            List<Person> persons = new List<Person>() { person1, person2, person3 };

            Sort(persons,SortByAgeA);

            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");

            Sort(persons, SortByAgeN);

            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }

        public static void Sort(List<Person> list, MyDel del)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (del(list[j], list[j + 1]))
                    {
                        Person temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        public static bool SortByAgeA(Person p1, Person p2)
        {
            return p1.Age > p2.Age; 
        }

        public static bool SortByAgeN(Person p1, Person p2)
        {
            return p1.Age < p2.Age; 
        }

    }



    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString() 
        {
            return $"{Name} : {Age}";
        }
    }
}
