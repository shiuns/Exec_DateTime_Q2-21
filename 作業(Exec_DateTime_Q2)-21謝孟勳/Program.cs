using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業_Exec_DateTime_Q2__21謝孟勳
{
    //計算圖書下個月歸還時間
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("書籍歸還時間 : ");
            string input = Console.ReadLine();
            int input1 = int.Parse(input);

            DateTime dt = DateTime.Now.AddMonths(input1);

            string MonthsAfter = dt.ToString("yyyy/MM/dd");
            Console.WriteLine(MonthsAfter);

            Console.Read();
        }
    }
}
