using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // 추가

namespace _260105_project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안");
            Thread.Sleep(1000); // 1000: 1초
            Console.Clear(); // 콘솔내용 한번씩 지움
            Console.WriteLine("안녕");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("안녕하");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("안녕하세");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("안녕하세요");
            Thread.Sleep(1000);

            // 과제 5
            // 저번 시간에 만들었던 UI 하나 정해서 비주얼하게 만들어보기

        }
    }
}
