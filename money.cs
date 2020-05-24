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
    public partial class money : Form
    {
        public money()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string months = txtmonth.Text;
            string bonuss = txtbonus.Text;
            string others = txtother.Text;
            //เช็คกรอกข้อมูลครบทุกช่อง
            if (months.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                int month = int.Parse(txtmonth.Text);
                //ช่องโบนัส หรือเงินอื่น ไม่กรอกจะมีค่าเท่ากับ 0
                if (bonuss.Trim().Equals("") || others.Trim().Equals(""))
                {
                    txtbonus.Text = "0";
                    txtother.Text = "0";
                }
                int bonus = int.Parse(txtbonus.Text);
                int other = int.Parse(txtother.Text);
                int outcome;
                //คิดเงินเดือนเป็นปี
                {
                    outcome = (month * 12) + bonus + other;
                    int count = (outcome * 50) / 100;
                    int test = 100000;
                    if (count > test)
                    {
                        count = test;
                    }
                    int allsum = outcome - count;
                    txtsum.Text = allsum.ToString();
                }
            }
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //จำเป็นต้องกรอกรายได้
            if (txtsum.Text.Trim().Equals(""))
            {
                MessageBox.Show("กรุณากรอกรายได้", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //เปลี่ยนหน้า ส่งข้อมูล
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.txt1.Text = txtsum.Text;
                frm1.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
