using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 암시적 변환 (작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long bigNumber = smallNumber; //int ->long(자동 변환)
            double doubleNumer = smallNumber; //int -> double(자동 변환)


            Console.WriteLine("=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber.GetType()}");
            Console.WriteLine($"long: {bigNumber.GetType()}");
            Console.WriteLine($"double: {doubleNumer.GetType()}");

            //2.명시적 변환 (큰타입 ->작은타입)
            double pi = 3.14159;
            int intPi = (int)pi;  //소수점을 버림!(명시적 변환 필요)

            Console.WriteLine("\n=== 명시적 변환 ===");
            Console.WriteLine($"double : {pi}");
            Console.WriteLine($"int로 변환 : {intPi}"); //3.14...     3

            //int,flaot ,double, char,long  정파
            //string 사파 커스터마이징 
            //스타벅스 tall  벤티 그란데 
            //개인 텀블러 
            //클래스 신공 구절다외우기힘듬 

            //3. 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); //문자열 -> 정수

            string priceText = "19.99";
            double price = double.Parse(priceText);  //문자열 -> 실수

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열) : {scoreText} -> 숫자: {score}");
            Console.WriteLine($"가격(문자열) : {priceText} -> 숫자: {price}");

            //4.숫자를 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString();

            Console.WriteLine("==== 숫자를 문자열로");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열 : {levelText}");


            //
            //// 1. 명시적 변환 시 데이터 손실
            //double value = 9.8;
            //int result = (int)value;  // 9.8 → 9 (소수점 버려짐!)

            //// 2. 범위 초과
            //int bigValue = 300;
            //byte smallValue = (byte)bigValue;  // 오버플로우 발생!

            //// 3. 잘못된 문자열 변환
            //string text = "abc";
            //// int num = int.Parse(text);  // ❌ 런타임 오류!

            //// 안전한 변환: TryParse 사용
            //if (int.TryParse(text, out int num))
            //{
            //    Console.WriteLine($"변환 성공: {num}");
            //}
            //else
            //{
            //    Console.WriteLine("변환 실패!");
            //}


            int a = 5, b = 3;
            int sum = a + b; // 산술 연산자 사용
            bool isEqual = (a == b); // 관계형 연산자 사용
            Console.WriteLine($"합: {sum}"); // 출력: 8
            Console.WriteLine($"a와 b가 같은가? {isEqual}"); // 출력: False


            int a = 10, b = 3;
            Console.WriteLine(a + b); // 덧셈: 13
            Console.WriteLine(a - b); // 뺄셈: 7
            Console.WriteLine(a * b); // 곱셈: 30
            Console.WriteLine(a / b); // 나눗셈: 3
            Console.WriteLine(a % b); // 나머지: 1


            string firstName = "Alice";
            string lastName = "Smith";
            Console.WriteLine(firstName + " " + lastName); // 출력: Alice Smith

        }
    }
}
