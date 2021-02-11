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
        }
        private SQLiteDatabase db = new SQLiteDatabase();
        private users urs = new users();
        private void btn_download_Click(object sender, EventArgs e)
        {
            db.download_user();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (user_name.Text == "test1234" && user_password.Text == "test1234")
            {


                DataVariables.User_Name = user_name.Text;
                DataVariables.Form_Login = this;
                MessageBox.Show("User exist ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // this.Hide();
                // frm_main obj_main = new frm_main();
                //obj_main.Show();

            }
            else if (user_name.Text != null && user_password.Text != null)
            {


                urs.username = user_name.Text;
                urs.password = user_password.Text;

                if (IsValid(urs.username, urs.password))
                {
                    DataVariables.User_Name = user_name.Text;
                    DataVariables.Form_Login = this;
                   // this.Hide();
                    //frm_main obj_main = new frm_main();
                    //obj_main.Show();
                    MessageBox.Show("User exist ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
