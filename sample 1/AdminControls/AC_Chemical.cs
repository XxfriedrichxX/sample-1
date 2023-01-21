using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_1.AdminControls
{
    public partial class AC_Chemical : UserControl
    {

        public AC_Chemical()
        {
            InitializeComponent();
        }

        private void SearchChembtn_Click_1(object sender, EventArgs e)
        {
            SearchChem Sc = new SearchChem();
            Sc.Show();

        }
    }
}
