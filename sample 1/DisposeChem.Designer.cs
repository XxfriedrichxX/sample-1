
namespace sample_1
{
    partial class DisposeChem
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposeChem));
            this.unittextbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateandtime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.expirydate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.amounttextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.chemicaltypetextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.chemNametextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChemIDtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chemicalTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DisChembtn = new Guna.UI2.WinForms.Guna2Button();
            this.deletebtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chemicalTable)).BeginInit();
            this.SuspendLayout();
            // 
            // unittextbox
            // 
            this.unittextbox.BackColor = System.Drawing.Color.Transparent;
            this.unittextbox.BorderRadius = 20;
            this.unittextbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.unittextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unittextbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unittextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unittextbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.unittextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.unittextbox.ItemHeight = 30;
            this.unittextbox.Items.AddRange(new object[] {
            "mL",
            "g"});
            this.unittextbox.Location = new System.Drawing.Point(440, 189);
            this.unittextbox.Name = "unittextbox";
            this.unittextbox.Size = new System.Drawing.Size(128, 36);
            this.unittextbox.TabIndex = 82;
            // 
            // dateandtime
            // 
            this.dateandtime.BackColor = System.Drawing.Color.PaleGreen;
            this.dateandtime.BorderRadius = 15;
            this.dateandtime.Checked = true;
            this.dateandtime.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateandtime.FocusedColor = System.Drawing.Color.White;
            this.dateandtime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateandtime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateandtime.Location = new System.Drawing.Point(783, 248);
            this.dateandtime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateandtime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateandtime.Name = "dateandtime";
            this.dateandtime.Size = new System.Drawing.Size(304, 37);
            this.dateandtime.TabIndex = 81;
            this.dateandtime.Value = new System.DateTime(2023, 1, 25, 19, 40, 45, 260);
            // 
            // expirydate
            // 
            this.expirydate.BackColor = System.Drawing.Color.PaleGreen;
            this.expirydate.BorderRadius = 15;
            this.expirydate.Checked = true;
            this.expirydate.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.expirydate.FocusedColor = System.Drawing.Color.White;
            this.expirydate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.expirydate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.expirydate.Location = new System.Drawing.Point(190, 248);
            this.expirydate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.expirydate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.expirydate.Name = "expirydate";
            this.expirydate.Size = new System.Drawing.Size(309, 37);
            this.expirydate.TabIndex = 80;
            this.expirydate.Value = new System.DateTime(2023, 1, 25, 19, 40, 45, 260);
            // 
            // amounttextbox
            // 
            this.amounttextbox.BorderRadius = 20;
            this.amounttextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amounttextbox.DefaultText = "";
            this.amounttextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amounttextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amounttextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amounttextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amounttextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amounttextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amounttextbox.Location = new System.Drawing.Point(145, 188);
            this.amounttextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.amounttextbox.Name = "amounttextbox";
            this.amounttextbox.PasswordChar = '\0';
            this.amounttextbox.PlaceholderText = "";
            this.amounttextbox.SelectedText = "";
            this.amounttextbox.Size = new System.Drawing.Size(220, 37);
            this.amounttextbox.TabIndex = 79;
            // 
            // chemicaltypetextbox
            // 
            this.chemicaltypetextbox.BorderRadius = 20;
            this.chemicaltypetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chemicaltypetextbox.DefaultText = "";
            this.chemicaltypetextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chemicaltypetextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chemicaltypetextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chemicaltypetextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chemicaltypetextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chemicaltypetextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemicaltypetextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chemicaltypetextbox.Location = new System.Drawing.Point(789, 88);
            this.chemicaltypetextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chemicaltypetextbox.Name = "chemicaltypetextbox";
            this.chemicaltypetextbox.PasswordChar = '\0';
            this.chemicaltypetextbox.PlaceholderText = "";
            this.chemicaltypetextbox.SelectedText = "";
            this.chemicaltypetextbox.Size = new System.Drawing.Size(266, 37);
            this.chemicaltypetextbox.TabIndex = 78;
            // 
            // chemNametextbox
            // 
            this.chemNametextbox.BorderRadius = 20;
            this.chemNametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chemNametextbox.DefaultText = "";
            this.chemNametextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chemNametextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chemNametextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chemNametextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chemNametextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chemNametextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemNametextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chemNametextbox.Location = new System.Drawing.Point(237, 139);
            this.chemNametextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chemNametextbox.Name = "chemNametextbox";
            this.chemNametextbox.PasswordChar = '\0';
            this.chemNametextbox.PlaceholderText = "";
            this.chemNametextbox.SelectedText = "";
            this.chemNametextbox.Size = new System.Drawing.Size(331, 37);
            this.chemNametextbox.TabIndex = 77;
            // 
            // ChemIDtextbox
            // 
            this.ChemIDtextbox.BorderRadius = 20;
            this.ChemIDtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChemIDtextbox.DefaultText = "";
            this.ChemIDtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ChemIDtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ChemIDtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChemIDtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ChemIDtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChemIDtextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChemIDtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ChemIDtextbox.Location = new System.Drawing.Point(199, 88);
            this.ChemIDtextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ChemIDtextbox.Name = "ChemIDtextbox";
            this.ChemIDtextbox.PasswordChar = '\0';
            this.ChemIDtextbox.PlaceholderText = "";
            this.ChemIDtextbox.SelectedText = "";
            this.ChemIDtextbox.Size = new System.Drawing.Size(331, 37);
            this.ChemIDtextbox.TabIndex = 76;
            this.ChemIDtextbox.TextChanged += new System.EventHandler(this.ChemIDtextbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 75;
            this.label9.Text = "Expiry Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(600, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 29);
            this.label8.TabIndex = 74;
            this.label8.Text = "Date and Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 73;
            this.label7.Text = "Unit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 29);
            this.label6.TabIndex = 72;
            this.label6.Text = "Chemical Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Chemical Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 70;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 69;
            this.label3.Text = "Chemical ID:";
            // 
            // chemicalTable
            // 
            this.chemicalTable.AllowUserToDeleteRows = false;
            this.chemicalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chemicalTable.Location = new System.Drawing.Point(28, 291);
            this.chemicalTable.Name = "chemicalTable";
            this.chemicalTable.ReadOnly = true;
            this.chemicalTable.RowHeadersWidth = 62;
            this.chemicalTable.RowTemplate.Height = 28;
            this.chemicalTable.Size = new System.Drawing.Size(1059, 326);
            this.chemicalTable.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 46);
            this.label1.TabIndex = 84;
            this.label1.Text = "Dispose Chemical List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(915, 55);
            this.label2.TabIndex = 85;
            this.label2.Text = "_________________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisChembtn
            // 
            this.DisChembtn.AutoRoundedCorners = true;
            this.DisChembtn.BorderRadius = 27;
            this.DisChembtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DisChembtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DisChembtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DisChembtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DisChembtn.FillColor = System.Drawing.Color.SeaGreen;
            this.DisChembtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisChembtn.ForeColor = System.Drawing.Color.White;
            this.DisChembtn.Image = ((System.Drawing.Image)(resources.GetObject("DisChembtn.Image")));
            this.DisChembtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DisChembtn.Location = new System.Drawing.Point(633, 185);
            this.DisChembtn.Name = "DisChembtn";
            this.DisChembtn.Size = new System.Drawing.Size(227, 57);
            this.DisChembtn.TabIndex = 86;
            this.DisChembtn.Text = "Dispose Chemical";
            this.DisChembtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DisChembtn.Click += new System.EventHandler(this.DisChembtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.AutoRoundedCorners = true;
            this.deletebtn.BorderRadius = 27;
            this.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebtn.FillColor = System.Drawing.Color.SeaGreen;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deletebtn.Location = new System.Drawing.Point(920, 188);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(135, 57);
            this.deletebtn.TabIndex = 87;
            this.deletebtn.Text = "Delete";
            this.deletebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DisposeChem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1120, 622);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.DisChembtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chemicalTable);
            this.Controls.Add(this.unittextbox);
            this.Controls.Add(this.dateandtime);
            this.Controls.Add(this.expirydate);
            this.Controls.Add(this.amounttextbox);
            this.Controls.Add(this.chemicaltypetextbox);
            this.Controls.Add(this.chemNametextbox);
            this.Controls.Add(this.ChemIDtextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "DisposeChem";
            this.Text = "DisposeChem";
            this.Load += new System.EventHandler(this.DisposeChem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chemicalTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox unittextbox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateandtime;
        private Guna.UI2.WinForms.Guna2DateTimePicker expirydate;
        private Guna.UI2.WinForms.Guna2TextBox amounttextbox;
        private Guna.UI2.WinForms.Guna2TextBox chemicaltypetextbox;
        private Guna.UI2.WinForms.Guna2TextBox chemNametextbox;
        private Guna.UI2.WinForms.Guna2TextBox ChemIDtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView chemicalTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button DisChembtn;
        private Guna.UI2.WinForms.Guna2Button deletebtn;
    }
}