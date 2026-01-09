using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _260108_project5
{
    class Program
    {
        // 화면 설정
        const int WIDTH = 60;
        const int HEIGHT = 15;
        const int GROUND_Y = HEIGHT - 2;

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(WIDTH + 5, HEIGHT + 5);
            Console.SetBufferSize(WIDTH + 5, HEIGHT + 5);

            // 타이틀
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================");
            Console.WriteLine("    SPEED UP DINO RUN");
            Console.WriteLine("===============================");
            Console.WriteLine(" Press SPACE to Start");
            Console.ReadKey();
            Console.Clear();

            // 게임 변수
            bool isGameRunning = true;
            int score = 0;
            int frame = 0;
            Random rand = new Random();

            // 게임 속도 변수 (초기값 60ms): 숫자가 클수록 느리고, 작을수록 빠름
            int sleepTime = 60;

            // 공룡 변수
            int dinoY = GROUND_Y;
            bool isJumping = false;
            int jumpVelocity = 0;

            List<Obstacle> obstacles = new List<Obstacle>();

            DrawGround();

            // ================= GAME LOOP =================
            while (isGameRunning)
            {
                // 1. 지우기
                ClearPixel(5, dinoY);
                foreach (var obs in obstacles)
                {
                    ClearPixel(obs.X, obs.Y);
                }

                // 2. 입력 처리
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Spacebar && !isJumping)
                    {
                        isJumping = true;
                        jumpVelocity = 2;
                    }
                }

                // 3. 로직 업데이트

                // 공룡 점프
                if (isJumping)
                {
                    dinoY -= jumpVelocity;
                    if (frame % 2 == 0) jumpVelocity--;
                    if (dinoY >= GROUND_Y)
                    {
                        dinoY = GROUND_Y;
                        isJumping = false;
                    }
                }

                // 장애물 생성
                if (frame % 5 == 0 && rand.Next(0, 100) < 15)
                {
                    if (obstacles.Count == 0 || obstacles[obstacles.Count - 1].X < WIDTH - 15)
                    {
                        obstacles.Add(new Obstacle(WIDTH - 1, GROUND_Y));
                    }
                }

                // 장애물 이동
                for (int i = 0; i < obstacles.Count; i++)
                {
                    obstacles[i].X--;

                    if (obstacles[i].X == 5 && obstacles[i].Y == dinoY)
                    {
                        isGameRunning = false;
                    }

                    if (obstacles[i].X < 0)
                    {
                        obstacles.RemoveAt(i);
                        score++;

                        // 점수 2점마다 속도 증가: 너무 빨라져서 0이 되지 않도록 최소 5ms 유지
                        if (score % 2 == 0 && sleepTime > 5)
                        {
                            sleepTime -= 3; // 3ms씩 빨라짐
                        }

                        DrawScore(score);
                        i--;
                    }
                }

                // 4. 그리기
                DrawPixel(5, dinoY, '&', ConsoleColor.Yellow);
                foreach (var obs in obstacles)
                {
                    DrawPixel(obs.X, obs.Y, 'Ψ', ConsoleColor.Red);
                }

                frame++;

                // 속도 변수 (점점 빨라짐)
                Thread.Sleep(sleepTime);
            }

            // ================= GAME OVER =================
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(WIDTH / 2 - 5, HEIGHT / 2);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(WIDTH / 2 - 6, HEIGHT / 2 + 2);
            Console.WriteLine($"Final Score: {score}");
            Console.ReadKey();
        }

        static void DrawPixel(int x, int y, char c, ConsoleColor color)
        {
            if (x < 0 || x >= WIDTH || y < 0 || y >= HEIGHT) return;
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }

        static void ClearPixel(int x, int y)
        {
            if (x < 0 || x >= WIDTH || y < 0 || y >= HEIGHT) return;
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

        static void DrawGround()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, GROUND_Y + 1);
            for (int i = 0; i < WIDTH; i++)
            {
                Console.Write("^");
            }
        }

        static void DrawScore(int score)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(WIDTH - 15, 1);
            Console.Write($"Score: {score}");
        }
    }

    class Obstacle
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Obstacle(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}


