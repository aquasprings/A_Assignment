using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OrderBO;
using OrderDAL;

namespace OrderManagementSystem
{
    public partial class neworder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int neworderid = 0;
            OrderDBO db_handler = new OrderDBO();
            Item obj = db_handler.itemDetails(TextBox1.Text);
            Response.Write("<script>alert('Item Price is" + obj.ItemPrice  +  "')</script>");
            //System.Diagnostics.Debug.Write(obj.ItemPrice);
            if(obj.Quantity < Convert.ToInt16(TextBox2.Text))
            {
                Response.Write("<script>alert('This quantity is not available for this item. Max available is "+obj.Quantity+"')</script>");
            }
            else
            {
                Label7.Text = (Convert.ToDouble(obj.ItemPrice) * Convert.ToInt16(TextBox2.Text)).ToString();
                Order ord = new Order(TextBox1.Text, Convert.ToInt16(TextBox2.Text), obj.ItemPrice*Convert.ToInt16(TextBox2.Text), TextBox3.Text,TextBox4.Text,TextBox5.Text);
                neworderid = db_handler.addOrder(ord);
                Response.Write("<script>alert('Order placed successfully. Order ID is " + neworderid + "')</script>");
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            /*if(TextBox1.Text != "")
            {
                OrderDBO db_handler = new OrderDBO();
                Item obj = db_handler.itemDetails(TextBox1.Text);
                Label7.Text = (Convert.ToInt16(obj.ItemPrice) * Convert.ToDouble(TextBox2.Text)).ToString();
            }*/
        }
    }
}
