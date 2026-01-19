using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_2601
{
    public class Animator
    {
        private List<string[]> _idleFaces; // 일반 모드 표정
        private List<string[]> _hardFaces; // 하드 모드 표정
        private int _frameIndex = 0;
        private bool _isHardMode = false;

        public Animator()
        {
            // 데이터 초기화
            _idleFaces = new List<string[]>
            {
                Faces.Idle1, Faces.Idle2, Faces.Idle3, Faces.Idle4
            };

            _hardFaces = new List<string[]>
            {
                // (하드 모드용)
                Faces.Hard1, Faces.Hard2
            };
        }

        // 모드 변경 (외부에서 Game이 호출)
        public void SetHardMode(bool isHard)
        {
            _isHardMode = isHard;
        }

        public void Render()
        {
            Console.SetCursorPosition(10, 0);

            // 모드에 따라 표정 리스트 선택
            var currentList = _isHardMode ? _hardFaces : _idleFaces;

            // 속도 조절 (/5) 및 순환 (% Count)
            string[] currentFace = currentList[(_frameIndex / 5) % currentList.Count];
            _frameIndex++;

            foreach (string line in currentFace)
            {
                Console.Write(line);
                Console.SetCursorPosition(10, Console.CursorTop + 1);
            }
        }
    }


    public static class Faces
    {
        // 1. 샌즈 애니메이션 데이터 
        public static string[] Idle1 = {
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

        public static string[] Idle2 = { // 머리 우측 위, 몸통 좌
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

        public static string[] Idle3 = { // 머리 아래
            "                    ",
            "      ■■■■■■■■■      ",
            "    ■■■■■■■■■■■■■    ",
            "   ■■  _ ■■■ _  ■■   ",
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

        public static string[] Idle4 = { // 머리 좌측 위, 몸통 우측 위
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

        public static string[] Hard1 = {
            "                    ",
            "     ■■■■■■■■■      ",
            "   ■■■■■■■■■■■■■    ",
            "  ■■    ■■■ 🟡 ■■   ",
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


        public static string[] Hard2 = {
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
    }

}
