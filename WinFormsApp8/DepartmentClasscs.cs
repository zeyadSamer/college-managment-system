using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp8
{
     class Departments
    {

        private string name;
        private string inTake;
        private string feesName;
        private string HODName;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Intake
        {
            get { return inTake; }

            set { inTake = value; }
        }
        public string FeesName
        {
            get { return feesName; }

            set { feesName = value; }
        }
        public string hodname
        {
            get { return HODName; }

            set { HODName = value; }
        }
  
       

        public Departments( string name, string intake, string feesName, string hodname)
        {
            this.name = name;
            this.Intake = intake;
            this.feesName = feesName;
            this.HODName = hodname;
        }   
    }
}
