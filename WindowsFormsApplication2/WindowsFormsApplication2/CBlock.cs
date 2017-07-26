using System;
using System.Drawing;
using System.Windows.Forms;

namespace _018_Application
{
    abstract class CBlock
    {
        protected readonly Color[] _Color = { Color.HotPink, Color.Red, Color.DarkOrange, Color.LimeGreen, Color.DeepSkyBlue, Color.Blue, Color.BlueViolet, Color.LightGray, Color.WhiteSmoke };
        protected readonly Color[] _GhostColor = { Color.FromArgb(60, 255, 105, 180), Color.FromArgb(60, 255, 0, 0), Color.FromArgb(60, 255, 140, 0), Color.FromArgb(60, 50, 205, 50), Color.FromArgb(60, 0, 191, 255), Color.FromArgb(60, 0, 0, 255), Color.FromArgb(60, 138, 43, 226), Color.FromArgb(60, 211, 211, 211), Color.WhiteSmoke };
        // 0 핑크 1 빨강 2 주황 3 그린 4 하늘 5 파랑 6 보라 7 회색 8 흰색

        protected PictureBox _pb;
        protected Bitmap _bm;
        protected Graphics _g;
        protected Point _blockCount, _blockSize; // 블럭 칸수, 블럭 넓이
        protected int _tempX, _tempY; // 공용 임시저장

        protected readonly string[,] _BlockArray = new string[7, 4] // 블럭 모양 01 ←(왼쪽xy) 23 ↑(위xy) 45 ↓(아래xy) 67 →(오른쪽xy), 4가지 방향
        { 
            { "01111222", "11201221", "11212232", "12211322" }, // ┌┘
            { "02211222", "11101222", "11211231", "11212322" }, // ──┘
            { "11211222", "11211222", "11211222", "11211222" }, // ■
            { "02111221", "11102221", "12212231", "12112322" }, // └┐
            { "02122232", "11101312", "01112131", "21202322" }, // ────
            { "12112232", "12111321", "01112221", "12202221" }, // └──
            { "02111222", "11101221", "11212231", "12212322" }  // ─┴─
        };

        public CBlock(PictureBox pb, Point blockCount)
        {
            _pb = pb;
            _blockCount = blockCount; // 블럭의 칸수 X Y
            _blockSize = new Point(_pb.Width / _blockCount.X, _pb.Height / _blockCount.Y); // 블럭 한칸의 Width Height 길이

            BlockReset();
        }

        void BlockReset() //백그라운드 이미지 생성
        {
            NewGraphice();

            for (int i = 0; i < _blockCount.X; i++)
                for (int j = 0; j < _blockCount.Y; j++)
                    BlockSellBackground(new Point(i, j));

            _pb.BackgroundImage = _bm;
        }

        protected void NewGraphice()
        {
            _g = Graphics.FromImage(_bm = new Bitmap(_pb.Width, _pb.Height));
        }

        void BlockSellBackground(Point blockPosition) // □ (위치)
        {
            _g.DrawRectangle(new Pen(_Color[7]), blockPosition.X * _blockSize.X + 1, blockPosition.Y * _blockSize.Y + 1, _blockSize.X, _blockSize.Y);
        }

        protected void BlockSell(Color fill, Point blockPosition) // ■ (색, 위치)
        {
            _g.FillRectangle(new SolidBrush(fill), blockPosition.X * _blockSize.X + 2, blockPosition.Y * _blockSize.Y + 2, _blockSize.X - 1, _blockSize.Y - 1);
        }

        protected void BlockDisplay(Color fill, Point blockShape, Point blockPosition) // 블럭 1개 디스플레이 (색, 모양, 위치)
        {
            for (int i = 0; i < 8; i += 2)
            {
                _tempX = Convert.ToInt32(_BlockArray[blockShape.X, blockShape.Y][i].ToString()) + blockPosition.X;
                _tempY = Convert.ToInt32(_BlockArray[blockShape.X, blockShape.Y][i + 1].ToString()) + blockPosition.Y;
                BlockSell(fill, new Point(_tempX, _tempY));
            }
            _pb.Image = _bm;
        }
    }
}
