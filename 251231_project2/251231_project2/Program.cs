using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _251231_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //리터럴: 코드에서 고정된 값을 의미
            //int number = 10;
            //double pi = 3.14;
            //char letter = 'A';
            //string name = "Alice";

            //Console.WriteLine(number);
            //Console.WriteLine(pi);
            //Console.WriteLine(letter);
            //Console.WriteLine(name);

            // 리터럴 연습
            // 플레이스코어 100
            // 파이 3.14
            // 등급 'A'
            // 플레이어 이름 홍길동


            //vsc : 컨트롤 알트 I -> 에이전트 ai 등


            //int playScore = 100;
            //double pi = 3.14;
            //char rank = 'A';
            //string playerName = "홍길동";
            //bool isGameOver = false;


            //Console.WriteLine("플레이어: " + playerName);
            //Console.WriteLine("점수: " + playScore);
            //Console.WriteLine("파이 값: " + pi);
            //Console.WriteLine("등급" + rank);
            //Console.WriteLine("게임 오버: " + isGameOver);


            //// 같은 데이터 타입의 변수를 쉼표로 구분해 한번에 선언
            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            ////
            //int age = 20;
            //string name = "철수";
            //Console.WriteLine("나이: {0}, 이름: {1}", age, name);

            ////
            //Console.WriteLine($"나이: {age}");


            //// 3d 좌표 예시
            //int posX = 0, posY = 50, posZ = 100;

            //Console.WriteLine("x: " + posX + ", y: " + posY + ", z: " + posZ);
            //Console.WriteLine("x: {0}, y: {1}, z: {2}", posX, posY, posZ);
            //Console.WriteLine($"좌표: {posX}, {posY}, {posZ}");

            //// RGB 색상 값 예시
            //int red = 255, green = 128, blue = 0;

            //Console.WriteLine("red: " + red + ", green: " + green + ", blue: " + blue);
            //Console.WriteLine("red: {0}, green: {1}, blue: {2}", red, green, blue);
            //Console.WriteLine($"RGB: {red}, {green}, {blue}");

            //
            int level       = 9;
            int vigor       = 15;
            int mind        = 10;
            int endurance   = 11;
            int strenghth   = 14;
            int dexterity   = 13;
            int intelligence = 9;
            int faith       = 9;
            int arcane = 7;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃    level           {level       }              ┃");
            Console.WriteLine($"┃    vigor           {vigor       }             ┃");
            Console.WriteLine($"┃    mind            {mind        }             ┃");
            Console.WriteLine($"┃    endurance       {endurance   }             ┃");
            Console.WriteLine($"┃    strenghth       {strenghth   }             ┃");
            Console.WriteLine($"┃    dexterity       {dexterity   }             ┃");
            Console.WriteLine($"┃    intelligence    {intelligence}              ┃");
            Console.WriteLine($"┃    faith           {faith       }              ┃");
            Console.WriteLine($"┃    arcane          {arcane      }              ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
