using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260113_project4
{
    class Character
    {
        private int Att; //은닉성
        //Get / Set함수
        public void SetAtt(int _Att)
        {
            Att = _Att;
        }
        public int GetAtt()
        {
            return Att;
        }

    }

    class Player
    {
        private string name;
        private int gold;

        //프로퍼티
        public string Name { get { return name; } set { name = value; } }
        public int Gold
        {
            get { return gold; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("골드가 부족합니다.");
                }
                else
                {
                    gold = value;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Character c = new Character();

            //c.SetAtt(10);

            //Console.WriteLine("공격력 : " + c.GetAtt());

            Player player = new Player();
            player.Name = "홍길동";
            player.Gold = -100;

            Console.WriteLine($"이름 : {player.Name}");
            Console.WriteLine($"골드 : {player.Gold}");


        }
    }
}
