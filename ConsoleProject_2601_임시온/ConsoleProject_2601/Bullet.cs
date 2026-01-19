using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_2601
{
    public class Bullet
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }  // 가로 길이
        public int Height { get; private set; } // 세로 길이

        // 총알 색깔
        public ConsoleColor Color { get; private set; }

        // 이동 방향 (속도)
        private int _velX;
        private int _velY;

        public bool IsActive { get; private set; } = true;

        // 속도 조절을 위한 변수
        private int _speedCounter = 0;
        private int _speedLimit; // 낮을수록 빠름

        // 생성자에서 방향과 속도를 받음
        public Bullet(int startX, int startY, int vX, int vY, int w = 1, int h = 1, int speedLimit = 2, ConsoleColor color = ConsoleColor.White)
        {
            X = startX;
            Y = startY;
            _velX = vX;
            _velY = vY;
            Width = w;
            Height = h;
            _speedLimit = speedLimit;
            Color = color; // 색상 저장
        }

        public void Update(int screenWidth, int screenHeight)
        {
            _speedCounter++;
            if (_speedCounter >= _speedLimit)
            {
                X += _velX;
                Y += _velY;
                _speedCounter = 0;
            }

            // 화면 밖으로 완전히 나갔는지 체크 (길이 고려)
            if (X + Width < 0 || X >= screenWidth || Y + Height < 0 || Y >= screenHeight)
            {
                IsActive = false;
            }
        }

        public void Draw(ScreenBuffer buffer)
        {
            if (!IsActive) return;

            // (Width * Height 만큼 그림)
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    // 긴 막대기 모양
                    buffer.Draw(X + j, Y + i, '■', Color);
                }
            }
        }

        // 충돌 판정 (점 & 직사각형 충돌 로직)
        public bool CheckHit(int playerX, int playerY)
        {
            // 플레이어 좌표가 사각형 안에 들어왔나?
            if (playerX >= X && playerX < X + Width &&
                playerY >= Y && playerY < Y + Height)
            {
                return true;
            }
            return false;
        }
    }
}
