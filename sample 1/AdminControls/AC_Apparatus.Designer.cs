
namespace sample_1.AdminControls
{
    partial class AC_Apparatus
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AC_Apparatus));
            this.ApparatusTable = new System.Windows.Forms.DataGridView();
            this.AddAppbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Disposebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Custodiantxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AppIDtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SerialNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AppNametxt = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ApparatusTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ApparatusTable
            // 
            this.ApparatusTable.AllowUserToDeleteRows = false;
            this.ApparatusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApparatusTable.Location = new System.Drawing.Point(121, 331);
            this.ApparatusTable.Name = "ApparatusTable";
            this.ApparatusTable.ReadOnly = true;
            this.ApparatusTable.RowHeadersWidth = 62;
            this.ApparatusTable.RowTemplate.Height = 28;
            this.ApparatusTable.Size = new System.Drawing.Size(694, 530);
            this.ApparatusTable.TabIndex = 17;
            this.ApparatusTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApparatusTable_CellContentClick);
            // 
            // AddAppbtn
            // 
            this.AddAppbtn.AutoRoundedCorners = true;
            this.AddAppbtn.BorderRadius = 27;
            this.AddAppbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddAppbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddAppbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddAppbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddAppbtn.FillColor = System.Drawing.Color.SeaGreen;
            this.AddAppbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddAppbtn.ForeColor = System.Drawing.Color.White;
            this.AddAppbtn.Image = ((System.Drawing.Image)(resources.GetObject("AddAppbtn.Image")));
            this.AddAppbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddAppbtn.Location = new System.Drawing.Point(38, 268);
            this.AddAppbtn.Name = "AddAppbtn";
            this.AddAppbtn.Size = new System.Drawing.Size(226, 57);
            this.AddAppbtn.TabIndex = 14;
            this.AddAppbtn.Text = "Add Apparatus";
            this.AddAppbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddAppbtn.Click += new System.EventHandler(this.AddAppbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(1, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "Appratus List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(-1, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(915, 55);
            this.label2.TabIndex = 12;
            this.label2.Text = "_________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Updatebtn
            // 
            this.Updatebtn.AutoRoundedCorners = true;
            this.Updatebtn.BorderRadius = 27;
            this.Updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Updatebtn.FillColor = System.Drawing.Color.SeaGreen;
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Image = ((System.Drawing.Image)(resources.GetObject("Updatebtn.Image")));
            this.Updatebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Updatebtn.Location = new System.Drawing.Point(300, 268);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(257, 57);
            this.Updatebtn.TabIndex = 18;
            this.Updatebtn.Text = "Update Apparatus";
            this.Updatebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Delete
            // 
            this.Delete.AutoRoundedCorners = true;
            this.Delete.BorderRadius = 27;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.FillColor = System.Drawing.Color.SeaGreen;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delete.Location = new System.Drawing.Point(902, 268);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 57);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Delete";
            this.Delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Disposebtn
            // 
            this.Disposebtn.AutoRoundedCorners = true;
            this.Disposebtn.BorderRadius = 27;
            this.Disposebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Disposebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Disposebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Disposebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Disposebtn.FillColor = System.Drawing.Color.SeaGreen;
            this.Disposebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Disposebtn.ForeColor = System.Drawing.Color.White;
            this.Disposebtn.Image = ((System.Drawing.Image)(resources.GetObject("Disposebtn.Image")));
            this.Disposebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Disposebtn.Location = new System.Drawing.Point(588, 268);
            this.Disposebtn.Name = "Disposebtn";
            this.Disposebtn.Size = new System.Drawing.Size(267, 57);
            this.Disposebtn.TabIndex = 20;
            this.Disposebtn.Text = "Dispose Apparatus";
            this.Disposebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Custodiantxt
            // 
            this.Custodiantxt.BorderRadius = 20;
            this.Custodiantxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Custodiantxt.DefaultText = "";
            this.Custodiantxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Custodiantxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Custodiantxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Custodiantxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Custodiantxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Custodiantxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custodiantxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Custodiantxt.Location = new System.Drawing.Point(811, 112);
            this.Custodiantxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Custodiantxt.Name = "Custodiantxt";
            this.Custodiantxt.PasswordChar = '\0';
            this.Custodiantxt.PlaceholderText = "";
            this.Custodiantxt.SelectedText = "";
            this.Custodiantxt.Size = new System.Drawing.Size(266, 42);
            this.Custodiantxt.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(546, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 37);
            this.label6.TabIndex = 78;
            this.label6.Text = "Custodian Name:";
            // 
            // AppIDtextbox
            // 
            this.AppIDtextbox.BorderRadius = 20;
            this.AppIDtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppIDtextbox.DefaultText = "";
            this.AppIDtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AppIDtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AppIDtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppIDtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppIDtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppIDtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppIDtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppIDtextbox.Location = new System.Drawing.Point(266, 107);
            this.AppIDtextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AppIDtextbox.Name = "AppIDtextbox";
            this.AppIDtextbox.PasswordChar = '\0';
            this.AppIDtextbox.PlaceholderText = "";
            this.AppIDtextbox.SelectedText = "";
            this.AppIDtextbox.Size = new System.Drawing.Size(272, 42);
            this.AppIDtextbox.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 76;
            this.label3.Text = "Apparatus ID:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(606, 163);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(131, 39);
            this.guna2HtmlLabel7.TabIndex = 75;
            this.guna2HtmlLabel7.Text = "Quantity:";
            // 
            // SerialNumber
            // 
            this.SerialNumber.BorderRadius = 25;
            this.SerialNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialNumber.DefaultText = "";
            this.SerialNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SerialNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SerialNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SerialNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SerialNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SerialNumber.Location = new System.Drawing.Point(811, 165);
            this.SerialNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.PasswordChar = '\0';
            this.SerialNumber.PlaceholderText = "";
            this.SerialNumber.SelectedText = "";
            this.SerialNumber.Size = new System.Drawing.Size(266, 42);
            this.SerialNumber.TabIndex = 74;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(8, 160);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(255, 39);
            this.guna2HtmlLabel6.TabIndex = 73;
            this.guna2HtmlLabel6.Text = "Apparatus Name:";
            // 
            // AppNametxt
            // 
            this.AppNametxt.BorderRadius = 25;
            this.AppNametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppNametxt.DefaultText = "";
            this.AppNametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AppNametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AppNametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppNametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppNametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppNametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppNametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppNametxt.Location = new System.Drawing.Point(266, 160);
            this.AppNametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppNametxt.Name = "AppNametxt";
            this.AppNametxt.PasswordChar = '\0';
            this.AppNametxt.PlaceholderText = "";
            this.AppNametxt.SelectedText = "";
            this.AppNametxt.Size = new System.Drawing.Size(291, 42);
            this.AppNametxt.TabIndex = 72;
            // 
            // AC_Apparatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.Custodiantxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AppIDtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.SerialNumber);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.AppNametxt);
            this.Controls.Add(this.Disposebtn);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.ApparatusTable);
            this.Controls.Add(this.AddAppbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AC_Apparatus";
            this.Size = new System.Drawing.Size(1085, 864);
            this.Load += new System.EventHandler(this.AC_Apparatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ApparatusTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ApparatusTable;
        private Guna.UI2.WinForms.Guna2Button AddAppbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Disposebtn;
        private Guna.UI2.WinForms.Guna2TextBox Custodiantxt;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox AppIDtextbox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox SerialNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox AppNametxt;
    }
}
