using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260105_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 상수: 값을 변경할 수 없는 변수
            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //// 출력
            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("Max Score: " + MaxScore);

            // 과제 1
            //const int MaxPlayer = 4;
            //const int InitGold = 1000;
            //const string version = "1.0.0";

            //Console.WriteLine("=== 게임 설정 ===");
            //Console.WriteLine("최대 플레이어: " + MaxPlayer);
            //Console.WriteLine("시작 골드: " + InitGold + "G");
            //Console.WriteLine("버전: " + version);


            // 1. 숫자 데이터 타입
            //int integerNum = 10; // 정수 데이터
            //float floatNum = 3.14f; // 단정밀도 실수 (f 안 붙이면 에러남)
            //double doubleNum = 3.14159; // 배정밀도 실수

            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            // 2. 정수 
            // 게임 캐릭터 스텟
            byte level = 50;
            short attack = 1500;
            int gold = 1234567;
            long experience = 999999999L;

            Console.WriteLine("=== 캐릭터 정보 ===");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"소지금: {gold:N0}골드"); // N0: 천 단위 콤마
            Console.WriteLine($"경험치: {experience:N0}");

            // 타입별 최대값 화면
            Console.WriteLine("\n=== 타입별 최대값 ===");
            Console.WriteLine($"byte 최대값: {byte.MaxValue}");
            Console.WriteLine($"short 최대값: {short.MaxValue}");
            Console.WriteLine($"int 최대값: {int.MaxValue}");
            Console.WriteLine($"long 최대값: {long.MaxValue}");
            

        }
    }
}
