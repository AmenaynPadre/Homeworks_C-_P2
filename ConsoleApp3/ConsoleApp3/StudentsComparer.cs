using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class StudentsComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null)) return false;

            if (ReferenceEquals(y, null)) return false;

            if (x.Age != y.Age) return false;
            if (x.Name != y.Name) return false;
            if (x.Surname != y.Surname) return false;


            return true;
        }

        public int GetHashCode(Student obj)
        {
            return HashCode.Combine(obj.Name, obj.Surname, obj.Age);
        }
    }
}
