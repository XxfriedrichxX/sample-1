using sample_1.AdminControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_1
{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();
            AC_Dash AC = new AC_Dash();
            addAdminControls(AC);

        }

    

        private void logout_Click(object sender, EventArgs e)
        {
            //transition to another form
            new Form1().Show();
            this.Hide();
        }

       

       



       
        

        private void addAdminControls(UserControl adminControl)
        {
            adminControl.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(adminControl);
            adminControl.BringToFront();
        }
        private void Homebtn_Click_1(object sender, EventArgs e)
        {
            AC_Dash AC = new AC_Dash();
            addAdminControls(AC);

        }

        private void Chemicalbtn_Click_2(object sender, EventArgs e)
        {
            AC_Chemical AC = new AC_Chemical();
            addAdminControls(AC);
        }

        private void Supplierbtn_Click_1(object sender, EventArgs e)
        {
            AC_Supplier AC = new AC_Supplier();
            addAdminControls(AC);
        }

        private void Apparatusbtn_Click_1(object sender, EventArgs e)
        {
            AC_Apparatus AC = new AC_Apparatus();
            addAdminControls(AC);
        }

        private void Formbtn_Click_1(object sender, EventArgs e)
        {
            AC_Form AC = new AC_Form();
            addAdminControls(AC);
        }

        private void Guidelinebtn_Click_1(object sender, EventArgs e)
        {
            AC_Guideline AC = new AC_Guideline();
            addAdminControls(AC);
        }

        private void Certificatebtn_Click_1(object sender, EventArgs e)
        {
            AC_Certificate AC = new AC_Certificate();
            addAdminControls(adminControl: AC);
        }
    }
}
