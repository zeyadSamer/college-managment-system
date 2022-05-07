using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            home ho = new home();
            ho.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            professors pr = new professors();
            pr.Show();
        }
     


        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            student st = new student();
            st.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            feess fe = new feess();
            fe.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            course coo = new course();
            coo.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            department de = new department();
            de.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            college col = new college();
            col.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}





