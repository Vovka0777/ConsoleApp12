using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// 2. Вычислить значение выражения, определив и использовав дополнительный метод:
    /// </summary>
    class Program
    {
        public static double Function(int x, int y)
        {
            /// <summary>
            /// Дополнительный метод
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            return (Math.Sqrt(x) + x) / (Math.Sqrt(y)+y);
        }
        static void Main(string[] args)
        {
            Console.Write(Function(5,7) + Function(12,8) + Function(19,2));
            Console.Read();
        }
    }
}
