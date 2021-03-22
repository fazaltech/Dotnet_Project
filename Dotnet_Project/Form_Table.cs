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
    public partial class Form_Table : Form
    {
        private SQLiteDatabase db = new SQLiteDatabase();
        public Form_Table()
        {
            InitializeComponent();
        }



        public void form_view()
        {
            try
            {



               
                List<forms_data> datas = new List<forms_data>();
                datas = db.GetForms();

                data_grid.DataSource = datas;




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void user_view()
        {
            try
            {




                List<users> datas = new List<users>();
                datas = db.GetUser();

                data_grid.DataSource = datas;




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_form_Click(object sender, EventArgs e)
        {
            form_view();
        }

        private void data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btn_villages_Click(object sender, EventArgs e)
        {

        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            user_view();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DataVariables.Form_Table = this;
            this.Hide();

            Form_Login ft = new Form_Login();
            ft.Show();
        }
    }
}
