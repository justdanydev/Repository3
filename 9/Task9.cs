using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public enum Department
    {
        IT,
        Sales,
        Marketing
    }

    public struct Employee
    {
        public string name;
        public double salary;
        public Department department;

        public Employee(string name, double salary, Department department)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, Зарплата: {salary}, Отдел: {department}");
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee("Иван Иванов", 50000, Department.IT);
            Employee emp2 = new Employee("Анна Петрова", 60000, Department.Sales);

            emp1.PrintInfo();
            emp2.PrintInfo();


            Console.WriteLine($"\nЗарплата Ивана Иванова: {emp1.salary}");
            Console.WriteLine($"Отдел Анны Петровой: {emp2.department}");


        }
    }
}
