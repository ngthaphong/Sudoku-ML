namespace source_sudoku
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
            this.Mau = new System.Windows.Forms.TextBox();
            this.myPanel = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnGiai = new System.Windows.Forms.Button();
            this.DiagOpen = new System.Windows.Forms.OpenFileDialog();
            this.myPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mau
            // 
            this.Mau.AllowDrop = true;
            this.Mau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mau.Location = new System.Drawing.Point(317, 57);
            this.Mau.Name = "Mau";
            this.Mau.Size = new System.Drawing.Size(31, 31);
            this.Mau.TabIndex = 2;
            this.Mau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mau.Visible = false;
            this.Mau.WordWrap = false;
            this.Mau.TextChanged += new System.EventHandler(this.Mau_TextChanged);
            this.Mau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mau_KeyPress);
            // 
            // myPanel
            // 
            this.myPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPanel.Controls.Add(this.Mau);
            this.myPanel.Location = new System.Drawing.Point(0, 61);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(414, 304);
            this.myPanel.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(12, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(12, 381);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(75, 23);
            this.btnMo.TabIndex = 4;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // btnGiai
            //
            this.btnGiai.Location = new System.Drawing.Point(12, 381);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(75, 23);
            this.btnGiai.TabIndex = 4;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // DiagOpen
            //
            this.DiagOpen.Filter = "Default type(*.txt)|*.txt;|Text file (*.txt)|" + "*.txt|All files(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 513);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.myPanel);
            this.Name = "Form1";
            this.Text = "Chương trình giải Sudoku";
            this.TopMost = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.myPanel.ResumeLayout(false);
            this.myPanel.PerformLayout();
            this.PerformLayout();
            this.ResumeLayout(false);
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

        #endregion

        private System.Windows.Forms.TextBox Mau;
        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.OpenFileDialog DiagOpen;
    }
}

