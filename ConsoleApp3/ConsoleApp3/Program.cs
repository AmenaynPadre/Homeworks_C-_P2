namespace ConsoleApp3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var x = await GetStudentsAsync(3);
            var x1 = await GetStudentsAsync(2);
            var x2 = await GetStudentsAsync(1);

            HashSet<Student> allStudents = new HashSet<Student>(new StudentsComparer());

            foreach (var item in x)
            {
                allStudents.Add(item);
            }

            foreach (var item in x1)
            {
                allStudents.Add(item);
            }

            foreach (var item in x2)
            {
                allStudents.Add(item);
            }

            foreach (var item in allStudents)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }

        public static async Task<List<Student>> GetStudentsAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://localhost:7093/api/Teacher/{id}/students";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode) 
                {
                    var jsonStr = await response.Content.ReadAsStringAsync();
                    List<Student> students = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Student>>(jsonStr);

                    return students;
                }
                else
                {
                    throw new Exception("asd" + response.StatusCode);
                }
            }
        }
    }
}
