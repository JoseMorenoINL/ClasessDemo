using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(5, 101);
            Console.WriteLine($"emp years of service: {emp.YearsOfService}");
            Console.WriteLine($"emo office: {emp.Office}");

            Employee emp2 = new Employee();

            emp2.YearsOfService = 5;
            emp2.Office = 201;

            Console.WriteLine($"emp2 years of service: {emp2.YearsOfService}");
            Console.WriteLine($"emp2 office: {emp2.Office}");


            Employee emp3 = new Employee();

            Console.WriteLine($"emp3 years of service: {emp3.YearsOfService}");
            Console.WriteLine($"emp3 office: {emp3.Office}");
        }


    }
}
