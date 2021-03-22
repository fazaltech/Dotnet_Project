using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Dotnet_Project.Model;


namespace Dotnet_Project
{
    class SQLiteDatabase
    {
        // This class implements all the functions required to create table, insert data, update data in the SQLite Database.
        //
        private DataRow emptyRow;
        public static String DATABASE_PATH = "enc";
        public static String DATABASE_NAME = DATABASE_PATH + "\\casi_gm.db3";
        public static int DATABASE_VERSION = 3;
        public static string DATABASE_PASSWORD = "123";

        public static String SQL_CREATE_USERS = "CREATE TABLE users ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " username TEXT,"
            + " password TEXT,"
            + " full_name TEXT"
            + " );";

        public static String SQL_CREATE_VILLAGES = "CREATE TABLE villages ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " country TEXT,"
            + " district TEXT,"
            + " uc TEXT,"
            + " village TEXT,"
            + " country_code TEXT,"
            + " district_code TEXT,"
            + " uc_code TEXT,"
            + " villlage_code TEXT,"
            + " cluster_no TEXT"
            + " );";

        

        public static String SQL_CREATE_ZSTANDARDS = "CREATE TABLE zstandards ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " sex TEXT,"
            + " age TEXT,"
            + " measure TEXT,"
            + " L TEXT,"
            + " M TEXT,"
            + " S TEXT,"
            + " cat TEXT"
            + " );";

        public static String SQL_CREATE_FORMS = "CREATE TABLE forms ("
            + "_id INTEGER PRIMARY KEY AUTOINCREMENT,"
            + "_uid TEXT,"
            + "appversion TEXT,"
            + "f1 TEXT,"
            + "f2 TEXT,"
            + "f3 TEXT,"
            + "f4 TEXT,"
            + "f5 TEXT,"
            + "f6 TEXT,"
            + "f7 TEXT,"
            + "deviceid TEXT,"
            + "endingdatetime TEXT,"
            + "gpsacc TEXT,"
            + "gpsdate TEXT,"
            + "gpslat TEXT,"
            + "gpslng TEXT,"
            + "istatus TEXT,"
            + "istatus96x TEXT,"
            + "sysdate TEXT,"
            + "tagid TEXT,"
            + "username TEXT" + " );";






        //private static String SQL_DELETE_USERS =
        //    "DROP TABLE IF EXISTS users";

        //private static String SQL_DELETE_VILLAGES =
        //    "DROP TABLE IF EXISTS villages";

        //private static String SQL_DELETE_ZSTANDARDS =
        //    "DROP TABLE IF EXISTS zstandards";


        //public static String SQL_INSERT_USERS = INSERT INTO SyncInformation(timestamp, last_sync_value, last_retrieved_change_file, status) values('


       public static SqliteConnection con;
        public static String strCon;
        public static string connectionString;

        public static SqliteDataReader r;

        public List<villages> village_obj;
       

        public SQLiteDatabase()
        {

            if (!Directory.Exists(DATABASE_PATH))
            {
                Directory.CreateDirectory(DATABASE_PATH);
            }

            //SqliteConnection.CreateFile(DATABASE_NAME);

            String strCon = "Data Source=" + DATABASE_NAME;
            Boolean dbExsits = File.Exists(DATABASE_NAME);

            connectionString = new SqliteConnectionStringBuilder(strCon)
            {
                Mode = SqliteOpenMode.ReadWriteCreate,
                Password = DATABASE_PASSWORD
            }.ToString();
            con = new SqliteConnection(connectionString);

            if (!dbExsits)
            {
                CreateTables();
            }
            //SQLiteCommand cmd = new SQLiteCommand(sql, con);
            //cmd.ExecuteNonQuery();
            //con.Close();



        }

        public static void CreateDatabase()
        {
            if (!File.Exists(DATABASE_NAME))
            {
                //SqliteConnection.CreateFile(DATABASE_NAME);

                String strCon = "Data Source=" + DATABASE_NAME;

                connectionString = new SqliteConnectionStringBuilder(strCon)
                {
                    Mode = SqliteOpenMode.ReadWriteCreate,
                    Password = DATABASE_PASSWORD
                }.ToString();
                con = new SqliteConnection(connectionString);

                try
                {
                    CreateTables();
                }
                catch { }


                //SQLiteCommand cmd = new SQLiteCommand(sql, con);
                //cmd.ExecuteNonQuery();
                //con.Close();

            }


            strCon = "Data Source=" + DATABASE_NAME;
            con = new SqliteConnection(strCon);




        }


