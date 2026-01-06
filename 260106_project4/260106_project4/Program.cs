using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문제 1: RPG 체력 계산기
            int currentHP = 80;
            int maxHP = 100;

            Console.WriteLine($"초기 체력: {currentHP}/{maxHP}");
            currentHP -= 25;
            Console.WriteLine($"데미지 -25: {currentHP}/{maxHP}");
            currentHP += 30;
            Console.WriteLine($"회복 +30: {currentHP}/{maxHP}");
            currentHP -= 5;
            Console.WriteLine($"독 데미지 -5: {currentHP}/{maxHP}");


            //문제 2: 경험치와 레벨 계산
            int expPerMonster = 150;
            int monstersKilled = 3;
            int expForLevelUp = 500;
            // * 연산자와 - 연산자 사용

            Console.WriteLine($"\n처치한 몬스터: {monstersKilled}마리");
            Console.WriteLine($"획득 경험치: {expPerMonster * monstersKilled}");
            Console.WriteLine($"레벨업까지 필요: {expForLevelUp - (expPerMonster * monstersKilled)}");


            // 문제 3: 아이템 분배 시스템
            int totalGold = 1234;
            int partyMembers = 5;
            // / 연산자와 % 연산자 사용

            Console.WriteLine($"\n총 골드: {totalGold}");
            Console.WriteLine($"파티원: {partyMembers}");
            Console.WriteLine($"1인당 골드: {totalGold / partyMembers}");
            Console.WriteLine($"남은 골드: {totalGold % partyMembers}");


            // 문제 4: 던전 입장 가능 여부
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currentHP2 = 60;
            int maxHP2 = 100;
            // >=, &&, || 연산자 활용

            Console.WriteLine("\n=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건 (30 이상): {playerLevel >= requiredLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상): {currentHP2 * 100 / maxHP2 >= 50}");
            Console.WriteLine($"입장 가능 : {(playerLevel >= requiredLevel) && hasKey && (currentHP2 * 100 / maxHP2 >= 50)}");


            // 문제 5: 상점 할인 계산기
            int originalPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;
            // 할인율 계산: 가격 * 0.8
            // 쿠폰 할인: 가격 - 500
            int result = originalPrice;

            Console.WriteLine($"\n원가: {originalPrice}골드");
            if ( isVIP ) 
            {
                result = result * 80 / 100;
                Console.WriteLine($"VIP 할인 (20%): {result}골드");
            }
            if (hasCoupon)
            {
                result -= 500;
                Console.WriteLine($"쿠폰 할인 (-500): {result}골드");
            }

            Console.WriteLine($"최종 가격: {result}골드");

        }
    }
}
