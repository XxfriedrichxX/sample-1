using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace sample_1
{
    public partial class Forms2 : Form
    {

        
        DataTable dt;
        DataTable gd;

        public Forms2()
        {
            InitializeComponent();
        }
        public SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-CSV670JQ\SQLEXPRESS;Initial Catalog=inventory_db;Integrated Security=True");
        private void Addbtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("updatechemical", Conn);
            com.CommandType = CommandType.StoredProcedure;
            int stock = 0;
            int borrow = 0;
            int result = 0;

            stock = Convert.ToInt32(amounnttxt.Text);
            borrow = Convert.ToInt32(borrowtxt.Text);

            result = stock - borrow;
            Conn.Open();
            com.Parameters.AddWithValue("@Chemical_ID", int.Parse(ChemIDtextbox.Text));
            com.Parameters.AddWithValue("@Chemical_Name", chemNametxt.Text);
            com.Parameters.AddWithValue("@amount", result);
            com.Parameters.AddWithValue("@unit", unittxt.Text);
            com.Parameters.AddWithValue("@chemical_Type", chemicaltypetextbox.Text);
            com.Parameters.AddWithValue("@expiryDate", DateTime.Parse(expirydate.Text));
            com.Parameters.AddWithValue("@DateAndTime", DateTime.Parse(dateandtime.Text));
            com.ExecuteNonQuery();
            Conn.Close();
            LoadAllRecords();


        }




        void LoadAllRecords()
        {
            SqlCommand com = new SqlCommand("exec dbo.viewChemical", Conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            chemicalTable.DataSource = dt;
        }

        private void Forms2_Load(object sender, EventArgs e)
        {
            // Set the text of the label to the value of the Username property
            LoadAllRecords();
            GetData();
        }

        private void chemicalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.chemicalTable.Rows[e.RowIndex];
                ChemIDtextbox.Text = row.Cells["Chemical_ID"].Value.ToString();
                chemNametxt.Text = row.Cells["Chemical_Name"].Value.ToString();
                amounnttxt.Text = row.Cells["amount"].Value.ToString();
                unittxt.Text = row.Cells["unit"].Value.ToString();
                chemicaltypetextbox.Text = row.Cells["Chemical_Type"].Value.ToString();
                expirydate.Text = row.Cells["expiryDate"].Value.ToString();
                dateandtime.Text = row.Cells["DateAndTime"].Value.ToString();
            }

        }

        private void chemNametxt_TextChanged(object sender, EventArgs e)
        {
            /*
            Conn.Close();
            Conn.Open();
            DataView chemView = new DataView(dt);
            chemView.RowFilter = string.Format("Chemical_Name LIKE '%{0}%'", chemNametxt.Text);
            chemicalTable.DataSource = chemView;
            Conn.Close();*/
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            arr[0] = chemNametxt.Text;
            arr[1] = borrowtxt.Text;
            arr[2] = unittxt.Text;

            ListViewItem listItems = new ListViewItem(arr);
            listView1.Items.Add(new ListViewItem(arr));
        }

        private void Searchbar_TextChanged(object sender, EventArgs e)
        {
            DataView chemView = new DataView(dt);
            chemView.RowFilter = String.Format("Chemical_Name LIKE '%{0}%'", Searchbar.Text);
            chemicalTable.DataSource = chemView;
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count;)
            {
                if (listView1.SelectedItems[i].Selected)
                    listView1.SelectedItems[i].Remove();
            }
        }

        private void Apparatustab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Apparatustab.Rows[e.RowIndex];
                AppIDtextbox.Text = row.Cells["Appratus_ID"].Value.ToString();
                AppNametxt.Text = row.Cells["Appratus_Name"].Value.ToString();
                SerialNumber.Text = row.Cells["SerialNumber"].Value.ToString();
                Custodiantxt.Text = row.Cells["CustodianName"].Value.ToString();

            }
        }
        void GetData()
        {
            SqlCommand com = new SqlCommand("exec dbo.viewApparatus", Conn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            gd = new DataTable();
            da.Fill(gd);
            Apparatustab.DataSource = gd;
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            SqlCommand Com = new SqlCommand("updateApparatus", Conn);
            Com.CommandType = CommandType.StoredProcedure;
            int stock = 0;
            int borrow = 0;
            int result = 0;

            stock = Convert.ToInt32(amounnttxt.Text);
            borrow = Convert.ToInt32(borrowtxt.Text);

            result = stock - borrow;
            Conn.Open();
            Com.Parameters.AddWithValue("@Appratus_ID", int.Parse(AppIDtextbox.Text));
            Com.Parameters.AddWithValue("@Appratus_Name", AppNametxt.Text);
            Com.Parameters.AddWithValue("@SerialNumber", int.Parse(SerialNumber.Text));
            Com.Parameters.AddWithValue("@CustodianName", Custodiantxt.Text);
            Com.ExecuteNonQuery();
            Conn.Close();
            GetData();
        }

        private void inputbutton_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            arr[0] = AppNametxt.Text;
            arr[1] = borrowtextbox.Text;

            ListViewItem listItems = new ListViewItem(arr);
            listView2.Items.Add(new ListViewItem(arr));
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView2.SelectedItems.Count;)
            {
                if (listView2.SelectedItems[i].Selected)
                    listView2.SelectedItems[i].Remove();
            }
        }

        private void chemicaltypetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            RequisiteReport report = new RequisiteReport();
            PrintForms2 print = new PrintForms2();
            report.SetParameterValue("Borrower", NameBorrowertxt.Text);
            report.SetParameterValue("subject", Subjecttxt.Text);
            report.SetParameterValue("course", Sectiontxt.Text);
            report.SetParameterValue("DateTime", needtxt.Text);
            report.SetParameterValue("Activity", activitytxt.Text);
            List<string> nonConsumableItemsList = new List<string>();
            foreach (ListViewItem item in listView2.Items)
            {
                string itemString = string.Join("  ", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text));
                nonConsumableItemsList.Add(itemString);
            }
            string nonConsumableItems = string.Join(Environment.NewLine, nonConsumableItemsList);

            List<string> consumableItemsList = new List<string>();
            foreach (ListViewItem item in listView1.Items)
            {
                string itemString = string.Join("  ", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text));
                consumableItemsList.Add(itemString);
            }
            string consumableItems = string.Join(Environment.NewLine, consumableItemsList);

            report.SetParameterValue("NonConsumable", nonConsumableItems);
            report.SetParameterValue("Consumable", consumableItems);
            report.SetParameterValue("instructor", instructortxt.Text);
            report.SetParameterValue("technician", techniciantxt.Text);
            report.SetParameterValue("return", returntxt.Text);
            // Set username and current date parameters
            report.SetParameterValue("User", label20.Text);
            report.SetParameterValue("Date", DateTime.Now.ToShortDateString());
            print.crystalReportViewer1.ReportSource = report;
            print.Show();

        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            /*// Create a new ReportDocument
            ReportDocument report = new ReportDocument();

            // Load the report file
            string reportPath = @"C:\path\to\MyReport.rpt";

            if (File.Exists(reportPath))
            {
                report.Load(reportPath);
            }
            else
            {
                Console.WriteLine("Report file not found.");
            }
            report.Load("MyReport.rpt");

            // Export the report to a file
            string reportTitle = "MyReport";
            string reportFileName = string.Format("{0}_{1}.pdf", DateTime.Now.ToString("yyyyMMddHHmmss"), reportTitle);
            report.ExportToDisk(ExportFormatType.PortableDocFormat, reportFileName);

            // Save the report data to the database
            

            SqlCommand cmd = new SqlCommand("INSERT INTO ReportTable (ReportFileName, ReportDateTime) VALUES (@ReportFileName, @ReportDateTime)", Conn);
            cmd.Parameters.AddWithValue("@ReportFileName", reportFileName);
            cmd.Parameters.AddWithValue("@ReportDateTime", DateTime.Now);
            Conn.Open();
            cmd.ExecuteNonQuery();
            Conn.Close();*/
        }
    }
}
