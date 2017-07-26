namespace _018_Application
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPlayBlock = new System.Windows.Forms.PictureBox();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.lbGameOverF = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pbNextBlock = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btPause = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.tbGameSpeed = new System.Windows.Forms.TrackBar();
            this.lbGameSpeed = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDeleteLine = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMaxCombo = new System.Windows.Forms.Label();
            this.tabCtl_Skill = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbBonusSkill = new System.Windows.Forms.Label();
            this.lbBlockCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmTetris = new System.Windows.Forms.Timer(this.components);
            this.tabGameSpeed = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabMemo = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbMome1 = new System.Windows.Forms.Label();
            this.lbMemo2 = new System.Windows.Forms.Label();
            this.lbMemo3 = new System.Windows.Forms.Label();
            this.lbMemo4 = new System.Windows.Forms.Label();
            this.lbMemo5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayBlock)).BeginInit();
            this.pbPlayBlock.SuspendLayout();
            this.lbGameOver.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextBlock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGameSpeed)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabCtl_Skill.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabGameSpeed.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabMemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPlayBlock
            // 
            this.pbPlayBlock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbPlayBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPlayBlock.Controls.Add(this.lbGameOver);
            this.pbPlayBlock.Location = new System.Drawing.Point(12, 12);
            this.pbPlayBlock.Name = "pbPlayBlock";
            this.pbPlayBlock.Size = new System.Drawing.Size(305, 755);
            this.pbPlayBlock.TabIndex = 0;
            this.pbPlayBlock.TabStop = false;
            this.pbPlayBlock.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbGameOver
            // 
            this.lbGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lbGameOver.Controls.Add(this.lbGameOverF);
            this.lbGameOver.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGameOver.ForeColor = System.Drawing.Color.DarkRed;
            this.lbGameOver.Location = new System.Drawing.Point(6, 320);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(291, 112);
            this.lbGameOver.TabIndex = 8;
            this.lbGameOver.Text = "Game Over";
            this.lbGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGameOver.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbGameOverF
            // 
            this.lbGameOverF.BackColor = System.Drawing.Color.Transparent;
            this.lbGameOverF.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGameOverF.ForeColor = System.Drawing.Color.Red;
            this.lbGameOverF.Location = new System.Drawing.Point(3, 30);
            this.lbGameOverF.Name = "lbGameOverF";
            this.lbGameOverF.Size = new System.Drawing.Size(281, 48);
            this.lbGameOverF.TabIndex = 7;
            this.lbGameOverF.Text = "Game Over";
            this.lbGameOverF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGameOverF.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl1.Location = new System.Drawing.Point(484, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(194, 55);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(186, 27);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "블  럭  수";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(651, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "개";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // pbNextBlock
            // 
            this.pbNextBlock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbNextBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNextBlock.Location = new System.Drawing.Point(323, 12);
            this.pbNextBlock.Name = "pbNextBlock";
            this.pbNextBlock.Size = new System.Drawing.Size(155, 605);
            this.pbNextBlock.TabIndex = 4;
            this.pbNextBlock.TabStop = false;
            this.pbNextBlock.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.btPause);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(484, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 140);
            this.panel1.TabIndex = 3;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(3, 95);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(186, 40);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "게 임 종 료";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btPause
            // 
            this.btPause.Location = new System.Drawing.Point(3, 49);
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(186, 40);
            this.btPause.TabIndex = 1;
            this.btPause.Text = "일 시 중 지";
            this.btPause.UseVisualStyleBackColor = true;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(3, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(186, 40);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "게 임 시 작";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbGameSpeed
            // 
            this.tbGameSpeed.AutoSize = false;
            this.tbGameSpeed.LargeChange = 1;
            this.tbGameSpeed.Location = new System.Drawing.Point(6, 6);
            this.tbGameSpeed.Minimum = 1;
            this.tbGameSpeed.Name = "tbGameSpeed";
            this.tbGameSpeed.Size = new System.Drawing.Size(174, 32);
            this.tbGameSpeed.TabIndex = 5;
            this.tbGameSpeed.Value = 5;
            this.tbGameSpeed.ValueChanged += new System.EventHandler(this.tbGameSpeed_ValueChanged);
            // 
            // lbGameSpeed
            // 
            this.lbGameSpeed.ForeColor = System.Drawing.Color.Blue;
            this.lbGameSpeed.Location = new System.Drawing.Point(74, 37);
            this.lbGameSpeed.Name = "lbGameSpeed";
            this.lbGameSpeed.Size = new System.Drawing.Size(24, 14);
            this.lbGameSpeed.TabIndex = 6;
            this.lbGameSpeed.Text = "5";
            this.lbGameSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbGameSpeed.Click += new System.EventHandler(this.tabGameSpeed_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Enabled = false;
            this.tabControl2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl2.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl2.Location = new System.Drawing.Point(484, 73);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(194, 55);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(186, 27);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "라인삭제";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(651, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "줄";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbDeleteLine
            // 
            this.lbDeleteLine.BackColor = System.Drawing.Color.White;
            this.lbDeleteLine.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDeleteLine.ForeColor = System.Drawing.Color.Blue;
            this.lbDeleteLine.Location = new System.Drawing.Point(494, 103);
            this.lbDeleteLine.Name = "lbDeleteLine";
            this.lbDeleteLine.Size = new System.Drawing.Size(158, 15);
            this.lbDeleteLine.TabIndex = 2;
            this.lbDeleteLine.Text = "0";
            this.lbDeleteLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDeleteLine.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Enabled = false;
            this.tabControl3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl3.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl3.Location = new System.Drawing.Point(484, 134);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(194, 55);
            this.tabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(186, 27);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "최대콤보";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(651, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "회";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbMaxCombo
            // 
            this.lbMaxCombo.BackColor = System.Drawing.Color.White;
            this.lbMaxCombo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMaxCombo.ForeColor = System.Drawing.Color.Blue;
            this.lbMaxCombo.Location = new System.Drawing.Point(494, 164);
            this.lbMaxCombo.Name = "lbMaxCombo";
            this.lbMaxCombo.Size = new System.Drawing.Size(158, 15);
            this.lbMaxCombo.TabIndex = 2;
            this.lbMaxCombo.Text = "0";
            this.lbMaxCombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMaxCombo.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // tabCtl_Skill
            // 
            this.tabCtl_Skill.Controls.Add(this.tabPage4);
            this.tabCtl_Skill.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabCtl_Skill.ItemSize = new System.Drawing.Size(100, 20);
            this.tabCtl_Skill.Location = new System.Drawing.Point(323, 623);
            this.tabCtl_Skill.Name = "tabCtl_Skill";
            this.tabCtl_Skill.SelectedIndex = 0;
            this.tabCtl_Skill.Size = new System.Drawing.Size(155, 144);
            this.tabCtl_Skill.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtl_Skill.TabIndex = 6;
            this.tabCtl_Skill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabCtl_Skill_KeyDown);
            this.tabCtl_Skill.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabCtl_Skill_KeyUp);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbBonusSkill);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(147, 116);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "보너스 스킬";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbBonusSkill
            // 
            this.lbBonusSkill.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBonusSkill.ForeColor = System.Drawing.Color.Blue;
            this.lbBonusSkill.Location = new System.Drawing.Point(20, 21);
            this.lbBonusSkill.Name = "lbBonusSkill";
            this.lbBonusSkill.Size = new System.Drawing.Size(106, 74);
            this.lbBonusSkill.TabIndex = 1;
            this.lbBonusSkill.Text = "5";
            this.lbBonusSkill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbBonusSkill.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbBlockCount
            // 
            this.lbBlockCount.BackColor = System.Drawing.Color.White;
            this.lbBlockCount.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBlockCount.ForeColor = System.Drawing.Color.Blue;
            this.lbBlockCount.Location = new System.Drawing.Point(494, 42);
            this.lbBlockCount.Name = "lbBlockCount";
            this.lbBlockCount.Size = new System.Drawing.Size(158, 15);
            this.lbBlockCount.TabIndex = 0;
            this.lbBlockCount.Text = "0";
            this.lbBlockCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbBlockCount.TextChanged += new System.EventHandler(this.lbBlockCount_TextChanged);
            this.lbBlockCount.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // tmTetris
            // 
            this.tmTetris.Interval = 600;
            this.tmTetris.Tick += new System.EventHandler(this.tmTetris_Tick);
            // 
            // tabGameSpeed
            // 
            this.tabGameSpeed.Controls.Add(this.tabPage5);
            this.tabGameSpeed.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabGameSpeed.ItemSize = new System.Drawing.Size(80, 20);
            this.tabGameSpeed.Location = new System.Drawing.Point(484, 366);
            this.tabGameSpeed.Name = "tabGameSpeed";
            this.tabGameSpeed.SelectedIndex = 0;
            this.tabGameSpeed.Size = new System.Drawing.Size(194, 87);
            this.tabGameSpeed.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGameSpeed.TabIndex = 4;
            this.tabGameSpeed.Click += new System.EventHandler(this.tabGameSpeed_Click);
            this.tabGameSpeed.Enter += new System.EventHandler(this.tabGameSpeed_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.tbGameSpeed);
            this.tabPage5.Controls.Add(this.lbGameSpeed);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(186, 59);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "게임속도";
            this.tabPage5.Click += new System.EventHandler(this.tabGameSpeed_Click);
            // 
            // tabMemo
            // 
            this.tabMemo.Controls.Add(this.tabPage6);
            this.tabMemo.Enabled = false;
            this.tabMemo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabMemo.ItemSize = new System.Drawing.Size(80, 20);
            this.tabMemo.Location = new System.Drawing.Point(484, 480);
            this.tabMemo.Name = "tabMemo";
            this.tabMemo.SelectedIndex = 0;
            this.tabMemo.Size = new System.Drawing.Size(194, 287);
            this.tabMemo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMemo.TabIndex = 5;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
           // this.tabPage6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage6.BackgroundImage")));
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(186, 259);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "설      명";
            // 
            // lbMome1
            // 
            this.lbMome1.AutoSize = true;
            this.lbMome1.BackColor = System.Drawing.Color.White;
            this.lbMome1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMome1.Location = new System.Drawing.Point(490, 595);
            this.lbMome1.Name = "lbMome1";
            this.lbMome1.Size = new System.Drawing.Size(82, 13);
            this.lbMome1.TabIndex = 0;
            this.lbMome1.Text = "Space bar";
            this.lbMome1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMome1.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbMemo2
            // 
            this.lbMemo2.AutoSize = true;
            this.lbMemo2.BackColor = System.Drawing.Color.White;
            this.lbMemo2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMemo2.Location = new System.Drawing.Point(530, 615);
            this.lbMemo2.Name = "lbMemo2";
            this.lbMemo2.Size = new System.Drawing.Size(119, 13);
            this.lbMemo2.TabIndex = 1;
            this.lbMemo2.Text = "블럭 빠르게 내리기";
            this.lbMemo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMemo2.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbMemo3
            // 
            this.lbMemo3.AutoSize = true;
            this.lbMemo3.BackColor = System.Drawing.Color.White;
            this.lbMemo3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMemo3.Location = new System.Drawing.Point(490, 645);
            this.lbMemo3.Name = "lbMemo3";
            this.lbMemo3.Size = new System.Drawing.Size(44, 13);
            this.lbMemo3.TabIndex = 2;
            this.lbMemo3.Text = "Enter";
            this.lbMemo3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMemo3.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbMemo4
            // 
            this.lbMemo4.AutoSize = true;
            this.lbMemo4.BackColor = System.Drawing.Color.White;
            this.lbMemo4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMemo4.Location = new System.Drawing.Point(530, 665);
            this.lbMemo4.Name = "lbMemo4";
            this.lbMemo4.Size = new System.Drawing.Size(106, 13);
            this.lbMemo4.TabIndex = 3;
            this.lbMemo4.Text = "보너스 스킬 사용";
            this.lbMemo4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMemo4.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // lbMemo5
            // 
            this.lbMemo5.AutoSize = true;
            this.lbMemo5.BackColor = System.Drawing.Color.White;
            this.lbMemo5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMemo5.Location = new System.Drawing.Point(530, 685);
            this.lbMemo5.Name = "lbMemo5";
            this.lbMemo5.Size = new System.Drawing.Size(121, 13);
            this.lbMemo5.TabIndex = 4;
            this.lbMemo5.Text = "맨 위 라인 3줄 삭제";
            this.lbMemo5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMemo5.Click += new System.EventHandler(this.TETRIS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 779);
            this.Controls.Add(this.lbMemo4);
            this.Controls.Add(this.lbMemo3);
            this.Controls.Add(this.lbMemo5);
            this.Controls.Add(this.lbMemo2);
            this.Controls.Add(this.lbMome1);
            this.Controls.Add(this.tabMemo);
            this.Controls.Add(this.tabGameSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbBlockCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDeleteLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaxCombo);
            this.Controls.Add(this.tabCtl_Skill);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbNextBlock);
            this.Controls.Add(this.pbPlayBlock);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
          //  this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TETRIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.TETRIS_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayBlock)).EndInit();
            this.pbPlayBlock.ResumeLayout(false);
            this.lbGameOver.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNextBlock)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbGameSpeed)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabCtl_Skill.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabGameSpeed.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabMemo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TrackBar tbGameSpeed;
        private System.Windows.Forms.Label lbGameSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabCtl_Skill;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.PictureBox pbPlayBlock;
        internal System.Windows.Forms.PictureBox pbNextBlock;
        internal System.Windows.Forms.Timer tmTetris;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabMemo;
        private System.Windows.Forms.TabPage tabPage6;
        internal System.Windows.Forms.Label lbDeleteLine;
        internal System.Windows.Forms.Label lbMaxCombo;
        internal System.Windows.Forms.Label lbBonusSkill;
        internal System.Windows.Forms.Label lbBlockCount;
        internal System.Windows.Forms.Label lbGameOverF;
        internal System.Windows.Forms.Label lbGameOver;
        internal System.Windows.Forms.TabControl tabGameSpeed;
        internal System.Windows.Forms.Button btPause;
        private System.Windows.Forms.Label lbMemo2;
        private System.Windows.Forms.Label lbMome1;
        private System.Windows.Forms.Label lbMemo5;
        private System.Windows.Forms.Label lbMemo4;
        private System.Windows.Forms.Label lbMemo3;
    }
}

