using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260115_project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();

            mainGame.Initialize();
            mainGame.Progress();
        }
    }
}
