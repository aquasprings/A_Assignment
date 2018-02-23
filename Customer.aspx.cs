using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerBO;
using CustomerDAL;

namespace CustomerUI
{
    public partial class Customer : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cn = cname.Text;
            string g = ddlgender.SelectedItem.Value;
            DateTime d = Convert.ToDateTime(dob.Text);
            long contact = Convert.ToInt64(cno.Text);
            string c = city.Text;

            Customerbo C = new Customerbo(cn,g,d,contact,c);
            CustomerMethods CM = new CustomerMethods();

            int cid = CM.AddCustomer(C);                    
            
            if (cid > 0)
            {
                Label1.Text = "" + cid;
            }

            else
            {
                Response.Write("<script>alert('Error')</script>");
            }            

        }
    }
}
