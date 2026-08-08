
using System;

namespace Main
{
    internal class Program
    {



        static void Main(string[] args)
        {

            //you don't specify any type here , automatically will be specified
            var student = new { Id = 20, FirstName = "Yahia", LastName = "Al-Sebaie" };

            Console.WriteLine("\nExample1:\n");
            Console.WriteLine(student.Id); //output: 20
            Console.WriteLine(student.FirstName); //output: Yahia
            Console.WriteLine(student.LastName); //output: Al-Sebaie

            //You can print like this:
            Console.WriteLine(student);


            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot change value
            // student.FirstName = "Ali";//Error: cannot change value


            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" } //another anonymous type.
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);



            Console.ReadKey();

        }
    }
}