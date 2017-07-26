using System;
using System.Drawing;

namespace _018_Application
{
    class CPlayBlock : CBlock
    {
        CNextBlock nextBlock_;
        public Form1 _form1;
        Point _blockShape, _blockPosition, _blockGhostPosition, _blockUpDown; // 블럭 모양 방향, 블럭 위치, 고스트 블럭 위치, 블럭 회전으로 변경되기 전 위치
        int[,] _spaceArray; // 충돌로 쌓인 블럭 정보
        string _spaceAllBlank; // 라인이 전부 공백인지 비교할 값
        int _spaceComboCount, _spaceDeleteCount; // 마지막 콤보로 삭제된 라인 수, 마지막 삭제된 라인수

        public CPlayBlock(Form1 f1, Point p, Point n) : base(f1.pbPlayBlock, p)
        {
            _form1 = f1;
            _spaceArray = new int[_blockCount.X, _blockCount.Y];
            nextBlock_ = new CNextBlock(_form1.pbNextBlock, n);

            for (int i = 0; i < _blockCount.X; i++) _spaceAllBlank += "8"; // 라인이 전부 공백인지 비교할 값 (8 공백)
        }

        public void GamePlayClear() // 게임 초기화
        {
            _form1.lbBlockCount.Text = _form1.lbDeleteLine.Text = _form1.lbMaxCombo.Text = "0";
            _form1.lbBonusSkill.Text = "5";
            _form1.btPause.Text = "일 시 중 지";
            _form1.lbGameOverF.ForeColor = Color.DodgerBlue;
            _form1.lbGameOver.ForeColor = Color.Blue;
            _form1.lbGameOver.Text = _form1.lbGameOverF.Text = "Pause";
            _form1.tabGameSpeed.Enabled = false;
            _form1.lbGameOver.Visible = false;

            NewGraphice();

            for (int i = 0; i < _blockCount.X; i++)
                for (int j = 0; j < _blockCount.Y; j++)
                    _spaceArray[i, j] = 8; // 충돌로 쌓인 블럭 정보 초기화 (8 공백)

            _spaceComboCount = _spaceDeleteCount = 0; // 마지막 콤보로 삭제된 라인 수, 마지막 삭제된 라인수 초기화
            GameNextBlock();
        }

