namespace Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paginationRequest = new PaginationRequest()
            {
                PageSize = 10,
                PageNumber = 3
            };

            var result1 = Helper.GetAnimals(paginationRequest);

            foreach (var item in result1.Items)
            {
                Console.WriteLine(item.Age);
            }
        }
    }

    public static class Helper
    {
        public static PaginationResult GetAnimals(PaginationRequest p)
        {
            int totalCount = Data.Pets.Count();
            return new PaginationResult()
            {
                Items = Data.Pets
                    .Skip((p.PageNumber - 1) * p.PageSize)
                    .Take(p.PageSize)
                    .ToList(),
                TotalCount = totalCount
            };
        }
    }



    public class PaginationRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }

    public class PaginationResult
    {
        public List<Pet> Items { get; set; }
        public int TotalCount { get; set; }
    }
    public class Data
    {
        static Random random = new Random();
        public static IEnumerable<Pet> Pets =
            Enumerable.Range(1, 1000000)
            .Select(i => new Pet(i, $"Pet{i * -1}", random.Next(0,30))).ToArray();
    }

    public class Pet
    {
        public int Id;
        public string Name { get; set; }
        public int Age { get; set; }


        public Pet(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
