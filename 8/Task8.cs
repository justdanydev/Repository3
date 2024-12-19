using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public enum Status
    {
        Pending,

        InProgress,

        Completed,

        Error
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Status taskStatus = Status.InProgress;
            Console.WriteLine($"Текущий статус задачи: {taskStatus}"); 

            Console.WriteLine("\nВсе возможные статусы:");
            foreach (Status s in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine($"{s} - {s.ToString()}");
            }
        }
    }
}
