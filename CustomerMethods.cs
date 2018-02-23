using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerBO;
using System.Data.SqlClient;
using System.Data;
using CustomerDAL;
using AccountBO;

namespace CustomerDAL
{
    public class CustomerMethods
    {
        public int AddCustomer(Customerbo C)
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id =PJ09TMS101_1718; database=DB09TMS101_1718;password= tcstvm");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_addcustomer_3", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cn", C.Name);
            cmd.Parameters.AddWithValue("@g", C.Gender);
            cmd.Parameters.AddWithValue("@d", C.Dob);
            cmd.Parameters.AddWithValue("@cno", C.Contact);
            cmd.Parameters.AddWithValue("@c", C.City);
            cmd.Parameters.AddWithValue("@cid", 0);

            cmd.Parameters["@cid"].Direction = ParameterDirection.Output;
            int ra = cmd.ExecuteNonQuery();
            if (ra > 0)
            {
                int cid = Convert.ToInt32(cmd.Parameters["@cid"].Value);
                return cid;
            }
            else
            {
                return 0;

            }


        }



        public int AddAccount(Accountbo A)
        {
            try
            {

                SqlConnection con = new SqlConnection("server= intvmsql01; user id =PJ09TMS101_1718; database=DB09TMS101_1718;password= tcstvm");
                con.Open();

                SqlCommand cmd = new SqlCommand("sp_addaccount_5", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@customerid", A.Cid);

                cmd.Parameters.AddWithValue("@amount", A.Amount);
                cmd.Parameters.AddWithValue("@acctype", A.Acctype);

                cmd.Parameters.AddWithValue("@accid", 0);

                cmd.Parameters["@accid"].Direction = ParameterDirection.Output;

                int ra = cmd.ExecuteNonQuery();

                if (ra > 0)
                {
                    int ai = Convert.ToInt32(cmd.Parameters["@accid"].Value);
                    return ai;
                }
                else
                {
                    return 0;

                }


            }
            catch (Exception E)
            {
                throw E;
            }

        }
    }
}
           
        





  
