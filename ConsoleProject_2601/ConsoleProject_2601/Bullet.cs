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
        public bool IsActive { get; private set; } = true;

        // 속도 조절을 위한 변수 (매 프레임 움직이면 너무 빠르니까)
        private int _speedCounter = 0;
        private int _speedLimit = 2; // 숫자가 클수록 느림

        public Bullet(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }

        public void Update()
        {
            _speedCounter++;
            if (_speedCounter >= _speedLimit)
            {
                X--; // 왼쪽으로 이동
                _speedCounter = 0;
            }

            // 화면 왼쪽 끝에 닿으면 비활성화
            if (X <= 0) IsActive = false;
        }

        public void Draw(ScreenBuffer buffer)
        {
            if (IsActive) buffer.Draw(X, Y, '■'); 
        }
    }
}
