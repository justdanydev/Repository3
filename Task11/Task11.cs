using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public struct MyStruct
    {
        public readonly int MyReadOnlyField;

        public MyStruct(int value)
        {
            MyReadOnlyField = value;
        }

    }

    public class Example
    {
        public static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct(10);

            Console.WriteLine($"Значение поля MyReadOnlyField: {myStruct.MyReadOnlyField}");

            Console.WriteLine($"Значение поля MyReadOnlyField (после попытки изменения): {myStruct.MyReadOnlyField}"); //Значение не изменится
        }
    }
}
