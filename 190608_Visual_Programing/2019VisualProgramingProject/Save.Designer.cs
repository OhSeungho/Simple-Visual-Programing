namespace _2019VisualProgramingProject
{
    partial class Save
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
            this.q12gb = new System.Windows.Forms.GroupBox();
            this.q12bt = new System.Windows.Forms.Button();
            this.q12tb = new System.Windows.Forms.TextBox();
            this.q12gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // q12gb
            // 
            this.q12gb.Controls.Add(this.q12bt);
            this.q12gb.Controls.Add(this.q12tb);
            this.q12gb.Location = new System.Drawing.Point(12, 12);
            this.q12gb.Name = "q12gb";
            this.q12gb.Size = new System.Drawing.Size(504, 484);
            this.q12gb.TabIndex = 35;
            this.q12gb.TabStop = false;
            this.q12gb.Text = "저장된 자료 조회";
            // 
            // q12bt
            // 
            this.q12bt.Location = new System.Drawing.Point(6, 22);
            this.q12bt.Name = "q12bt";
            this.q12bt.Size = new System.Drawing.Size(122, 23);
            this.q12bt.TabIndex = 35;
            this.q12bt.Text = "저장 자료 조회";
            this.q12bt.UseVisualStyleBackColor = true;
            this.q12bt.Click += new System.EventHandler(this.q12bt_Click);
            // 
            // q12tb
            // 
            this.q12tb.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q12tb.Location = new System.Drawing.Point(6, 51);
            this.q12tb.Multiline = true;
            this.q12tb.Name = "q12tb";
            this.q12tb.Size = new System.Drawing.Size(492, 427);
            this.q12tb.TabIndex = 33;
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 508);
            this.Controls.Add(this.q12gb);
            this.Name = "Save";
            this.Text = "Save";
            this.q12gb.ResumeLayout(false);
            this.q12gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox q12gb;
        private System.Windows.Forms.Button q12bt;
        private System.Windows.Forms.TextBox q12tb;
    }
}