using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VATt;


namespace VATt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox99_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(textBox99.Text);
            int c = int.Parse(numericUpDownSon1.Text);
            int d = int.Parse(numericUpDownSon2.Text);
            int g = int.Parse(numericUpDownPaMa.Text);
            int h = int.Parse(numericUpDownPikan.Text);
            int all = 0;
            int a = 0;
            c = c * 30000;
            d = d * 30000;
            g = g * 30000;
            h = h * 60000;
            //ตรวจสอบบุตร 2561
            if (radioButton1.Checked == true)
            {
                a = 60000;
            }
            else
            {
                a = 0;
            }
            
            int b = 0;
            if (radioButton2.Checked == true)
            {
                b = 60000;
            }
            else
            {
                b = 0;
            }
            all = money -( a + b + c + d  + g + h);
            txtboxsum.Text = all.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //ตรวจสอบไม่มีบุตร
            if (radioButton5.Checked == true)
            {
                numericUpDownSon1.Enabled = false;
                groupBox4.Enabled = false;
            }
            else
            {
                numericUpDownSon1.Enabled = true;
                groupBox4.Enabled = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            //สถานะโสด
            if (radioButton13.Checked == true)
            {
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = true;
                
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            //บุตรคนที่สองเกิด 2561
            if (radioButton7.Checked == true)
            {
                numericUpDownSon2.Enabled = false;
            }
            else
            {
                numericUpDownSon2.Enabled = true;

            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            //คลอดบุตร ฝากครรภ์
            if (radioButton11.Checked == true)
            {
                numericUpDownFakkan.Enabled = false;
            }
            else
            {
                numericUpDownFakkan.Enabled = true;

            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            //บิดามารดา
            if (radioButton15.Checked == true)
            {
                numericUpDownPaMa.Enabled = false;
            }
            else
            {
                numericUpDownPaMa.Enabled = true;

            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            //อุปการะคนพิการ
            if (radioButton17.Checked == true)
            {
                numericUpDownPikan.Enabled = false;
            }
            else
            {
                numericUpDownPikan.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //เปลี่ยนหน้า ส่งข้อมูลไปหน้าถัดไป
            if (txtboxsum.Text.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากดลดหย่อนรวม", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.textBox99.Text = txtboxsum.Text;
                frm3.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
