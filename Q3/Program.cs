using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q3
            //有一個數值,是四位數
            //左邊二位的數字相同
            //右邊二位的數字相同
            //這個四位數值, 剛好也是某整數的平方
            //請問這個四位數值是什麼 ?
            
            for (int i = 1; i <= 9 ; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    string iString = i.ToString();
                    string jString = j.ToString();
                    string value = $"{iString}{iString}{jString}{jString}";
                    int number = Convert.ToInt32(value);
                    string sqrt = Math.Sqrt(number).ToString();
                    bool isInt = int.TryParse(sqrt, out int x);
                    if(isInt == false)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(Math.Pow(x,2));
                    }

                }
            }
            
            
        }
    }
}
