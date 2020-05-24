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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //ประกันสังคม
            if (checkBox2.Checked == true)
            {
                numericUpDownSocial.Enabled = false;
            }
            else
            {
                numericUpDownSocial.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //เบี้ยประกันชีวิต
            if (checkBox4.Checked == true)
            {
                numericUpDownChevit.Enabled = false;
            }
            else
            {
                numericUpDownChevit.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
                //เบี้ยประกันสุขภาพ
            if (checkBox6.Checked == true)
            {
                numericUpDownHealth.Enabled = false;
            }
            else
            {
                numericUpDownHealth.Enabled = true;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            //เช็คประกันสังคม
            if (checkBox2.Checked == true)
            {
                numericUpDownPaMa.Enabled = false;
            }
            else
            {
                numericUpDownPaMa.Enabled = true;
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            //ไม่มีจะกรอกไม่ได้ สำรองเลี้ยงชีพ
            if (checkBox12.Checked == true)
            {
                numericUpDownSamrong.Enabled = false;
            }
            else
            {
                numericUpDownSamrong.Enabled = true;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            //ถ้ากดไม่มีจะกรอกไม่ได้ สะสมกองทุน
            if (checkBox14.Checked == true)
            {
                numericUpDownKongtun.Enabled = false;
            }
            else
            {
                numericUpDownKongtun.Enabled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            //ประกันชีวิตบิดามารดาไม่มี จะไม่สามรถกรอกได้
            if (checkBox8.Checked == true)
            {
                numericUpDownPaMa.Enabled = false;
            }
            else
            {
                numericUpDownPaMa.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //ถ้ากดโสดจะไม่สามารถกดประกันค่สมรสได้
            if (radioButton3.Checked == true)
            {
                groupBox5.Enabled = false;
            }
            else
            {
                groupBox5.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //เช็คไม่ให้ว่าง ส่งข้อมูลไป Form ถัดไป
            if (txtsum.Text.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากดลดหย่อนรวม", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.textBox99.Text = txtsum.Text;
                frm2.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numericUpDownSocial.Text);
            int b = int.Parse(numericUpDownChevit.Text);
            int c = int.Parse(numericUpDownHealth.Text);
            int d = int.Parse(numericUpDownPaMa.Text);
            int ex = 0;
            int xi = 0;
            int f = int.Parse(numericUpDownSamrong.Text);
            int g = int.Parse(numericUpDownKongtun.Text);
            int total = int.Parse(txt1.Text);
            double outcame;
            //เช็คประกันชีวิตคู่สมรส
            if (radioButton1.Checked)
            {
                ex = 10000;
            }
            else if (radioButton2.Checked)
            {
                ex = 0;
            }
            if ((b + c) > 100000)
            {
                xi = 100000;
            }
            else if ((b + c) < 100000)
            {
                xi = c + b;
            }
            {
                outcame = total - (a + xi + d + ex + f + g);
                txtsum.Text = outcame.ToString();
            }
        }
    }
}
