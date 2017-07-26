using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  
    public class Puzzle : Button
    {
        public int 원래값;   //퍼즐이 섞이기전의 값(완성된 값..1.2.3.4.5.....)
        public int 현재값;  //섞여있는 퍼즐의 값
    }
    
    public partial class Form1 : Form
    {
        public int 퍼즐가로갯수 = 5; //퍼즐의 가로값 사용자에게 입력을 받도록 해도 됨
        public int 퍼즐세로갯수 = 5; //퍼즐의 세로값
       int 퍼즐총갯수;   //가로*세로값
        int Empty;   //빈 퍼즐의 번호
        const int puzFormSize = 80;  //퍼즐의 크기
        Puzzle[] bPuzz;   //퍼즐...(버튼 배열)

        public Form1()
        {
            InitializeComponent();
            퍼즐총갯수 = 퍼즐가로갯수 * 퍼즐세로갯수;   //퍼즐의 갯수는 가로*세로다
            Empty = 퍼즐총갯수 - 1;   //퍼즐의 갯수를 구한다음 거기서 한개의 퍼즐을 가려버린다.
            폼초기화();
        }

        public void 폼초기화()
        {
            int count = 0;  //배열에 쓰일 카운드
            bPuzz = new Puzzle[퍼즐총갯수];  //버튼 배열의 크기를 정하고...
            this.Size = new Size(퍼즐가로갯수 * puzFormSize + 30, 퍼즐세로갯수 * puzFormSize + 80); //프로그램 창의 크기를 바꿔준다.
            for (int i = 0; i < 퍼즐총갯수; i++)
                bPuzz[i] = new Puzzle();
            for (int i = 0; i < 퍼즐세로갯수; i++) //세로만큼
            {
                for (int j = 0; j < 퍼즐가로갯수; j++) //가로만큼
                {
                    bPuzz[count].Width = puzFormSize;
                    bPuzz[count].Height = puzFormSize;
                    bPuzz[count].Top = i *puzFormSize + 30;
                    bPuzz[count].Left = j *puzFormSize + 10;
                                       
                    bPuzz[count].원래값 = count;  //섞이기 전의 값에 현재값을 대입....(처음 프로그램을 실해하면 퍼즐이 완성된 상태로 나오므로)
                    bPuzz[count].현재값 = count;
                    bPuzz[count].Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                    bPuzz[count].Click += new EventHandler(this.퍼즐클릭); //버튼을 누를 때마다 퍼즐클릭 메소드를 호출한다.
                    bPuzz[count].Text = (count + 1).ToString(); // 퍼즐에 숫자를 넣어준다.
                    this.Controls.Add(bPuzz[count]); //퍼즐을 생성
                    count++;  //퍼즐 배열에 들어가는 카운트 증가
                }
                bPuzz[Empty].Visible = false; //퍼즐 하나를 가림~
            }
        }
        public void 퍼즐클릭(object sender, EventArgs e)
        {
            Puzzle bPuzzSelected = (Puzzle)sender;  //클릭되는 퍼즐을 핸들링?
            if(주변에빈퍼즐이있는지검사((Puzzle)sender)==true)  //사용자가 누르는 퍼즐의 주위에 빈 퍼즐이 있는지 체크
            {
                퍼즐바꾸기(bPuzz[Empty],bPuzzSelected); //인접해있다면 사용자가 클릭한 퍼즐과, 인접한 빈 퍼즐의 위치를 바꿈
            }
            if(퍼즐을다맞췄는지검사())   //퍼즐이 1.2.3.4.5.....이런 순서가 됬는지 체크
            {
                MessageBox.Show("축하합니다. 퍼즐을 다시 섞겠습니다.");
                퍼즐뒤섞기();  //축하 메시지를 띄운후, 퍼즐을 다시 섞는 메소드 호출
            }
        }
        private void 퍼즐바꾸기(Puzzle n1, Puzzle n2)  //버튼 객체
        {
            Point p = new Point(n1.Left, n1.Top); //클릭한 버튼의 왼쪽, 위쪽의 값을 가져오고
            int t = 0;
            n1.Location = n2.Location;  //클릭한 퍼즐에 빈 퍼즐의 위치값을 넣어주고...
            n2.Location = p; //빈 퍼즐에는 클릭한 퍼즐을 대입....즉, 서로 위치를 바꿔주는..거....

            t = n1.현재값;   //위에는 퍼즐의 위치를 바꾸는 것이고, 여기는 퍼즐에 들어있는 숫자를 담는...
            n1.현재값 = n2.현재값;
            n2.현재값 = t;
        }
        private bool 주변에빈퍼즐이있는지검사(Puzzle buttonTmp)
        {
            int AbsSum = 0;
            AbsSum = Math.Abs(bPuzz[Empty].Left - buttonTmp.Left) + Math.Abs(bPuzz[Empty].Top - buttonTmp.Top);
            //클릭되어진 퍼즐의 좌에서 빈 퍼즐의 좌를 빼주고, 그것에 절대값을 취하고....클릭된 퍼즐의 위와 빈 퍼즐의 위를 뺀것을 더해주면....
            //결국 퍼즐의 크기가 나온다...여기서는 puzFormSize.....가 된다.
            return (AbsSum == puzFormSize) ? true : false; //인접해 있다면...트루 반환, 틀리면 펄스....
        }
        private void 퍼즐뒤섞기()
        {
            Random rnd = new Random();  //난수를 만들기 위해 rnd 생성
            int r1, r2;
            for (int i = 0; i < 퍼즐총갯수; i++) //퍼즐의 최대갯수만큼..i를 돌리고...
            {
                r1 = rnd.Next(0, 퍼즐총갯수); //난수를 만들고..
                r2 = rnd.Next(0, 퍼즐총갯수); //
                퍼즐바꾸기(bPuzz[r1], bPuzz[r2]); //퍼즐들을 마구 섞는다....숫자는 안바뀌고 칸만 어질러지니깐, 결국엔 숫자도 바뀜
            }
        }
        private bool 퍼즐을다맞췄는지검사()
        {
            bool ret = true;
            for (int i = 0; i < Empty; i++)
            {
                if (bPuzz[i].원래값 != bPuzz[i].현재값)  //오리지널 숫자값 1.2.3.4.5.....과 섞여있는 퍼즐의 값을..4.3.5.6..을 비교....
                {
                    ret = false;  //같지 않으면 펄스를 주고
                    break;  //if문 중지
                }
            }
            return ret; //위 if문에서 다른 게 발견되지 않았다면 true를 그대로 반환
        }
    }
    
}
