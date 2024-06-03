using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Delivery_Management.codes
{
    public class dbcalling
    {
        public dbcalling() { }

        public DataTable GetData(string query, bool isSP = true)
        {
            try
            {
                SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = sql;
                if (isSP)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void LoginDetails(parameters cParams)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AddAdminLogin";
            cmd.Connection = sql;
            cmd.CommandType = CommandType.StoredProcedure;

            List<SqlParameter> istPar = new List<SqlParameter>();
            istPar.Add(new SqlParameter("@UserName", cParams.UserName));
            istPar.Add(new SqlParameter("@Password", cParams.Password));

            foreach (SqlParameter p in istPar)
            {
                cmd.Parameters.Add(p);
            }
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();

        }

        public void AddDelivery(parameters cParams)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "AddDetails";
            cmd.Connection = sql;
            cmd.CommandType = CommandType.StoredProcedure;

            List<SqlParameter> istPar = new List<SqlParameter>();
            istPar.Add(new SqlParameter("@FirstName", cParams.FirstName));
            istPar.Add(new SqlParameter("@LastName", cParams.LastName));
            istPar.Add(new SqlParameter("@MobileNumber", cParams.MobileNumber));
            istPar.Add(new SqlParameter("@Email", cParams.Email));
            istPar.Add(new SqlParameter("@Addres", cParams.Address));
            istPar.Add(new SqlParameter("@States", cParams.State));
            istPar.Add(new SqlParameter("@Country", cParams.Country));
            istPar.Add(new SqlParameter("@PinCode", cParams.Pincode));
            istPar.Add(new SqlParameter("@DeliveryDate", cParams.DeliveryDate));
            istPar.Add(new SqlParameter("@DeliveryType", cParams.DeliveryType));
            istPar.Add(new SqlParameter("@PaymentType", cParams.PaymentMethod));

            foreach (SqlParameter p in istPar)
            {
                cmd.Parameters.Add(p);
            }
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public DataSet GetCharts(string query, bool isSP = true)
        {
            try
            {
                SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = sql;
                if (isSP)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void UpdateDetails(parameters cParams)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdateDetails";
            cmd.Connection = sql;
            cmd.CommandType = CommandType.StoredProcedure;

            List<SqlParameter> istPar = new List<SqlParameter>();
            istPar.Add(new SqlParameter("@ID", cParams.ID));
            istPar.Add(new SqlParameter("@FirstName", cParams.FirstName));
            istPar.Add(new SqlParameter("@LastName", cParams.LastName));
            istPar.Add(new SqlParameter("@MobileNumber", cParams.MobileNumber));
            istPar.Add(new SqlParameter("@Email", cParams.Email));
            istPar.Add(new SqlParameter("@Addres", cParams.Address));
            istPar.Add(new SqlParameter("@States", cParams.State));
            istPar.Add(new SqlParameter("@Country", cParams.Country));
            istPar.Add(new SqlParameter("@PinCode", cParams.Pincode));

            foreach (SqlParameter p in istPar)
            {
                cmd.Parameters.Add(p);
            }
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }
        public void DeleteEmolyee(string query, int index)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete";
            cmd.CommandText = query;
            cmd.Connection = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ID", index));
            // SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        //public DataTable GetStates(string query, int index)
        //{

        //    SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["Alex"].ConnectionString);
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = "getStates";
        //    cmd.CommandText = query;
        //    cmd.Connection = sql;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("CountryID", index));
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    return dt;
           
        //}

    }
}