using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL
{
    class PhoneAction
    {
        SqlDataAdapter dataAdapter;
        public PhoneAction()
        {
        }

        public DataTable getAllPhone()
        {
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("showAllPhone", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Get the phone have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool insert(Phone phone)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addNewPhone";

                cmd.Parameters.AddWithValue("@sPhoneID", phone.SPhoneID);
                cmd.Parameters.AddWithValue("@sBrandID", phone.SBrandID);
                cmd.Parameters.AddWithValue("@sPhoneModel", phone.SPhoneModel);
                cmd.Parameters.AddWithValue("@iQuantity", phone.IQuantity);
                cmd.Parameters.AddWithValue("@iPrice", phone.IPrice);

                cmd.Connection = conn;
                cmd.ExecuteScalar();// exec proc
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool delete(String _sPhoneID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deletePhone";

                cmd.Parameters.AddWithValue("@sPhoneID", _sPhoneID);

                cmd.Connection = conn;
                cmd.ExecuteScalar();// exec proc
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool update(Phone phone)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updatePhone";

                cmd.Parameters.AddWithValue("@sPhoneID", phone.SPhoneID);
                cmd.Parameters.AddWithValue("@sBrandID", phone.SBrandID);
                cmd.Parameters.AddWithValue("@sPhoneModel", phone.SPhoneModel);
                cmd.Parameters.AddWithValue("@iQuantity", phone.IQuantity);
                cmd.Parameters.AddWithValue("@iPrice", phone.IPrice);

                cmd.Connection = conn;
                cmd.ExecuteScalar();// exec proc
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public DataTable search(String _sPhoneModel)
        {
            
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("searchPhone", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@sPhoneModel", _sPhoneModel);
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Search the phone have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
    }
}
