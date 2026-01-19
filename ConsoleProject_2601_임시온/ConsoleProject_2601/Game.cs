using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ConsoleProject_2601
{
    public class Game
    {
        private ScreenBuffer _screen;
        private Player _player;
        private Animator _animator;
        private List<Bullet> _bullets;

        private bool _isRunning = true;
        private Random _rand = new Random();

        // 시간 및 웨이브 관리
        private Stopwatch _totalTime;
        private Stopwatch _waveTimer;
        private bool _isHardPhase = false;
        private int _level = 1;

        // 밸런스 설정
        private const int NORMAL_PHASE_TIME = 10000;
        private const int HARD_PHASE_TIME = 5000;

        public void Initialize()
        {
            Console.CursorVisible = false;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.SetWindowSize(80, 50);
                Console.SetBufferSize(80, 50);
            }
            catch { }

            _screen = new ScreenBuffer(40, 15);
            _player = new Player(20, 7, _screen);
            _bullets = new List<Bullet>();
            _animator = new Animator();
            _totalTime = new Stopwatch();
            _waveTimer = new Stopwatch();
        }

        public void Run()
        {
            Initialize();
            _totalTime.Start();
            _waveTimer.Start();

            while (_isRunning && _player.HP > 0)
            {
                ManageWave();
                _player.Update();
                UpdateBullets();
                CheckCollision();

                _screen.Clear();
                foreach (var bullet in _bullets) bullet.Draw(_screen);
                _player.Draw(_screen);

                Render();
                Thread.Sleep(33);
            }

            GameOver();
        }

        private void ManageWave()
        {
            long currentWaveTime = _waveTimer.ElapsedMilliseconds;

            if (_isHardPhase)
            {
                if (currentWaveTime > HARD_PHASE_TIME)
                {
                    _isHardPhase = false;
                    _level++;
                    _waveTimer.Restart();
                    _animator.SetHardMode(false);
                }
            }
            else
            {
                if (currentWaveTime > NORMAL_PHASE_TIME)
                {
                    _isHardPhase = true;
                    _waveTimer.Restart();
                    _animator.SetHardMode(true);
                }
            }
        }

        private void UpdateBullets()
        {
            int baseRate = _isHardPhase ? 30 : 5;
            int spawnRate = baseRate + (_level * 2);
            if (spawnRate > 90) spawnRate = 90;

            if (_rand.Next(0, 100) < spawnRate)
            {
                if (_isHardPhase) SpawnHardPattern();
                else SpawnNormalPattern();
            }

            for (int i = _bullets.Count - 1; i >= 0; i--)
            {
                _bullets[i].Update(_screen.Width, _screen.Height);
                if (!_bullets[i].IsActive)
                {
                    _bullets.RemoveAt(i);
                }
            }
        }

        // [노말 패턴] 오른쪽에서 왼쪽으로 한 개씩
        private void SpawnNormalPattern()
        {
            int y = _rand.Next(1, _screen.Height - 1);

            // [레벨에 따른 속도 조절]
            // 기본 속도 2 (느림)
            // 레벨 5가 되면 속도 1(빠름)로 변경
            // 0(초고속)까지는 안 가게 제한
            int currentSpeedLimit = Math.Max(1, 2 - (_level / 5));

            // x, y, vx, vy, w, h, [speed]
            _bullets.Add(new Bullet(_screen.Width - 2, y, -1, 0, 1, 1, currentSpeedLimit));
        }

        // [하드 패턴] 전방위 공격
        private void SpawnHardPattern()
        {
            // 패턴 4가지로 확장
            int pattern = _rand.Next(0, 4);

            // 하드 모드 전용 bullet 색상 - 시안색
            ConsoleColor bulletColor = ConsoleColor.Cyan;

            // [난이도 조절 - 총알 속도]
            // 기본 딜레이 2 (숫자가 클수록 느림)
            // 레벨 3마다 딜레이를 1씩 줄임 (최소 0까지)
            // 예: Lv.1~2=2, Lv.3~5=1, Lv.6이상=0 (초고속)
            int currentSpeedLimit = Math.Max(0, 2 - (_level / 3));

            switch (pattern)
            {
                // [패턴 0] 세로 (위 or 아래) - 시안색
                case 0:
                    bool fromTop = _rand.Next(0, 2) == 0; // 50% 확률
                    int x = _rand.Next(1, _screen.Width - 1);
                    int h = _rand.Next(3, 6); // 길이 3~5 랜덤

                    if (fromTop)
                        _bullets.Add(new Bullet(x, 1, 0, 1, 1, h, currentSpeedLimit, bulletColor));
                    else
                        _bullets.Add(new Bullet(x, _screen.Height - h - 1, 0, -1, 1, h, currentSpeedLimit, bulletColor));
                    break;

                // [패턴 1] 가로 (왼쪽 or 오른쪽) - 시안색
                case 1:
                    bool fromRight = _rand.Next(0, 2) == 0;
                    int y = _rand.Next(1, _screen.Height - 1);
                    int w = _rand.Next(4, 8); // 길이 4~7 랜덤

                    if (fromRight)
                    {
                        // 우 -> 좌 (vX = -1)
                        _bullets.Add(new Bullet(_screen.Width - 2, y, -1, 0, w, 1, currentSpeedLimit, bulletColor));
                    }
                    else
                    {
                        // 좌 -> 우 (vX = 1)
                        _bullets.Add(new Bullet(1, y, 1, 0, w, 1, currentSpeedLimit, bulletColor));
                    }
                    break;

                // [패턴 2] 4방향 대각선 (모서리에서 발사) - 시안색
                case 2:
                    int corner = _rand.Next(0, 4); // 0:좌상, 1:우상, 2:좌하, 3:우하

                    if (corner == 0) // 좌상 -> 우하
                        _bullets.Add(new Bullet(1, 1, 1, 1, 1, 1, currentSpeedLimit, bulletColor));
                    else if (corner == 1) // 우상 -> 좌하
                        _bullets.Add(new Bullet(_screen.Width - 2, 1, -1, 1, 1, 1, currentSpeedLimit, bulletColor));
                    else if (corner == 2) // 좌하 -> 우상
                        _bullets.Add(new Bullet(1, _screen.Height - 2, 1, -1, 1, 1, currentSpeedLimit, bulletColor));
                    else if (corner == 3) // 우하 -> 좌상
                        _bullets.Add(new Bullet(_screen.Width - 2, _screen.Height - 2, -1, -1, 1, 1, currentSpeedLimit, bulletColor));
                    break;

                // [패턴 3] 조준 사격 (빠른 단발) - 노란색
                case 3:
                    ConsoleColor specialColor = ConsoleColor.Yellow;

                    int fastY = _rand.Next(1, _screen.Height - 1);

                    // 기본 6 + 레벨당 0.5씩 증가하되, 최대 25칸을 넘지 못하게 함
                    int beamLength = Math.Min(25, 6 + (_level / 2));

                    int beamSpeed = 3; // 속도 조절 (높게)

                    if (_rand.Next(0, 2) == 0)
                    {
                        // 좌 -> 우 (vX = 3)
                        _bullets.Add(new Bullet(1, fastY, beamSpeed, 0, beamLength, 1, 0, specialColor));
                    }
                    else
                    {
                        // 우 -> 좌 (vX = -3)
                        _bullets.Add(new Bullet(_screen.Width - 2, fastY, -beamSpeed, 0, beamLength, 1, 0, specialColor));
                    }
                    break;
            }
        }

        private void CheckCollision()
        {
            foreach (var bullet in _bullets)
            {
                if (bullet.CheckHit(_player.X, _player.Y))
                {
                    _player.HP -= 1;
                }
            }
        }

        public void Render()
        {
            if (_animator != null) _animator.Render();

            TimeSpan ts = _totalTime.Elapsed;
            string timeStr = $"{ts.Minutes:D2}:{ts.Seconds:D2}";
            string modeStr = _isHardPhase ? "!! HELL !!" : "NORMAL";

            string uiText = $"LV.{_level} | {timeStr} | HP:{_player.HP} | {modeStr}";

            _screen.DrawString(2, 0, uiText);

            int boxStartY = 14;
            Console.SetCursorPosition(0, boxStartY);
            _screen.Render();
        }

        private void GameOver()
        {
            _totalTime.Stop();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n\n");
            Console.WriteLine("               G A M E  O V E R ");
            Console.WriteLine("\n");

            // 3. 결과 출력
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ========================================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"      SURVIVED: {_totalTime.Elapsed.TotalSeconds:F2} sec");
            Console.WriteLine($"      LEVEL: {_level}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    ========================================");


            Console.WriteLine("\n    Press [Enter] to exit...");

            Console.ReadLine();
        }
    
    }
}
