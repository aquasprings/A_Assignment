using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderDAL;
using OrderBO;

namespace OrderManagementSystem
{
    public partial class vieworders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="cancel")
            {
                OrderDBO db_handler = new OrderDBO();
                Order ord = new Order();
                ord.OrderID= Convert.ToInt16(e.CommandArgument);
                db_handler.cancelOrder(ord);
            }
        }
    }
}
