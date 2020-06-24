namespace _2019VisualProgramingProject
{
    partial class Profile
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
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbPN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(12, 29);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(83, 21);
            this.tbFN.TabIndex = 0;
            this.tbFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(12, 73);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(170, 21);
            this.tbP.TabIndex = 1;
            this.tbP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(12, 117);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(170, 21);
            this.tbN.TabIndex = 2;
            this.tbN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPN
            // 
            this.tbPN.Location = new System.Drawing.Point(12, 161);
            this.tbPN.Name = "tbPN";
            this.tbPN.Size = new System.Drawing.Size(172, 21);
            this.tbPN.TabIndex = 3;
            this.tbPN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "성";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(101, 29);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(83, 21);
            this.tbLN.TabIndex = 6;
            this.tbLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "주민등록번호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "국적";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "여권번호";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btIN
            // 
            this.btIN.Location = new System.Drawing.Point(12, 189);
            this.btIN.Name = "btIN";
            this.btIN.Size = new System.Drawing.Size(172, 23);
            this.btIN.TabIndex = 10;
            this.btIN.Text = "입력";
            this.btIN.UseVisualStyleBackColor = true;
            this.btIN.Click += new System.EventHandler(this.btIN_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 224);
            this.Controls.Add(this.btIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPN);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbFN);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btIN;
    }
}