using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260108_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //// ==========================================
            //// 예제 2: 숫자 표 만들기
            //// ==========================================
            //Console.WriteLine("\n=== 예제 2: 숫자 표 ===");

            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{j} ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("\n=== 예제 3: 좌표 찍기 ===");

            //for (int y = 0; y < 3; y++)
            //{
            //    for (int x = 0; x < 3; x++)
            //    {
            //        Console.Write($"({x},{y}) ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("⭐");
            //    }
            //    Console.WriteLine();
            //}

            int mapSize = 4;

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (i == 0 && j == 0)
                        Console.Write("🏠");
                    else if (i == mapSize - 1 && j == mapSize - 1)
                        Console.Write("🎯");
                    else
                        Console.Write("🟩");
                }
                Console.WriteLine();
            }
        }
    }
}