        void GameNextBlock()
        {
            _form1.lbBlockCount.Text = (Convert.ToDouble(_form1.lbBlockCount.Text) + 1).ToString(); // 블럭 수 증가
            _blockShape = nextBlock_.NextBlockReturn();  // 대기열 블럭 리스트의 첫번째 블럭 정보
            _blockUpDown = _blockPosition = new Point(3, Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][5].ToString()) * -1 - 1); // 첫번째 블럭의 Y값 계산
            PlayBlockGhostY(); // 고스트 블럭의 Y값 계산
            BlockDisplay(_GhostColor[_blockShape.X], _blockShape, _blockGhostPosition); // 고스트 블럭 디스플레이
            BlockDisplay(_Color[_blockShape.X], _blockShape, _blockPosition); // 블럭 디스플레이
        }

        public void GameStart()
        {
            if (!BlockClash()) // Game Over
            {
                _form1.lbGameOverF.ForeColor = Color.Red;
                _form1.lbGameOver.ForeColor = Color.DarkRed;
                _form1.lbGameOverF.Text = _form1.lbGameOver.Text = "Game Over";
                _form1.tabGameSpeed.Enabled = true;
                _form1.lbGameOver.Visible = true;
            }
            else GameStartDisplay();
        }

        bool BlockClash() // 블럭 충돌 체크
        {
            for (int i = 0; i < 8; i += 2)
            { // 블럭 좌표 + 현재 좌표
                _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i].ToString()) + _blockPosition.X;
                _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i + 1].ToString()) + _blockPosition.Y + 1;

                if (_tempY > -1 && (_tempY > _blockCount.Y - 1 || _spaceArray[_tempX, _tempY] != 8)) // 충돌 (8 공백)
                {
                    if (Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][3].ToString()) + _blockPosition.Y < 1) return false; // 블럭의 맨위 Y 값 (게임오버)
                    GameDeleteLine(); // 라인 삭제, 다음 블럭 호출
                    return true;
                }
            }
            return true;
        }
        
        void GameDeleteLine()
        {
            for (int i = 0; i < 8; i += 2) // 충돌된 블럭을 배열에 저장
            {
                _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i].ToString()) + _blockPosition.X;
                _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i + 1].ToString()) + _blockPosition.Y;
                _spaceArray[_tempX, _tempY] = _blockShape.X;
            }

            _tempX = _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][5].ToString()) + _blockPosition.Y; // 충돌한 블럭의 맨 아래 Y값
            SpaceArraySort(_tempX, _tempY);
            GameNextBlock(); // 대기열의 다음 블럭 호출
        }

        string _spaceStr; // 쌓인 블럭의 라인 임시저장
        void SpaceArraySort(int maxY, int minY) // 쌓인 블럭정보 배열에 공백없는 라인삭제 (변경 될 Y, 현재 읽은 Y)
        {
            _spaceStr = "";
            for (int i = 0; i < _blockCount.X; i++) _spaceStr += _spaceArray[i, minY];

            if (_spaceStr.Equals(_spaceAllBlank)) // 라인이 전부 공백 (더이상 위로 블럭이 없다)
            {
                _tempY = ++minY;
                for (int x = 0; x < _blockCount.X; x++)
                    for (int y = minY; y <= maxY; y++)
                        _spaceArray[x, y] = 8;

                if (_spaceDeleteCount > 0) // 삭제된 라인이 존재하면
                {
                    SpaceArrayDisplay(); // 삭제된 라인 디스플레이

                    _spaceComboCount += _spaceDeleteCount;
                    _spaceDeleteCount = 0;
                    if (Convert.ToInt32(_form1.lbMaxCombo.Text) < _spaceComboCount) // 최대 콤보 수 비교
                        _form1.lbMaxCombo.Text = (_spaceComboCount).ToString();
                }
                else _spaceComboCount = 0;
            }
            else if (_spaceStr.IndexOf("8") < 0)  // 공백이 없어 라인을 삭제해야 되는 경우
            {
                _spaceDeleteCount++; // 콤보에 적용할 마지막 삭제된 라인 수 증가
                _form1.lbDeleteLine.Text = (Convert.ToDouble(_form1.lbDeleteLine.Text) + 1).ToString(); // 삭제된 라인 수 증가
                SpaceArraySort(maxY, --minY);
            }
            else // 공백이 있는 경우
            {
                for (int i = 0; i < _blockCount.X; i++) _spaceArray[i, maxY] = _spaceArray[i, minY];
                SpaceArraySort(--maxY, --minY);
            }
        }

        void SpaceArrayDisplay() // 공백으로 변경된 라인 디스플레이 : 변경된 맨 아래 Y(_tempX), 맨 위 Y(_tempY)
        {
            for (int i = 0; i < _blockCount.X; i++)
                for (int j = _tempY; j <= _tempX; j++)
                    BlockSell(_Color[_spaceArray[i, j]], new Point(i, j)); // ■ (색, 위치)

            _pb.Image = _bm;
        }

        void GameStartDisplay() // 블럭 디스플레이
        {
            BlockDisplay(_Color[8], _blockShape, _blockPosition); // 이전 블럭 이미지 삭제
            _blockPosition.Y++;
            _blockUpDown.Y++;
            BlockDisplay(_Color[_blockShape.X], _blockShape, _blockPosition); // 현재 블럭 이미지 디스플레이
        }

        public void GameMoveLeftRight(int positionX) // 블럭 좌우 이동 ← → (이동할 X값)  
        {
            if (!BlockClashLeftRight(positionX)) return;
            PlayBlockDisplay(_blockShape.Y, positionX, 0);
            _blockUpDown = _blockPosition; // 블럭이 좌우로 이동 했으니 블럭 회전으로 움직인 위치 초기화
        }

        bool BlockClashLeftRight(int positionX) // 블럭 충돌 체크
        {
            _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][0].ToString()) + _blockPosition.X + positionX; // 가장 왼쪽 X값
            _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][6].ToString()) + _blockPosition.X + positionX; // 가장 오른쪽 X값
            if (_tempX < 0 || _tempY > _blockCount.X - 1) return false; // 좌우 벽에 충돌한 경우

            for (int i = 0; i < 8; i += 2)
            { // 블럭 좌표 + 현재 좌표 + 이동할 X값
                _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i].ToString()) + _blockPosition.X + positionX;
                _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i + 1].ToString()) + _blockPosition.Y;

                if (_tempY > -1 && (_tempY > _blockCount.Y - 1 || _spaceArray[_tempX, _tempY] != 8)) return false; // 충돌 (8 공백)
            }
            return true;
        }

        public void GameMoveUpDown(int direction) // 블럭 회전 ↑ ↓ (블럭 회전 방향)
        {
            direction = (_blockShape.Y + direction) % 4; //블럭 방향 Y++ == (Y + 1) % 4, Y-- == (Y + 3) % 4
            if (BlockClashUpDown(UpBlockCheck(), direction, 0)) PlayBlockDisplay(direction, _tempX, _tempY);
        }

        readonly int[,] _UdLeftArray = { { 0, 0 }, { -1, 0 }, { 1, 0 }, { -2, 0 }, { 2, 0 }, { 0, -1 }, { 0, -2 } }; // (제자리  ←  →  ←←  →→  ↑  ↑↑ 순서로 블럭 회전 가능 체크) 
        readonly int[,] _UdRightArray = { { 0, 0 }, { 1, 0 }, { -1, 0 }, { 2, 0 }, { -2, 0 }, { 0, -1 }, { 0, -2 } }; // (제자리  →  ←  →→  ←←  ↑  ↑↑ 순서로 블럭 회전 가능 체크) 
        int[,] UpBlockCheck() // 블럭 회전이 가능한지 체크할 배열 리턴
        {
            if (_blockPosition.X < _blockUpDown.X) return _UdLeftArray; // 블럭이 회전으로 왼쪽으로 움직인 경우
            else if (_blockPosition.X > _blockUpDown.X) return _UdRightArray; // 블럭이 회전으로 오른쪽으로 움직인 경우
            else
            {
                _tempX = _tempY = 0;
                for (int x = _blockUpDown.X; x < _blockUpDown.X + 1; x++)
                    for (int y = _blockUpDown.Y; y < _blockUpDown.Y + 3; y++)
                        if (y > -1 && y < _blockCount.Y && (x < 0 || x > _blockCount.X - 1 || _spaceArray[x, y] != 8))
                            _tempX++; // 왼쪽에 쌓인 블럭 수

                for (int x = _blockUpDown.X + 2; x < _blockUpDown.X + 3; x++)
                    for (int y = _blockUpDown.Y; y < _blockUpDown.Y + 3; y++)
                        if (y > -1 && y < _blockCount.Y && (x < 0 || x > _blockCount.X - 1 || _spaceArray[x, y] != 8))
                            _tempY++; // 오른쪽에 쌓인 블럭 수

                return (_tempX < _tempY) ? _UdLeftArray : _UdRightArray; // 쌓여있는 블럭이 적은 방향의 배열 리턴 
            }
        }

        bool BlockClashUpDown(int[,] UdArray, int direction, int count) // 재귀호출 (UdArray 순서로 블럭 회전 가능 체크)
        {
            if (count > 6) return false; // 체크가 끝나고 회전이 불가능하면 false 리턴

            _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, direction][0].ToString()) + _blockUpDown.X + UdArray[count, 0]; // 가장 왼쪽 X값
            _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, direction][6].ToString()) + _blockUpDown.X + UdArray[count, 0]; // 가장 오른쪽 X값
            if (_tempX < 0 || _tempY > _blockCount.X - 1) return BlockClashUpDown(UdArray, direction, ++count); // 좌우 벽에 충돌하면 재귀호출로 배열 다음방향 회전가능 체크
            else
            {
                for (int i = 0; i < 8; i += 2)
                { // 블럭 좌표 + 현재 좌표 + _UpDownArray 위치
                    _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, direction][i].ToString()) + _blockUpDown.X + UdArray[count, 0];
                    _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, direction][i + 1].ToString()) + _blockUpDown.Y + UdArray[count, 1];

                    if (_tempY > -1 && (_tempY > _blockCount.Y - 1 || _spaceArray[_tempX, _tempY] != 8)) return BlockClashUpDown(UdArray, direction, ++count); // 쌓여있는 블럭에 출동하면 재귀호출로 배열 다음방향 회전가능 체크
                }
            }
            _tempX = _blockUpDown.X - _blockPosition.X + UdArray[count, 0]; // 블럭 회전으로 변경된 위치 반영
            _tempY = _blockUpDown.Y - _blockPosition.Y + UdArray[count, 1];
            return true;
        }

        public void BonusSkill() // 보너스 스킬
        {
            if (Convert.ToInt32(_form1.lbBonusSkill.Text) > 0) BonusSkillCheck(_blockCount.Y - 1);
        }

        void BonusSkillCheck(int minY) // 충돌로 쌓인 블럭의 맨위 라인 3개 삭제 (현재 읽은 Y)
        {
            _spaceStr = "";
            for (int i = 0; i < _blockCount.X; i++) _spaceStr += _spaceArray[i, minY];

            if (_spaceStr.Equals(_spaceAllBlank)) // 라인이 전부 공백 (더이상 위로 블럭이 없다)
            {
                if (minY == _blockCount.Y - 1) return; // 맨 아래 라인이 공백이면 삭제할 라인이 없으니 리턴

                _form1.lbBonusSkill.Text = (Convert.ToInt32(_form1.lbBonusSkill.Text) - 1).ToString(); // 보너스 스킬 -1
                _tempY = ++minY; // 삭제할 맨 위 Y
                _tempX = (_tempY + 3 > _blockCount.Y) ? _blockCount.Y : _tempY + 3; // 삭제할 맨 아래 Y
                BonusSkillDisplay();
            }
            else BonusSkillCheck(--minY);
        }

        void BonusSkillDisplay() // 공백으로 변경된 라인 디스플레이 : 삭제할 맨 아래 Y(_tempX), 맨 위 Y(_tempY)
        {
            for (int x = 0; x < _blockCount.X; x++)
                for (int y = _tempY; y < _tempX; y++)
                    _spaceArray[x, y] = 8; // 공백 8

            for (int i = 0; i < _blockCount.X; i++)
                for (int j = _tempY; j < _tempX; j++)
                    BlockSell(_Color[8], new Point(i, j)); // ■ (색, 위치)

            PlayBlockDisplay(_blockShape.Y, 0, 0);
        }

        void PlayBlockDisplay(int blockShape, int positionX, int positionY) // 블럭 디스플레이 (변경된 블럭 방향, 이동할 X값, 이동할 Y값)
        {
            BlockDisplay(_Color[8], _blockShape, _blockPosition); // 이전 블럭 이미지 삭제
            BlockDisplay(_Color[8], _blockShape, _blockGhostPosition); // 이전 고스트 블럭 이미지 삭제

            _blockShape.Y = blockShape;
            _blockPosition.X += positionX;
            _blockPosition.Y += positionY;

            PlayBlockGhostY();
            BlockDisplay(_GhostColor[_blockShape.X], _blockShape, _blockGhostPosition); // 현재 고스트 블럭 이미지 디스플레이
            BlockDisplay(_Color[_blockShape.X], _blockShape, _blockPosition); // 현재 블럭 이미지 디스플레이
        }

        void PlayBlockGhostY() // 고스트 블럭 Y값 계산
        {
            for (int y = _blockPosition.Y; y < _blockCount.Y; y++) // 현재 블럭 위치 부터 충돌 확인
            {
                for (int i = 0; i < 8; i += 2)
                {
                    _tempX = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i].ToString()) + _blockPosition.X;
                    _tempY = Convert.ToInt32(_BlockArray[_blockShape.X, _blockShape.Y][i + 1].ToString()) + y;

                    if (_tempY > -1 && (_tempY > _blockCount.Y - 1 || _spaceArray[_tempX, _tempY] != 8)) return; // 충돌 (8 공백)
                }
                _blockGhostPosition = new Point(_blockPosition.X, y);
            }
        }
    }
}