        public static void CreateTables()
        {

            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = @SQL_CREATE_USERS;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @SQL_CREATE_VILLAGES;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @SQL_CREATE_ZSTANDARDS;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @SQL_CREATE_FORMS;
                cmd.ExecuteNonQuery();

            };
            con.Close();
        }


        //public static void CreateTables()
        //{


        //    using (var cmd = new SQLiteCommand(con))
        //    {

        //        cmd.CommandText = @SQL_CREATE_USERS;
        //        cmd.ExecuteNonQuery();

        //        cmd.CommandText = @SQL_CREATE_VILLAGES;
        //        cmd.ExecuteNonQuery();

        //        cmd.CommandText = @SQL_DELETE_ZSTANDARDS;
        //        cmd.ExecuteNonQuery();

        //        //cmd.CommandText = @SQL_DELETE_FORMS;
        //        //cmd.ExecuteNonQuery();

        //    };
        //    con.Close();
        //}

        //public static void InsertTestUser(List<users> users)
        //{


        //    using (con)
        //    {
        //        con.Open();


        //        using (var cmd = con.CreateCommand())
        //        {
        //            cmd.CommandText = "INSERT INTO users (username, password) VALUES(@username, @password)";

        //            for (int i = 0; i < users.Count; i++)
        //            {
        //                cmd.Parameters.Clear();
        //                cmd.Parameters.AddWithValue("@username", users[i].username);
        //                cmd.Parameters.AddWithValue("@password", users[i].password);

        //                cmd.ExecuteNonQuery();
        //            }
        //        }

        //        con.Close();
        //    }
        //}



