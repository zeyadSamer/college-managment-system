using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp8
{
     abstract class Money
    {

        public string amount;
        public string period;

        public abstract void Pay();

        public abstract void Reset();


    }
}
