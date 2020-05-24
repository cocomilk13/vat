using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VATt
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDownHospital.Enabled = false;
                
            }
            else
            {
                numericUpDownHospital.Enabled = true;
                
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDownSport.Enabled = false;

            }
            else
            {
                numericUpDownSport.Enabled = true;

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                numericUpDownEDU.Enabled = false;

            }
            else
            {
                numericUpDownEDU.Enabled = true;

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                numericUpDownSatarana.Enabled = false;

            }
            else
            {
                numericUpDownSatarana.Enabled = true;

            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                numericUpDownPayu.Enabled = false;

            }
            else
            {
                numericUpDownPayu.Enabled = true;

            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                numericUpDownTuipai.Enabled = false;

            }
            else
            {
                numericUpDownTuipai.Enabled = true;

            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                numericUpDownLungTu.Enabled = false;

            }
            else
            {
                numericUpDownLungTu.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox99.Text);
            int a = int.Parse(numericUpDownHospital.Text);
            int b = int.Parse(numericUpDownSport.Text);
            int c = int.Parse(numericUpDownEDU.Text);
            int d = int.Parse(numericUpDownSatarana.Text);
            int tester = (money * 10) / 100;
            //หักได้ 2 เท่าตามที่จ่ายจริง
            a = a * 2;
            b = b * 2;
            c = c * 2;
            d = d * 2;
            int sum = a + b + c + d;
            //เงินบริจาคทั่วไปไม่เกิน 10%
            if (sum>tester)
            {
                sum = tester;
            } 
            int tester2 = (money - sum)*10/100;
            int f = int.Parse(numericUpDownPayu.Text);
            int g = int.Parse(numericUpDownTuipai.Text);
            //รวมกันไม่เกิน 10% ของรายได้
            if(g>tester2)
            {
                g = tester2;
            }
            int h = int.Parse(numericUpDownLungTu.Text);
            int all = 0;
            all = money - (sum+ f + g + h);
            textBoxSum.Text = all.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //เช็คช่องว่าง ส่งข้อมูล
            if (textBoxSum.Text.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากดลดหย่อนรวม", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.Hide();
                Form5 frm5 = new Form5();
                frm5.textBox99.Text = textBoxSum.Text;
                frm5.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
