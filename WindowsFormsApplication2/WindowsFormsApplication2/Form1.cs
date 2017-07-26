using System;
using System.Drawing;
using System.Windows.Forms;

namespace _018_Application
{
    public partial class Form1 : Form
    {
        CPlayBlock playBlock_;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playBlock_ = new CPlayBlock(this, new Point(10, 25), new Point(6, 24)); // (Form1, pbPlayBlock X Y 칸수, pbNextBlock X Y 칸수)
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            playBlock_.GamePlayClear();
            tabCtl_Skill.Focus();
            tmTetris.Enabled = true;
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            if (lbGameOver.ForeColor == Color.DarkRed) return;

            if (btPause.Text == "계 속 하 기")
            {
                lbGameOver.Visible = false;
                tmTetris.Enabled = true;
                tabGameSpeed.Enabled = false;
                btPause.Text = "일 시 중 지";
                tabCtl_Skill.Focus();
            }
            else
            {
                lbGameOver.Visible = true;
                tabGameSpeed.Enabled = true;
                btPause.Text = "계 속 하 기";
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        readonly int[,] _gameSpeedArray = new int[10, 2] // (lbGameSpeed.Left, tmTetris.Interval)
        { {9,1000},{25,900},{42,800},{58,700},{74,600},{91,500},{106,400},{123,300},{140,200},{156,100} };
        private void tbGameSpeed_ValueChanged(object sender, EventArgs e)
        {
            lbGameSpeed.Text = tbGameSpeed.Value.ToString();
            lbGameSpeed.Left = _gameSpeedArray[tbGameSpeed.Value - 1, 0];
            tmTetris.Interval = _gameSpeedArray[tbGameSpeed.Value - 1, 1];
        }

        private void tabCtl_Skill_KeyDown(object sender, KeyEventArgs e)
        {
            if (lbGameOver.Visible == true) return; // 게임 오버
            else if (e.KeyCode == Keys.Left) playBlock_.GameMoveLeftRight(-1);
            else if (e.KeyCode == Keys.Right) playBlock_.GameMoveLeftRight(1);
            else if (e.KeyCode == Keys.Up) playBlock_.GameMoveUpDown(3); // Y-- == (Y + 3) % 4
            else if (e.KeyCode == Keys.Down) playBlock_.GameMoveUpDown(1); // Y++ == (Y + 1) % 4 
            else if (e.KeyCode == Keys.Space) tmTetris.Interval = 25;
            else if (e.KeyCode == Keys.Enter) playBlock_.BonusSkill();
        }

        private void tabCtl_Skill_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) tmTetris.Interval = _gameSpeedArray[tbGameSpeed.Value - 1, 1];
        }

        private void lbBlockCount_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbBonusSkill.Text) > 98) return; // 보너스 스킬 최대값 99
            if (Convert.ToInt32(lbBlockCount.Text) % 50 == 0) lbBonusSkill.Text = (Convert.ToInt32(lbBonusSkill.Text) + 1).ToString(); // 블럭수 50개 보너스 +1
        }

        private void TETRIS_Click(object sender, EventArgs e)
        {
            tabCtl_Skill.Focus();
        }

        private void tabGameSpeed_Click(object sender, EventArgs e)
        {
            tbGameSpeed.Focus();
        }

        private void tmTetris_Tick(object sender, EventArgs e)
        {
            tmTetris.Enabled = false;
            if (lbGameOver.Visible == true) return;
            playBlock_.GameStart();
            tmTetris.Enabled = true;
        }
    }
}
