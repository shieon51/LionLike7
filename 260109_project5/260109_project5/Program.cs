using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _260109_project5
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //c언어 함수 가져옴

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25); //콘솔 창 크기 설정
            Console.SetBufferSize(80, 25); //버퍼 크기도 동일하게 설정 (스크롤 방지)

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            }; // 배열 문자열로 그리기

            string bullet = "--*";

            int playerX = 0;
            int playerY = 0;
            List<int> bulletsPosX = new List<int>();
            List<int> bulletsPosY = new List<int>();

            ConsoleKeyInfo keyInfo; // 키정보

            Console.CursorVisible = false;

            //Sleep() // 1000 (1초)동안 프로그램을 잠시 멈춤
            // 지연방법 시간을 계산해서 1초 루프
            int dwTiem = Environment.TickCount;

            while (true) 
            {
                if (dwTiem + 50 < Environment.TickCount)
                {
                    dwTiem = Environment.TickCount;
                    Console.Clear();

                    // 키 영역
                    int pressKey;

                    if (Console.KeyAvailable)
                    {
                        pressKey = _getch(); //요렇게 하면
                        if (pressKey == 224)
                            pressKey = _getch(); //요렇게 하면


                        switch (pressKey)
                        {

                            case 72:  //위쪽방향 아스키코드                    
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;
                            case 75:
                                //왼쪽 화살표키
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;
                            case 77:
                                //오른쪽
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;
                            case 80: //아래
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;
                            case 32: //스페이스바
                                //-> 미사일 날라가기
                                bulletsPosX.Add(playerX);
                                bulletsPosY.Add(playerY + 1);
                                break;
                        }


                    }

                    // 총알
                    for (int j = 0; j < bulletsPosX.Count; j++)
                    {
                        Console.SetCursorPosition(bulletsPosX[j], bulletsPosY[j]);
                        Console.WriteLine(bullet);
                        bulletsPosX[j] += 3;

                        if (bulletsPosX[j] > 75)
                        {
                            bulletsPosX.RemoveAt(j);
                            bulletsPosY.RemoveAt(j);
                        }

                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        //콘솔좌표 설정 플레이어X 플레이어Y
                        Console.SetCursorPosition(playerX, playerY + i);
                        //문자열배열 출력
                        Console.WriteLine(player[i]);
                    }

                }
            }
        }
    }
}
