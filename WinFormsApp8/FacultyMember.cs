using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp8
{
    abstract class FacultyMember
    {


        public string name;
        public int id;
        public string DateOfBirth;
        public string gender;
        public string phone;
        public string dep;

        public int depId;
        public string email;
        public string address;

        public FacultyMember(string name, int id,string DateOfBirth,string gender,string phone,string dep,string email,string address,int depId) {



            this.name = name;
            this.id = id;
            this.DateOfBirth = DateOfBirth;
            this.gender = gender;
            this.phone = phone;
            this.dep = dep;
            this.email = email;
            this.address = address;

        }


       

        
        public abstract void show(int id);
        public  abstract void add(Student student);

       public  abstract void delete(int id);

        public abstract void update(Student student);


    }
}


