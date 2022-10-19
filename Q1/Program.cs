using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1 判斷某數是不是質數
            Console.Write("請輸入一個正整數: ");
            string input = Console.ReadLine();
            bool isInt = int.TryParse(input, out int value);
            if( isInt ==false)
            {
                Console.WriteLine ("您輸入的不是整數");
                return;
            }
            if( value < 0)
            {
                Console.WriteLine("您輸入的數值非正整數");
                return ;
            }
            int count = 0;
            for (int i = 2; i < Math.Sqrt(value); i++)
            {
                if(value % i == 0)
                {
                    count += 1; 
                    break;
                }            
            }
            if( count == 0 && value !=1)
            {
                Console.WriteLine("是質數");
            }
            else
            {
                Console.WriteLine("不是質數");
            }
        }
    }
}
