using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _260107_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int score = 0;
            //string rank;

            //Console.WriteLine("=== 게임 랭크 시스템 ===");
            //Console.WriteLine("스코어를 입력하세요 : ");
            //score = int.Parse(Console.ReadLine());
            //Console.WriteLine($"점수 : {score}");


            //if (score >= 10000)
            //{
            //    rank = "SSS";
            //    Console.WriteLine($"등급 : {rank} (레전드)");
            //    Console.WriteLine("보상: 전설 아이템 + 골드 10000");
            //}
            //else if (score >= 8000)
            //{
            //    rank = "SS";
            //    Console.WriteLine($"등급 : {rank} (마스터)");
            //    Console.WriteLine("보상: 영웅 아이템 + 골드 5000");
            //}
            //else if (score >= 6000)
            //{
            //    rank = "S";
            //    Console.WriteLine($"등급 : {rank} (다이아)");
            //    Console.WriteLine("보상: 희귀 아이템 + 골드 3000");
            //}
            //else if (score >= 4000)
            //{
            //    rank = "A";
            //    Console.WriteLine($"등급 : {rank} (플래티넘)");
            //    Console.WriteLine("보상: 고급 아이템 + 골드 1500");
            //}
            //else
            //{
            //    rank = "B";
            //    Console.WriteLine($"등급 : {rank} (골드)");
            //    Console.WriteLine("보상: 일반 아이템 + 골드 500");
            //}


            //Console.OutputEncoding = Encoding.UTF8;

            //// 캐릭터 상태 판정
            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //int health = 0;
            //Console.WriteLine("현재 hp를 입력하세요: ");
            //health = int.Parse(Console.ReadLine());
            ////헬스값을 입력받아서 테스트해보시오.

            //if (health >= 80)
            //{
            //    Console.WriteLine("💚 상태: 매우 좋음");
            //}
            //else if (health >= 60)
            //{
            //    Console.WriteLine("🟢 상태: 좋음");
            //}
            //else if (health >= 40)
            //{
            //    Console.WriteLine("🟡 상태: 보통");
            //}
            //else if (health >= 20)
            //{
            //    Console.WriteLine("🟠 상태: 위험");
            //}
            //else
            //{
            //    Console.WriteLine("🔴 상태: 매우 위험!");
            //}

            //int day = 3;

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("화요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("수요일");
            //        break;
            //    default:
            //        Console.WriteLine("유효하지 않은 요일");
            //        break;
            //}

            //Console.OutputEncoding = Encoding.UTF8;

            //// 캐릭터 직업 선택
            //int jobChoice = 2;  // 1:전사, 2:마법사, 3:궁수, 4:도적

            //Console.WriteLine("=== 캐릭터 생성 ===");

            //switch (jobChoice)
            //{
            //    case 1:
            //        Console.WriteLine("직업: ⚔️ 전사");
            //        Console.WriteLine("특성: 높은 체력과 방어력");
            //        Console.WriteLine("주 무기: 검, 도끼");
            //        Console.WriteLine("스탯: HP +50, 공격력 +10");
            //        break;

            //    case 2:
            //        Console.WriteLine("직업: 🔮 마법사");
            //        Console.WriteLine("특성: 강력한 마법 공격");
            //        Console.WriteLine("주 무기: 지팡이, 마법서");
            //        Console.WriteLine("스탯: 마나 +100, 마법력 +20");
            //        break;

            //    case 3:
            //        Console.WriteLine("직업: 🏹 궁수");
            //        Console.WriteLine("특성: 원거리 공격 특화");
            //        Console.WriteLine("주 무기: 활, 석궁");
            //        Console.WriteLine("스탯: 민첩 +15, 크리티컬 +10%");
            //        break;

            //    case 4:
            //        Console.WriteLine("직업: 🗡️ 도적");
            //        Console.WriteLine("특성: 빠른 속도와 치명타");
            //        Console.WriteLine("주 무기: 단검, 쌍검");
            //        Console.WriteLine("스탯: 민첩 +20, 회피율 +15%");
            //        break;

            //    default:
            //        Console.WriteLine("❌ 잘못된 선택입니다.");
            //        Console.WriteLine("1~4 중에서 선택해주세요.");
            //        break;
            //}


            //// 아이템 타입별 설명
            //Console.WriteLine("\n=== 아이템 정보 ===");
            //string itemType = "weapon";

            //switch (itemType)
            //{
            //    case "weapon":
            //        Console.WriteLine("🗡️ 무기 - 공격력 증가");
            //        break;
            //    case "armor":
            //        Console.WriteLine("🛡️ 방어구 - 방어력 증가");
            //        break;
            //    case "potion":
            //        Console.WriteLine("🧪 물약 - 체력/마나 회복");
            //        break;
            //    case "accessory":
            //        Console.WriteLine("💍 장신구 - 특수 능력 부여");
            //        break;
            //    default:
            //        Console.WriteLine("❓ 알 수 없는 아이템");
            //        break;
            //}

            //// 요일별 이벤트
            //Console.WriteLine("\n=== 오늘의 이벤트 ===");
            //int dayOfWeek = 3;  // 0:일, 1:월, 2:화, 3:수, 4:목, 5:금, 6:토

            //switch (dayOfWeek)
            //{
            //    case 0:
            //        Console.WriteLine("🎁 일요일: 경험치 2배");
            //        break;
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("📅 평일: 일반 보상");
            //        break;
            //    case 5:
            //        Console.WriteLine("💰 금요일: 골드 2배");
            //        break;
            //    case 6:
            //        Console.WriteLine("🎲 토요일: 아이템 드롭률 2배");
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 요일");
            //        break;
            //}


            //Console.OutputEncoding = Encoding.UTF8;

            //int count = 5;  //ctrl + R 두번 하면 같은 변수명 한번에 바꾸기 가능

            //Console.WriteLine("=== 게임 시작 카운트다운 ===");
            //for (int i = count; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}
            //Console.WriteLine("🎮 게임 시작!");
            string sword = "무한의 대검";

            Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

            Random rand = new Random();

            int random = 0;

            for (int i = 0; i < 20; i++)
            {
                random = rand.Next(1, 101);

                if (random >= 1 && random <= 10)
                {
                    sword = "무한의 대검";
                }
                else if (random >= 11 && random <= 30)
                {
                    sword = "카타나";
                }
                else if (random >= 31 && random <= 60)
                {
                    sword = "엑스칼리버";
                }
                else if (random >= 61 && random <= 100)
                {
                    sword = "정기정검";
                }

                Console.WriteLine(sword);
                Thread.Sleep(500);
            }
        }
    }
}
