using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_2601
{
    public class ScreenBuffer
    {
        private char[,] _buffer;
        private ConsoleColor[,] _colors; // 색상 저장용 배열
        private int _width;
        private int _height;

        public int Width => _width;
        public int Height => _height;

        public ScreenBuffer(int width, int height)
        {
            _width = width;
            _height = height;
            _buffer = new char[height, width];
            _colors = new ConsoleColor[height, width];
        }

        // 화면을 비우는 대신 공백과 테두리로 채움
        public void Clear()
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    // 1. 네 귀퉁이 (모서리)
                    if (x == 0 && y == 0) _buffer[y, x] = '┏';
                    else if (x == _width - 1 && y == 0) _buffer[y, x] = '┓';
                    else if (x == 0 && y == _height - 1) _buffer[y, x] = '┗';
                    else if (x == _width - 1 && y == _height - 1) _buffer[y, x] = '┛';

                    // 2. 상하 (가로선)
                    else if (y == 0 || y == _height - 1) _buffer[y, x] = '━';

                    // 3. 좌우 (세로선)
                    else if (x == 0 || x == _width - 1) _buffer[y, x] = '┃';

                    // 4. 내부 빈공간
                    else _buffer[y, x] = ' ';


                    // 기본 색상은 흰색(Gray)으로 초기화
                    _colors[y, x] = ConsoleColor.Gray;
                }
            }
        }

        // 특정 좌표에 문자 그리기
        public void Draw(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            if (x < 0 || x >= _width || y < 0 || y >= _height) return;
            _buffer[y, x] = c;
            _colors[y, x] = color; // 색상도 저장
        }

        // 특정 좌표에 문자열 그리기
        public void DrawString(int x, int y, string text, ConsoleColor color = ConsoleColor.Gray)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Draw(x + i, y, text[i], color);
            }
        }

        // 최종적으로 콘솔에 출력 (StringBuilder 사용 최적화)
        public void Render()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleColor currentColor = ConsoleColor.Gray; // 현재 잡고 있는 붓 색깔
            Console.ForegroundColor = currentColor; // 초기 색상 설정

            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _width; x++)
                {
                    // 이번 칸의 색깔이 붓 색깔과 다르면
                    if (_colors[y, x] != currentColor)
                    {
                        // 1. 지금까지 모아둔 글자들을 먼저 출력하고
                        Console.Write(sb.ToString());
                        sb.Clear(); // 버퍼 비움

                        // 2. 붓 색깔을 바꿈
                        currentColor = _colors[y, x];
                        Console.ForegroundColor = currentColor;
                    }
                    // 글자를 버퍼에 담음
                    sb.Append(_buffer[y, x]);
                }
                sb.Append("\n");
            }
            Console.Write(sb.ToString());
            Console.ResetColor(); // 다 그리고 나면 원래대로 복구
        }
    }
}
