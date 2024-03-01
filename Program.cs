using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bai4_w06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan quat1 = new Fan(Fan.fast, true, 10, "yellow");
            Fan quat2 = new Fan(Fan.medium, false, 5, "blue");
            Console.WriteLine(quat1.ToString());
            Console.WriteLine(quat2.ToString());
            Console.ReadKey();
        }
    }
}
