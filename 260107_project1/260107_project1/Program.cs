using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260107_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b; // 삼항 연산자
            //Console.WriteLine(max); // 출력: 20


            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine($"점수: {score}");
            //Console.WriteLine($"결과: {result}");

            //// 예제 1
            //int level = 45;
            //string grade = (level > 50) ? "고급" :
            //               ((level > 30) ? "중급" : "초급");
            //Console.WriteLine("플레이어 등급");
            //Console.WriteLine($"레벨: {level}");
            //Console.WriteLine($"등급: {grade}");


            //// 예제 2
            //int currentHP = 30;
            //int maxHP = 100;
            //string state = (currentHP >= maxHP * 0.7) ? "안전" :
            //               (currentHP >= maxHP * 0.3) ? "주의" : "위험";
            //Console.WriteLine($"체력: {currentHP}/{maxHP}");
            //Console.WriteLine($"상태: {state}");


            //// 예제 3: 데미지 계산
            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0

            //Console.OutputEncoding = Encoding.UTF8;

            //int currentHP = 30;
            //int maxHP = 100;
            //int danger = currentHP * 100 / maxHP;

            //Console.WriteLine($"현재 체력: {currentHP}/{maxHP}");
            //if (currentHP == 0)
            //{
            //    Console.WriteLine("게임 오버!");
            //    Console.WriteLine("부활 지점에서 다시 시작합니다.");
            //}
            //else 
            //{
            //    if (danger <= 30)
            //    {
            //        Console.WriteLine("⚠️ 경고: 체력이 위험합니다!");
            //        Console.WriteLine("회복 아이템을 사용하세요!");
            //    }
            //    if (danger <= 50)
            //    {
            //        Console.WriteLine("💊 체력이 50% 이하입니다.");
            //    }
            //}

            //int attackRange = 5;
            //int enemyDistance = 3;

            //if (attackRange >= enemyDistance)
            //{
            //    Console.WriteLine("⚔️ 적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}

            // 아이템 구매 시스템
            // 아이템 구매 시스템
            int playerGold = 500;
            int itemPrice = 350;
            string itemName = "강철 검";

            Console.WriteLine("=== 상점 ===");
            Console.WriteLine($"아이템: {itemName}");
            Console.WriteLine($"가격: {itemPrice}골드");
            Console.WriteLine($"소지금: {playerGold}골드");
            Console.WriteLine();

            if (playerGold >= itemPrice)
            {
                // 구매 가능
                playerGold -= itemPrice;
                Console.WriteLine("✅ 구매 성공!");
                Console.WriteLine($"{itemName}을(를) 획득했습니다!");
                Console.WriteLine($"남은 골드: {playerGold}");
            }
            else
            {
                // 구매 불가
                int needGold = itemPrice - playerGold;
                Console.WriteLine("❌ 골드가 부족합니다!");
                Console.WriteLine($"필요한 골드: {needGold}골드 더 필요");
            }

            Console.WriteLine("\n=== 던전 입장 ===");
            int playerLevel = 48;
            int requiredLevel = 50;

            if (playerLevel >= requiredLevel)
            {
                Console.WriteLine("🚪 던전에 입장합니다!");
                Console.WriteLine("전투 준비!");
            }
            else
            {
                Console.WriteLine("🚫 레벨이 부족합니다!");
                Console.WriteLine($"필요 레벨: {requiredLevel}");
                Console.WriteLine($"현재 레벨: {playerLevel}");
                Console.WriteLine($"레벨업이 필요합니다: {requiredLevel - playerLevel}레벨");
            }
        }
    }
}
