using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260112_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //모든매개변수 지정
            CastFireBall("고블린", 150, 40);
            Console.WriteLine();
            CastFireBall("오크", 20);
            Console.WriteLine();
            CastFireBall("드래곤");
            Console.WriteLine();

            //ref 키워드 참조
            //C# 내부적으로 포인터 개발자들이 신경덜쓰게 잘만들어놓음

            int a = 10;
            Attack(ref a);
            Console.WriteLine("a 값 : " + a);


            // out 사용
            int attack;
            int defense;

            Attack(10, 20, out attack, out defense);

            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"공격력 : {defense}");
        }

        //기본매개변수 사용
        static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        {
            Console.WriteLine($" 파이어볼 시전!");
            Console.WriteLine($" 대상: {target}");
            Console.WriteLine($" 데미지: {damage}");
            Console.WriteLine($" 마나 소모: {manaCost}");
        }

        //매개변수 int a 대신받아준다.
        static void Attack(ref int a)
        {
            Console.WriteLine("공격력 : " + a);
            a++;
        }

        static void Attack(int a, int d, out int attack, out int defense)
        {
            attack = a;
            defense = d;
            attack++;
            defense++;
        }
    }
}
