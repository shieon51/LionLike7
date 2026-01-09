using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260109_project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> stats = new Dictionary<string, int>();

            ////데이터추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);


            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach (KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            ////키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //}
            //else
            //{
            //    Console.WriteLine("해당스탯이 없습니다.");
            //}


            Dictionary<string, int> items = new Dictionary<string, int>();

            items.Add("회복 포션", 50);
            items.Add("마나 포션", 40);
            items.Add("강철 검", 500);
            items.Add("가죽 갑옷", 300);
            items.Add("마법 반지", 1000);


            Console.WriteLine("=== 상점 아이템 ===");
            foreach (KeyValuePair<string, int> item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}골드");
            }

            // 구매 시스템
            string buyItem = "강철 검";
            int playerGold = 600;

            if (items.ContainsKey(buyItem))
            {
                int price = items[buyItem];
                if (playerGold >= price)
                {
                    playerGold -= price;
                    Console.WriteLine($"\n✅ '{buyItem}' 구매 성공!");
                    Console.WriteLine($"남은 골드: {playerGold}");
                }
                else
                {
                    Console.WriteLine($"\n❌ 골드가 부족합니다!");
                }
            }

        }
    }
}
