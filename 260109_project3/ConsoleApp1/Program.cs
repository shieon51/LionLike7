using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 선언 방법
            //List<int> numbers = new List<int>();           // 빈 리스트
            //List<string> names = new List<string>();       // 문자열 리스트
            //List<float> prices = new List<float>();        // 실수 리스트

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };


            //List<string> items = new List<string>();

            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");


            //List 생성
            List<string> inventory = new List<string>();

            Console.WriteLine("=== 도적 인벤토리 시스템 ==");

            //아이템 추가 (Add)
            inventory.Add("회복 포션");
            inventory.Add("마나 포션");
            inventory.Add("강철 검");
            Console.WriteLine("아이템 3개 추가");

            //현재 인벤토리
            Console.WriteLine($"인벤토리 ({inventory.Count}개):");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventory[i]}");
            }
            Console.WriteLine();
            inventory[0] = "초록포션";

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventory[i]}");
            }
            Console.WriteLine();
            //특정 위치에 추가 (Insert)
            inventory.Insert(1, "전설 검");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventory[i]}");
            }

            //아이템 제거 (Remove)
            inventory.Remove("초록포션");
            Console.WriteLine();

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventory[i]}");
            }

            //인덱스로 제거 (RemoveAt)
            inventory.RemoveAt(0);
            Console.WriteLine();
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"[{i}] {inventory[i]}");
            }
        }
    }
}
