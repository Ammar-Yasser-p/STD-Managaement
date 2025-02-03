using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace DBUP
{
    public class DBMySQL
    {
        //string conn = "Server=srv1688.hstgr.io;Database=u641226040_system;Uid=u641226040_painSystem;Pwd=;Port=3306;";
        public static MySqlConnection conn = new MySqlConnection("Server=srv1688.hstgr.io;Database=u641226040_system;Uid=u641226040_painSystem;Pwd=;Port=3306;");
        //"DBMySQL\nError:- "
        public static void Open()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("DBMySQL\nError:- " + e.Message);
            }
        }

        public static void Close()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("DBMySQL\nError:- " + e.Message);
            }
        }

        public static void EditData(string sqlCommand)
        {
            Open();
            MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
            cmd.ExecuteNonQuery();
        }
    }

    public class DB
    {
        public static SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=std;Integrated Security=True");

        public static void Open()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("20.DB\nError:- " + e.Message);
            }
        }

        public static void Close()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("33.DB\nError:- " + e.Message);
            }
        }
        public static DataTable GetData(string sqlCommand)
        {
            Open();
            SqlCommand dt = new SqlCommand(sqlCommand, conn);
            SqlDataAdapter sd = new SqlDataAdapter(dt);
            DataTable tb = new DataTable();
            sd.Fill(tb);
            return tb;
        }

        public static SqlDataReader GetDataInRow(string sqlCommand)
        {
            Open();
            SqlCommand command = new SqlCommand(sqlCommand, conn);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static void EditData(string sqlCommand)
        {
            Open();
            SqlCommand dt = new SqlCommand(sqlCommand, conn);
            dt.ExecuteNonQuery();
        }
    }

    
}
