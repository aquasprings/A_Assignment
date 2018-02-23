using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBO
{
    public class Accountbo
    {
        int accountid;
        int amount;
        string acctype;        
        int cid;

        public int Accountid
        {
            get
            {
                return accountid;
            }

            set
            {
                accountid = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

       

        public string Acctype
        {
            get
            {
                return acctype;
            }

            set
            {
                acctype = value;
            }
        }

       
        public int Cid
        {
            get
            {
                return cid;
            }

            set
            {
                cid = value;
            }
        }

        public Accountbo(int amount, string acctype,  int cid)
        {
            this.Amount = amount;           
            this.Acctype = acctype;            
            this.Cid = cid;
        }

       
    }
}
