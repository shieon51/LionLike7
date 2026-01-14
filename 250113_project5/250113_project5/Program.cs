using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250113_project5
{
    /*프로퍼티 연습 문제 (쉬운 난이도)
    📝 문제 1: 학생 성적 관리 시스템
    문제 설명
    Student 클래스를 만들어 학생의 성적을 관리하세요.

    요구사항
    name (이름) - 읽기 전용 프로퍼티
    score (점수) - 0~100 사이의 값만 허용하는 프로퍼티
    Grade (등급) - 점수에 따라 자동 계산되는 읽기 전용 프로퍼티
    90점 이상: "A"
    80점 이상: "B"
    70점 이상: "C"
    60점 이상: "D"
    60점 미만: "F"*/

    //public class Student
    //{
    //    private string name;
    //    private int score;

    //    public string Name
    //    {
    //        get { return name; }
    //    }

    //    public int Score 
    //    { 
    //        get { return score; } 
    //        set 
    //        {
    //            if (value < 0)
    //            {
    //                Console.WriteLine($"점수는 0~100사이여야 합니다.(입력값 : {value})");
    //                score = 0;
    //            }
    //            else if (value > 100)
    //            {
    //                Console.WriteLine($"점수는 0~100사이어야 합니다. (입력값: {value})");
    //                score = 100;
    //            }
    //            else
    //            {
    //                score = value;
    //            }
    //        } 
    //    }
    //    public string Grade
    //    {
    //        get
    //        {
    //            if (score >= 90)
    //                return "A";
    //            else if (score >= 80)
    //                return "B";
    //            else if (score >= 70)
    //                return "C";
    //            else if (score >= 60)
    //                return "D";
    //            else
    //                return "F";
    //        }
    //    }

    //    // 생성자
    //    public Student(string studentName)
    //    {
    //        name = studentName;
    //        score = 0;
    //    }

    //    // 정보 출력
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━");
    //        Console.WriteLine($"이름: {Name}");
    //        Console.WriteLine($"점수: {Score}점");
    //        Console.WriteLine($"등급: {Grade}");
    //        Console.WriteLine($"━━━━━━━━━━━━━━━━");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Student student = new Student("홍길동");
    //        student.Score = 95;
    //        student.ShowInfo();

    //        Console.WriteLine();

    //        student.Score = 75;
    //        student.ShowInfo();

    //        Console.WriteLine();

    //        // 잘못된 값 입력 시도
    //        student.Score = 150;  // 100으로 제한되어야 함
    //        student.Score = -10;  // 0으로 제한되어야 함
    //        student.ShowInfo();
    //    }
    //}


    // 부모 클래스
    class Character
    {
        private int hp;

        // virtual 프로퍼티 (가상 함수 테이블에 등록됨!)
        public virtual int HP
        {
            get
            {
                Console.WriteLine("[Character.HP.get 호출]");
                return hp;
            }
            set
            {
                Console.WriteLine($"[Character.HP.set 호출] {value}");
                if (value < 0) hp = 0;
                else hp = value;
            }
        }

        // virtual 메서드 (비교를 위해)
        public virtual void ShowHP()
        {
            Console.WriteLine($"[Character.ShowHP 호출] HP: {HP}");
        }
    }

    // 자식 클래스
    class Warrior : Character
    {
        // 프로퍼티 오버라이드 (vtable의 엔트리를 교체!)
        public override int HP
        {
            get
            {
                Console.WriteLine("[Warrior.HP.get 호출 - 방어력 보너스 적용]");
                return base.HP + 50;  // 전사는 HP에 방어력 보너스
            }
            set
            {
                Console.WriteLine($"[Warrior.HP.set 호출] {value} (전사 버전)");
                base.HP = value;
            }
        }

        // 메서드 오버라이드
        public override void ShowHP()
        {
            Console.WriteLine($"[Warrior.ShowHP 호출] ⚔️ 전사 HP: {HP}");
        }
    }

    class Mage : Character
    {
        // 프로퍼티 오버라이드
        public override int HP
        {
            get
            {
                Console.WriteLine("[Mage.HP.get 호출 - 마나 실드 적용]");
                return base.HP * 2;  // 마법사는 마나 실드로 2배
            }
            set
            {
                Console.WriteLine($"[Mage.HP.set 호출] {value} (마법사 버전)");
                base.HP = value / 2;  // 실제 HP는 절반만 저장
            }
        }

        public override void ShowHP()
        {
            Console.WriteLine($"[Mage.ShowHP 호출] 🔮 마법사 HP: {HP}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║   Virtual 프로퍼티와 가상 함수 테이블   ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝\n");

            // ========== 1. 다형성 테스트 ==========
            Console.WriteLine("【 1. 다형성 (Polymorphism) 】\n");

            Character[] party = new Character[3];
            party[0] = new Character();
            party[1] = new Warrior();
            party[2] = new Mage();

            Console.WriteLine("=== HP 설정 (set 접근자 호출) ===\n");

            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine($"캐릭터 {i + 1}:");
                party[i].HP = 100;  // 각 클래스의 set 접근자 호출!
                Console.WriteLine();
            }

            Console.WriteLine("=== HP 읽기 (get 접근자 호출) ===\n");

            for (int i = 0; i < party.Length; i++)
            {
                Console.WriteLine($"캐릭터 {i + 1}:");
                int currentHP = party[i].HP;  // 각 클래스의 get 접근자 호출!
                Console.WriteLine($"결과값: {currentHP}\n");
            }

            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

            // ========== 2. 메서드와 프로퍼티 비교 ==========
            Console.WriteLine("【 2. 메서드 vs 프로퍼티 오버라이드 】\n");

            Character warrior = new Warrior();

            Console.WriteLine("메서드 호출:");
            warrior.ShowHP();

            Console.WriteLine("\n프로퍼티 접근:");
            Console.WriteLine($"HP 값: {warrior.HP}");

            Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

            // ========== 3. vtable 동작 확인 ==========
            Console.WriteLine("【 3. 런타임 타입에 따른 동작 】\n");

            Character baseRef;

            Console.WriteLine("▶ Character 타입으로 Warrior 참조:");
            baseRef = new Warrior();
            baseRef.HP = 50;
            Console.WriteLine($"읽은 값: {baseRef.HP}");

            Console.WriteLine("\n▶ Character 타입으로 Mage 참조:");
            baseRef = new Mage();
            baseRef.HP = 50;
            Console.WriteLine($"읽은 값: {baseRef.HP}");

            Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");

            // ========== 4. get과 set을 각각 오버라이드 ==========
            Console.WriteLine("【 4. get/set 개별 오버라이드 】\n");

            PartialOverride po = new PartialOverride();

            //Console.WriteLine("set 호출:");
            //po.PartialProp = 100;

            //Console.WriteLine("\nget 호출:");
            //Console.WriteLine($"값: {po.PartialProp}");
        }
    }

    // get만 오버라이드하는 예제
    class PartialOverride : Character
    {
        // get만 오버라이드 (set은 부모 클래스 사용)
        public override int HP
        {
            get
            {
                Console.WriteLine("[PartialOverride.HP.get] - 10배 반환");
                return base.HP * 10;
            }
            set => base.HP = value;
        }
    }
}
