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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                
                numericUpDownHome.Enabled = false;
            }
            else
            {
                numericUpDownHome.Enabled = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox99.Text);
            int a = int.Parse(numericUpDownHome.Text);
            int b = int.Parse(numericUpDownFirstHome.Text);           
            int c = int.Parse(numericUpDownPayFirstHome.Text);                   
            int tester1 = 200000; 
            int all = 0;
            //ลดหย่อนได้ปีละ 4% 
            b = (b * 4) / 100;
            //ลดหย่อนได้ไม่เกิน 200000 บ้านหลังแรก
            if (c>tester1)
            {
                c = tester1;
            }
            all = money - (a + b + c);
            textBoxSum.Text = all.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //บ้านหลังแรก
            if (radioButton5.Checked == true)
            {

                numericUpDownFirstHome.Enabled = false;
            }
            else
            {
                numericUpDownFirstHome.Enabled = true;

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //ซื้อบ้านหลังแรก
            if (radioButton4.Checked == true)
            {

                numericUpDownPayFirstHome.Enabled = false;
            }
            else
            {
                numericUpDownPayFirstHome.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //เช็คช่องว่าง สั่งข้อมูล เปลี่ยนหน้าใหม่
            if (textBoxSum.Text.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากดลดหย่อนรวม", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.Hide();
                Form4 frm4 = new Form4();
                frm4.textBox99.Text = textBoxSum.Text;
                frm4.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
