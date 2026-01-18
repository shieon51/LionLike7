using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_2601
{
    public class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int HP { get; set; } = 30;

        private ScreenBuffer _screen; // 이동 범위 제한을 위해 화면 정보 필요

        public Player(int startX, int startY, ScreenBuffer screen)
        {
            X = startX;
            Y = startY;
            _screen = screen;
        }

        public void Update()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                // 테두리 안쪽에서만 움직이도록 제한 (1 ~ Width-2)
                if (key == ConsoleKey.LeftArrow && X > 1) X--;
                if (key == ConsoleKey.RightArrow && X < _screen.Width - 2) X++;
                if (key == ConsoleKey.UpArrow && Y > 1) Y--;
                if (key == ConsoleKey.DownArrow && Y < _screen.Height - 2) Y++;
            }
        }

        public void Draw(ScreenBuffer buffer)
        {
            buffer.Draw(X, Y, '♥', ConsoleColor.Red);
        }


    }
}
