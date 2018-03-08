using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderManagementSystem
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            HttpCookie namecookie = Request.Cookies["myCookie"];
            Label1.Text = "Welcome, " + namecookie["username"];
            namecookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(namecookie);
        }
    }
}
