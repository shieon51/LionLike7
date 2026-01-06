using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); // 사용자로부터 입력 받기
            //Console.WriteLine($"안녕하세요, {userName}님!"); // 입력값 출력

            //// 문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine(); // 사용자로부터 입력 받기
            //int age = int.Parse(input); // 문자열을 정수로 변환
            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!"); // 변환된 값 사용


            //// 이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환
            //                                                    // 정수를 이진수로 변환
            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로 변환: {decimalValue}");

            //// 정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2);

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"2진수로 변환: {binaryOutput}");


            //// 과제1
            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write("캐릭터 이름을 입력하세요: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"환영합니다, {userName}님!");

            //Console.Write("시작 레벨을 입력하세요: ");
            //int level = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{userName}님의 시작 레벨은 {level}입니다.");


            // var를 사용하여 변수 선언
            var name = "Alice"; // 문자열로 추론
            var age = 25; // 정수로 추론
            var isStudent = true; // 논리값으로 추론
            Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");



            // default 키워드를 사용한 기본값 설정
            int defaultInt = default; // 기본값: 0
            string defaultString = default; // 기본값: null
            bool defaultBool = default; // 기본값: false

            Console.WriteLine($"정수 기본값: {defaultInt}"); // 출력: 0
            Console.WriteLine($"문자열 기본값: {defaultString}"); // 출력: (null)
            Console.WriteLine($"논리값 기본값: {defaultBool}"); // 출력: False

            //+ 복붙 편하게 하려면 ctrl + D


        }
    }
}
