using System;
using System.Windows.Forms;

namespace VATt
{
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void picSum_Click(object sender, EventArgs e)
        {
            //เช็คว่าต้องคิดกี่เปอร์ของรายได้ทั้งหมด
            int xi = int.Parse(textBoxSum2.Text);
            double final;
            if (int.Parse(textBoxSum2.Text) < 150000)
                {
                final = xi * 0;
                txtFinalSum.Text = final.ToString();
                }
            else if (int.Parse(textBoxSum2.Text) < 300000)
            {
                final = xi * 0.05;
                txtFinalSum.Text = final.ToString();
             }
             else if (int.Parse(textBoxSum2.Text) < 500000)
            {
                final = xi * 0.1;
                txtFinalSum.Text = final.ToString();
             }
             else if (int.Parse(textBoxSum2.Text) < 750000)
            {
                final = xi * 0.15;
                txtFinalSum.Text = final.ToString();
            }
            else if (int.Parse(textBoxSum2.Text) < 1000000)
            {   
                final = xi * 0.2;
                txtFinalSum.Text = final.ToString();
            }
            else if (int.Parse(textBoxSum2.Text) < 2000000)
            {
                final = xi * 0.25;
                txtFinalSum.Text = final.ToString();
             }
            else if (int.Parse(textBoxSum2.Text) < 5000000)
            {
                final = xi * 0.3;
                txtFinalSum.Text = final.ToString();
             }
            else if (int.Parse(textBoxSum2.Text) > 5000001)
             {
                final = xi * 0.35;
                txtFinalSum.Text = final.ToString();
            }
        }
    }
}
