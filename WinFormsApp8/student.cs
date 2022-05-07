namespace WinFormsApp8
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
            professors pro = new professors();
            pro.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            salary sa = new salary();
            sa.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            feess fe = new feess();
            fe.Show();
        }
        
   
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            college col = new college();
            col.Show();
        }
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}



