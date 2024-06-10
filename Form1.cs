using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_hinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tinhdientich(double bk) { return bk * bk * Math.PI; }
        double tinhchuvi(double bk) { return bk * 2 * Math.PI; }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbdientich_CheckedChanged(object sender, EventArgs e)
        {
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double r, kq;
            r = Convert.ToDouble(txtbankinh.Text);
            kq = r * r * Math.PI;
            txtkq.Text = kq.ToString(txtkq.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double r, kq;
            r = Convert.ToDouble(txtbankinh.Text);
            kq = r * 2 * Math.PI;
            
            txtkq.Text = kq.ToString(txtkq.Text);
        }

        private void btnthoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbntinh_Click(object sender, EventArgs e)
        {
            if(bankinh)
            if (rdbchuvi.Checked)
                
            {
                Double r, kq;
                r = Convert.ToDouble(txtbankinh.Text);
                kq = r * 2 * Math.PI;

                txtkq.Text = kq.ToString(txtkq.Text);
            }
            if (rdbdientich.Checked)
                
            {
                Double r, kq;
                r = Convert.ToDouble(txtbankinh.Text);
                kq = r * 2 * Math.PI;

                txtkq.Text = kq.ToString(txtkq.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btntinh2_Click(object sender, EventArgs e)
        {
            
            double bankinh =Convert.ToDouble(txtbankinh.Text);
            string thongbao = "";
            if (ckbchuvi.Checked)
            {
                double chuvi = tinhchuvi(bankinh);
                thongbao = thongbao+ "chu vi"+Convert.ToString(chuvi)+Environment.NewLine;
            }
            if (ckbdientich.Checked)
            {
                double dientich = tinhdientich(bankinh);
                thongbao = thongbao + "diện  tích" + Convert.ToString(dientich) + Environment.NewLine;
            }
            if(thongbao.Length > 0)
            {
                MessageBox.Show(thongbao,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("vui lòng nhập chức năng","thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
