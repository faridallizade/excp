using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excp
{
    internal class User
    {
        string Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        static byte Age { get; set; }


        void GetFullName()
        {

            Console.WriteLine($"Full name is {Name} {Surname}");
        }

        static void ChangeAge(byte age)
        {
            Age = age;
            Console.WriteLine(Age);

        }
    }
}
