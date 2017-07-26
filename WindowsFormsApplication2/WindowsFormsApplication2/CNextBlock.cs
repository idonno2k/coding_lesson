using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _018_Application
{
    class CNextBlock : CBlock
    {
        List<Point> _blockList = new List<Point>();
        Random _rd = new Random(Guid.NewGuid().GetHashCode());
        string _rdPercent = "0135012435601265321046531053"; // 블럭이 나올 확율 0 (┌┘ 5/28%), 1 (──┘ 5/28%), 2 (■ 3/28%), 3 (└┐ 5/28%), 4 (──── 2/28%), 5 (└──  5/28%), 6 (─┴─ 3/28%)
        int _rdX, _rdY, _rKey;

        public CNextBlock(PictureBox pb, Point n) : base(pb, n)
        {
            _rdX = _rd.Next(0, 7);
            _rdY = _rd.Next(0, 4);
            NextBlockList();
        }

        void NextBlockList() // 대기중인 블럭 리스트 생성
        {
            for (int i = _blockList.Count; i < 6; i++) _blockList.Add(new Point(RandomKeyX(), RandomKeyY()));
        }

        int RandomKeyX() // 블럭 같은 모양 방지
        {
            _rKey = Convert.ToInt32(_rdPercent[_rd.Next(0, _rdPercent.Length)].ToString());
            if (_rdX == _rKey) return RandomKeyX();
            else return _rdX = _rKey;
        }

        int RandomKeyY() // 블럭 같은 방향 방지
        {
            _rKey = _rd.Next(0, 4);
            if (_rdY == _rKey) return RandomKeyY();
            else return _rdY = _rKey;
        }

        public Point NextBlockReturn()
        {
            Point x = _blockList[0]; // 대기중인 첫번째 블럭 리턴
            _blockList.RemoveAt(0);  // 대기중인 첫번째 블럭 리스트에서 삭제

            NextBlockList(); // 대기중인 블럭 리스트를 6개로 만들기
            NextBlockDisplay(); 
            return x;
        }

        void NextBlockDisplay() // 대기중인 블럭 디스플레이
        {
            NewGraphice();
            for (int i = 0; i < _blockList.Count; i++) BlockDisplay(_Color[_blockList[i].X], _blockList[i], new Point(1, i * 4));
        }
    }
}
