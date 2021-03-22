using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dotnet_Project.Model
{
    class DataVariables
    {


        static Form formLogin;
        static Form formData;
        static Form formtable;

        static string username;


        public static Form Form_Login
        {
            get
            {
                return formLogin;
            }

            set
            {
                formLogin = value;
            }
        }


        public static Form Form_Data
        {
            get
            {
                return formData;
            }

            set
            {
                formData = value;
            }
        }


        public static string User_Name
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }


        public static Form Form_Table
        {
            get
            {
                return formtable;
            }

            set
            {
                formtable = value;
            }
        }

    }
}
