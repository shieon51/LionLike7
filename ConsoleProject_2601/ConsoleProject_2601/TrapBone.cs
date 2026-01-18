using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_2601
{
    public class TrapBone
    {
        public int X { get; private set; }
        public int Y { get; private set; } // 바닥 좌표 (보통 height-2)
        public bool IsActive { get; private set; } = true;

        // 상태 관리 (0: 경고, 1: 공격, 2: 끝)
        private int _state = 0;
        private int _timer = 0;

        // 밸런스 조절
        private const int WARNING_TIME = 20; // 경고 지속 시간 (프레임)
        private const int ATTACK_TIME = 15;  // 공격 지속 시간

        public TrapBone(int x, int bottomY)
        {
            X = x;
            Y = bottomY; // 박스 바닥 바로 위
        }

        public void Update()
        {
            _timer++;

            if (_state == 0) // 경고 단계
            {
                if (_timer > WARNING_TIME)
                {
                    _state = 1; // 공격 시작!
                    _timer = 0;
                }
            }
            else if (_state == 1) // 공격 단계
            {
                if (_timer > ATTACK_TIME)
                {
                    _state = 2; // 사라짐
                    IsActive = false;
                }
            }
        }

        // 그리기 및 충돌 판정 도우미
        public void Draw(ScreenBuffer buffer)
        {
            if (_state == 0)
            {
                // 경고 표시 (바닥에 작은 점이나 느낌표)
                buffer.Draw(X, Y, '░');
            }
            else if (_state == 1)
            {
                // 뼈다귀 솟아오름 (높이 3칸 정도 그림)
                buffer.Draw(X, Y, '║');
                buffer.Draw(X, Y - 1, '║');
                buffer.Draw(X, Y - 2, '∩'); // 뼈다귀 머리
            }
        }

        // 충돌 체크 함수 (플레이어가 이 뼈다귀의 공격 범위에 있는가?)
        public bool IsColliding(int playerX, int playerY)
        {
            if (_state != 1) return false; // 공격 중일 때만 아픔

            // 뼈다귀는 위로 3칸(Y, Y-1, Y-2) 차지한다고 가정
            if (playerX == X && (playerY == Y || playerY == Y - 1 || playerY == Y - 2))
            {
                return true;
            }
            return false;
        }
    }
}
