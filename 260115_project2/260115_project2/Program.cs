using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260115_project2
{
    //인터페이스 
    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();
    }

    //인터페이스 Defendable 구현 방어기능
    interface IDefendable
    {
        void Defend();
        int GetDefensePower();
    }


    class Knight : IAttackable, IDefendable //알트 + 엔터
    {

        public string name;
        public int attackPower;
        public int defensePower;

        public Knight()
        {
            name = "검사";
            attackPower = 10;
            defensePower = 5;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 {target}를 공격 했습니다.");

        }

        public void Defend()
        {
            Console.WriteLine("기사가 방어모드중입니다.");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetDefensePower()
        {
            return defensePower;
        }
    }

    //마법사클래스를 만들고 어택 인터페이스를 구현하시오
    class Mage : IAttackable  //알트 + 엔터
    {

        public string name;
        public int attackPower;

        public Mage()
        {
            name = "검사";
            attackPower = 10;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 {target}를 공격 했습니다.");

        }

        public int GetAttackPower()
        {
            return attackPower;
        }
    }

    
    abstract class GameUnit
    {
        protected string name;
        protected int hp;
        protected int maxHP;
        protected int moveSpeed;

        public GameUnit(string unitName, int health, int speed)
        {
            name = unitName;
            maxHP = health;
            hp = maxHP;
            moveSpeed = speed;
        }

        // 추상 메서드 (구현 안 됨 - 자식이 반드시 구현)
        public abstract void ShowInfo();
    }


    // 구체 클래스 1: 전사
    class Warrior : GameUnit
    {
        private int attack;
        private int defense;

        public Warrior(string name) : base(name, 200, 5)
        {
            attack = 80;
            defense = 50;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[전사] {name}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }
    }

    // 구체 클래스 2: 마법사
    class Wizard : GameUnit
    {
        private int magicPower;
        private int mana;

        public Wizard(string name) : base(name, 120, 4)
        {
            magicPower = 150;
            mana = 100;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[마법사] {name}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"마력: {magicPower}");
            Console.WriteLine($"마나: {mana}");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }
    }


    // 구체 클래스 3: 궁수
    class Ranger : GameUnit
    {
        private int rangedAttack;
        private int arrows;

        public Ranger(string name) : base(name, 150, 6)
        {
            rangedAttack = 100;
            arrows = 50;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[궁수] {name}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {rangedAttack}");
            Console.WriteLine($"화살: {arrows}");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // 다형성: 추상 클래스 타입으로 배열 생성
            GameUnit[] units = new GameUnit[3];
            units[0] = new Warrior("홍길동");
            units[1] = new Wizard("김마법");
            units[2] = new Ranger("이궁수");

            // 모든 유닛 정보 출력
            foreach (GameUnit unit in units)
            {
                unit.ShowInfo();
                Console.WriteLine();
            }

            //

            Knight knight = new Knight();
            knight.Attack("오크");
            knight.Defend();

            Mage mage = new Mage();
            mage.Attack("고블린");
        }
    }
}
