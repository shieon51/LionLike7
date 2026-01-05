using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260105_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 실수 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; // 단정밀도 실수
            //double doublePrecision = 3.1415926535; // 배정밀도 실수
            //decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도(16바이트) 

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);


            //// 접미사 사용: 숫자의 데이터 형식을 명시
            //int integerValue = 100; // 기본 정수형 (int)
            //long longValue = 100L; // 정수형 (long)
            //float floatValue = 3.14f; // 실수형 (float)
            //double doubleValue = 3.14; // 기본 실수형 (double)
            //decimal decimalValue = 3.14m; // 고정밀도 실수형 (decimal)

            //Console.WriteLine(integerValue); // 출력: 100
            //Console.WriteLine(longValue); // 출력: 100
            //Console.WriteLine(floatValue); // 출력: 3.14
            //Console.WriteLine(doubleValue); // 출력: 3.1


            //// char 형식: 단일 문자를 표현
            //char letter = 'A'; // 문자 'A' 저장
            //char symbol = '#'; // 특수 기호 저장
            //char number = '9'; // 숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)
            //Console.WriteLine(letter); // 출력: A
            //Console.WriteLine(symbol); // 출력: #
            //Console.WriteLine(number); // 출력: 9


            // 과제 2
            // float 이동속도 5.5
            // double 공격속도 1.25
            // decimal 아이템 가격 12.99
            float fspeed = 5.5f;
            double speed = 1.25;
            decimal dspeed = 12.99m;

            Console.WriteLine("이동속도: " + fspeed);
            Console.WriteLine("공격속도: " + speed);
            Console.WriteLine("아이템 가격: " + dspeed);


        }

    }
}
