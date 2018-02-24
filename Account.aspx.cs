using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountBO;
using CustomerDAL;
using CustomerBO;

namespace CustomerUI
{
    public partial class account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cusid = Convert.ToInt32(TextBox1.Text);
            int amount = Convert.ToInt32(TextBox2.Text);
            string atype = DropDownList1.SelectedItem.Value;
            DateTime dt = DateTime.Now;
            asd.Text = ""+dt;

            Accountbo A = new Accountbo(amount,atype,cusid);

            CustomerMethods CM = new CustomerMethods();
            try { int aid = CM.AddAccount(A);
                aid1.Text = "" + aid;
            }
            catch (Exception Ex)
            {
                //if (Ex.Message.Contains("ForeignKeyException"))
                //{
                    Response.Write("<script>alert('The Customer Id doesn't Exists')</script>");
               //}
                
            }
            astatus.Text = "Active";
            

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //int check = Convert.ToInt32(TextBox1.Text);
        }
    }
}
