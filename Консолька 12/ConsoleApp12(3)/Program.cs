using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    /// <summary>
    /// 3. Найти максимальную величину из двух целых переменных a, b с использованием вспомогательных методов.
    /// </summary>
    class Program
    {
        public static int Function(int x, int y)
        {
            /// <summary>
            /// Дополнительный метод
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            return x > y ? x : y;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите y = ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Function(x, y));
            Console.Read();
        }
    }
}