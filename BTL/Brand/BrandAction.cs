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
    class BrandAction
    {
        SqlDataAdapter dataAdapter;
        public BrandAction()
        {
        }

        public DataTable getAllBrand()
        {
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("showAllBrand", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Get the brand have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool insert(Brand brand)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addNewBrand";

                cmd.Parameters.AddWithValue("@sBrandName", brand.SBrandName);
                cmd.Parameters.AddWithValue("@sBrandID", brand.SBrandID);

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

        public bool delete(String _sBrandID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteBrand";

                cmd.Parameters.AddWithValue("@sBrandID", _sBrandID);

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

        public bool update(Brand brand)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateBrand";

                cmd.Parameters.AddWithValue("@sBrandName", brand.SBrandName);
                cmd.Parameters.AddWithValue("@sBrandID", brand.SBrandID);

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
    }
}
