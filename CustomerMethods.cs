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

        public List<Customerbo> ViewCustomer()
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id =PJ09TMS101_1718; database=DB09TMS101_1718;password= tcstvm");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_viewcustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            List<Customerbo> listbo = new List<Customerbo>();
            while (reader.Read())
            {
                Customerbo C = new Customerbo();
                C.Id = Convert.ToInt32(reader["customerid"]);
                C.Name = reader["cname"].ToString();
                C.Dob = Convert.ToDateTime(reader["dob"]);
                C.Gender = reader["gender"].ToString();
                C.Contact = Convert.ToInt64(reader["contact"]);
                C.City = reader["city"].ToString();

                listbo.Add(C);

            }
            return listbo;
        }
        public List<Customerbo> ViewCustomerById(int id)
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id =PJ09TMS101_1718; database=DB09TMS101_1718;password= tcstvm");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_viewcustomerbyid", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            
            SqlDataReader reader = cmd.ExecuteReader();

            List<Customerbo> listbo1 = new List<Customerbo>();
            while (reader.Read())
            {
                
                Customerbo C = new Customerbo();
                C.Id = Convert.ToInt32(reader["customerid"]);
                C.Name = reader["cname"].ToString();
                C.Dob = Convert.ToDateTime(reader["dob"]);
                C.Gender = reader["gender"].ToString();
                C.Contact = Convert.ToInt64(reader["contact"]);
                C.City = reader["city"].ToString();
                
                listbo1.Add(C);

            }
            return listbo1;
        }        
        public List<Accountbo> ViewAccount()
        {
            SqlConnection con = new SqlConnection("server= intvmsql01; user id =PJ09TMS101_1718; database=DB09TMS101_1718;password= tcstvm");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_viewaccount", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            List<Accountbo> listacc = new List<Accountbo>();
            while (reader.Read())
            {
                Accountbo A1 = new Accountbo();
                A1.Accountid = Convert.ToInt32(reader["accid"]);
                A1.Amount = Convert.ToInt32(reader["amount"]);
                A1.Acctype = reader["acctype"].ToString();
                A1.Cid = Convert.ToInt32(reader["cusid"]);             

                listacc.Add(A1);

            }
            return listacc;
        }

        public int  Delete(int id)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_deletecustomer_3", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);

            int rowaffected = cmd.ExecuteNonQuery();
            return rowaffected;

        }
    }
}
           
        





  
