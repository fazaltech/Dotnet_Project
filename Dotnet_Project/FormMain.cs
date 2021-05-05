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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //SubFormAdministrativeInformation subfrmAdminInfo = new SubFormAdministrativeInformation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            SubFormTemplate subfrmAdminInfo = new SubFormTemplate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(subfrmAdminInfo);
            pContainer.AutoScrollMinSize = new Size(0, subfrmAdminInfo.Height);
            subfrmAdminInfo.FormBorderStyle = FormBorderStyle.None;
            subfrmAdminInfo.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
