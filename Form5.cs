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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                numericUpDownMungLak.Enabled = false;
                numericUpDownMungRong.Enabled = false;

            }
            else
            {
                numericUpDownMungLak.Enabled = true;
                numericUpDownMungRong.Enabled = true;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                numericUpDownEDU.Enabled = false;
                

            }
            else
            {
                numericUpDownEDU.Enabled = true;
                

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                numericUpDownChuiChart.Enabled = false;


            }
            else
            {
                numericUpDownChuiChart.Enabled = true;


            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                numericUpDownPaYu.Enabled = false;
                numericUpDownCar.Enabled = false;


            }
            else
            {
                numericUpDownPaYu.Enabled = true;
                numericUpDownCar.Enabled = true;


            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                numericUpDownHome.Enabled = false;
                numericUpDownCar2.Enabled = false;


            }
            else
            {
                numericUpDownHome.Enabled = true;
                numericUpDownCar2.Enabled = true;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox99.Text);
            int a = int.Parse(numericUpDownEDU.Text);
            int b = int.Parse(numericUpDownChuiChart.Text);
            int c = int.Parse(numericUpDownOtop.Text);
            int d1 = int.Parse(numericUpDownMungLak.Text);
            int d2 = int.Parse(numericUpDownMungRong.Text);
            int f = int.Parse(numericUpDownPaYu.Text);
            int g = int.Parse(numericUpDownCar.Text);
            int h = int.Parse(numericUpDownHome.Text);
            int i = int.Parse(numericUpDownCar2.Text);
            int d = 0;            
            int tester = 20000;
            int all = 0;
            //ท่องเที่ยวเมืองหลัก เมืองรอง 2 อันรวมกันไม่เกิน 20000
            d = d1 + d2;
            if ((d)>tester)
            {
                d = tester;
            }
            all = money - (a + b + c + d + f + g + h + i);
            textBoxSum.Text = all.ToString();
        }

        private void picnext_Click(object sender, EventArgs e)
        {
            //เช็คช่องว่าง ส่งข้อมูล เปลี่ยนหน้า
            if (textBoxSum.Text.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากดลดหย่อนรวม", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.Hide();
                Final frm2 = new Final();
                frm2.textBoxSum2.Text = textBoxSum.Text;
                frm2.Show();
            }
        }
    }
}
