using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Orders
{
    class OrdersAction
    {
        public OrdersAction()
        {
        }

        public DataTable getAllOrders()
        {
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("showAllOrders", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Get the orders have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool insert(Orders orders)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addNewOrders";

                cmd.Parameters.AddWithValue("@iCustomerID", orders.ICustomerID);
                cmd.Parameters.AddWithValue("@iStaffID", orders.IStaffID);
                cmd.Parameters.AddWithValue("@dOrdersDate", orders.DOrdersDate);

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

        public bool delete(int _iOrdersID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteOrders";

                cmd.Parameters.AddWithValue("@iOrdersID", _iOrdersID);

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

        public bool update(Orders orders)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateOrders";

                cmd.Parameters.AddWithValue("@iOrdersID", orders.IOrdersID);
                cmd.Parameters.AddWithValue("@iCustomerID", orders.ICustomerID);
                cmd.Parameters.AddWithValue("@iStaffID", orders.IStaffID);
                cmd.Parameters.AddWithValue("@dOrdersDate", orders.DOrdersDate);

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
