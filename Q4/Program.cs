using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q4
            //百元買百雞
            //想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
            //公雞(Cock), 母雞(Hen), 小雞(Chicken)
            const int cockPrice = 5;
            const int henPrice = 3;
            const int threeChicken = 1;
            const int numbers = 100;
            const int budget = 100;
            int sumNum = 0;
            int sumFee = 0;
            for(int i = 0; i < budget/cockPrice; i++)
            {
                for (int j = 0; j < budget/henPrice; j++)
                {
                    for (int k = 0; k < budget/threeChicken; k++)
                    {
                        sumNum = i + j + 3*k;
                        sumFee = i*cockPrice + j*henPrice + k*threeChicken;
                        if (sumNum == numbers && sumFee == budget)
                        {
                            Console.WriteLine("一共有以下可能: ");
                            Console.WriteLine($"公雞{i}隻；母雞{j}隻；小雞{3*k}隻");
                        }
                    }
                }
            }
     
            
        }
    }
}
