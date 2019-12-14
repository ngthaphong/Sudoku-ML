using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace source_sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public TextBox[] text = new TextBox[82];
        int[] de = new int[82];
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadText();
        }
        public void LoadText()
        {
        const int space = 10;
            for (int i = 1; i <= 81; i++)
            {
                text[i] = new TextBox();
                text[i].Size = Mau.Size;
                text[i].Font = Mau.Font;
                text[i].MaxLength = 1;
                text[i].TabIndex = i;
                text[i].Top = ((i - 1) / 9) % 9 * text[i].Height + 1 + ((i - 1) / 27) * space + space;
                text[i].Left = (i - 1) % 9 * text[i].Width + 1 + ((i - 1) % 9) / 3 * space + space;
                text[i].Show();
                text[i].TextAlign = HorizontalAlignment.Center;
                text[i].Name = "Text" + i.ToString();
                text[i].Tag = i;
                text[i].Text = "";
                //
                this.text[i].TextChanged += new System.EventHandler(this.Mau_TextChanged);
                this.text[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mau_KeyPress);
                myPanel.Controls.Add(text[i]);
            }
            myPanel.Left = 0;
            //myPanel.Top = 
            myPanel.Height = text[81].Top + text[81].Height + space;
            myPanel.Width = text[81].Left + text[81].Width + space;
            btnXoa.Left = 12;
            btnXoa.Top = myPanel.Height + 59;
            btnXoa.Height += 15;
            btnMo.Left = btnXoa.Left + btnXoa.Width + 35;
            btnMo.Top = myPanel.Height + 59;
            btnMo.Height += 15;
            btnGiai.Left = btnXoa.Left + btnXoa.Width + btnMo.Left + btnMo.Width - 50;
            btnGiai.Top = myPanel.Height + 59;
            btnGiai.Height += 15;
            this.Width = myPanel.Width + 16;
            this.Height = myPanel.Top + myPanel.Height + space - 2 + 75;
        }
        private void Mau_TextChanged(object sender, EventArgs e)//Nếu text của txt thay đổi thì màu cũng thay đổi theo
        {
            int i = int.Parse(((TextBox)sender).Tag.ToString());
            text[i].SelectAll();
            text[i].ForeColor = Color.Red;
            text[i].BackColor = Color.DarkBlue;
        }

        private void Mau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
                ((TextBox)sender).BackColor = Color.White;
            }
            if (e.KeyChar > '9' || e.KeyChar < '1') e.KeyChar = '\0';
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                text[i + 1].Text = "";
                text[i + 1].ForeColor = Color.Black;
                text[i + 1].BackColor = Color.White;
            }
            text[1].Focus();
        }
        private void btnMo_Click(object sender, EventArgs e)//system Input Output
        {
            DiagOpen.InitialDirectory = Application.StartupPath;
            if (DiagOpen.ShowDialog() == DialogResult.Cancel) return;
            char x;
            try
            {
                FileStream file = new FileStream(DiagOpen.FileName, FileMode.Open);
                BinaryReader BR = new BinaryReader(file);
                for (int i = 0; i < 81; i++)
                {
                    do
                    {
                        x = BR.ReadChar();
                    } while (x < '0' || x > '9');
                    if (x > '0')
                    {
                        text[i + 1].Text = x.ToString();
                        text[i + 1].ForeColor = Color.Red;
                        text[i + 1].BackColor = Color.DarkBlue;
                    }
                    else
                    {
                        text[i + 1].Text = "";
                        text[i + 1].ForeColor = Color.Black;
                        text[i + 1].BackColor = Color.White;
                    }
                }
                BR.Close();
                file.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Lỗi khi đọc file !\n" + Ex.Message, "Đã có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            };
        }
        private void Nap()//Nạp đề vào chương trình từ text của txt
        {
            for (int i = 1; i <= 81; i++)
            {
                if ((text[i].Text == "") || (text[i].ForeColor == Color.Black)) de[i] = 0;
                else de[i] = int.Parse(text[i].Text);
            }
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            this.Nap();
            //Gọi contructor của sudoku
            SDK a = new SDK(de);
            if (a.SolveFirst())//Check xem có kết quả nào khả thi hay không
            {
                for (int i = 1; i <= 81; i++)//Loop
                {
                    text[i].Text = a.Result[i].ToString();//Đổi text của txt
                    if (de[i] == 0)//Do text của txt thay đổi nên màu cũng thay đổi. Hàm này dùng để check xem nếu không phải là đề thì chuyển lại màu bình thường, chỉ có đề mới highlight màu.
                    {
                        text[i].BackColor = Color.White;
                        text[i].ForeColor = Color.Black;
                    }
                }
            }
            else//Nếu SolveFirst == false
            {
                MessageBox.Show("Không có kết quả nào cả !", "Vô nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
