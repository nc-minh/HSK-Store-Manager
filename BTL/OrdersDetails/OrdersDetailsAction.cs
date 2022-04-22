using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.OrdersDetails
{
    class OrdersDetailsAction
    {
        public OrdersDetailsAction()
        {
        }

        public DataTable getAllOrdersDetails()
        {
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("showAllOrdersDetails", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Get the orders details have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool insert(OrdersDetails ordersDetails)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addNewOrdersDetails";

                cmd.Parameters.AddWithValue("@iOrdersID", ordersDetails.IOrdersID);
                cmd.Parameters.AddWithValue("@sPhoneID", ordersDetails.SPhoneID);
                cmd.Parameters.AddWithValue("@iQuantity", ordersDetails.IQuantity);

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

        public bool delete(int _iOrdersDetailsID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteOrdersDetails";

                cmd.Parameters.AddWithValue("@iOrdersDetailsID", _iOrdersDetailsID);

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

        public bool update(OrdersDetails ordersDetails)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateOrdersDetails";

                cmd.Parameters.AddWithValue("@iOrdersDetailsID", ordersDetails.IOrdersDetailID);

                cmd.Parameters.AddWithValue("@iOrdersID", ordersDetails.IOrdersID);
                cmd.Parameters.AddWithValue("@sPhoneID", ordersDetails.SPhoneID);
                cmd.Parameters.AddWithValue("@iQuantity", ordersDetails.IQuantity);

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
