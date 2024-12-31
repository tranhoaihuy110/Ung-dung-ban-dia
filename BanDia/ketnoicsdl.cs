using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BanDia
{
    public class ketnoicsdl
    {
        SqlConnection conn;

        public ketnoicsdl()
        {
          

            string str = "Data Source=DESKTOP-9BAJ70V\\SQLEXPRESS;Initial Catalog=QLCD;Integrated Security=True";
            conn = new SqlConnection(str);
        }

        public string GetConnectionString()
        {
            return conn.ConnectionString;
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            openConection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            closeConection();
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            openConection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            closeConection();
        }

        public void openConection()
        {
            if (ConnectionState.Closed == conn.State)
            {
                try
                {
                    conn.Open();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }

        public void closeConection()
        {
            if (ConnectionState.Open == conn.State)
            {
                try
                {
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }
        public int ExecuteStoredProcedureWithOutput(string storedProcedure, Dictionary<string, object> parameters, string outputParameterName)
        {
            int outputValue = 0;

            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcedure;

                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                SqlParameter outputParam = new SqlParameter(outputParameterName, SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    outputValue = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

            return outputValue;
        }
        public DataTable getLogin(string query, string user, string pass)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@TaiKhoan", user);
                    cmd.Parameters.AddWithValue("@MatKhau", pass);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
        public void ExecuteStoredProcedure(string storedProcedure, Dictionary<string, object> parameters)
        {
           
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storedProcedure;

                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        
                        throw;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}