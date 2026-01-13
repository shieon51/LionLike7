using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260112_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //함수 호출
            ShowGameStart();
            Console.WriteLine();

            SayHello();
            PrintSeparator();

            Console.WriteLine("게임 메뉴를 불러옵니다.....");

            PrintSeparator();


            //같은 함수를 여러번 호출 가능
            Console.WriteLine("게임 종료");

            PrintSeparator();
        }

        //1단계 기본함수
        static void SayHello()
        {
            Console.WriteLine("안녕하세요, 용사님");
            Console.WriteLine("모험을 시작합니다.");
        }

        static void ShowGameStart()
        {
            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║        ⚔ RPG 게임 시작 ⚔        ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
        }

        //함수 정의: 구분선 출력
        static void PrintSeparator()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }


        // ---------------------------------------------
        //int넘겨보기   2매개변수 입력쪽활용
        static void Attack(int att)
        {
            Console.WriteLine("공격력 전달받았다. : " + att);
        }
        static void PlayerInfo(string playerName, int att, int def, int dex, int luck)
        {
            Console.WriteLine("플레이어이름 : " + playerName);
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("방어력 : " + def);
            Console.WriteLine("민첩   : " + dex);
            Console.WriteLine("운     : " + luck);
        }

        //매개변수 3개 체력바 출력
        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.Write("HP [");

            int filledLength = (int)((double)current / max * barLength);

            for (int i = 0; i < barLength; i++)
            {
                if (i < filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }

            Console.WriteLine($"] {current}/{max}");
        }

        //데미지 계산 출력
        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격!");
            Console.WriteLine($"    {target}에게 {damage} 데미지!");
        }

        //반환값이 있는함수 3단계

        //정수반환
        static int GetNumber() //정수반환
        {
            return 42;
        }
        //문자열반환 2단계 입력 / 반환
        static string ConnectMessage(string name)
        {
            return name + "님 접속하셨습니다.";
        }

    }
}
