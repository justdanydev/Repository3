using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    [Flags]
    public enum AccessRights
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        ReadWrite = Read | Write,
        ReadExecute = Read | Execute,
        WriteExecute = Write | Execute,
        All = Read | Write | Execute
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            AccessRights access = AccessRights.Read | AccessRights.Write;

            Console.WriteLine($"Права доступа: {access}");

            AccessRights access2 = AccessRights.ReadWrite;
            Console.WriteLine($"Права доступа 2: {access2}");

            AccessRights access3 = AccessRights.Read | AccessRights.Execute;
            Console.WriteLine($"Права доступа 3: {access3}");

            AccessRights access4 = AccessRights.All;
            Console.WriteLine($"Права доступа 4: {access4}");
            Console.WriteLine($"Битовое представление прав доступа 4: {(int)access4}");

        }
    }
}

