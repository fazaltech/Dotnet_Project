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
        private SubFormSectionB subfrmB = new SubFormSectionB() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private SubFormSectionC subfrmC = new SubFormSectionC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
          
            this.pContainer.Controls.Add(subfrmB);
        
            subfrmB.FormBorderStyle= FormBorderStyle.None;

            subfrmB.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pContainer.Controls.Count >0 )
            {
                this.pContainer.Controls.Remove(subfrmB);
               
            }
            this.pContainer.Controls.Add(subfrmC);
            subfrmC.FormBorderStyle = FormBorderStyle.None;

            subfrmC.Show();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
