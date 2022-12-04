using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    public class Unboxing
    {
        public static void Unbox()
        {
            int num1 = 20;
            object value = num1;
            int num2 = (int)value;
            Console.WriteLine("The value num in object = " + value);
            Console.WriteLine("The value num2 in int = " + num2 );
            Console.ReadKey();
        }
    }
}
