using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp8
{
    class Student : FacultyMember
    {
        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zeyad\OneDrive\Documents\UniversityDb.mdf;Integrated Security=True;Connect Timeout=30";

        public int semester;

        public Fee fee;
        public  Departments department;
        //        get,set required

        


        public Student(string name , int id, string DOB, string gender , string email, string phone , string dep , int semester , string address ,int depId) : base(name, id, DOB, gender, phone, dep, email, address,depId)
        {
            this.semester = semester;
           

        }




        public override void show(int id)
        {

            


            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sqlQuery = "select * from students where Stid=@id";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader DataTableReader = cmd.ExecuteReader();

            if (DataTableReader.HasRows == true)
            {


                while (DataTableReader.Read())
                {

                    //getting data from database


                    this.id = id;

                    this.name = DataTableReader["name"].ToString();

                    this.email = DataTableReader["email"].ToString();

                    this.address = DataTableReader["address"].ToString();

                    this.phone = DataTableReader["phone"].ToString();

                    this.DateOfBirth = DataTableReader["DOB"].ToString();

                    this.fee.amount = DataTableReader["fee"].ToString();

                    this.gender = DataTableReader["gender"].ToString();

                    this.dep = DataTableReader["dep"].ToString();

                    //  data should  be then assigned to form elements



                }

            }
            else
            {


                // student not found  
                MessageBox.Show("student not found");

            }







            conn.Close();



        }

        int n;



          public override void add(Student student)
          {
          
              //inserting student data in db
              
           
              SqlConnection conn = new SqlConnection(connectionString);



            string sqlQuery = "SET IDENTITY_INSERT students ON insert into Students (Stid,StName,StDOB,Stgender,Staddress,StDepId,StDepName,Stphone,Stsemester,StEmail) values(@StId,@StName,@StDOB,@Stgender,@Staddress,@StDepId,@StDepName,@Stphone,@Stsemester,@StEmail)  SET IDENTITY_INSERT students OFF ";


              SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                  cmd.Parameters.AddWithValue("@StId", student.id);
                  cmd.Parameters.AddWithValue("@StName", student.name);
                  cmd.Parameters.AddWithValue("@StEmail", student.email);
                  cmd.Parameters.AddWithValue("@Staddress", student.address);
                  cmd.Parameters.AddWithValue("@StDOB", student.DateOfBirth);
                  cmd.Parameters.AddWithValue("@Stgender", student.gender);
                  cmd.Parameters.AddWithValue("@StDepName", student.dep);
                  cmd.Parameters.AddWithValue("@Stsemester", student.semester);
                  cmd.Parameters.AddWithValue("@Stphone",student.phone);

                  cmd.Parameters.AddWithValue("@StDepId", student.depId);

              conn.Open();
   
             MessageBox.Show(conn.State.ToString());

                  cmd.ExecuteNonQuery();


              conn.Close();

              MessageBox.Show("student {0} add successfully",student.name);
          }
        
      
        public override void delete(int id)
        {
           
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            //first we check if this student already exist

            string sqlQuery = "select * from students where Stid=@id";

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader DataTableReader = cmd.ExecuteReader();

            if (DataTableReader.HasRows == true)
            {


                sqlQuery = "delete * from students where Stid=@id";
                cmd = new SqlCommand(sqlQuery, conn);

                cmd.Parameters.AddWithValue("id", id);


                MessageBox.Show("student whose id:{0} is deleted", id.ToString());
            }
            else {


                MessageBox.Show("Student of id:{0} doesn't exist ",id.ToString());
            
            
            }
            conn.Close();
        }



        public override void update(Student student)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();


            string sqlQuery="select * from students where Stid=@id";



            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("id",student.id);

            sqlQuery = "UPDATE students SET Stname=@name,Stid=@id,Stgender=@gender,Stphone=@phone,Stsemester=@semester,Staddress=@address,StDOB=@DOB,StDepName=@dep,StEmail=@email,StDepId=@DepId  WHERE Stid=@id";



             cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("id", student.id);
            cmd.Parameters.AddWithValue("name", student.name);
            cmd.Parameters.AddWithValue("email", student.email);
            cmd.Parameters.AddWithValue("address", student.address);
            cmd.Parameters.AddWithValue("DOB", student.DateOfBirth);
            cmd.Parameters.AddWithValue("gender", student.gender);
            cmd.Parameters.AddWithValue("dep", student.dep);
            cmd.Parameters.AddWithValue("semester",student.semester);

            cmd.Parameters.AddWithValue("phone", student.phone);
            cmd.Parameters.AddWithValue("DepId",student.depId);


            cmd.ExecuteNonQuery();



            conn.Close();

            MessageBox.Show("student updated successfully");
        }





    }
}
