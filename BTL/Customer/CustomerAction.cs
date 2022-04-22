using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Customer
{
    class CustomerAction
    {
        public CustomerAction()
        {
        }

        public DataTable getAllCustomer()
        {
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("showAllCustomer", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Get the customer have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool insert(Customer customer)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addNewCustomer";

                cmd.Parameters.AddWithValue("@sFullName", customer.SFullName);
                cmd.Parameters.AddWithValue("@sAddress", customer.SAddress);
                cmd.Parameters.AddWithValue("@dDateOfBirth", customer.DDateOfBirth);
                cmd.Parameters.AddWithValue("@sGender", customer.SGender);
                cmd.Parameters.AddWithValue("@sPhoneNumber", customer.SPhoneNumber);

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

        public bool delete(string _iCustomerID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteCustomer";

                cmd.Parameters.AddWithValue("@iCustomerID", _iCustomerID);

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

        public bool update(Customer customer)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateCustomer";

                cmd.Parameters.AddWithValue("@iCustomerID", customer.ICustomerID);
                cmd.Parameters.AddWithValue("@sFullName", customer.SFullName);
                cmd.Parameters.AddWithValue("@sAddress", customer.SAddress);
                cmd.Parameters.AddWithValue("@dDateOfBirth", customer.DDateOfBirth);
                cmd.Parameters.AddWithValue("@sGender", customer.SGender);
                cmd.Parameters.AddWithValue("@sPhoneNumber", customer.SPhoneNumber);

                cmd.Connection = conn;
                cmd.ExecuteScalar();// exec proc
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
