using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q2找出數值區間內的所有質數
            Console.Write("輸入區間起始之正整數: ");
            string input = Console.ReadLine();
            Console.Write("輸入區間結束之正整數: ");
            string input2 = Console.ReadLine();
            
            //判斷是否輸入的真的是正整數
            bool isInt = int.TryParse(input, out int value);
            bool isInt2 = int.TryParse(input2, out int value2);
            if (isInt == false || isInt2 == false || value <0 || value2 <0)
            {
                Console.WriteLine("您輸入的格式有誤，請檢查");
                return;
            }

            //將輸入的兩個數字帶入陣列並排列
            int[] numbers = { value, value2 };
            Array.Sort(numbers);
            
            //依序判斷是否為質數
            int count = 0;
            for (int i = numbers[0]  ; i <= numbers[1]; i++)
            {
                count = 0;
                for (int j = 2 ; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                        break;
                    }
                }
                if(count == 0)
                {
                    if (i == 1) continue; 
                    Console.WriteLine(i);
                }
            }

        }
    }
}
