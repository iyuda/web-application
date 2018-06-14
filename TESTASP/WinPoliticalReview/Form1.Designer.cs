namespace WinPoliticalReview
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPoliticians = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYOF = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkLiberal = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPoliticians);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Politicians";
            // 
            // cboPoliticians
            // 
            this.cboPoliticians.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPoliticians.FormattingEnabled = true;
            this.cboPoliticians.Location = new System.Drawing.Point(16, 22);
            this.cboPoliticians.Name = "cboPoliticians";
            this.cboPoliticians.Size = new System.Drawing.Size(576, 24);
            this.cboPoliticians.TabIndex = 0;
            this.cboPoliticians.SelectedIndexChanged += new System.EventHandler(this.cboPoliticians_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Years in Office:";
            // 
            // txtYOF
            // 
            this.txtYOF.BackColor = System.Drawing.Color.White;
            this.txtYOF.Location = new System.Drawing.Point(95, 119);
            this.txtYOF.Name = "txtYOF";
            this.txtYOF.ReadOnly = true;
            this.txtYOF.Size = new System.Drawing.Size(95, 20);
            this.txtYOF.TabIndex = 2;
            this.txtYOF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.White;
            this.txtJob.Location = new System.Drawing.Point(266, 119);
            this.txtJob.Name = "txtJob";
            this.txtJob.ReadOnly = true;
            this.txtJob.Size = new System.Drawing.Size(207, 20);
            this.txtJob.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job:";
            // 
            // chkLiberal
            // 
            this.chkLiberal.AutoSize = true;
            this.chkLiberal.Location = new System.Drawing.Point(525, 122);
            this.chkLiberal.Name = "chkLiberal";
            this.chkLiberal.Size = new System.Drawing.Size(74, 17);
            this.chkLiberal.TabIndex = 5;
            this.chkLiberal.Text = "Is Liberal?";
            this.chkLiberal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 388);
            this.Controls.Add(this.chkLiberal);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYOF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Political Review";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPoliticians;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYOF;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLiberal;
    }
}

