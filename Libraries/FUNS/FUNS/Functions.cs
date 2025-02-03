using System;
using System.Text.RegularExpressions;
using DBUP;
using MySql.Data;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;
using MySql.Data.MySqlClient;

namespace Funs
{
    public static class Functions
    {
        public static string connectMysql()
        {
            //string connectionString = "Server=127.0.0.1;Database=site;Uid=root;";
            string connectionString = "Server=srv1688.hstgr.io;Database=u641226040_system;Uid=u641226040_painSystem;Pwd=;Port=3306;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return "success";
                    /*string query = "SELECT * FROM your_table_name";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["column_name"].ToString());  // Adjust column name as needed
                        }
                    }*/
                }
                catch (MySqlException ex)
                {
                    //Console.WriteLine("An error occurred: " + ex.Message);
                    return ex.Message;
                }
            }
        }

        public static string delData()
        {
            string connectionString = "Server=srv1688.hstgr.io;Database=u641226040_system;Uid=u641226040_painSystem;Pwd=Nouhnouhamar1;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryAd = "DELETE FROM Admins";
                    string queryGd = "DELETE FROM Grades";
                    string queryGp = "DELETE FROM Groups";
                    string queryStd = "DELETE FROM Students";
                    string queryMo = "DELETE FROM MonthP";
                    string queryPa = "DELETE FROM Payments";
                    string queryStdPres = "DELETE FROM StudentPres";
                    string queryAct = "DELETE FROM ActivityLog";

                    MySqlCommand cmdAd = new MySqlCommand(queryAd, connection);
                    cmdAd.ExecuteNonQuery();

                    MySqlCommand cmdGd = new MySqlCommand(queryGd, connection);
                    cmdGd.ExecuteNonQuery();

                    MySqlCommand cmdGp = new MySqlCommand(queryGp, connection);
                    cmdGp.ExecuteNonQuery();

                    MySqlCommand cmdStd = new MySqlCommand(queryStd, connection);
                    cmdStd.ExecuteNonQuery();

                    MySqlCommand cmdMo = new MySqlCommand(queryMo, connection);
                    cmdMo.ExecuteNonQuery();

                    MySqlCommand cmdPa = new MySqlCommand(queryPa, connection);
                    cmdPa.ExecuteNonQuery();

                    MySqlCommand cmdStdPres = new MySqlCommand(queryStdPres, connection);
                    cmdStdPres.ExecuteNonQuery();

                    MySqlCommand cmdAct = new MySqlCommand(queryAct, connection);
                    cmdAct.ExecuteNonQuery();

                    return "Success";
                }
                catch (MySqlException ex)
                {
                    return "An error occurred: " + ex.Message;
                }
            }
        }

        public static string sendData()
        {
            string sqlServerConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=std;Integrated Security=True";
            string mySqlConnectionString = "Server=srv1688.hstgr.io;Database=u641226040_system;Uid=u641226040_painSystem;Pwd=Nouhnouhamar1;Port=3306;";
            try
            {
                //admins
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM admins";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string Code = sqlReader.GetByte(0).ToString();
                                string Name = sqlReader.GetString(1);
                                string PW = sqlReader.GetString(2);
                                string mySqlInsertQuery = "INSERT INTO Admins (Code, Name, PW) VALUES (@Code, @Name, @PW)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@Code", Code);
                                mySqlCommand.Parameters.AddWithValue("@Name", Name);
                                mySqlCommand.Parameters.AddWithValue("@PW", PW);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                //Grades
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM grades";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string Code = sqlReader.GetByte(0).ToString();
                                string Name = sqlReader.GetString(1);
                                string mySqlInsertQuery = "INSERT INTO Grades (Code, Name) VALUES (@Code, @Name)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@Code", Code);
                                mySqlCommand.Parameters.AddWithValue("@Name", Name);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                //Groups
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM groups";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string Code = sqlReader.GetByte(0).ToString();
                                string Name = sqlReader.GetString(1);
                                string GradeCode = sqlReader.GetByte(2).ToString();
                                string GradeName = sqlReader.GetString(3);
                                string Days = sqlReader.GetString(4);
                                string Time = sqlReader.GetString(5);

                                string mySqlInsertQuery = "INSERT INTO Groups (Code, Name, GradeCode, GradeName, Days, Time) VALUES (@Code, @Name, @GradeCode, @GradeName, @Days, @Time)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@Code", Code);
                                mySqlCommand.Parameters.AddWithValue("@Name", Name);
                                mySqlCommand.Parameters.AddWithValue("@GradeCode", GradeCode);
                                mySqlCommand.Parameters.AddWithValue("@GradeName", GradeName);
                                mySqlCommand.Parameters.AddWithValue("@Days", Days);
                                mySqlCommand.Parameters.AddWithValue("@Time", Time);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                //Students
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM students";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string Code = sqlReader.GetInt32(0).ToString();
                                string Name = sqlReader.GetString(1);
                                string GradeCode = sqlReader.GetByte(2).ToString();
                                string GradeName = sqlReader.GetString(3);
                                string GroupCode = sqlReader.GetByte(4).ToString();
                                string GroupName = sqlReader.GetString(5);
                                string Phone = sqlReader.GetString(6);
                                string PrtPhone = sqlReader.GetString(7);
                                string RegDate = sqlReader.GetDateTime(8).ToString();

                                string mySqlInsertQuery = "INSERT INTO Students (Code, Name, GradeCode, GradeName, GroupCode, GroupName, Phone, PrtPhone, RegDate ) VALUES (@Code, @Name, @GradeCode, @GradeName, @GroupCode, @GroupName, @Phone, @PrtPhone, @RegDate)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@Code", Code);
                                mySqlCommand.Parameters.AddWithValue("@Name", Name);
                                mySqlCommand.Parameters.AddWithValue("@GradeCode", GradeCode);
                                mySqlCommand.Parameters.AddWithValue("@GradeName", GradeName);
                                mySqlCommand.Parameters.AddWithValue("@GroupCode", GroupCode);
                                mySqlCommand.Parameters.AddWithValue("@GroupName", GroupName);
                                mySqlCommand.Parameters.AddWithValue("@Phone", Phone);
                                mySqlCommand.Parameters.AddWithValue("@PrtPhone", PrtPhone);
                                mySqlCommand.Parameters.AddWithValue("@RegDate", RegDate);

                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
                //MonthP
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM MonthP";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string Code = sqlReader.GetInt32(0).ToString();
                                string YearP = sqlReader.GetString(1);
                                string MonthP = sqlReader.GetString(2);
                                string GradeCode = sqlReader.GetByte(3).ToString();
                                string GradeName = sqlReader.GetString(4);
                                string Price = sqlReader.GetDecimal(5).ToString();

                                string mySqlInsertQuery = "INSERT INTO MonthP (Code, YearP, MonthP, GradeCode, GradeName, Price) VALUES (@Code, @YearP, @MonthP, @GradeCode, @GradeName, @Price)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@Code", Code);
                                mySqlCommand.Parameters.AddWithValue("@YearP", YearP);
                                mySqlCommand.Parameters.AddWithValue("@MonthP", MonthP);
                                mySqlCommand.Parameters.AddWithValue("@GradeCode", GradeCode);
                                mySqlCommand.Parameters.AddWithValue("@GradeName", GradeName);
                                mySqlCommand.Parameters.AddWithValue("@Price", Price);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                //Payments
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM Payments";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string Code = sqlReader.GetInt32(0).ToString();
                                string MonthPCode = sqlReader.GetInt32(1).ToString();
                                string stdCode = sqlReader.GetInt32(2).ToString();
                                string stdName = sqlReader.GetString(3);
                                string GradeCode = sqlReader.GetByte(4).ToString();
                                string GradeName = sqlReader.GetString(5);
                                string GroupCode = sqlReader.GetByte(6).ToString();
                                string GroupName = sqlReader.GetString(7);
                                string YearP = sqlReader.GetString(8);
                                string MonthP = sqlReader.GetString(9);
                                string MPrice = sqlReader.GetDecimal(10).ToString();
                                string State = sqlReader.GetBoolean(11).ToString();
                                string Discount = sqlReader.GetDecimal(12).ToString();
                                string Paid = sqlReader.GetDecimal(13).ToString();
                                DateTime? Date = sqlReader.IsDBNull(14) ? (DateTime?)null : sqlReader.GetDateTime(14);
                                string mySqlInsertQuery = "INSERT INTO Payments (Code, MonthPCode, stdCode, stdName, GradeCode, GradeName, GroupCode, GroupName, YearP, MonthP, MPrice, State, Discount, Paid, Date) VALUES (@Code, @MonthPCode, @stdCode, @stdName, @GradeCode, @GradeName, @GroupCode, @GroupName, @YearP, @MonthP, @MPrice, @State, @Discount, @Paid, @Date)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@Code", Code);
                                mySqlCommand.Parameters.AddWithValue("@MonthPCode", MonthPCode);
                                mySqlCommand.Parameters.AddWithValue("@stdCode", stdCode);
                                mySqlCommand.Parameters.AddWithValue("@stdName", stdName);
                                mySqlCommand.Parameters.AddWithValue("@GradeCode", GradeCode);
                                mySqlCommand.Parameters.AddWithValue("@GradeName", GradeName);
                                mySqlCommand.Parameters.AddWithValue("@GroupCode", GroupCode);
                                mySqlCommand.Parameters.AddWithValue("@GroupName", GroupName);
                                mySqlCommand.Parameters.AddWithValue("@YearP", YearP);
                                mySqlCommand.Parameters.AddWithValue("@MonthP", MonthP);
                                mySqlCommand.Parameters.AddWithValue("@MPrice", MPrice);
                                mySqlCommand.Parameters.AddWithValue("@State", State);
                                mySqlCommand.Parameters.AddWithValue("@Discount", Discount);
                                mySqlCommand.Parameters.AddWithValue("@Paid", Paid);
                                mySqlCommand.Parameters.AddWithValue("@Date", Date);

                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                //StudentPres
                using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM StudentPres";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string stdCode = sqlReader.GetInt32(0).ToString();
                                string stdName = sqlReader.GetString(1);
                                string Mark = sqlReader.IsDBNull(2) ? null : sqlReader.GetString(2);
                                string GradeCode = sqlReader.GetByte(3).ToString();
                                string GradeName = sqlReader.GetString(4);
                                string GroupCode = sqlReader.GetByte(5).ToString();
                                string GroupName = sqlReader.GetString(6);
                                string DayDate = sqlReader.GetString(7);
                                string DayName = sqlReader.GetString(8);
                                string Presence = sqlReader.GetBoolean(9).ToString();
                                DateTime? Tpres = sqlReader.IsDBNull(10) ? (DateTime?)null : sqlReader.GetDateTime(10);
                                DateTime Topen = sqlReader.GetDateTime(11);
                                string Method = sqlReader.GetString(12);
                                string ID = sqlReader.GetInt32(13).ToString();

                                string mySqlInsertQuery = "INSERT INTO StudentPres (stdCode, stdName, Mark, GradeCode, GradeName, GroupCode, GroupName, DayDate, DayName, Presence, Tpres, Topen, Method, ID) VALUES (@stdCode, @stdName, @Mark, @GradeCode, @GradeName, @GroupCode, @GroupName, @DayDate, @DayName, @Presence, @Tpres, @Topen, @Method, @ID)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@stdCode", stdCode);
                                mySqlCommand.Parameters.AddWithValue("@stdName", stdName);
                                mySqlCommand.Parameters.AddWithValue("@Mark", Mark);
                                mySqlCommand.Parameters.AddWithValue("@GradeCode", GradeCode);
                                mySqlCommand.Parameters.AddWithValue("@GradeName", GradeName);
                                mySqlCommand.Parameters.AddWithValue("@GroupCode", GroupCode);
                                mySqlCommand.Parameters.AddWithValue("@GroupName", GroupName);
                                mySqlCommand.Parameters.AddWithValue("@DayDate", DayDate);
                                mySqlCommand.Parameters.AddWithValue("@DayName", DayName);
                                mySqlCommand.Parameters.AddWithValue("@Presence", Presence);
                                mySqlCommand.Parameters.AddWithValue("@Tpres", Tpres);
                                mySqlCommand.Parameters.AddWithValue("@Topen", Topen);
                                mySqlCommand.Parameters.AddWithValue("@Method", Method);
                                mySqlCommand.Parameters.AddWithValue("@ID", ID);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                //ActivityLog
                /*using (SqlConnection sqlConnection = new SqlConnection(sqlServerConnectionString))
                {
                    sqlConnection.Open();
                    string sqlSelectQuery = "SELECT * FROM ActivityLog";
                    SqlCommand sqlCommand = new SqlCommand(sqlSelectQuery, sqlConnection);
                    using (SqlDataReader sqlReader = sqlCommand.ExecuteReader())
                    {
                        using (MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString))
                        {
                            mySqlConnection.Open();
                            while (sqlReader.Read())
                            {
                                string LogID = sqlReader.GetInt32(0).ToString();
                                string ActivityType = sqlReader.GetString(1);
                                string TableName = sqlReader.GetString(2);
                                string RecordID = sqlReader.GetString(3);
                                string UserCode = sqlReader.GetString(4);
                                string UserName = sqlReader.GetString(5);
                                DateTime Timestamp = sqlReader.GetDateTime(6);
                                string AdditionalInfo = sqlReader.GetString(7);
                                string mySqlInsertQuery = "INSERT INTO ActivityLog (LogID, ActivityType, TableName, RecordID, UserCode, UserName, Timestamp, AdditionalInfo) VALUES (@LogID, @ActivityType, @TableName, @RecordID, @UserCode, @UserName, @Timestamp, @AdditionalInfo)";
                                MySqlCommand mySqlCommand = new MySqlCommand(mySqlInsertQuery, mySqlConnection);
                                mySqlCommand.Parameters.AddWithValue("@LogID", LogID);
                                mySqlCommand.Parameters.AddWithValue("@ActivityType", ActivityType);
                                mySqlCommand.Parameters.AddWithValue("@TableName", TableName);
                                mySqlCommand.Parameters.AddWithValue("@RecordID", RecordID);
                                mySqlCommand.Parameters.AddWithValue("@UserCode", UserCode);
                                mySqlCommand.Parameters.AddWithValue("@UserName", UserName);
                                mySqlCommand.Parameters.AddWithValue("@Timestamp", Timestamp);
                                mySqlCommand.Parameters.AddWithValue("@AdditionalInfo", AdditionalInfo);
                                mySqlCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }*/

                return "Success";
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }
        //A


        public static bool addStd(string name , string gradeCode, string gradeName ,string groupCode , string groupName , string phone , string prtPhone)
        {
            //DBMySQL.EditData("INSERT INTO Students(Name, GradeCode, GradeName, GroupCode, GroupName, Phone, PrtPhone, RegDate) VALUES(N'" + name + "','" + gradeCode + "',N'" + gradeName + "','" + groupCode + "',N'" + groupName + "',N'" + phone + "',N'" + prtPhone + "',NOW())");
            DB.EditData("INSERT INTO Students(Name, GradeCode, GradeName, GroupCode, GroupName, Phone, PrtPhone, RegDate) VALUES(N'" + name + "','" + gradeCode + "',N'" + gradeName + "','" + groupCode + "',N'" + groupName + "',N'" + phone + "',N'" + prtPhone + "',getdate())");
            string stdCode = DB.GetData("SELECT Code FROM Students WHERE Phone='" + phone + "'").Rows[0][0].ToString();
            addStdPaymentsAfterSTD(stdCode);
            return true;
        }

        public static bool addGrade(string name)
        {
            //DBMySQL.EditData("INSERT INTO Grades(Name) VALUES(N'" + name + "')");
            DB.EditData("INSERT INTO Grades(Name) VALUES(N'" + name + "')");
            return true;
        }

        public static bool addGroup(string name, string gradeCode , string gradeName, string days , string time)
        {
            //DBMySQL.EditData("INSERT INTO Groups(Name, GradeCode, GradeName, Days, Time) VALUES(N'" + name + "','" + gradeCode + "',N'" + gradeName + "',N'" + days + "',N'" + time + "')");
            DB.EditData("INSERT INTO Groups(Name, GradeCode, GradeName, Days, Time) VALUES(N'" + name + "','" + gradeCode + "',N'" + gradeName + "',N'" + days + "',N'" + time + "')");
            return true;
        }

        public static bool addNewMonthPrice(string year, string month, string gradeCode, string gradeName, string price)
        {
            //DBMySQL.EditData("INSERT INTO MonthP(YearP, MonthP, GradeCode, GradeName, Price) VALUES(N'" + year + "','" + month + "','" + gradeCode + "',N'" + gradeName + "','" + price + "')");
            DB.EditData("INSERT INTO MonthP(YearP, MonthP, GradeCode, GradeName, Price) VALUES(N'" + year + "','" + month + "','" + gradeCode + "',N'" + gradeName + "','" + price + "')");
            string monthCode = DB.GetData("SELECT Code FROM MonthP WHERE YearP='" + year + "' AND MonthP='" + month + "' AND GradeCode='" + gradeCode + "'").Rows[0][0].ToString();
            addAllStdPaymentsAfterMonth(monthCode, year, month, gradeCode, price);
            return true;
        }

        public static bool addAllStdPaymentsAfterMonth(string monthCode, string year, string month, string gradeCode, string price)
        {
            int intedYear = int.Parse(year);
            int intedMonth = int.Parse(month);
            DataTable std = getSTDsGrade(gradeCode);
            for(int i =0; i< std.Rows.Count; i++)
            {
                //0 month
                //1 day
                //2 year + time.
                string[] date = std.Rows[i][8].ToString().Split('/');
                string yearGet = date[2].Substring(0, 4);

                int[] dateInted = new int[2];
                //month
                dateInted[0] = int.Parse(date[0]);
                //year
                dateInted[1] = int.Parse(yearGet);
                if(intedYear == dateInted[1] && intedMonth >= dateInted[0])
                {
                    //DBMySQL.EditData("INSERT INTO Payments(MonthPCode,stdCode,stdName,GradeCode,GradeName,GroupCode,GroupName,YearP,MonthP,MPrice) VALUES('" + monthCode + "','" + std.Rows[i][0].ToString() + "',N'" + std.Rows[i][1].ToString() + "','" + std.Rows[i][2].ToString() + "',N'" + std.Rows[i][3].ToString() + "','" + std.Rows[i][4].ToString() + "',N'" + std.Rows[i][5].ToString() + "','" + year + "','" + month + "','" + price + "')");
                    DB.EditData("INSERT INTO Payments(MonthPCode,stdCode,stdName,GradeCode,GradeName,GroupCode,GroupName,YearP,MonthP,MPrice) VALUES('" + monthCode + "','" + std.Rows[i][0].ToString() + "',N'" + std.Rows[i][1].ToString() + "','" + std.Rows[i][2].ToString() + "',N'" + std.Rows[i][3].ToString() + "','" + std.Rows[i][4].ToString() + "',N'" + std.Rows[i][5].ToString() + "','" + year + "','" + month + "','" + price + "')");
                }
                else if(intedYear > dateInted[1])
                {
                    //DBMySQL.EditData("INSERT INTO Payments(MonthPCode,stdCode,stdName,GradeCode,GradeName,GroupCode,GroupName,YearP,MonthP,MPrice) VALUES('" + monthCode + "','" + std.Rows[i][0].ToString() + "',N'" + std.Rows[i][1].ToString() + "','" + std.Rows[i][2].ToString() + "',N'" + std.Rows[i][3].ToString() + "','" + std.Rows[i][4].ToString() + "',N'" + std.Rows[i][5].ToString() + "','" + year + "','" + month + "','" + price + "')");
                    DB.EditData("INSERT INTO Payments(MonthPCode,stdCode,stdName,GradeCode,GradeName,GroupCode,GroupName,YearP,MonthP,MPrice) VALUES('" + monthCode + "','" + std.Rows[i][0].ToString() + "',N'" + std.Rows[i][1].ToString() + "','" + std.Rows[i][2].ToString() + "',N'" + std.Rows[i][3].ToString() + "','" + std.Rows[i][4].ToString() + "',N'" + std.Rows[i][5].ToString() + "','" + year + "','" + month + "','" + price + "')");
                }

            }
            return true;
        }

        public static bool addStdPayments(string monthCode, string year, string month, string gradeCode, string price, DataTable std)
        {
            //DBMySQL.EditData("INSERT INTO Payments(MonthPCode,stdCode,stdName,GradeCode,GradeName,GroupCode,GroupName,YearP,MonthP,MPrice) VALUES('" + monthCode + "','" + std.Rows[0][0].ToString() + "',N'" + std.Rows[0][1].ToString() + "','" + std.Rows[0][2].ToString() + "',N'" + std.Rows[0][3].ToString() + "','" + std.Rows[0][4].ToString() + "',N'" + std.Rows[0][5].ToString() + "','" + year + "','" + month + "','" + price + "')");
            DB.EditData("INSERT INTO Payments(MonthPCode,stdCode,stdName,GradeCode,GradeName,GroupCode,GroupName,YearP,MonthP,MPrice) VALUES('" + monthCode + "','" + std.Rows[0][0].ToString() + "',N'" + std.Rows[0][1].ToString() + "','" + std.Rows[0][2].ToString() + "',N'" + std.Rows[0][3].ToString() + "','" + std.Rows[0][4].ToString() + "',N'" + std.Rows[0][5].ToString() + "','" + year + "','" + month + "','" + price + "')");
            return true;
        }

        public static bool addStdPaymentsAfterSTD(string stdCode)
        {
            DataTable std = getSpecificStd(stdCode);
            string gradeCode = std.Rows[0][2].ToString();


            string[] regDate = std.Rows[0][8].ToString().Split('/');


            //0 month
            //1 day
            //2 year + time.
            string yearGet = regDate[2].Substring(0, 4);

            int intedYear = int.Parse(yearGet);
            int intedMonth = int.Parse(regDate[0]);
            DataTable monthForStd = DB.GetData("SELECT * FROM MonthP WHERE GradeCode='" + gradeCode + "' AND YearP >='" + yearGet + "' AND MonthP >= '" + regDate[0] + "'");
            for (int i = 0; i < monthForStd.Rows.Count; i++)
            {
                string monthCode = monthForStd.Rows[i][0].ToString();
                string year = monthForStd.Rows[i][1].ToString();
                string month = monthForStd.Rows[i][2].ToString();
                string price = monthForStd.Rows[i][5].ToString();
                addStdPayments(monthCode, year, month, gradeCode, price, std);
            }
            return true;
        }

        public static bool attendStd(DataGridViewRow dr)
        {
            //stdCode 0
            //gbCode 5
            //dayDate 7
            //method 12
            //DBMySQL.EditData("UPDATE StudentPres SET Tpres = NOW() , Presence =1 WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            DB.EditData("UPDATE StudentPres SET Tpres = getdate() , Presence =1 WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            return true;
        }

        public static bool absentStd(DataGridViewRow dr)
        {
            //stdCode 0
            //gbCode 5
            //dayDate 7
            //method 12
            //DBMySQL.EditData("UPDATE StudentPres SET Mark = NULL , Tpres = NULL , Presence =0 WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            DB.EditData("UPDATE StudentPres SET Mark = NULL , Tpres = NULL , Presence =0 WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            return true;
        }

        public static bool addStdMark(DataGridViewRow dr , string mark)
        {
            //stdCode 0
            //gbCode 5
            //dayDate 7
            //method 12
            //DBMySQL.EditData("UPDATE StudentPres SET Mark='" + mark + "' WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            DB.EditData("UPDATE StudentPres SET Mark='" + mark + "' WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            return true;
        }

        public static void addActivity(string activityType, string tableName, string recordId,string userCode, string userName, string additionalInfo)
        {
            //DBMySQL.EditData("INSERT INTO ActivityLog(ActivityType , TableName , RecordID , UserName , UserCode , Timestamp , AdditionalInfo) VALUES(N'" + activityType + "',N'" + tableName + "','" + recordId + "', N'" + userName + "','" + userCode + "', NOW() , N'" + additionalInfo + "')");
            DB.EditData("INSERT INTO ActivityLog(ActivityType , TableName , RecordID , UserName , UserCode , Timestamp , AdditionalInfo) VALUES(N'" + activityType + "',N'" + tableName + "','" + recordId + "', N'" + userName + "','" + userCode + "', getdate() , N'" + additionalInfo + "')");


            //DB.EditData("INSERT INTO ActivityLog(ActivityType , TableName , RecordID , UserName , UserCode , Timestamp , AdditionalInfo) VALUES(N'تعديل كلمة مرور' , N'بيانات الوصول' , '" + cbxCurrentCDs_EdtCashier.Text + "' ,N'" + n + "','" + c + "', getdate(), N' محاولة ناجحة عن تغيير كلمة مرور الكاشير " + cbxCurrentCDs_EdtCashier.Text + " بإسم " + edtCashierName + "')");
            //DB.EditData("INSERT INTO ActivityLog(ActivityType , TableName , RecordID , UserName , UserCode , Timestamp , AdditionalInfo) VALUES(N'التحقق من بيانات الادمن' , NULL , NULL ,N'" + n + "','" + c + "', getdate(), N'محاولة فاشلة عن التحقق من بيانات الادمن ، فقط تم الضغط على زر تحقق')");
        }

        //B

        //C
        public static bool createAcc(string userName, string pass)
        {
            string qAdd = "INSERT INTO Admins(Name , PW) VALUES(N'" + userName + "', N'" + pass + "')";
            //DBMySQL.EditData(qAdd);
            DB.EditData(qAdd);
            return true;
        }

        public static bool cancelPayMonth(string payCode)
        {
            //DBMySQL.EditData("UPDATE Payments SET Discount= 0 , Paid = 0 , State = 0 , Date = NULL WHERE Code ='" + payCode + "'");
            DB.EditData("UPDATE Payments SET Discount= 0 , Paid = 0 , State = 0 , Date = NULL WHERE Code ='" + payCode + "'");
            return true;
        }

        public static bool changeAdminPass(string adminCode , string newPass)
        {
            //DBMySQL.EditData("UPDATE Admins SET PW =N'" + newPass + "' WHERE Code='" + adminCode + "'");
            DB.EditData("UPDATE Admins SET PW =N'" + newPass + "' WHERE Code='" + adminCode + "'");
            return true;
        }

        //D
        public static bool delStd(string stdCode , bool payments , bool presMarks)
        {
            if(payments && presMarks)
            {
                //DBMySQL.EditData("DELETE FROM Payments WHERE stdCode = '" + stdCode + "'");
                //DBMySQL.EditData("DELETE FROM StudentPres WHERE stdCode  = '" + stdCode + "'");
                //DBMySQL.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                DB.EditData("DELETE FROM Payments WHERE stdCode = '" + stdCode + "'");
                DB.EditData("DELETE FROM StudentPres WHERE stdCode  = '" + stdCode + "'");
                DB.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                return true;
            }
            else if (payments)
            {
                //DBMySQL.EditData("DELETE FROM Payments WHERE stdCode = '" + stdCode + "'");
                //DBMySQL.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                DB.EditData("DELETE FROM Payments WHERE stdCode = '" + stdCode + "'");
                DB.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                return true;
            }
            else if(presMarks)
            {
                //DBMySQL.EditData("DELETE FROM StudentPres WHERE stdCode  = '" + stdCode + "'");
                //DBMySQL.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                DB.EditData("DELETE FROM StudentPres WHERE stdCode  = '" + stdCode + "'");
                DB.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                return true;
            }
            else
            {
                //DBMySQL.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                DB.EditData("DELETE FROM Students WHERE Code = '" + stdCode + "'");
                return true;
            }
        }

        public static bool delMonthPrice(string monthCode)
        {
            //DBMySQL.EditData("DELETE FROM Payments WHERE MonthPCode ='" + monthCode + "'");
            //DBMySQL.EditData("DELETE FROM MonthP WHERE Code = '" + monthCode + "'");
            DB.EditData("DELETE FROM Payments WHERE MonthPCode ='" + monthCode + "'");
            DB.EditData("DELETE FROM MonthP WHERE Code = '" + monthCode+ "'");
            return true;
        }

        //E
        public static bool editStudent(string[] newData)
        {
            //DBMySQL.EditData("UPDATE Students SET Name = N'" + newData[1] + "' , GradeCode ='" + newData[2] + "', GradeName =N'" + newData[3] + "', GroupCode= '" + newData[4] + "' , GroupName=N'" + newData[5] + "' , Phone='" + newData[6] + "' , PrtPhone='" + newData[7] + "' WHERE Code = '" + newData[0] + "'");
            DB.EditData("UPDATE Students SET Name = N'" + newData[1] + "' , GradeCode ='" + newData[2] + "', GradeName =N'" + newData[3] + "', GroupCode= '" + newData[4] + "' , GroupName=N'" + newData[5] + "' , Phone='" + newData[6] + "' , PrtPhone='" + newData[7] + "' WHERE Code = '" + newData[0] + "'");
            return true;
        }

        //F
        //G
        public static DataTable getActivity()
        {
            return DB.GetData("SELECT * FROM ActivityLog");
        }
        public static DataTable getGrades()
        {
            return DB.GetData("SELECT * FROM Grades");
        }


        public static DataTable getGroups()
        {
            return DB.GetData("SELECT * FROM Groups");
        }

        public static DataTable getStudents()
        {
            return DB.GetData("SELECT * FROM Students");
        }

        public static DataTable getSTDsGrade(string gdCode)
        {
            return DB.GetData("SELECT * FROM Students WHERE GradeCode ='" + gdCode + "'");
        }

        public static DataTable getGroupStd(string gbCode)
        {
            return DB.GetData("SELECT * FROM Students WHERE GroupCode='" + gbCode + "'");
        }

        public static DataTable getSpecificStd(string stdCode)
        {
            return DB.GetData("SELECT * FROM Students WHERE Code='" + stdCode + "'");
        }

        public static DataTable getGroupsWithGrade(string gradeCode)
        {
            return DB.GetData("SELECT * FROM Groups WHERE GradeCode ='" + gradeCode + "'");
        }

        public static DataTable getGroupData(string groupCode)
        {
            return DB.GetData("SELECT * FROM Groups WHERE Code ='" + groupCode + "'");
        }

        public static DataTable getUsers()
        {
            return DB.GetData("SELECT * FROM Admins");
        }

        public static DataTable getOpenedDayWithSearch(string dtFrom, string dtTo, string gbCode, string method, string txtSearch)
        {
            DataTable pres = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = DB.conn;
                string command;
                if (method == "code") command = "SELECT * FROM StudentPres WHERE DayDate >= @StartDate AND  DayDate <= @EndDate AND GroupCode = '" + gbCode + "' AND stdCode LIKE N'" + txtSearch + "%'";
                else command = "SELECT * FROM StudentPres WHERE DayDate >= @StartDate AND  DayDate <= @EndDate AND GroupCode = '" + gbCode + "' AND stdName LIKE N'%" + txtSearch + "%'";
                sqlCommand.Parameters.AddWithValue("@StartDate", dtFrom);
                sqlCommand.Parameters.AddWithValue("@EndDate", dtTo);
                sqlCommand.CommandText = command;
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                sda.Fill(pres);
            }
            return pres;
        }

        public static DataTable getPayments()
        {
            return DB.GetData("SELECT * FROM Payments");
        }

        public static DataTable getPyamentsWithSearch(string gdCode , string gbCode, string method, string txtSearch , string year , string month)
        {
            if (method == "name")
            {
                if (gdCode == "" && gbCode == "")
                {
                    if (year != "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND YearP='" + year + "' AND MonthP='" + month + "'");
                    }
                    else if (year != "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND YearP LIKE '" + year + "%'");
                    }
                    else if (year == "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND MonthP ='" + month+ "'");
                    }
                    else if(year == "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%'");
                    }
                    else return null;
                }
                else if (gdCode != "" && gbCode != "")
                {
                    if (year != "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND YearP='" + year + "' AND MonthP='" + month + "' AND GroupCode = '" + gbCode + "'");
                    }
                    else if (year != "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND YearP LIKE '" + year + "%' AND GroupCode='" + gbCode + "'");
                    }
                    else if (year == "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND MonthP ='" + month + "' AND GroupCode='" + gbCode + "'");
                    }
                    else if (year == "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND GroupCode='" + gbCode + "'");
                    }
                    else return null;
                }
                else if (gbCode == "" && gdCode != "")
                {
                    if (year != "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND YearP='" + year + "' AND MonthP='" + month + "' AND GradeCode='" + gdCode + "'");
                    }
                    else if (year != "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND YearP LIKE '" + year + "%' AND GradeCode='" + gdCode + "'");
                    }
                    else if (year == "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND MonthP ='" + month + "' AND GradeCode='" + gdCode + "'");
                    }
                    else if (year == "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdName LIKE N'%" + txtSearch + "%' AND GradeCode='" + gdCode + "'");
                    }
                    else return null;
                }
                else return null;
            }
            else if (method == "code")
            {
                if (gdCode == "" && gbCode == "")
                {
                    if (year != "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND YearP='" + year + "' AND MonthP='" + month + "'");
                    }
                    else if (year != "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND YearP LIKE '" + year + "%'");
                    }
                    else if (year == "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND MonthP ='" + month + "'");
                    }
                    else if (year == "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%'");
                    }
                    else return null;
                }
                else if (gdCode != "" && gbCode != "")
                {
                    if (year != "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND YearP='" + year + "' AND MonthP='" + month + "' AND GroupCode = '" + gbCode + "'");
                    }
                    else if (year != "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND YearP LIKE '" + year + "%' AND GroupCode='" + gbCode + "'");
                    }
                    else if (year == "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND MonthP ='" + month + "' AND GroupCode='" + gbCode + "'");
                    }
                    else if (year == "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND GroupCode='" + gbCode + "'");
                    }
                    else return null;
                }
                else if (gbCode == "" && gdCode != "")
                {
                    if (year != "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND YearP='" + year + "' AND MonthP='" + month + "' AND GradeCode='" + gdCode + "'");
                    }
                    else if (year != "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND YearP LIKE '" + year + "%' AND GradeCode='" + gdCode + "'");
                    }
                    else if (year == "" && month != "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND MonthP ='" + month + "' AND GradeCode='" + gdCode + "'");
                    }
                    else if (year == "" && month == "")
                    {
                        return DB.GetData("SELECT * FROM Payments WHERE stdCode LIKE '" + txtSearch + "%' AND GradeCode='" + gdCode + "'");
                    }
                    else return null;
                }
                else return null;
            }
            else return null;
        }

        public static string getPresID(DataGridViewRow dr)
        {
            //DB.EditData("UPDATE StudentPres SET Tpres = getdate() , Presence =1 WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'");
            return DB.GetData("SELECT ID FROM StudentPres WHERE stdCode='" + dr.Cells[0].Value.ToString() + "' AND GroupCode='" + dr.Cells[5].Value.ToString() + "' AND DayDate=N'" + dr.Cells[7].Value.ToString() + "' AND Method=N'" + dr.Cells[12].Value.ToString() + "'").Rows[0][0].ToString();
        }

        public static int getGradeSTDCount(string gradeCode)
        {
            return DB.GetData("SELECT CODE FROM Students WHERE GradeCode='" + gradeCode + "'").Rows.Count;
        }

        public static int getGroupSTDCount(string groupCode)
        {
            return DB.GetData("SELECT CODE FROM Students WHERE GroupCode='" + groupCode + "'").Rows.Count;
        }

        public static string getMonthCode(string year , string month , string gdCode)
        {
            DataTable monthGet = DB.GetData("SELECT Code From MonthP Where YearP='" + year + "' AND MonthP='" + month + "' AND GradeCode='" + gdCode + "'");
            if (monthGet.Rows.Count == 0) return null;
            else return monthGet.Rows[0][0].ToString();
        }

        public static string getAdminCode(string name)
        {
            DataTable table = DB.GetData("SELECT Code FROM Admins WHERE Name =N'" + name + "'");
            if (table.Rows.Count == 1) return table.Rows[0][0].ToString();
            else return null;
        }

        public static string getAdminPass(string adCode)
        {
            return DB.GetData("SELECT PW FROM Admins WHERE Code='" + adCode + "'").Rows[0][0].ToString();
        }

        public static string getGroupCode(string name)
        {
            DataTable table = DB.GetData("SELECT Code FROM Groups WHERE Name =N'" + name + "'");
            if (table.Rows.Count == 1)
            {
                return table.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }

        public static string getGradeCode(string name)
        {
            DataTable table = DB.GetData("SELECT Code FROM Grades WHERE Name =N'" + name + "'");
            if (table.Rows.Count == 1)
            {
                return table.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }

        //H
        public static bool hasSpecialChar(string _in)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s.\u0620-\u064A]");
            return regex.IsMatch(_in);
        }

        //I
        public static bool ifMonthUsed(string monthCode)
        {
            DataTable tb =  DB.GetData("SELECT * FROM Payments WHERE MonthPCode='" + monthCode + "' AND State = 1");
            if (tb.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isDigit(string _in)
        {
            int zero = 0;
            return int.TryParse(_in, out zero);
        }

        public static bool isFirstTimeUsingProg()
        {
            DataTable table = DB.GetData("SELECT * FROM Admins");
            if (table.Rows.Count > 0) return false;
            else return true;
        }

        public static bool isMonthPriceExist(string year, string month, string gradeCode)
        {
            DataTable table = DB.GetData("SELECT * FROM MonthP WHERE YearP = N'" + year + "' AND MonthP = N'" + month + "' AND GradeCode = N'" + gradeCode + "'");
            if (table.Rows.Count == 1) return true;
            else return false;
        }

        public static bool isStdAlreadyPaid(string payCode)
        {
            DataTable table = DB.GetData("SELECT * FROM Payments WHERE Code ='" + payCode + "' AND State = 1");
            if (table.Rows.Count == 1) return true;
            else return false;
        }

        public static bool isAdminNameExist(string adminName)
        {
            DataTable table = DB.GetData("SELECT * FROM Admins WHERE Name=N'" + adminName + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isStdNameExist(string stdName)
        {
            DataTable table = DB.GetData("SELECT * FROM Students WHERE Name=N'" + stdName + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isStdNameExistExcept(string stdName , string stdCode)
        {
            DataTable table = DB.GetData("SELECT * FROM Students WHERE (Name=N'" + stdName + "') And (Code <> '" + stdCode + "')");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isStdPhoneExist(string stdPhone)
        {
            DataTable table = DB.GetData("SELECT * FROM Students WHERE Phone=N'" + stdPhone + "' OR PrtPhone=N'" + stdPhone + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isStdPhoneExistExcept(string stdPhone , string stdCode)
        {
            DataTable table = DB.GetData("SELECT * FROM Students WHERE (Phone=N'" + stdPhone + "' OR PrtPhone=N'" + stdPhone + "') AND (Code <> '" + stdCode + "')");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isPrtPhoneExist(string prtPhone)
        {
            DataTable table = DB.GetData("SELECT * FROM Students WHERE Phone=N'" + prtPhone + "' OR PrtPhone=N'" + prtPhone + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isPrtPhoneExistExcept(string stdPhone, string stdCode)
        {
            DataTable table = DB.GetData("SELECT * FROM Students WHERE (Phone=N'" + stdPhone + "' OR PrtPhone=N'" + stdPhone + "') AND (Code <> '" + stdCode + "')");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isGradeNameExist(string gradeName)
        {
            DataTable table = DB.GetData("SELECT * FROM Grades WHERE Name=N'" + gradeName + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isGroupNameExist(string groupName)
        {
            DataTable table = DB.GetData("SELECT * FROM Groups WHERE Name=N'" + groupName + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isDayOpened(string day, string groupCode, string method)
        {
            DataTable table = DB.GetData("SELECT * FROM StudentPres WHERE DayDate =N'" + day + "' AND GroupCode='" + groupCode + "' AND Method=N'" + method + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }

        public static bool isDayRight(string dayName, string gbCode)
        {
            string gbDays = DB.GetData("SELECT Days FROM Groups WHERE Code='" + gbCode + "'").Rows[0][0].ToString();
            if (gbDays.Contains(dayName)) return true;
            else return false;
        }

        /*public static bool isBaseDayOpened(string day, string groupCode)
        {
            DataTable table = DB.GetData("SELECT * FROM OpenedBaseDay WHERE Day =N'" + day + "' AND GroupCode='" + groupCode + "'");
            if (table.Rows.Count > 0) return true;
            else return false;
        }*/

        /*public static bool isAdditionDayOpened(string day, string groupCode)
         {
             DataTable table = DB.GetData("SELECT * FROM OpenedAdditionDay WHERE Day =N'" + day + "' AND GroupCode='" + groupCode + "'");
             if (table.Rows.Count > 0) return true;
             else return false;
         }*/

        //L
        public static bool login(string userName, string pass)
        {
            DB.Open();
            DataTable table = DB.GetData("SELECT * FROM Admins WHERE Name = N'" + userName + "' AND PW = N'" + pass + "'");
            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //O
        public static bool openPresDay(DataTable stds, string[] details)
        {
            for (int i = 0; i < stds.Rows.Count; i++)
            {
                try
                {
                    //DBMySQL.EditData("INSERT INTO StudentPres(stdCode, stdName, GradeCode, GradeName, GroupCode, GroupName, DayDate, DayName, Topen, Method) VALUES('" + stds.Rows[i][0].ToString() + "',N'" + stds.Rows[i][1].ToString() + "','" + details[0] + "',N'" + details[1] + "','" + details[2] + "',N'" + details[3] + "','" + details[4] + "',N'" + details[5] + "', NOW() , N'" + details[6] + "')");
                    DB.EditData("INSERT INTO StudentPres(stdCode, stdName, GradeCode, GradeName, GroupCode, GroupName, DayDate, DayName, Topen, Method) VALUES('" + stds.Rows[i][0].ToString() + "',N'" + stds.Rows[i][1].ToString() + "','" + details[0] + "',N'" + details[1] + "','" + details[2] + "',N'" + details[3] + "','" + details[4] + "',N'" + details[5] + "', getdate() , N'" + details[6] + "')");
                }
                catch (Exception)
                {
                }
                
            }
            return true;
        }

        /*public static DataTable getCashierOrdersFromTo(string cashierCode, DateTimePicker dtFrom, DateTimePicker dtTo)
        {
            DataTable orders = new DataTable();
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.Connection = DB.conn;
                string command = "SELECT * FROM Orders WHERE Timestamp >= @StartDate AND  Timestamp <= DATEADD(DAY , 1 ,@EndDate) AND CashierCode = '" + cashierCode + "'";
                sqlCommand.Parameters.AddWithValue("@StartDate", dtFrom.Value.ToShortDateString());
                sqlCommand.Parameters.AddWithValue("@EndDate", dtTo.Value.ToShortDateString());
                sqlCommand.CommandText = command;
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                sda.Fill(orders);
            }
            return orders;
        }*/

        /*public static bool openBaseDay(string day , string groupCode, string groupName)
        {
            DB.EditData("INSERT INTO OpenedBaseDay(Day, GroupCode, GroupName, Topen) VALUES('" + day + "','" + groupCode + "',N'" + groupName + "',getdate())");
            return true;
        }*/

        /*public static bool openAdditionDay(string day, string groupCode, string groupName)
        {
            DB.EditData("INSERT INTO OpenedAdditionDay(Day, GroupCode, GroupName, Topen) VALUES('" + day + "','" + groupCode + "',N'" + groupName + "',getdate())");
            return true;
        }*/

        //P
        public static bool payMonth(string payCode, string discount, string paid)
        {
            //DBMySQL.EditData("UPDATE Payments SET Discount='" + discount + "' , Paid='" + paid + "', State = 1 , Date = NOW() WHERE Code ='" + payCode + "'");
            DB.EditData("UPDATE Payments SET Discount='" + discount + "' , Paid='" + paid + "', State = 1 , Date = getdate() WHERE Code ='" + payCode + "'");
            return true;
        }

        //S
        public static DataTable searcherForStd(string method , string txtSearch , string gdCode , string gbCode)
        {
            if(method == "name")
            {
                if (gdCode == "" && gbCode == "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Name LIKE N'%" + txtSearch + "%'");
                }
                else if (gdCode != "" && gbCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Name LIKE N'%" + txtSearch + "%' AND GroupCode='" + gbCode + "'");
                }
                else if (gbCode == "" && gdCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Name LIKE N'%" + txtSearch + "%' AND GradeCode='" + gdCode + "'");
                }
                else return null;
            }
            else if(method == "code")
            {
                if (gdCode == "" && gbCode == "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Code LIKE '" + txtSearch + "%'");
                }
                else if (gdCode != "" && gbCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Code LIKE '" + txtSearch + "%' AND GroupCode='" + gbCode + "'");
                }
                else if (gbCode == "" && gdCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Code LIKE '" + txtSearch + "%' AND GradeCode='" + gdCode + "'");
                }
                else return null;
            }
            else if(method == "phone")
            {
                if (gdCode == "" && gbCode == "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Phone LIKE '" + txtSearch + "%'");
                }
                else if (gdCode != "" && gbCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Phone LIKE '" + txtSearch + "%' AND GroupCode='" + gbCode + "'");
                }
                else if (gbCode == "" && gdCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE Phone LIKE '" + txtSearch + "%' AND GradeCode='" + gdCode + "'");
                }
                else return null;
            }
            else if(method == "prtPhone")
            {
                if (gdCode == "" && gbCode == "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE PrtPhone LIKE '" + txtSearch + "%'");
                }
                else if (gdCode != "" && gbCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE PrtPhone LIKE '" + txtSearch + "%' AND GroupCode='" + gbCode + "'");
                }
                else if (gbCode == "" && gdCode != "")
                {
                    return DB.GetData("SELECT * FROM Students WHERE PrtPhone LIKE '" + txtSearch + "%' AND GradeCode='" + gdCode + "'");
                }
                else return null;
            }
            else return null;
        }
    }

    public class BaseFunc
    {
        //lap me
        /*private static string licSerial = "4CCAD100";
        private static string licMAC = "9C:B6:54:1E:52:91";*/

        //pc me 
        //private static string licSerial = "6C446DBC";
        //private static string licMAC = "B4:2E:99:8B:3D:21";

        //pc diaa
        private static string licSerial = "0E370D4B";

        public static void licenseCheck()
        {
            string progDire = AppDomain.CurrentDomain.BaseDirectory;
            DriveInfo dvi = new DriveInfo(Path.GetPathRoot(progDire));
            string driveLetter = Path.GetPathRoot(progDire).Replace("\\", "");
            string serial = GetDriveSerialNumber(driveLetter);
            string mac = GetMacAddress();
            if (licSerial != serial)
            {
                MessageBox.Show("قم بشراء البرنامج");
                Application.Exit();
            }
        }

        static string GetDriveSerialNumber(string letter)
        {
            ManagementObjectSearcher hardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID = '" + letter + "'");
            foreach (ManagementObject obj in hardSearcher.Get())
            {
                return obj["VolumeSerialNumber"].ToString();
            }
            return null;
        }

        static string GetMacAddress()
        {
            ManagementObjectSearcher macSearcher = new ManagementObjectSearcher("SELECT MACAddress FROM Win32_NetworkAdapter WHERE AdapterType LIKE '%Ethernet%'");
            foreach (ManagementObject obj in macSearcher.Get())
            {
                return obj["MACAddress"].ToString();
            }
            return null;
        }
        static string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (bytes == 0)
                return "0" + suffixes[0];

            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return $"{num}{suffixes[place]}";
        }

        public static string[] getCurrentDriveForDB_Details()
        {
            string cmd = "SELECT physical_name AS PhysicalPath FROM sys.master_files WHERE database_id = DB_ID('momo')";
            string fullpath = DB.GetData(cmd).Rows[0][0].ToString();
            string CurrDrive = DB.GetData(cmd).Rows[0][0].ToString()[0].ToString();
            string partition = CurrDrive + ":\\";
            string totalSize, availableSpace;
            DriveInfo driveInfo = new DriveInfo(partition);
            totalSize = FormatBytes(driveInfo.TotalSize).ToString();
            availableSpace = FormatBytes(driveInfo.AvailableFreeSpace).ToString();
            string[] arr = { CurrDrive, totalSize, availableSpace, fullpath };
            return arr;
        }
        public static void giveFC(string filePath)
        {
            /*FileSecurity fileSecurity = File.GetAccessControl(filePath);
            FileSystemAccessRule rule = new FileSystemAccessRule(Environment.UserName,FileSystemRights.FullControl,AccessControlType.Allow);
            fileSecurity.AddAccessRule(rule);
            File.SetAccessControl(filePath, fileSecurity);*/

            FileSecurity fileSecurity = File.GetAccessControl(filePath);
            NTAccount userAccount = new NTAccount("Users");
            FileSystemAccessRule rule = new FileSystemAccessRule(userAccount, FileSystemRights.FullControl, AccessControlType.Allow);
            fileSecurity.AddAccessRule(rule);
            File.SetAccessControl(filePath, fileSecurity);

        }
    }
}
