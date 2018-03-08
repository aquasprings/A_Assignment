using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace OrderManagementSystem
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            string pass = TextBox2.Text;
            if(FormsAuthentication.Authenticate(user,pass))
            {
                HttpCookie cookie = Request.Cookies["myCookie"] as HttpCookie;
                if (cookie == null)
                {
                    cookie = new HttpCookie("MyCookie");
                }
                cookie.Values.Add("username", TextBox1.Text);
                Response.Cookies.Add(cookie);
                FormsAuthentication.RedirectFromLoginPage(user, true);
            }
        }
    }
}
