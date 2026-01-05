using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260105_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// string 형식: 여러 문자를 저장
            //string greeting = "Hello, World!"; // 문자열 저장
            //string name = "Alice"; // 이름 저장

            //Console.WriteLine(greeting); // 출력: Hello, World!
            //Console.WriteLine(name); // 출력: Alice


            //// 과제 3: 

            ////실행 결과:
            ////=== RPG 게임 ===
            ////플레이어: 홍길동
            ////등급: A등급 ★
            ////게임에 오신 것을 환영합니다!`

            //char grade = 'A';
            //char symbol = '★';
            //char number = '9'; // 문자 '9'이지 숫자 9가 아님!

            //// 문자열 (string) - 여러 문자의 조합
            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = ""; // 빈 문자열도 가능

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}");
            //Console.WriteLine(welcomeMessage);


            //// bool 형식: 참(True) 또는 거짓(False)
            //bool isRunning = true; // 프로그램 실행 상태
            //bool isFinished = false; // 프로그램 종료 상태
            //Console.WriteLine(isRunning); // 출력: True
            //Console.WriteLine(isFinished); // 출력: False

            // 과제 4
            // === 게임 상태 ===
            // 게임 실행중: t
            // 일시 정지: f
            // 열쇠 소지: f
            // 문 열림: f
            // 플레이어 생존: t

            // === 캐릭터 상태 ===
            // 체력: 80
            // 건강 상태: t
            // 위험 상태: f

            //bool isGameRunning = true;
            //bool isGamePaused = false;
            //bool isKeyExist = false;
            //bool isDoorOpen = false;
            //bool isPlayerAlive = true;

            //int hp = 80;
            //bool isHealthy = true;
            //bool isBadCondition = false;

            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {isGameRunning}");
            //Console.WriteLine($"일시정지: {isGamePaused}");
            //Console.WriteLine($"열쇠 소지: {isKeyExist}");
            //Console.WriteLine($"문 열림: {isDoorOpen}");
            //Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //Console.WriteLine($"체력: {hp}");
            //Console.WriteLine($"건강 상태: {isHealthy}");
            //Console.WriteLine($"위험 상태: {isBadCondition}");


            // 닷넷 형식: 기본 형식의 닷넷 표현
            //System.Int32 number = 123; // int의 닷넷 형식
            //System.String text = "Hello"; // string의 닷넷 형식
            //System.Boolean flag = true; // bool의 닷넷 형식

            //Console.WriteLine(number); // 출력: 123
            //Console.WriteLine(text); // 출력: Hello
            //Console.WriteLine(flag); // 출력: True



            // int 래퍼 형식의 메서드 활용
            int number = 123;
            string numberAsString = number.ToString(); // 정수를 문자열로 변환
                                                       // bool 래퍼 형식의 메서드 활용
            bool flag = true;
            string flagAsString = flag.ToString(); // 논리값을 문자열로 변환

            Console.WriteLine(numberAsString); // 출력: "123"
            Console.WriteLine(flagAsString); // 출력: "True"



        }
    }
}
