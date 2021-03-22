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



            var result = "";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }


            if (result == null)
            {
                MessageBox.Show("Data Upload", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Upload Failed" + result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
