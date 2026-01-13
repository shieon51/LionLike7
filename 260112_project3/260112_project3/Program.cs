using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260112_project3
{
    internal class Program
    {
        //일반함수
        static void Swap1(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //1부터 n까지의 합 구하기
        static int SumToN(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            return n + SumToN(n - 1); //n+ (n-1까지의 합)

        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;


            //swap 두개의 변수의 값을 바꿔주기
            Swap(ref x, ref y);

            Console.WriteLine("x : " + x + " y : " + y);


            // 재귀

            //1부터 n까지의 합 구하기
            int sum = SumToN(10);

            Console.WriteLine("1+2....10 = " + sum);
        }
    }
}