        public  void InsertForm(forms_data form_data )
        {
            var rdnum = new System.Random();
            string ml = DateTime.Now.ToString("mmss");
          
            int random = rdnum.Next(100);
            string abc = ml + random;
            string def = abc.Substring(1,3);
            int id = Convert.ToInt16(def);
            using (con)
            {
                try
                {
                    con.Open();

                 
                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO forms (_id,f1,f2,f3,f4,f5,f6,f7) VALUES (@_id,@f1,@f2,@f3,@f4,@f5,@f6,@f7)";

                        
                            cmd.Parameters.Clear();
                         
                            cmd.Parameters.AddWithValue("_id", id);
                            cmd.Parameters.AddWithValue("f1", form_data.f1);
                            cmd.Parameters.AddWithValue("f2", form_data.f2);
                            cmd.Parameters.AddWithValue("f3", form_data.f3);
                            cmd.Parameters.AddWithValue("f4", form_data.f4);
                            cmd.Parameters.AddWithValue("f5", form_data.f5);
                            cmd.Parameters.AddWithValue("f6", form_data.f6);
                            cmd.Parameters.AddWithValue("f7", form_data.f7);

                            //cmd.Parameters.AddWithValue("deviceid", forms_data.deviceid);
                            //cmd.Parameters.AddWithValue("endingdatetime", forms_data.endingdatetime);
                            //cmd.Parameters.AddWithValue("gpsacc", forms_data.gpsacc);
                            //cmd.Parameters.AddWithValue("gpsdate", forms_data.gpsdate);
                            //cmd.Parameters.AddWithValue("gpslat", forms_data.gpslat);
                            //cmd.Parameters.AddWithValue("gpslng", forms_data.gpslng);
                            //cmd.Parameters.AddWithValue("istatus", forms_data.istatus);
                            //cmd.Parameters.AddWithValue("istatus96x", forms_data.istatus96x);
                            //cmd.Parameters.AddWithValue("sysdate", forms_data.sysdate);
                            //cmd.Parameters.AddWithValue("tagid", forms_data.tagid);
                            //cmd.Parameters.AddWithValue("username", forms_data.username);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("SUCCESS!", "Form saved!");

                        
                    }

                    con.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR!", "Form was not saved. " + "\n" + e.Message);
                }
            }
        }


        //public List<form_data> GetAllForms()
        //{
        //    List<form_data> fdList = new List<form_data>();


        //    con.Open();
        //    using (var cmd = con.CreateCommand())
        //    {
        //        cmd.CommandText = @"SELECT * from forms";
        //        SqliteDataReader r = cmd.ExecuteReader();
        //        while (r.Read())
        //        {
        //            form_data fd = new form_data();
        //            fd._id = r["_id"].ToString();
        //            fd._uid = r["_uid"].ToString();
        //            fd.appversion = r["appversion"].ToString();
        //            fd.cr01 = r["cr01"].ToString();
        //            fd.cr02 = r["cr02"].ToString();
        //            fd.cr03 = r["cr03"].ToString();
        //            fd.cr04 = r["cr04"].ToString();
        //            fd.cr05 = r["cr05"].ToString();
        //            fd.cr06 = r["cr06"].ToString();
        //            fd.cr07 = r["cr07"].ToString();
        //            fd.cr08d = r["cr08d"].ToString();
        //            fd.cr08m = r["cr08m"].ToString();
        //            fd.cr08y = r["cr08y"].ToString();
        //            fd.cr09 = r["cr09"].ToString();
        //            fd.cr10 = r["cr10"].ToString();
        //            fd.cr11 = r["cr11"].ToString();
        //            fd.cr12 = r["cr12"].ToString();
        //            fd.cr13 = r["cr13"].ToString();
        //            fd.cr14d = r["cr14d"].ToString();
        //            fd.cr15m = r["cr15m"].ToString();
        //            fd.cr15y = r["cr15y"].ToString();
        //            fd.cr16 = r["cr16"].ToString();
        //            fd.cr17 = r["cr17"].ToString();
        //            fd.cr18 = r["cr18"].ToString();
        //            fd.cr19 = r["cr19"].ToString();
        //            fd.cr20 = r["cr20"].ToString();
        //            fd.cr21 = r["cr21"].ToString();
        //            fd.cr22 = r["cr22"].ToString();
        //            fd.cr23 = r["cr23"].ToString();
        //            fd.cr24a = r["cr24a"].ToString();
        //            fd.cr24b = r["cr24b"].ToString();
        //            fd.cr24c = r["cr24c"].ToString();
        //            fd.cr24d = r["cr24d"].ToString();
        //            fd.cr24e = r["cr24e"].ToString();
        //            fd.cr24f = r["cr24f"].ToString();
        //            fd.cr25 = r["cr25"].ToString();
        //            fd.cr26 = r["cr26"].ToString();
        //            fd.cr27a = r["cr27a"].ToString();
        //            fd.cr27b = r["cr27b"].ToString();
        //            fd.cr27c = r["cr27c"].ToString();
        //            fd.cr28a = r["cr28a"].ToString();
        //            fd.cr28b = r["cr28b"].ToString();
        //            fd.cr28c = r["cr28c"].ToString();
        //            fd.cr28d = r["cr28d"].ToString();
        //            fd.cr28e = r["cr28e"].ToString();
        //            fd.cr28f = r["cr28f"].ToString();
        //            fd.cr28fx = r["cr28fx"].ToString();
        //            fd.deviceid = r["deviceid"].ToString();
        //            fd.endingdatetime = r["endingdatetime"].ToString();
        //            fd.gpsacc = r["gpsacc"].ToString();
        //            fd.gpsdate = r["gpsdate"].ToString();
        //            fd.gpslat = r["gpslat"].ToString();
        //            fd.gpslng = r["gpslng"].ToString();
        //            fd.istatus = r["istatus"].ToString();
        //            fd.istatus96x = r["istatus96x"].ToString();
        //            fd.sysdate = r["sysdate"].ToString();
        //            fd.tagid = r["tagid"].ToString();
        //            fd.username = r["username"].ToString();



        //            fdList.Add(fd);

        //        }
        //    }

        //    con.Close();

        //    return fdList;
        //}
        ////////////////////////////////////////////////////////////////////////////////////////////
        //                                   SQLite Database
        ////////////////////////////////////////////////////////////////////////////////////////////


        public static void InsertRecords(long last_sync_value, string last_retrieved_change_file)
        {
            //SQLiteConnection.CreateFile("SyncInfoDatabase.sqllite");
            string sql = @"INSERT INTO SyncInformation(timestamp, last_sync_value, last_retrieved_change_file, status) values ('" +
                    DateTime.UtcNow.ToString() + "', " + last_sync_value.ToString() + ", '" + last_retrieved_change_file + "', 'CREATED')";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();


            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static string SelectNextUploadedFile()
        {
            string Change_captureFile = "";
            //SQLiteConnection.("SyncInfoDatabase.sqllite");
            string sql = @"SELECT last_retrieved_change_file FROM SyncInformation where status = 'CREATED' order by datetime(timestamp) LIMIT 1";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            object tempval = cmd.ExecuteScalar();
            if (tempval != null)
            {
                Change_captureFile = Convert.ToString(tempval);
                Console.WriteLine($"File To Upload -> {Change_captureFile}");
            }

            else
                Console.WriteLine($"No Files To Upload ");
            con.Close();
            return Change_captureFile;
        }
        public static long SelectLastSyncVersion()
        {
            long last_sync_version = 0;
            //SQLiteConnection.CreateFile("SyncInfoDatabase.sqllite");
            string sql = @"SELECT max(last_sync_value) as last_sync_version FROM SyncInformation";
            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            object tempval = cmd.ExecuteScalar();
            if (tempval.GetType() != typeof(DBNull))
                last_sync_version = Convert.ToInt64(tempval);
            con.Close();
            Console.WriteLine($"Last Sync Version -> {last_sync_version}");
            return last_sync_version;
        }
        public static void UpdateRecords(string last_retrieved_change_file_value)
        {
            //SQLiteConnection.CreateFile("SyncInfoDatabase.sqllite");
            string sql = @"Update SyncInformation set status = 'Uploaded' where last_retrieved_change_file = '" + last_retrieved_change_file_value + "'";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static string[] GetFilesToDelete()
        {
            List<string> filestodelete = new List<string>();
            //SQLiteConnection.("SyncInfoDatabase.sqllite");
            string sql = @"SELECT last_retrieved_change_file FROM SyncInformation where status = 'Uploaded' order by datetime(timestamp)";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                filestodelete.Add(Convert.ToString(reader["last_retrieved_change_file"]));
            }
            con.Close();
            return filestodelete.ToArray();
        }

        public static void DeleteEntryFromDatabase(string filename)
        {
            string sql = @"Delete  FROM SyncInformation where status = 'Uploaded' and last_retrieved_change_file = '" + filename + "'";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
        }



    
        public void get_villages()
        {

            try
            {


                using (con)
                {
                    try
                    {
                        con.Open();


                        using (var cmd = con.CreateCommand())
                        {

                            cmd.CommandText = "Delete from villages";


                            cmd.ExecuteNonQuery();


                        }

                        con.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("ERROR!", "Form was not saved. " + "\n" + e.Message);
                    }
                }





                using (con)
                {
                    try
                    {
                        con.Open();


                        using (var cmd = con.CreateCommand())
                        {
                            //for (int a = 0; a <= d_user_obj.Count - 1; a++)
                            //{
                            //    cmd.CommandText = "insert into users(username,password,full_name)  values('" + d_user_obj[a].username + "','" + d_user_obj[a].password + "','" + d_user_obj[a].full_name + "')";


                            //    cmd.ExecuteNonQuery();

                            //}
                        }

                        con.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("ERROR!", "Form was not saved. " + "\n" + e.Message);
                    }
                }



            }
            catch (Exception ex)
            {

                if (ex.Message == "The remote name could not be resolved: 'f38158'")
                {
                    MessageBox.Show("Please Open Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }




        }




        public void insert_user(List<users> d_user_obj)
        {
           

            try
            {
               

                using (con)
                {
                    try
                    {
                        con.Open();


                        using (var cmd = con.CreateCommand())
                        {

                            cmd.CommandText = "Delete from users";


                            cmd.ExecuteNonQuery();


                        }

                        con.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("ERROR!", "Form was not saved. " + "\n" + e.Message);
                    }
                }





                using (con)
                {
                    try
                    {
                        con.Open();


                        using (var cmd = con.CreateCommand())
                        {
                            for (int a = 0; a <= d_user_obj.Count - 1; a++)
                            {
                                cmd.CommandText = "insert into users(username,password,full_name)  values('" + d_user_obj[a].username + "','" + d_user_obj[a].password + "','" + d_user_obj[a].full_name + "')";


                                cmd.ExecuteNonQuery();

                            }
                        }

                        con.Close();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("ERROR!", "Form was not saved. " + "\n" + e.Message);
                    }
                }



            }
            catch (Exception ex)
            {

                if (ex.Message == "The remote name could not be resolved: 'f38158'")
                {
                    MessageBox.Show("Please Open Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }


      

     







        //public List<district_data> GetDistrict()
        //{


        //    List<district_data> fdList = new List<district_data>() ;

            
        //    try
        //    {
        //        con.Open();
        //        using (var cmd = con.CreateCommand())
        //        {


        //            cmd.CommandText = "select * from villages where country_code = 2 group by district";
        //            r = cmd.ExecuteReader();

        //            district_data fd = new district_data();
        //            fd.district_code = "";
        //            fd.district = "";

        //            fdList.Add(fd);
        //            while (r.Read())
        //            {
        //                district_data f = new district_data();

        //                f.district_code = r["district_code"].ToString();
        //                f.district = r["district"].ToString();


        //                // 
        //                fdList.Add(f);

        //            }
        //            r.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return fdList;
        //}


        //public List<uc_data> GetUC(string dis)
        //{


        //    List<uc_data> fdList = new List<uc_data>();


        //    try
        //    {
        //        con.Open();
        //        using (var cmd = con.CreateCommand())
        //        {


        //            cmd.CommandText = "select * from villages  where district_code ='" + dis + "' group by uc";
        //            r = cmd.ExecuteReader();

        //            uc_data fd = new uc_data();
        //            fd.uc = "";
        //            fd.uc_code = "";
        //            fdList.Add(fd);
        //            while (r.Read())
        //            {
        //                uc_data f = new uc_data();

        //                f.uc_code = r["uc_code"].ToString();
        //                f.uc = r["uc"].ToString();


        //                // 
        //                fdList.Add(f);

        //            }
        //            r.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return fdList;
        //}

        //public List<village_data> GetVillage(string getvalue)
        //{


        //    List<village_data> fdList = new List<village_data>();


        //    try
        //    {
        //        con.Open();
        //        using (var cmd = con.CreateCommand())
        //        {


        //            cmd.CommandText = "select * from villages  where uc_code ='" + getvalue + "' group by village";
        //            r = cmd.ExecuteReader();

        //            village_data fd = new village_data();
        //            fd.villlage_code = "";
        //            fd.village = "";
        //            fdList.Add(fd);
        //            while (r.Read())
        //            {
        //                village_data f = new village_data();

        //                f.villlage_code = r["villlage_code"].ToString();
        //                f.village = r["village"].ToString();


        //                // 
        //                fdList.Add(f);

        //            }
        //            r.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return fdList;
        //}



        public List<users> GetUser()
        {


            List<users> fdList = new List<users>();


            try
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {


                    cmd.CommandText = "select * from users ";
                    r = cmd.ExecuteReader();

                   
                    while (r.Read())
                    {
                        users f = new users();

                        f.username = r["username"].ToString();
                        f.password = r["password"].ToString();
                        f.full_name = r["full_name"].ToString();


                        // 
                        fdList.Add(f);

                    }
                    r.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return fdList;
        }


        public List<forms_data> GetForms()
        {


            List<forms_data> froms = new List<forms_data>();


            try
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {


                    cmd.CommandText = "select * from forms ";
                    r = cmd.ExecuteReader();


                    while (r.Read())
                    {
                        forms_data f = new forms_data();

                        f.f1 = r["f1"].ToString();
                        f.f2 = r["f2"].ToString();
                        f.f3 = r["f3"].ToString();
                        f.f4 = r["f4"].ToString();
                        f.f5 = r["f5"].ToString();
                        f.f6 = r["f6"].ToString();
                        f.f7 = r["f7"].ToString();



                        // 
                        froms.Add(f);

                    }
                    r.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return froms;
        }

        public List<forms_data> UploadForms()
        {


            List<forms_data> froms = new List<forms_data>();


            try
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {


                    cmd.CommandText = "select * from forms ";
                    r = cmd.ExecuteReader();


                    while (r.Read())
                    {
                        forms_data f = new forms_data();
                        f._id = r["_id"].ToString();
                        f._uid = r["_uid"].ToString();
                        f.appversion = r["appversion"].ToString();
                        f.f1 = r["f1"].ToString();
                        f.f2 = r["f2"].ToString();
                        f.f3 = r["f3"].ToString();
                        f.f4 = r["f4"].ToString();
                        f.f5 = r["f5"].ToString();
                        f.f6 = r["f6"].ToString();
                        f.f7 = r["f7"].ToString();
                        f.deviceid = r["deviceid"].ToString();
                        f.endingdatetime = r["endingdatetime"].ToString();
                        f.gpsacc = r["gpsacc"].ToString();
                        f.gpsdate = r["gpsdate"].ToString();
                        f.gpslat = r["gpslat"].ToString();
                        f.gpslng = r["gpslng"].ToString();
                        f.istatus = r["istatus"].ToString();
                        f.istatus96x = r["istatus96x"].ToString();
                        f.sysdate = r["sysdate"].ToString();
                        f.tagid = r["tagid"].ToString();
                        f.username = r["username"].ToString();



                        // 
                        froms.Add(f);

                    }
                    r.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return froms;
        }
    }
}
