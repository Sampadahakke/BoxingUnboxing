using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    public class Boxing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Boxing------------");
            int num = 20;
            object value = num;
            Console.WriteLine("The value num in object = " + value);
            Console.WriteLine("The value num in int = " + num);

            Console.WriteLine("-----------Unboxing------------");
            Unboxing.Unbox();
            Console.ReadLine();
        }
      
    }
}
