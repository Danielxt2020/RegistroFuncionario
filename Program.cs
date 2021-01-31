using System;
using System.Globalization;
using System.Collections.Generic;
namespace RegistroFuncionario
    
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Emplyoee> list = new List<Emplyoee>();
            List<Emplyoee> list2 = new List<Emplyoee>();

            Console.Write("How many emplyoee will be registered?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Emplyoee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase:");
            int search_id = int.Parse(Console.ReadLine());

            Emplyoee emp = list.Find(x => x.Id == search_id);


            if (emp != null)
            {
                Console.Write("Enter the percentage:");
                double porcentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(porcentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Emplyoee obj in list)
            {
                Console.WriteLine(obj);
            }
          
        }
    }
}
