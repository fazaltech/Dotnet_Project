using Dotnet_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dotnet_Project
{
    public partial class Form_Data : Form
    {
        public Form_Data()
        {
            InitializeComponent();
            dateTime_dob.MaxDate = DateTime.Today;
            control_value();
        }

        private void text_childname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void text_fathername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public string f1 = "-1";
        public string f2 = "-1";
        public string f3 = "-1";
        public string f4 = "-1";
        public string f5 = "-1";
        public string f6 = "-1";
        public string f7 = "-1";

        public void control_value()
        {
            
            if (text_childname != null) { f1 = text_childname.Text; }
            if (text_fathername != null) { f2 = text_fathername.Text; }
            if (radio_gender1.Checked) { f4 = "1"; } else if (radio_gender2.Checked) { f4 = "2"; }
            if (text_mauc != null) { f5 = text_mauc.Text; } 
            if (text_height != null) { f6 = text_height.Text; } 
            if (text_weight != null) { f7 = text_weight.Text; } 
        



        }

        public bool validation()
        {

            if (text_childname.Text == "")
            {

                errorProvider1.SetError(text_childname, "Please Enter Child Name.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }


            if (text_fathername.Text == "")
            {

                errorProvider1.SetError(text_fathername, "Please Enter Father Name.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }


            if (radio_gender1.Checked != true && radio_gender2.Checked != true)
            {

                errorProvider1.SetError(groupBox2, "Please Select Gender");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }


            if (!text_mauc.MaskFull)
            {

                errorProvider1.SetError(text_mauc, "Please Enter MAUC.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (!text_height.MaskFull)
            {

                errorProvider1.SetError(text_height, "Please Enter Height.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (!text_weight.MaskFull)
            {

                errorProvider1.SetError(text_weight, "Please Enter Weight.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            float mauc;
            if (float.TryParse(text_mauc.Text, out mauc))
            {
                if (mauc <= 05.0 || mauc >= 25.0)
                {
                    errorProvider1.SetError(text_mauc, "Value Between 05.0 and 25.0 ");
                    return false;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
            float height;
            if (float.TryParse(text_height.Text, out height))
            {
                if (height <= 010.0 || height >= 140.0)
                {
                    errorProvider1.SetError(text_height, "Value Between 10.0 and 140.0");
                    return false;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
            float weight;
            if (float.TryParse(text_weight.Text, out weight))
            {
                if (weight <= 00.5 || weight >= 40.0)
                {
                    errorProvider1.SetError(text_weight, "Value Between 00.5 and 40.0 ");
                    return false;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
          
            return true;
        }

        public void Insert_Form()
        {
            control_value();
            forms_data fr = new forms_data();

            fr.f1 = f1;
            fr.f2 = f2;
            fr.f3 = dateTime_dob.Value.ToString("MM/dd/yyyy");
            fr.f4 = f4;
            fr.f5 = f5;
            fr.f6 = f6;
            fr.f7 = f7;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validation())
            {


            }
        }
    }

}
