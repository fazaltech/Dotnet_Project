using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dotnet_Project.Model;

namespace Dotnet_Project
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

            
            btnlogin.FlatStyle = FlatStyle.Flat;
           
        }
        private SyncData sy = new SyncData();
        private SQLiteDatabase db = new SQLiteDatabase();
        private users urs = new users();
        private void btn_download_Click(object sender, EventArgs e)
        {
            sy.download_user();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (user_name.Text == "test1234" && user_password.Text == "test1234")
            {


                DataVariables.User_Name = user_name.Text;
                DataVariables.Form_Login = this;
             
                this.Hide();
                //Form_Data obj_main = new Form_Data();
                //obj_main.Show();

               FormMain form_main = new FormMain();
                form_main.Show();

            }
            else if (user_name.Text == "dmu@aku" && user_password.Text == "aku?dmu")
            {


                DataVariables.User_Name = user_name.Text;
                DataVariables.Form_Login = this;

                this.Hide();
                Form_Data obj_main = new Form_Data();
                obj_main.Show();

            }
            else if (user_name.Text != null && user_password.Text != null)
            {


                urs.username = user_name.Text;
                urs.password = user_password.Text;

                if (IsValid(urs.username, urs.password))
                {
                    DataVariables.User_Name = user_name.Text;
                    DataVariables.Form_Login = this;
                    this.Hide();
                    Form_Data obj_main = new Form_Data();
                    obj_main.Show();

                }
                else
                {
                    MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_name.Focus();
                }
            }
        }


        private bool IsValid(string username, string passwords)
        {

            bool IsValid = false;

            


            List<users> datas = new List<users>();
            datas = db.GetUser();

            var usernames = datas.FirstOrDefault(u => u.username == username);


            if (usernames != null)
            {
                if (usernames.password == passwords)
                {
                    IsValid = true;
                }
            }

            return IsValid;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            sy.upload_forms();
        }
    }
}
