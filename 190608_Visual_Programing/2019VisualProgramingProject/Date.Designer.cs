namespace _2019VisualProgramingProject
{
    partial class Date
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.q6gb = new System.Windows.Forms.GroupBox();
            this.q6lbl1 = new System.Windows.Forms.Label();
            this.q6rbIDR = new System.Windows.Forms.RadioButton();
            this.q6rbEEUR = new System.Windows.Forms.RadioButton();
            this.q6rbWEUR = new System.Windows.Forms.RadioButton();
            this.q6rbAUD = new System.Windows.Forms.RadioButton();
            this.q6rbUSD = new System.Windows.Forms.RadioButton();
            this.q6rbCHN = new System.Windows.Forms.RadioButton();
            this.q6rbJPN = new System.Windows.Forms.RadioButton();
            this.q6rbKOR = new System.Windows.Forms.RadioButton();
            this.q6gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // q6gb
            // 
            this.q6gb.Controls.Add(this.q6lbl1);
            this.q6gb.Controls.Add(this.q6rbIDR);
            this.q6gb.Controls.Add(this.q6rbEEUR);
            this.q6gb.Controls.Add(this.q6rbWEUR);
            this.q6gb.Controls.Add(this.q6rbAUD);
            this.q6gb.Controls.Add(this.q6rbUSD);
            this.q6gb.Controls.Add(this.q6rbCHN);
            this.q6gb.Controls.Add(this.q6rbJPN);
            this.q6gb.Controls.Add(this.q6rbKOR);
            this.q6gb.Location = new System.Drawing.Point(12, 12);
            this.q6gb.Name = "q6gb";
            this.q6gb.Size = new System.Drawing.Size(230, 139);
            this.q6gb.TabIndex = 18;
            this.q6gb.TabStop = false;
            this.q6gb.Text = "여행 추천 날짜";
            // 
            // q6lbl1
            // 
            this.q6lbl1.Location = new System.Drawing.Point(6, 111);
            this.q6lbl1.Name = "q6lbl1";
            this.q6lbl1.Size = new System.Drawing.Size(228, 23);
            this.q6lbl1.TabIndex = 11;
            this.q6lbl1.Text = "가장 적합한 날짜";
            this.q6lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q6rbIDR
            // 
            this.q6rbIDR.AutoSize = true;
            this.q6rbIDR.Location = new System.Drawing.Point(138, 44);
            this.q6rbIDR.Name = "q6rbIDR";
            this.q6rbIDR.Size = new System.Drawing.Size(59, 16);
            this.q6rbIDR.TabIndex = 10;
            this.q6rbIDR.TabStop = true;
            this.q6rbIDR.Text = "동남아";
            this.q6rbIDR.UseVisualStyleBackColor = true;
            this.q6rbIDR.CheckedChanged += new System.EventHandler(this.q6rbIDR_CheckedChanged);
            // 
            // q6rbEEUR
            // 
            this.q6rbEEUR.AutoSize = true;
            this.q6rbEEUR.Location = new System.Drawing.Point(138, 88);
            this.q6rbEEUR.Name = "q6rbEEUR";
            this.q6rbEEUR.Size = new System.Drawing.Size(59, 16);
            this.q6rbEEUR.TabIndex = 9;
            this.q6rbEEUR.TabStop = true;
            this.q6rbEEUR.Text = "동유럽";
            this.q6rbEEUR.UseVisualStyleBackColor = true;
            this.q6rbEEUR.CheckedChanged += new System.EventHandler(this.q6rbEEUR_CheckedChanged);
            // 
            // q6rbWEUR
            // 
            this.q6rbWEUR.AutoSize = true;
            this.q6rbWEUR.Location = new System.Drawing.Point(138, 66);
            this.q6rbWEUR.Name = "q6rbWEUR";
            this.q6rbWEUR.Size = new System.Drawing.Size(59, 16);
            this.q6rbWEUR.TabIndex = 8;
            this.q6rbWEUR.TabStop = true;
            this.q6rbWEUR.Text = "서유럽";
            this.q6rbWEUR.UseVisualStyleBackColor = true;
            this.q6rbWEUR.CheckedChanged += new System.EventHandler(this.q6rbWEUR_CheckedChanged);
            // 
            // q6rbAUD
            // 
            this.q6rbAUD.AutoSize = true;
            this.q6rbAUD.Location = new System.Drawing.Point(138, 22);
            this.q6rbAUD.Name = "q6rbAUD";
            this.q6rbAUD.Size = new System.Drawing.Size(47, 16);
            this.q6rbAUD.TabIndex = 7;
            this.q6rbAUD.TabStop = true;
            this.q6rbAUD.Text = "호주";
            this.q6rbAUD.UseVisualStyleBackColor = true;
            this.q6rbAUD.CheckedChanged += new System.EventHandler(this.q6rbAUD_CheckedChanged);
            // 
            // q6rbUSD
            // 
            this.q6rbUSD.AutoSize = true;
            this.q6rbUSD.Location = new System.Drawing.Point(6, 88);
            this.q6rbUSD.Name = "q6rbUSD";
            this.q6rbUSD.Size = new System.Drawing.Size(47, 16);
            this.q6rbUSD.TabIndex = 6;
            this.q6rbUSD.TabStop = true;
            this.q6rbUSD.Text = "미국";
            this.q6rbUSD.UseVisualStyleBackColor = true;
            this.q6rbUSD.CheckedChanged += new System.EventHandler(this.q6rbUSD_CheckedChanged);
            // 
            // q6rbCHN
            // 
            this.q6rbCHN.AutoSize = true;
            this.q6rbCHN.Location = new System.Drawing.Point(6, 66);
            this.q6rbCHN.Name = "q6rbCHN";
            this.q6rbCHN.Size = new System.Drawing.Size(47, 16);
            this.q6rbCHN.TabIndex = 2;
            this.q6rbCHN.TabStop = true;
            this.q6rbCHN.Text = "중국";
            this.q6rbCHN.UseVisualStyleBackColor = true;
            this.q6rbCHN.CheckedChanged += new System.EventHandler(this.q6rbCHN_CheckedChanged);
            // 
            // q6rbJPN
            // 
            this.q6rbJPN.AutoSize = true;
            this.q6rbJPN.Location = new System.Drawing.Point(6, 44);
            this.q6rbJPN.Name = "q6rbJPN";
            this.q6rbJPN.Size = new System.Drawing.Size(47, 16);
            this.q6rbJPN.TabIndex = 1;
            this.q6rbJPN.TabStop = true;
            this.q6rbJPN.Text = "일본";
            this.q6rbJPN.UseVisualStyleBackColor = true;
            this.q6rbJPN.CheckedChanged += new System.EventHandler(this.q6rbJPN_CheckedChanged);
            // 
            // q6rbKOR
            // 
            this.q6rbKOR.AutoSize = true;
            this.q6rbKOR.Location = new System.Drawing.Point(6, 22);
            this.q6rbKOR.Name = "q6rbKOR";
            this.q6rbKOR.Size = new System.Drawing.Size(47, 16);
            this.q6rbKOR.TabIndex = 0;
            this.q6rbKOR.TabStop = true;
            this.q6rbKOR.Text = "국내";
            this.q6rbKOR.UseVisualStyleBackColor = true;
            this.q6rbKOR.CheckedChanged += new System.EventHandler(this.q6rbKOR_CheckedChanged_1);
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 159);
            this.Controls.Add(this.q6gb);
            this.Name = "Date";
            this.Text = "Date";
            this.q6gb.ResumeLayout(false);
            this.q6gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox q6gb;
        private System.Windows.Forms.Label q6lbl1;
        private System.Windows.Forms.RadioButton q6rbIDR;
        private System.Windows.Forms.RadioButton q6rbEEUR;
        private System.Windows.Forms.RadioButton q6rbWEUR;
        private System.Windows.Forms.RadioButton q6rbAUD;
        private System.Windows.Forms.RadioButton q6rbUSD;
        private System.Windows.Forms.RadioButton q6rbCHN;
        private System.Windows.Forms.RadioButton q6rbJPN;
        private System.Windows.Forms.RadioButton q6rbKOR;
    }
}