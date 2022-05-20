using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp8
{
     class Fee:Money
    {

        int n;

        public override void Reset()
        {
            n = 1;



        }


        public override void Pay() {


            n = 1;
        }
      
    }
}
