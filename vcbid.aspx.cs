using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerDAL;
using CustomerBO;

namespace CustomerUI
{
    public partial class vcbid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CustomerMethods cm = new CustomerMethods();
            int id = Convert.ToInt32(cid.Text);
           
            List < Customerbo > list= new List<Customerbo>();
            list = cm.ViewCustomerById(id);
            GridView1.DataSource = list;

            if ( list.Count() == 0)

            {       Response.Write("<script>alert('Customer Id doesnt exist')</script>");}

                GridView1.DataBind();
        }
    }
}
