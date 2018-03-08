using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using OrderBO;

namespace OrderDAL
{
    public class OrderDBO
    {
        public SqlConnection con;
        public OrderDBO()
        {
            con = new SqlConnection("server=intvmsql01;user id=pj01tms55_1718; password=tcstvm; database=db01tms55_1718");
            con.Open();
        }
        public int addOrder(Order ord)
        {
            SqlCommand cmd = new SqlCommand("addOrder1349995",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itemName", ord.ItemName);
            cmd.Parameters.AddWithValue("@quantity",ord.Quantity);
            cmd.Parameters.AddWithValue("@totalPrice", ord.TotalPrice);
            cmd.Parameters.AddWithValue("@name", ord.CustomerName);
            cmd.Parameters.AddWithValue("@contact", ord.CustomerContact);
            cmd.Parameters.AddWithValue("@email", ord.CustomerEmail);
            cmd.Parameters.AddWithValue("@orderID", 0);
            cmd.Parameters["@orderID"].Direction = ParameterDirection.Output;
            ord.OrderID = 0;

            SqlDataReader reader = cmd.ExecuteReader();
            int neworderid = 0;
            neworderid = Convert.ToInt16(cmd.Parameters["@orderID"].Value);
            reader.Close();
            return neworderid;
        }
        public bool cancelOrder(Order ord)
        {
            SqlCommand cmd = new SqlCommand("cancelOrder1349995", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderID", ord.OrderID);

            int x = cmd.ExecuteNonQuery();
            if (x > 0)
                return true;
            else
                return false;
        }
        public Item itemDetails(string itemname)
        {
            Item retItem = new Item();
            SqlCommand cmd = new SqlCommand("SELECT quantityAvailable from tblItem_1349995 where itemName = '"+itemname+"'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                retItem.Quantity=Convert.ToInt16(rdr["quantityAvailable"]);
            }
            rdr.Close();
            cmd = new SqlCommand("SELECT price from tblItem_1349995 where itemName = '" + itemname + "'", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                retItem.ItemPrice = Convert.ToDouble(rdr["price"]);
            }
            rdr.Close();
            /*cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@itemName", itemname);
            cmd.Parameters.AddWithValue("@quantity", 0);
            cmd.Parameters.AddWithValue("@itemPrice", 0);
            cmd.Parameters["@quantity"].Direction = ParameterDirection.Output;
            cmd.Parameters["@itemPrice"].Direction = ParameterDirection.Output;
            retItem.ItemName = itemname;
            retItem.Quantity =  Convert.ToInt16(cmd.Parameters["@quantity"].Value);
            retItem.ItemPrice = Convert.ToDouble(cmd.Parameters["@itemPrice"].Value);*/
            return retItem;
        }
    }
}
