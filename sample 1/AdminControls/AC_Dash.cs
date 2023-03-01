using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_1.AdminControls
{
    public partial class AC_Dash : UserControl
    {
        private string folderPath;

        public AC_Dash()
        {
            InitializeComponent();
        }

        private void AC_Dash_Load(object sender, EventArgs e)
        {
            LoadReportFiles();
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Path to the folder containing the PDF files
            string folderPath = @"C:\Reports\";

            // Retrieve all the PDF files in the folder
            string[] files = Directory.GetFiles(folderPath, "*.pdf");

            // Create a new DataTable and add columns for file name, date, and print preview
            DataTable dt = new DataTable();
            dt.Columns.Add("File Name");
            dt.Columns.Add("Date");
            dt.Columns.Add("Print Document");
            dt.Columns.Add("Print Preview");

            // Add each file name and other details to the DataTable
            foreach (string file in files)
            {
                DataRow row = dt.NewRow();
                row[0] = Path.GetFileName(file);
                row[1] = File.GetLastWriteTime(file).ToString();
                DataGridViewButtonCell printButtonCell = new DataGridViewButtonCell();
                printButtonCell.Value = "Print";
                row[2] = printButtonCell;
                DataGridViewButtonCell previewButtonCell = new DataGridViewButtonCell();
                previewButtonCell.Value = "Preview";
                row[3] = previewButtonCell;
                dt.Rows.Add(row);
            }

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;

            // Set the "Print Document" column to a button column
            DataGridViewButtonColumn printButtonColumnCol = new DataGridViewButtonColumn();
            printButtonColumnCol.HeaderText = "Print Document";
            printButtonColumnCol.Name = "Print Document";
            printButtonColumnCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.RemoveAt(2);
            dataGridView1.Columns.Insert(2, printButtonColumnCol);

            // Handle the CellClick event of the DataGridView control
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            DataGridViewButtonColumn printPreviewColumn = new DataGridViewButtonColumn();
            printPreviewColumn.HeaderText = "Print Preview";
            printPreviewColumn.Name = "PrintPreviewColumn";
            printPreviewColumn.Text = "Preview";
            dataGridView1.Columns.Add(printPreviewColumn);

            // Handle the CellClick event
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Handle the CellFormatting event to set the icon for the Print Preview column
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            /*// Display the file names in a message box
            foreach (string file in files)
            {

                MessageBox.Show(Path.GetFileName(file));
            }*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void LoadReportFiles()
        {
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "Print Document" button was clicked
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                // Retrieve the file path from the "File Name" column
                string filePath = @"C:\Reports\" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Create a PrintDialog object to display the print dialog
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = new System.Drawing.Printing.PrintDocument();

                // Show the print dialog
                DialogResult result = printDialog.ShowDialog();

                // If the user clicked OK in the print dialog, print the document using the default printer
                if (result == DialogResult.OK)
                {
                    Process.Start(filePath);
                }
            }
            // Check if the clicked cell is in the Print Preview column
            if (e.ColumnIndex == dataGridView1.Columns["PrintPreviewColumn"].Index &&
                e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the path of the PDF file from the corresponding cell in the File Name column
                string fileName = dataGridView1.Rows[e.RowIndex].Cells["File Name"].Value.ToString();
                string filePath = Path.Combine(folderPath, "*.pdf");

                // Open the PDF file in a print preview dialog
                if (File.Exists(filePath))
                {
                    using (PdfReader reader = new PdfReader(filePath))
                    {
                        using (PrintPreviewDialog dialog = new PrintPreviewDialog())
                        {
                            PdfDocument document = new PdfDocument(reader);
                            PrintDocument printDocument = document.CreatePrintDocument();
                            dialog.Document = printDocument;
                            dialog.ShowDialog();
                            document.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"File {fileName} not found.");
                }
            }
        }

    }
}
