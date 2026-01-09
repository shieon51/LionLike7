using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260108_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\n=== 예제 2: 카운트다운 ===");
            //int countdown = 10;

            //while (countdown > 0)
            //{
            //    Console.WriteLine(countdown);
            //    countdown--;
            //}

            //// ==========================================
            //// 예제 3: 합계 구하기 (1+2+3+4+5)
            //// ==========================================
            //Console.WriteLine("\n=== 예제 3: 합계 구하기 ===");
            //int sum = 0;
            //int i = 1;

            //while (i <= 5)
            //{
            //    sum = sum + i;  // sum += i;
            //    Console.WriteLine(sum);
            //    i++;
            //}

            Console.OutputEncoding = Encoding.UTF8;
            // ==========================================
            // 예제 4: 특정 값까지 반복
            // ==========================================
            Console.WriteLine("\n=== 예제 4: 목표 달성하기 ===");
            int coins = 0;
            int target = 50;
            int day = 0;

            while (coins < target)
            {
                day++;
                coins += 10;  // 하루에 10코인씩
                Console.WriteLine($"{day}일차: 코인 {coins}개");
            }
            Console.WriteLine($"🎉 목표 달성! {day}일 걸렸습니다.");


            int n = 1;

            //천마귀환:

            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;
                //goto 천마귀환; //레이블로 이동
            }
        }
    }
}
