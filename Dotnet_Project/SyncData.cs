using Dotnet_Project.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace Dotnet_Project
{
    class SyncData
    {

        private SQLiteDatabase db = new SQLiteDatabase();

        public void download_user()

        {
            List<users> d_user_obj = new List<users>();
            try
            {
                // System.Diagnostics.Debug.WriteLine("user start");



                var user_var = "{";
                user_var += "\"table\":\"users\",";
                user_var += "\"check\":\"users\"";
                user_var += "}";



                HttpWebRequest webRequest;

                string requestParams = user_var.ToString();

                webRequest = (HttpWebRequest)WebRequest.Create("http://f38158/casi_gm/api/getdata.php");

                webRequest.Method = "POST";
                webRequest.UserAgent = "POST";
                webRequest.ContentType = "application/json";

                byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
                webRequest.ContentLength = byteArray.Length;
                Stream requestStream = webRequest.GetRequestStream();

                requestStream.Write(byteArray, 0, byteArray.Length);


                // Get the response.
                WebResponse response = webRequest.GetResponse();

                Stream responseStream = response.GetResponseStream();

                StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
                string Json = rdr.ReadToEnd(); // response from server
                d_user_obj = JsonConvert.DeserializeObject<List<users>>(Json);


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



            finally
            {
                db.insert_user(d_user_obj);
                MessageBox.Show("Data Download", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void upload_forms()
        {
            List<forms_data> datas = new List<forms_data>();
            datas = db.UploadForms();
            int total=datas.Count;
            if (datas.Any())
            {
                var data_obj = JsonConvert.SerializeObject(datas);


                var table_var = "[{\"table\":\"forms\", \"check\":\"users\"}, " + data_obj + "]";

                string requestParams = table_var.ToString();
                HttpWebRequest webRequest;



                webRequest = (HttpWebRequest)WebRequest.Create("http://f38158/casi_gm/api/sync.php");

                webRequest.Method = "POST";
                webRequest.UserAgent = "POST";
                webRequest.ContentType = "application/json";


                //  byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    streamWriter.Write(requestParams);
                }



                dynamic result = "";

                var httpResponse = (HttpWebResponse)webRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }








                var message = JsonConvert.DeserializeObject<List<Item>>(result);

                var errormeg = "";
                var statusmessage = "";

                int errcount = 0;
                int statuscount = 0;
                int dupliatecount = 0;
                string id;
                List<string> errormsg=new List<string>();
                var displaymessage = "";
                try
                {

                    foreach (var item in message)
                    {

                        

                        errormeg = item.error;
                        statusmessage = item.status;


                        if (errormeg == "1")
                        {
                            errcount++;
                            errormsg.Add("ID: "+item.id+ " : " +item.message);

                        }

                        if (statusmessage == "1")
                        {
                            statuscount++;
                            id =item.id;

                            db.update_status(Int16.Parse(id));
                        }
                        if (statusmessage == "2")
                        {
                            dupliatecount++;
                            id = item.id;

                            db.update_status(Int16.Parse(id));
                        }



                    }
                    displaymessage = "\n  Total:" + total + "\n  Duplicate:" + dupliatecount + "\n  Successfull:" + statuscount + "\n  Error:" + errcount;
                    foreach (var errtext in errormsg) { 
                    displaymessage += "\n"+errtext;
                    }
                    MessageBox.Show("Data Upload" + displaymessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Upload Failed" + ex + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }





                //if (result == null)
                //{
                //    MessageBox.Show("Data Upload" + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    db.Del_Forms();
                //}
                //else
                //{
                //    MessageBox.Show("Data Upload Failed" + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}


            }
            else {
                MessageBox.Show("No new record upload" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public class Class1
        {
            public string error { get; set; }

        }



        public class RootObject
        {
            public List<Item> response { get; set; }
        }
        public class Item
        {
            public string error { get; set; }
            public string message { get; set; }
            public string status { get; set; }
            public string id { get; set; }
        }



    }
}
