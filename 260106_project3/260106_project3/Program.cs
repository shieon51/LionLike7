using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260106_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage = 30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("=== 공격력 계산 ===");
            //Console.WriteLine($"기본 공격력 : {baseAttack}");
            //Console.WriteLine($"무기 데미지 : {weaponDamage}");
            //Console.WriteLine($"총 공격력 : {totalAttack}");

            ////데미지 계산
            //int playerHealth = 100;
            //int damage = 25;
            //playerHealth = playerHealth - damage;

            //Console.WriteLine("\n === 데미지 계산 ===");
            //Console.WriteLine($"받은 데미지: {damage}");
            //Console.WriteLine($"남은 체력: {playerHealth}");


            ////경험치 계산
            //int monsterSkilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterSkilled * expPerMonster;

            //Console.WriteLine("=== 경험치 획득 ===");
            //Console.WriteLine($"처치한 몬스터: {monsterSkilled}마리");
            //Console.WriteLine($"몬스터당 경험치: {expPerMonster}");
            //Console.WriteLine($"총 경험치: {totalExp}");

            ////아이템 분배
            //int totalGold = 1000;
            //int playerCount = 4;
            //int goldPerPlayer = totalGold / playerCount;
            //int remainingGold = totalGold % playerCount;


            //Console.WriteLine("===골드 분배===");
            //Console.WriteLine($"총 골드: {totalGold}");
            //Console.WriteLine($"플레이어 수 : {playerCount}명");
            //Console.WriteLine($"1인당 골드 : {goldPerPlayer}");
            //Console.WriteLine($"남은골드: {remainingGold}");


            //int killCount = 0;

            //Console.WriteLine("=== 몬스터 처치 ===");
            //Console.WriteLine($"고블린 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"오크 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"드래곤 처치! (킬 카운트: {++killCount})");
            //Console.WriteLine($"총 처치 수: {killCount}");

            //int bulletNum = 30;
            //Console.WriteLine("\n=== 사격 ===");
            //Console.WriteLine($"남은 탄약: {bulletNum}");
            //Console.WriteLine($"발사! 남은 탄약: {--bulletNum}");
            //Console.WriteLine($"발사! 남은 탄약: {--bulletNum}");
            //Console.WriteLine($"발사! 남은 탄약: {--bulletNum}");

            //int countdown = 3;

            //Console.WriteLine("\n=== 카운트다운 ===");
            //Console.WriteLine(countdown--);
            //Console.WriteLine(countdown--);
            //Console.WriteLine(countdown--);
            //Console.WriteLine("발사!");


            //bool a = true;
            //bool b = true;


            //Console.WriteLine(a && b);
            //a = false;
            //b = true;
            //Console.WriteLine(a && b);
            //a = true;
            //b = false;
            //Console.WriteLine(a && b);
            //a = false;
            //b = false;
            //Console.WriteLine(a && b);


            ////OR
            //a = false;
            //b = false;

            //Console.WriteLine(a || b);
            //a = false; b = true;
            //Console.WriteLine(a || b);
            //a = true; b = false;
            //Console.WriteLine(a || b);
            //a = true; b = true;
            //Console.WriteLine(a || b);


            ////!
            //Console.WriteLine(!a);


            //// 비트 연산
            //int x = 5; // 0101
            //int y = 3; // 0011

            //string binary = Convert.ToString(x & y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(x | y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(x ^ y, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");

            //binary = Convert.ToString(~x, 2);
            //Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}");


            int value = 4; //0100

            string binary = Convert.ToString(value << 1, 2);
            Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}"); // 왼쪽 이동: 8 (00001000)

            binary = Convert.ToString(value >> 1, 2);
            Console.WriteLine($"8비트 : {binary.PadLeft(8, '0')}"); // 오른쪽 이동: 2 (00000010)


            //
            int inventory = 0; // 0000 0000 

            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //슬롯 번호
            int slot1 = 1; //활
            int slot2 = 2; //지팡이

            //슬롯 0에 활을 추가
            inventory = inventory | (1 << slot1); // 2번째로 1추가
            Console.WriteLine($"슬롯 {slot1}에 활 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //슬롯 0에 활을 추가
            inventory = inventory | (1 << slot2); // 2번째로 1추가
            Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

        }
    }
}
