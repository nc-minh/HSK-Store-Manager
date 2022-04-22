using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL.Staff
{
    class StaffAction
    {
        public StaffAction()
        {
        }

        public DataTable getAllStaff()
        {
            SqlConnection conn = new SqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;

                var adapter = new SqlDataAdapter("showAllStaff", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Get the staff have some error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public bool insert(Staff staff)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "addNewStaff";

                cmd.Parameters.AddWithValue("@sFullName", staff.SFullName);
                cmd.Parameters.AddWithValue("@sAddress", staff.SAddress);
                cmd.Parameters.AddWithValue("@dDateOfBirth", staff.DDateOfBirth);
                cmd.Parameters.AddWithValue("@sPhoneNumber", staff.SPhoneNumber);
                cmd.Parameters.AddWithValue("@fBasicSalary", staff.FBasicSalary);
                cmd.Parameters.AddWithValue("@fGrant", staff.FGrant);

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

        public bool delete(String _iStaffID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteStaff";

                cmd.Parameters.AddWithValue("@iStaffID", _iStaffID);

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

        public bool update(Staff staff)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["store_manager"].ConnectionString;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "updateStaff";

                cmd.Parameters.AddWithValue("@istaffid", staff.IStaffID);
                cmd.Parameters.AddWithValue("@sfullname", staff.SFullName);
                cmd.Parameters.AddWithValue("@saddress", staff.SAddress);
                cmd.Parameters.AddWithValue("@ddateofbirth", staff.DDateOfBirth);
                cmd.Parameters.AddWithValue("@sphonenumber", staff.SPhoneNumber);
                cmd.Parameters.AddWithValue("@fbasicsalary", staff.FBasicSalary);
                cmd.Parameters.AddWithValue("@fgrant", staff.FGrant);
                
                cmd.Connection = conn;
                cmd.ExecuteScalar();// exec proc
            }
            catch(Exception ex)
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
