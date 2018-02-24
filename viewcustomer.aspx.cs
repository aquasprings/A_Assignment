using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccountBO;
using CustomerBO;
using CustomerDAL;

namespace CustomerUI
{
    public partial class viewcustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CustomerMethods cm = new CustomerMethods();
                GridView1.DataSource = cm.ViewCustomer();
                GridView1.DataBind();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("del"))
            {
                int cid = Convert.ToInt32(e.CommandArgument);
                CustomerMethods Op = new CustomerMethods();
                int res = Op.Delete(cid);
                if (res > 0)
                {
                    GridView1.DataSource = Op.ViewCustomer();
                    GridView1.DataBind();
                    Response.Write("Deactivated");
                }


            }
        }
    }
}
