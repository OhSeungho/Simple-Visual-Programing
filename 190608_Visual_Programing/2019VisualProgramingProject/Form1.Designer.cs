namespace _2019VisualProgramingProject
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
            this.q1bt1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.프로그램ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.체크리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환율계산기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.날짜추천ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.항공권예약ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자료조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회및수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btGetAirlineTicket = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbloutCk = new System.Windows.Forms.Label();
            this.lblout2 = new System.Windows.Forms.Label();
            this.q1pb1 = new System.Windows.Forms.PictureBox();
            this.q1pb5 = new System.Windows.Forms.PictureBox();
            this.q1pb4 = new System.Windows.Forms.PictureBox();
            this.q1pb3 = new System.Windows.Forms.PictureBox();
            this.q1pb2 = new System.Windows.Forms.PictureBox();
            this.rdpb = new System.Windows.Forms.PictureBox();
            this.lblout = new System.Windows.Forms.Label();
            this.데이터베이스열람ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpb)).BeginInit();
            this.SuspendLayout();
            // 
            // q1bt1
            // 
            this.q1bt1.Location = new System.Drawing.Point(716, 28);
            this.q1bt1.Name = "q1bt1";
            this.q1bt1.Size = new System.Drawing.Size(230, 40);
            this.q1bt1.TabIndex = 1;
            this.q1bt1.Text = "배너 변경";
            this.q1bt1.UseVisualStyleBackColor = true;
            this.q1bt1.Click += new System.EventHandler(this.q1bt1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램ToolStripMenuItem,
            this.사용자정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 프로그램ToolStripMenuItem
            // 
            this.프로그램ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.체크리스트ToolStripMenuItem,
            this.환율계산기ToolStripMenuItem,
            this.날짜추천ToolStripMenuItem,
            this.항공권예약ToolStripMenuItem,
            this.자료조회ToolStripMenuItem,
            this.데이터베이스열람ToolStripMenuItem});
            this.프로그램ToolStripMenuItem.Name = "프로그램ToolStripMenuItem";
            this.프로그램ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.프로그램ToolStripMenuItem.Text = "프로그램";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 체크리스트ToolStripMenuItem
            // 
            this.체크리스트ToolStripMenuItem.Name = "체크리스트ToolStripMenuItem";
            this.체크리스트ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.체크리스트ToolStripMenuItem.Text = "체크리스트";
            this.체크리스트ToolStripMenuItem.Click += new System.EventHandler(this.체크리스트ToolStripMenuItem_Click);
            // 
            // 환율계산기ToolStripMenuItem
            // 
            this.환율계산기ToolStripMenuItem.Name = "환율계산기ToolStripMenuItem";
            this.환율계산기ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.환율계산기ToolStripMenuItem.Text = "환율계산기";
            this.환율계산기ToolStripMenuItem.Click += new System.EventHandler(this.환율계산기ToolStripMenuItem_Click);
            // 
            // 날짜추천ToolStripMenuItem
            // 
            this.날짜추천ToolStripMenuItem.Name = "날짜추천ToolStripMenuItem";
            this.날짜추천ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.날짜추천ToolStripMenuItem.Text = "날짜 추천";
            this.날짜추천ToolStripMenuItem.Click += new System.EventHandler(this.날짜추천ToolStripMenuItem_Click);
            // 
            // 항공권예약ToolStripMenuItem
            // 
            this.항공권예약ToolStripMenuItem.Name = "항공권예약ToolStripMenuItem";
            this.항공권예약ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.항공권예약ToolStripMenuItem.Text = "항공권 예약";
            this.항공권예약ToolStripMenuItem.Click += new System.EventHandler(this.항공권예약ToolStripMenuItem_Click);
            // 
            // 자료조회ToolStripMenuItem
            // 
            this.자료조회ToolStripMenuItem.Name = "자료조회ToolStripMenuItem";
            this.자료조회ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.자료조회ToolStripMenuItem.Text = "자료 조회";
            this.자료조회ToolStripMenuItem.Click += new System.EventHandler(this.자료조회ToolStripMenuItem_Click);
            // 
            // 사용자정보ToolStripMenuItem
            // 
            this.사용자정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.조회및수정ToolStripMenuItem});
            this.사용자정보ToolStripMenuItem.Name = "사용자정보ToolStripMenuItem";
            this.사용자정보ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.사용자정보ToolStripMenuItem.Text = "사용자 정보";
            // 
            // 조회및수정ToolStripMenuItem
            // 
            this.조회및수정ToolStripMenuItem.Name = "조회및수정ToolStripMenuItem";
            this.조회및수정ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.조회및수정ToolStripMenuItem.Text = "조회 및 수정";
            this.조회및수정ToolStripMenuItem.Click += new System.EventHandler(this.조회및수정ToolStripMenuItem_Click);
            // 
            // btGetAirlineTicket
            // 
            this.btGetAirlineTicket.Location = new System.Drawing.Point(251, 675);
            this.btGetAirlineTicket.Name = "btGetAirlineTicket";
            this.btGetAirlineTicket.Size = new System.Drawing.Size(213, 23);
            this.btGetAirlineTicket.TabIndex = 36;
            this.btGetAirlineTicket.Text = "항공권 출력";
            this.btGetAirlineTicket.UseVisualStyleBackColor = true;
            this.btGetAirlineTicket.Click += new System.EventHandler(this.btGetAirlineTicket_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "런던.jpg");
            this.imageList1.Images.SetKeyName(1, "슬로베니아.jpg");
            this.imageList1.Images.SetKeyName(2, "퀘벡.jpg");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "여행 도우미";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "여권 정보 조회";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "챙길 물품";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbloutCk
            // 
            this.lbloutCk.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbloutCk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbloutCk.Image = global::_2019VisualProgramingProject.Properties.Resources.다운로드;
            this.lbloutCk.Location = new System.Drawing.Point(471, 534);
            this.lbloutCk.Name = "lbloutCk";
            this.lbloutCk.Size = new System.Drawing.Size(239, 138);
            this.lbloutCk.TabIndex = 41;
            this.lbloutCk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblout2
            // 
            this.lblout2.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblout2.ForeColor = System.Drawing.Color.DimGray;
            this.lblout2.Image = global::_2019VisualProgramingProject.Properties.Resources.여권;
            this.lblout2.Location = new System.Drawing.Point(12, 534);
            this.lblout2.Name = "lblout2";
            this.lblout2.Size = new System.Drawing.Size(229, 138);
            this.lblout2.TabIndex = 39;
            this.lblout2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q1pb1
            // 
            this.q1pb1.Image = global::_2019VisualProgramingProject.Properties.Resources.q1pb제주;
            this.q1pb1.Location = new System.Drawing.Point(716, 71);
            this.q1pb1.Name = "q1pb1";
            this.q1pb1.Size = new System.Drawing.Size(230, 120);
            this.q1pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1pb1.TabIndex = 6;
            this.q1pb1.TabStop = false;
            this.q1pb1.Click += new System.EventHandler(this.q1pb1_Click);
            // 
            // q1pb5
            // 
            this.q1pb5.Image = global::_2019VisualProgramingProject.Properties.Resources.q1pb인천오사카;
            this.q1pb5.Location = new System.Drawing.Point(716, 457);
            this.q1pb5.Name = "q1pb5";
            this.q1pb5.Size = new System.Drawing.Size(230, 120);
            this.q1pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1pb5.TabIndex = 10;
            this.q1pb5.TabStop = false;
            this.q1pb5.Click += new System.EventHandler(this.q1pb5_Click);
            // 
            // q1pb4
            // 
            this.q1pb4.Image = global::_2019VisualProgramingProject.Properties.Resources.q1pb인천텐진;
            this.q1pb4.Location = new System.Drawing.Point(716, 331);
            this.q1pb4.Name = "q1pb4";
            this.q1pb4.Size = new System.Drawing.Size(230, 120);
            this.q1pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1pb4.TabIndex = 9;
            this.q1pb4.TabStop = false;
            this.q1pb4.Click += new System.EventHandler(this.q1pb4_Click);
            // 
            // q1pb3
            // 
            this.q1pb3.Image = global::_2019VisualProgramingProject.Properties.Resources.q1pb인천팔라우;
            this.q1pb3.Location = new System.Drawing.Point(716, 583);
            this.q1pb3.Name = "q1pb3";
            this.q1pb3.Size = new System.Drawing.Size(230, 120);
            this.q1pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1pb3.TabIndex = 8;
            this.q1pb3.TabStop = false;
            this.q1pb3.Click += new System.EventHandler(this.q1pb3_Click);
            // 
            // q1pb2
            // 
            this.q1pb2.Image = global::_2019VisualProgramingProject.Properties.Resources.q1pb인천후쿠오카;
            this.q1pb2.Location = new System.Drawing.Point(716, 204);
            this.q1pb2.Name = "q1pb2";
            this.q1pb2.Size = new System.Drawing.Size(230, 120);
            this.q1pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1pb2.TabIndex = 7;
            this.q1pb2.TabStop = false;
            this.q1pb2.Click += new System.EventHandler(this.q1pb2_Click);
            // 
            // rdpb
            // 
            this.rdpb.Image = global::_2019VisualProgramingProject.Properties.Resources.퀘벡;
            this.rdpb.Location = new System.Drawing.Point(12, 71);
            this.rdpb.Name = "rdpb";
            this.rdpb.Size = new System.Drawing.Size(698, 452);
            this.rdpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rdpb.TabIndex = 37;
            this.rdpb.TabStop = false;
            // 
            // lblout
            // 
            this.lblout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblout.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblout.Image = global::_2019VisualProgramingProject.Properties.Resources.l_2017071801002224700173651;
            this.lblout.Location = new System.Drawing.Point(247, 534);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(217, 138);
            this.lblout.TabIndex = 35;
            this.lblout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 데이터베이스열람ToolStripMenuItem
            // 
            this.데이터베이스열람ToolStripMenuItem.Name = "데이터베이스열람ToolStripMenuItem";
            this.데이터베이스열람ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.데이터베이스열람ToolStripMenuItem.Text = "항공편 조회";
            this.데이터베이스열람ToolStripMenuItem.Click += new System.EventHandler(this.데이터베이스열람ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 710);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbloutCk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblout2);
            this.Controls.Add(this.q1bt1);
            this.Controls.Add(this.q1pb1);
            this.Controls.Add(this.q1pb5);
            this.Controls.Add(this.q1pb4);
            this.Controls.Add(this.q1pb3);
            this.Controls.Add(this.q1pb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdpb);
            this.Controls.Add(this.btGetAirlineTicket);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox q1pb1;
        private System.Windows.Forms.PictureBox q1pb2;
        private System.Windows.Forms.PictureBox q1pb3;
        private System.Windows.Forms.PictureBox q1pb4;
        private System.Windows.Forms.PictureBox q1pb5;
        private System.Windows.Forms.Button q1bt1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 프로그램ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 체크리스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환율계산기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 날짜추천ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조회및수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 항공권예약ToolStripMenuItem;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Button btGetAirlineTicket;
        private System.Windows.Forms.PictureBox rdpb;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 자료조회ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblout2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.Label lbloutCk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 데이터베이스열람ToolStripMenuItem;
    }
}

