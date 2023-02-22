using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_1
{
    public partial class DisposeChem : Form
    {
        public DisposeChem()
        {
            InitializeComponent();

        }
        public SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-CSV670JQ\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True");
        disposeDataContext db = new disposeDataContext();
        private void DisChembtn_Click(object sender, EventArgs e)
        {
            var st = new disposeChemical_tab
            {
                Chemical_ID = int.Parse(ChemIDtextbox.Text),
                dateAndTime = DateTime.Parse(dateandtime.Text),
            };
            db.disposeChemical_tabs.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Dispose Succesfully");
            LoadDispose();
        
    }
        void LoadDispose()
        {
            var st = from s in db.chemical_tabs join o in db.disposeChemical_tabs on s.Chemical_ID equals o.Chemical_ID select new { s.Chemical_ID, s.Chemical_Name, s.amount, s.unit, s.chemical_Type, s.expiryDate, s.DateAndTime, o.dateAndTime };
            chemicalTable.DataSource = st;
        }

        private void ChemIDtextbox_TextChanged(object sender, EventArgs e)
        {
            if (ChemIDtextbox.Text !="")
            {
                var chemExist = from s in db.chemical_tabs where s.Chemical_ID == int.Parse(ChemIDtextbox.Text) select s.Chemical_ID;
                if (chemExist.Count()>0)
                {
                    var Chemname = (from s in db.chemical_tabs where s.Chemical_ID == int.Parse(ChemIDtextbox.Text) select s).First();
                    chemNametextbox.Text = Chemname.Chemical_Name;
                }
                else
                {
                    chemNametextbox.Text = "Not found";
                }
            }
            else
            {
                chemNametextbox.Text = "";
            }
        }

        private void DisposeChem_Load(object sender, EventArgs e)
        {
            LoadDispose();
        }
    }
}
