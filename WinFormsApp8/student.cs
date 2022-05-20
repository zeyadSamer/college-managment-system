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



    
      
        private void save_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_textBox.Text);
            string name = name_textBox.Text;
            string dob = dateTimePicker_box.Value.Date.ToString();
            string address = address_textBox.Text;
            int semester = Convert.ToInt32(semester_Box.Value);
            string email = email_textBox.Text;
            string gender = gender_comboBox.Text;
            string department = department_textBox.Text;
            int depId = Convert.ToInt32(depId_textbox.Text);
            string phone = PhoneNumber_textBox.Text;

            Student std = new Student(name, id, dob, gender, email, phone, department, semester, address, depId);

            std.add(std);
            
        }

        private void id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("adsa");
            int id = Convert.ToInt32(id_textBox.Text);
            string name = name_textBox.Text;
            string dob = dateTimePicker_box.Value.Date.ToString();
            string address = address_textBox.Text;
            int semester = Convert.ToInt32(semester_Box.Value);
            string email = email_textBox.Text;
            string gender = gender_comboBox.Text;
            string department = department_textBox.Text;
            int depId = Convert.ToInt32(depId_textbox.Text);
            string phone = PhoneNumber_textBox.Text;

            Student std = new Student(name, id, dob, gender, email, phone, department, semester, address, depId);
            std.show(id);


            name_textBox.Text = std.name;
            dateTimePicker_box.Value = Convert.ToDateTime(std.DateOfBirth.ToString());
            PhoneNumber_textBox.Text = std.phone;
            address_textBox.Text = std.address;
            gender_comboBox.SelectedValue = std.gender;
            department_textBox.Text = std.department.Name;
            semester_Box.Text = std.semester.ToString();
            email_textBox.Text = std.email;

        
        
        
        }
    }
}



