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
        DataTable dt;
        private void DisChembtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("dispose", Conn);
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.AddWithValue("@Chemical_ID", int.Parse(ChemIDtextbox.Text));
            Com.Parameters.AddWithValue("@Chemical_Name", chemNametextbox.Text);
            Com.Parameters.AddWithValue("@amount", decimal.Parse(amounttextbox.Text));
            Com.Parameters.AddWithValue("@unit", unittextbox.Text);
            Com.Parameters.AddWithValue("@chemical_Type", chemicaltypetextbox.Text);
            Com.Parameters.AddWithValue("@expiryDate", DateTime.Parse(expirydate.Text));
            Com.Parameters.AddWithValue("@DateAndTime", DateTime.Parse(dateandtime.Text));
            Com.ExecuteNonQuery();
            Conn.Close();
            LoadDispose();
            MessageBox.Show("Dispose Recorded");

        }
        void LoadDispose()
        {
            SqlCommand com = new SqlCommand("exec dbo.viewDispose", Conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chemicalTable.DataSource = dt;
        }

        private void ChemIDtextbox_TextChanged(object sender, EventArgs e)
        {
            DataView chemView = new DataView(dt);
            chemView.RowFilter = String.Format("Chemical_ID LIKE '%{0}%'", ChemIDtextbox.Text);
            chemicalTable.DataSource = chemView;
        }

        private void DisposeChem_Load(object sender, EventArgs e)
        {
            LoadDispose();
        }
    }
}
