using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260113_project1
{
    class Character 
    {
        public string name;
        public int level;
        public int hp;
        public int maxHP;
        public int mp;
        public int maxMP;

        //기본 생성자  초기화용도로 많이사용
        public Character()
        {
            name = "홍길동";
            level = 1;
            hp = 100;
            maxHP = 150;
            mp = 80;
            maxMP = 100;
        }

        //인자있는 생성자 - 여기서 언더바 보통 사용
        public Character(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHP;
            mp = _mp;
            maxMP = _maxMP;
        }

        //함수를 모아서 사용
        public void ShowStats()
        {
            Console.WriteLine("이름 : " + name);
            Console.WriteLine("레벨 : " + level);
            Console.WriteLine("Hp : " + hp);
            Console.WriteLine("MaxHP : " + maxHP);
            Console.WriteLine("MP : " + mp);
            Console.WriteLine("MaxMP : " + maxMP);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체 생성
            Character player = new Character();

            player.name = "홍길동";
            player.level = 1;
            player.hp = 100;
            player.maxHP = 150;
            player.mp = 80;  
            player.maxMP = 100;


        }
    }
}
