using System;
using System.Reflection;
namespace excp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User person1 = new User();
            Type userType = typeof(User);


            PropertyInfo propName = userType.GetProperty("Name", BindingFlags.NonPublic | BindingFlags.Instance);
            propName.SetValue(person1, "Ferid");
            Console.WriteLine(propName.GetValue(person1));

            PropertyInfo propSurname = userType.GetProperty("Surname", BindingFlags.NonPublic | BindingFlags.Instance);
            propSurname.SetValue(person1, "Elizade");
            Console.WriteLine(propSurname.GetValue(person1));

            PropertyInfo propAge = userType.GetProperty("Age", BindingFlags.NonPublic | BindingFlags.Static);
            propAge.SetValue(person1, (byte)20);
            Console.WriteLine(propAge.GetValue(person1));


            MethodInfo methodRef = userType.GetMethod("GetFullName", BindingFlags.NonPublic| BindingFlags.Instance);
            methodRef.Invoke(person1, null);

            MethodInfo changeRef = userType.GetMethod("ChangeAge", BindingFlags.NonPublic | BindingFlags.Static);
            object[] array = { (byte)21 };
            changeRef.Invoke(person1, array);

        }
    }
}