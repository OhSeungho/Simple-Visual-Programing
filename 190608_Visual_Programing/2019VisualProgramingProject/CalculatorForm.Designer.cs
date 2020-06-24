namespace _2019VisualProgramingProject
{
    partial class CalculatorForm
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
            this.q4gb = new System.Windows.Forms.GroupBox();
            this.q4tb1 = new System.Windows.Forms.TextBox();
            this.q4lbl3 = new System.Windows.Forms.Label();
            this.q4lbl1 = new System.Windows.Forms.Label();
            this.q4bt1 = new System.Windows.Forms.Button();
            this.q5bt1 = new System.Windows.Forms.Button();
            this.q4gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // q4gb
            // 
            this.q4gb.Controls.Add(this.q4tb1);
            this.q4gb.Controls.Add(this.q4lbl3);
            this.q4gb.Controls.Add(this.q4lbl1);
            this.q4gb.Controls.Add(this.q4bt1);
            this.q4gb.Controls.Add(this.q5bt1);
            this.q4gb.Location = new System.Drawing.Point(12, 12);
            this.q4gb.Name = "q4gb";
            this.q4gb.Size = new System.Drawing.Size(308, 198);
            this.q4gb.TabIndex = 28;
            this.q4gb.TabStop = false;
            this.q4gb.Text = "환율계산기";
            // 
            // q4tb1
            // 
            this.q4tb1.Location = new System.Drawing.Point(6, 22);
            this.q4tb1.Name = "q4tb1";
            this.q4tb1.Size = new System.Drawing.Size(95, 21);
            this.q4tb1.TabIndex = 11;
            this.q4tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q4lbl3
            // 
            this.q4lbl3.Location = new System.Drawing.Point(107, 22);
            this.q4lbl3.Name = "q4lbl3";
            this.q4lbl3.Size = new System.Drawing.Size(14, 21);
            this.q4lbl3.TabIndex = 15;
            this.q4lbl3.Text = "원";
            this.q4lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q4lbl1
            // 
            this.q4lbl1.BackColor = System.Drawing.Color.Silver;
            this.q4lbl1.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q4lbl1.Location = new System.Drawing.Point(127, 22);
            this.q4lbl1.Name = "q4lbl1";
            this.q4lbl1.Size = new System.Drawing.Size(175, 158);
            this.q4lbl1.TabIndex = 13;
            this.q4lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // q4bt1
            // 
            this.q4bt1.Location = new System.Drawing.Point(6, 49);
            this.q4bt1.Name = "q4bt1";
            this.q4bt1.Size = new System.Drawing.Size(112, 50);
            this.q4bt1.TabIndex = 12;
            this.q4bt1.Text = "환율계산";
            this.q4bt1.UseVisualStyleBackColor = true;
            this.q4bt1.Click += new System.EventHandler(this.q4bt1_Click);
            // 
            // q5bt1
            // 
            this.q5bt1.Location = new System.Drawing.Point(6, 130);
            this.q5bt1.Name = "q5bt1";
            this.q5bt1.Size = new System.Drawing.Size(112, 50);
            this.q5bt1.TabIndex = 16;
            this.q5bt1.Text = "비용계산";
            this.q5bt1.UseVisualStyleBackColor = true;
            this.q5bt1.Click += new System.EventHandler(this.q5bt1_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 222);
            this.Controls.Add(this.q4gb);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.q4gb.ResumeLayout(false);
            this.q4gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox q4gb;
        private System.Windows.Forms.TextBox q4tb1;
        private System.Windows.Forms.Label q4lbl3;
        private System.Windows.Forms.Label q4lbl1;
        private System.Windows.Forms.Button q4bt1;
        private System.Windows.Forms.Button q5bt1;
    }
}