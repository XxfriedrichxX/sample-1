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
    public partial class AC_Apparatus : UserControl
    {
        DataTable dt;
        public AC_Apparatus()
        {
            InitializeComponent();
        }
        public SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-CSV670JQ\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True");
        private void AC_Apparatus_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
        }

        private void AddAppbtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("addAppartus", Conn);
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.AddWithValue("@Appratus_ID", int.Parse(AppIDtextbox.Text));
            Com.Parameters.AddWithValue("@Appratus_Name", AppNametxt.Text);
            Com.Parameters.AddWithValue("@SerialNumber", int.Parse(SerialNumber.Text));
            Com.Parameters.AddWithValue("@CustodianName", Custodiantxt.Text);
            
            Com.ExecuteNonQuery();
            Conn.Close();
            LoadAllRecords();
            MessageBox.Show("Added Succesfully");
        }
        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.viewApparatus", Conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            ApparatusTable.DataSource = dt;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlCommand Com = new SqlCommand("updateApparatus", Conn);
            Com.CommandType = CommandType.StoredProcedure;
            Com.Parameters.AddWithValue("@Appratus_ID", int.Parse(AppIDtextbox.Text));
            Com.Parameters.AddWithValue("@Appratus_Name", AppNametxt.Text);
            Com.Parameters.AddWithValue("@SerialNumber", int.Parse(SerialNumber.Text));
            Com.Parameters.AddWithValue("@CustodianName", Custodiantxt.Text);

            Com.ExecuteNonQuery();
            Conn.Close();
            LoadAllRecords();
            MessageBox.Show("Update Succesfully");
        }

        private void ApparatusTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ApparatusTable.Rows[e.RowIndex];
                AppIDtextbox.Text = row.Cells["Appratus_ID"].Value.ToString();
                AppNametxt.Text = row.Cells["Appratus_Name"].Value.ToString();
                SerialNumber.Text = row.Cells["SerialNumber"].Value.ToString();
                Custodiantxt.Text = row.Cells["CustodianName"].Value.ToString();
                
            }
        }
    }
}
