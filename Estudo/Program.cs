using Estudo.Entities;
using Estudo.Entities.Enums;
using System;
using System.Globalization;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departement's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i}  contract data:");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string mountAndYear = Console.ReadLine();
            int mounth = int.Parse(mountAndYear.Substring(0, 2));
            int year = int.Parse(mountAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("DEpartment: " + worker.Department.Name);
            Console.WriteLine("Income for " + mountAndYear + " : " + worker.Income(year, mounth));

        }
    }
}
