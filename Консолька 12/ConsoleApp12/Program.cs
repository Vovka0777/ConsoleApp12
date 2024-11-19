using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// 1.Вычислить значение выражения, определив и использовав дополнительный метод:
    /// </summary>
    class Program
    {
        public static double Function(int x)
        {
            /// <summary>
            /// Дополнительный метод
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            return (Math.Sqrt(x)+x)/2;
        }
        static void Main(string[] args)
        {
            Console.Write(Function(5) + Function(12) + Function(19));
            Console.Read();
        }
    }
}