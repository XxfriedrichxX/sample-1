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

namespace sample_1.AdminControls
{
    public partial class AC_Chemical : UserControl
    {
        DataTable dt;
        public AC_Chemical()
        {
            InitializeComponent();
            LoadAllRecords();
            
        }

        public SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-CSV670JQ\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True");
        

        private void AddChembtn_Click(object sender, EventArgs e)
        {

            Conn.Open();
            SqlCommand Com = new SqlCommand("addchemicals", Conn);
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
            LoadAllRecords();
            MessageBox.Show("Added Succesfully");
        }

        private void DisChembtn_Click(object sender, EventArgs e)
        {
            DisposeChem DisChem = new DisposeChem();
            DisChem.Show();
        }
        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.viewChemical", Conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            chemicalTable.DataSource = dt;
        }

        private void AC_Chemical_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }

        private void UpdateChembtn_Click(object sender, EventArgs e)
        {

            Conn.Open();
            SqlCommand com = new SqlCommand("updatechemical", Conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Chemical_ID", int.Parse(ChemIDtextbox.Text));
            com.Parameters.AddWithValue("@Chemical_Name", chemNametextbox.Text);
            com.Parameters.AddWithValue("@amount", decimal.Parse(amounttextbox.Text));
            com.Parameters.AddWithValue("@unit", unittextbox.Text);
            com.Parameters.AddWithValue("@chemical_Type", chemicaltypetextbox.Text);
            com.Parameters.AddWithValue("@expiryDate", DateTime.Parse(expirydate.Text));
            com.Parameters.AddWithValue("@DateAndTime", DateTime.Parse(dateandtime.Text));
            com.ExecuteNonQuery();
            Conn.Close();
            LoadAllRecords();
            MessageBox.Show("Update Succesfully");

        }

        private void chemicalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.chemicalTable.Rows[e.RowIndex];
                ChemIDtextbox.Text = row.Cells["Chemical_ID"].Value.ToString();
                chemNametextbox.Text = row.Cells["Chemical_Name"].Value.ToString();
                amounttextbox.Text = row.Cells["amount"].Value.ToString();
                unittextbox.Text = row.Cells["unit"].Value.ToString();
                chemicaltypetextbox.Text = row.Cells["chemical_Type"].Value.ToString();
                expirydate.Text = row.Cells["expiryDate"].Value.ToString();
                dateandtime.Text = row.Cells["dateandtime"].Value.ToString();
            }
        }

        private void chemNametextbox_TextChanged(object sender, EventArgs e)
        {
            /*
            Conn.Open();
            DataView chemView = new DataView(dt);
            chemView.RowFilter = string.Format("Chemical_Name LIKE '%{0}%'", chemNametextbox.Text);
            chemicalTable.DataSource = chemView;
            Conn.Close();*/
        }

        private void Searchbar_TextChanged(object sender, EventArgs e)
        {
            DataView chemView = new DataView(dt);
            chemView.RowFilter = String.Format("Chemical_Name LIKE '%{0}%'", Searchbar.Text);
            chemicalTable.DataSource = chemView;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("deleteChemical", Conn);
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.AddWithValue("@Chemical_Name", chemNametextbox.Text);
            Com.ExecuteNonQuery();
            Conn.Close();
            LoadAllRecords();
            MessageBox.Show("Deleted Succesfully");
        }

        
    }
}
