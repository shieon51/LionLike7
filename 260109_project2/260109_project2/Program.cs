using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _260109_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 방법 1: 크기만 지정
            //int[,] grid = new int[3, 4];  // 3행 4열

            //// 방법 2: 선언과 동시에 초기화
            //int[,] numbers = new int[2, 3]
            //{
            //    { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};

            //// 방법 3: new 생략 (간단한 초기화)
            //int[,] scores =
            //{
            //     { 90, 85, 88 },
            //     { 92, 78, 95 },
            //     { 87, 91, 84 }
            //};


            //int[,] array = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = array.Length;  // 12 (3 x 4)

            //// 특정 차원의 길이
            //int rows = array.GetLength(0);     // 3 (행 개수)
            //int cols = array.GetLength(1);     // 4 (열 개수)

            //// Rank: 배열의 차원 수
            //int dimensions = array.Rank;       // 2


            //string[,] seat =
            //{
            //    {"A1", "A2", "A3" },
            //    {"B1", "B2", "B3" },
            //    {"C1", "C2", "C3" },
            //};

            //for(int i = 0; i < seat.GetLength(0); i++)
            //{
            //    for(int j = 0; j < seat.GetLength(1); j++)
            //    {
            //        Console.Write($"[{seat[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}

            ////2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //      { 0,0,1,0,0},
            //      { 0,2,1,0,3},
            //      { 0,0,1,0,0},
            //      { 1,1,1,0,0},
            //      { 0,0,0,0,9},
            //};

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");
            //Console.OutputEncoding = Encoding.UTF8;

            ////맵 출력
            //for (int y = 0; y < map.GetLength(0); y++)
            //{
            //    for (int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch (map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");
            //                break;
            //            case 1:
            //                Console.Write("⬛ ");
            //                break;
            //            case 2:
            //                Console.Write("👹 ");
            //                break;
            //            case 3:
            //                Console.Write("💎 ");
            //                break;
            //            case 9:
            //                Console.Write("🚪 ");
            //                break;
            //        }

            //    }
            //    Console.WriteLine();
            //}


            // 학생 3명, 과목 4개 (국어, 영어, 수학, 과학)
            int[,] scores = new int[3, 4]
            {
            { 85, 90, 88, 92 },  // 학생 1
            { 78, 85, 90, 87 },  // 학생 2
            { 92, 88, 95, 90 }   // 학생 3
            };

            string[] students = { "김철수", "이영희", "박민수" };
            string[] subjects = { "국어", "영어", "수학", "과학" };

            Console.WriteLine("=== 성적표 ===\n");

            // 헤더 출력
            Console.Write("이름\t");
            foreach (string subject in subjects)
            {
                Console.Write($"{subject}\t");
            }
            Console.WriteLine("평균");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            // 학생별 성적 출력
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.Write($"{students[i]}\t");

                int sum = 0;
                for (int j = 0; j < scores.GetLength(1); j++)
                {
                    Console.Write($"{scores[i, j]}\t");
                    sum += scores[i, j];
                }

                double average = (double)sum / scores.GetLength(1);
                Console.WriteLine($"{average:F1}");
            }

            // 과목별 평균
            Console.WriteLine("\n=== 과목별 평균 ===");
            for (int subject = 0; subject < scores.GetLength(1); subject++)
            {
                int sum = 0;
                for (int student = 0; student < scores.GetLength(0); student++)
                {
                    sum += scores[student, subject];
                }
                double avg = (double)sum / scores.GetLength(0);
                Console.WriteLine($"{subjects[subject]}: {avg:F1}점");
            }


        }
    }
}
