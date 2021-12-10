using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_0
{
    public delegate void Wrapped();

    public class Test
    {
        static public void Wrap(Wrapped test, int testNumber, string header)
        {
            Console.WriteLine(header + ", Тест № " + testNumber + ":");
            Console.WriteLine("__________________________________");
            test();
            Console.WriteLine("__________________________________");
        }
    }
}
