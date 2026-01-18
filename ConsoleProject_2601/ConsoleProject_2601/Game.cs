using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleProject_2601
{
    public class Game
    {
        private ScreenBuffer _screen;
        private Player _player;
        private List<Bullet> _bullets;
        private bool _isRunning = true;
        private Random _rand = new Random();


        int animationFrame = 0;

        // 1. 샌즈 애니메이션 데이터 (간단한 눈 깜빡임)
        string[] sansFace1_1 = {
            "                    ",
            "    ■■■■■■■■■      ",
            "  ■■■■■■■■■■■■■    ",
            " ■■  o ■■■ o  ■■   ",
            "  ■■■■■ ∧ ■■■■■    ",
            "  ■■┻┼─┼─┼─┼┴■■   ",
            "   .■■■■■■■■■ .    ",
            "  ' - `-. .-' -.'   ",
            "  / ┃   │■│   ┃ \\   ",
            "  \\ ┃___│■│___┃  /   ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };

        string[] sansFace1_2 = { // 머리 우측 위, 몸통 좌
            "      ■■■■■■■■■      ",
            "    ■■■■■■■■■■■■■    ",
            "   ■■  o ■■■ o  ■■   ",
            "    ■■■■■ ∧ ■■■■■    ",
            "    ■■┻┼─┼─┼─┼┴■■   ",
            "     ■■■■■■■■■      ",
            "  .`           .      ",
            " ' - `-.  .-' -.'    ",
            " / ┃   │■│   ┃ \\    ",
            " \\ ┃___│■│___┃  /    ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };

        string[] sansFace1_3 = { // 머리 아래
            "                    ",
            "      ■■■■■■■■■      ",
            "    ■■■■■■■■■■■■■    ",
            "   ■■  o ■■■ o  ■■   ",
            "    ■■■■■ ∧ ■■■■■    ",
            "    ■■┻┼─┼─┼─┼┴■■   ",
            "   .  ■■■■■■■■■.    ",
            "  ' - `-. .-' -. '    ",
            " \\ ┃___│■│___┃  /    ",
            "    /         \\      ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };

        string[] sansFace1_4 = { // 머리 좌측 위, 몸통 우측위
            "    ■■■■■■■■■      ",
            "  ■■■■■■■■■■■■■    ",
            " ■■  o ■■■ o  ■■   ",
            "  ■■■■■ ∧ ■■■■■    ",
            "  ■■┻┼─┼─┼─┼┴■■   ",
            "  . ■■■■■■■■■   .   ",
            "   ' - `-. .-' -. '    ",
            "   / ┃   │■│   ┃ \\   ",
            "   \\ ┃___│■│___┃  /   ",
            "    /          |    ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };

        string[] sansFace2 = {
            "                    ",
            "     ■■■■■■■■■      ",
            "   ■■■■■■■■■■■■■    ",
            "  ■■  _ ■■■ _  ■■   ",
            "   ■■■■■ ∧ ■■■■■    ",
            "   ■■┻┼─┼─┼─┼┴■■   ",
            "   . ■■■■■■■■■ .    ",
            "  ' - `-. .-' -.'   ",
            "  / ┃   │■│   ┃ \\   ",
            "  \\ ┃___│■│___┃  /   ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };

        string[] sansFace3 = {
            "                    ",
            "     ■■■■■■■■■      ",
            "   ■■■■■■■■■■■■■    ",
            "  ■■    ■■■    ■■   ",
            "   ■■■■■ ∧ ■■■■■    ",
            "   ■■┻┼─┼─┼─┼┴■■   ",
            "   . ■■■■■■■■■ .    ",
            "  ' - `-. .-' -.'   ",
            "  / ┃   │■│   ┃ \\   ",
            "  \\ ┃___│■│___┃  /   ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };


        string[] sansFace4 = {
            "                    ",
            "     ■■■■■■■■■      ",
            "   ■■■■■■■■■■■■■    ",
            "  ■■    ■■■ 🔵 ■■   ", // 한쪽 눈 (파랑) / 🟡 노랑
            "   ■■■■■ ∧ ■■■■■    ",
            "   ■■┻┼─┼─┼─┼┴■■   ",
            "   . ■■■■■■■■■ .    ",
            "  ' - `-. .-' -.'   ",
            "  / ┃   │■│   ┃ \\   ",
            "  \\ ┃___│■│___┃  /   ",
            "   /           \\    ",
            "  |      /'     |    ",
            "  '_____' |_____'    ",
            "  ■■■■ ■   ■ ■■■■    ",
            "                     ",
        };

        List<string[]> _sansFacesIdle;


    public void Initialize()
        {
            // 1. 콘솔 설정
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 2. 창 크기 강제 조절
            try
            {
                Console.SetWindowSize(80, 50); // 창 크기 늘리기
                Console.SetBufferSize(80, 50); // 스크롤 버퍼도 늘리기
            }
            catch (Exception)
            {
                // 모니터 해상도나 시스템 설정 때문에 실패하면 그냥 넘어갑니다.
            }


            _sansFacesIdle = new List<string[]> { sansFace1_1, sansFace1_2, sansFace1_3, sansFace1_4 }; // 4개 순서대로

            _screen = new ScreenBuffer(40, 15);
            _player = new Player(20, 7, _screen);
            _bullets = new List<Bullet>();
        }

        public void Run()
        {
            Initialize();

            while (_isRunning && _player.HP > 0)
            {
                // 1. 로직
                _player.Update();

                UpdateBullets();
                CheckCollision();

                // 2. 그리기 준비
                _screen.Clear();
                foreach (var bullet in _bullets) bullet.Draw(_screen);
                _player.Draw(_screen);
                _screen.DrawString(2, 0, $" HP: {_player.HP} ");

                // 3. 최종 렌더링 (여기 수정됨!)
                Render(); // _screen.Render()가 아니라 이 클래스의 Render()를 호출해야 함

                // 4. 프레임 딜레이
                Thread.Sleep(33);
            }

            // 게임 오버
            Console.Clear();
            Console.WriteLine("\n\n   GAME OVER");
            Console.WriteLine($"   Final HP: {_player.HP}");
        }

        private void UpdateBullets()
        {
            // 10% 확률로 새 뼈다귀 생성 (오른쪽 끝에서)
            if (_rand.Next(0, 100) < 10)
            {
                int randomY = _rand.Next(1, _screen.Height - 1);
                _bullets.Add(new Bullet(_screen.Width - 2, randomY));
            }

            // 모든 뼈다귀 이동
            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                _bullets[i].Update();
                if (!_bullets[i].IsActive)
                {
                    _bullets.RemoveAt(i);
                }
            }
        }

        private void CheckCollision()
        {
            foreach (var bullet in _bullets)
            {
                if (bullet.X == _player.X && bullet.Y == _player.Y)
                {
                    _player.HP -= 5;
                    // 맞으면 뼈다귀 사라지게 할지, 관통할지 결정 (여기선 관통하되 무적시간 없음)
                }
            }
        }

        public void Render()
        {
            // (1) 샌즈 그리기
            // 샌즈는 (10, 0) 위치부터 그립니다.
            Console.SetCursorPosition(10, 0);

            // 4개 프레임을 순환하도록 % 4 로 변경
            // 속도 조절: / 5 (숫자가 낮을수록 빠름)
            string[] currentFace = _sansFacesIdle[(animationFrame / 5) % 4];
            animationFrame++;

            foreach (string line in currentFace)
            {
                Console.Write(line);
                Console.SetCursorPosition(10, Console.CursorTop + 1);
            }

            // (2) 게임 박스 그리기
            int boxStartY = 14;

            Console.SetCursorPosition(0, boxStartY);
            _screen.Render(); // 중요: ScreenBuffer 코드를 수정해야 함 (아래 참고)
        }
    }
}
