
namespace sample_1
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.PictureBox();
            this.Homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Chemicalbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Supplierbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Apparatusbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Formbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Guidelinebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Certificatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 81);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightGreen;
            this.logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Location = new System.Drawing.Point(1074, 0);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(134, 81);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(1187, 81);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 649);
            this.vScrollBar1.TabIndex = 2;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DarkGreen;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.Homebtn);
            this.sidebar.Controls.Add(this.Chemicalbtn);
            this.sidebar.Controls.Add(this.Supplierbtn);
            this.sidebar.Controls.Add(this.Apparatusbtn);
            this.sidebar.Controls.Add(this.Formbtn);
            this.sidebar.Controls.Add(this.Guidelinebtn);
            this.sidebar.Controls.Add(this.Certificatebtn);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 81);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(280, 649);
            this.sidebar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 92);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(91, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin";
            // 
            // menu
            // 
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(15, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(70, 70);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 4;
            this.menu.TabStop = false;
            // 
            // Homebtn
            // 
            this.Homebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Homebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Homebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Homebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Homebtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Homebtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.Homebtn.ForeColor = System.Drawing.Color.White;
            this.Homebtn.Image = ((System.Drawing.Image)(resources.GetObject("Homebtn.Image")));
            this.Homebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Homebtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Homebtn.Location = new System.Drawing.Point(3, 101);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(277, 72);
            this.Homebtn.TabIndex = 0;
            this.Homebtn.Text = "Home";
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click_1);
            // 
            // Chemicalbtn
            // 
            this.Chemicalbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Chemicalbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Chemicalbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Chemicalbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Chemicalbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Chemicalbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chemicalbtn.ForeColor = System.Drawing.Color.White;
            this.Chemicalbtn.Image = ((System.Drawing.Image)(resources.GetObject("Chemicalbtn.Image")));
            this.Chemicalbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Chemicalbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Chemicalbtn.Location = new System.Drawing.Point(3, 179);
            this.Chemicalbtn.Name = "Chemicalbtn";
            this.Chemicalbtn.Size = new System.Drawing.Size(277, 72);
            this.Chemicalbtn.TabIndex = 5;
            this.Chemicalbtn.Text = "    Chemical";
            this.Chemicalbtn.Click += new System.EventHandler(this.Chemicalbtn_Click_2);
            // 
            // Supplierbtn
            // 
            this.Supplierbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Supplierbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Supplierbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Supplierbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Supplierbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Supplierbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplierbtn.ForeColor = System.Drawing.Color.White;
            this.Supplierbtn.Image = ((System.Drawing.Image)(resources.GetObject("Supplierbtn.Image")));
            this.Supplierbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Supplierbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Supplierbtn.Location = new System.Drawing.Point(3, 257);
            this.Supplierbtn.Name = "Supplierbtn";
            this.Supplierbtn.Size = new System.Drawing.Size(277, 72);
            this.Supplierbtn.TabIndex = 6;
            this.Supplierbtn.Text = "  Supplier";
            this.Supplierbtn.Click += new System.EventHandler(this.Supplierbtn_Click_1);
            // 
            // Apparatusbtn
            // 
            this.Apparatusbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Apparatusbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Apparatusbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Apparatusbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Apparatusbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Apparatusbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apparatusbtn.ForeColor = System.Drawing.Color.White;
            this.Apparatusbtn.Image = ((System.Drawing.Image)(resources.GetObject("Apparatusbtn.Image")));
            this.Apparatusbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Apparatusbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Apparatusbtn.Location = new System.Drawing.Point(3, 335);
            this.Apparatusbtn.Name = "Apparatusbtn";
            this.Apparatusbtn.Size = new System.Drawing.Size(277, 72);
            this.Apparatusbtn.TabIndex = 7;
            this.Apparatusbtn.Text = "     Apparatus";
            this.Apparatusbtn.Click += new System.EventHandler(this.Apparatusbtn_Click_1);
            // 
            // Formbtn
            // 
            this.Formbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Formbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Formbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Formbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Formbtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Formbtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Formbtn.ForeColor = System.Drawing.Color.White;
            this.Formbtn.Image = ((System.Drawing.Image)(resources.GetObject("Formbtn.Image")));
            this.Formbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Formbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Formbtn.Location = new System.Drawing.Point(3, 413);
            this.Formbtn.Name = "Formbtn";
            this.Formbtn.Size = new System.Drawing.Size(277, 72);
            this.Formbtn.TabIndex = 8;
            this.Formbtn.Text = "Forms";
            this.Formbtn.Click += new System.EventHandler(this.Formbtn_Click_1);
            // 
            // Guidelinebtn
            // 
            this.Guidelinebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guidelinebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guidelinebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guidelinebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guidelinebtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Guidelinebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guidelinebtn.ForeColor = System.Drawing.Color.White;
            this.Guidelinebtn.Image = ((System.Drawing.Image)(resources.GetObject("Guidelinebtn.Image")));
            this.Guidelinebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guidelinebtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Guidelinebtn.Location = new System.Drawing.Point(3, 491);
            this.Guidelinebtn.Name = "Guidelinebtn";
            this.Guidelinebtn.Size = new System.Drawing.Size(277, 72);
            this.Guidelinebtn.TabIndex = 9;
            this.Guidelinebtn.Text = "      Guidelines";
            this.Guidelinebtn.Click += new System.EventHandler(this.Guidelinebtn_Click_1);
            // 
            // Certificatebtn
            // 
            this.Certificatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Certificatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Certificatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Certificatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Certificatebtn.FillColor = System.Drawing.Color.DarkGreen;
            this.Certificatebtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Certificatebtn.ForeColor = System.Drawing.Color.White;
            this.Certificatebtn.Image = ((System.Drawing.Image)(resources.GetObject("Certificatebtn.Image")));
            this.Certificatebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Certificatebtn.ImageSize = new System.Drawing.Size(40, 40);
            this.Certificatebtn.Location = new System.Drawing.Point(3, 569);
            this.Certificatebtn.Name = "Certificatebtn";
            this.Certificatebtn.Size = new System.Drawing.Size(277, 72);
            this.Certificatebtn.TabIndex = 10;
            this.Certificatebtn.Text = "      Certificates";
            this.Certificatebtn.Click += new System.EventHandler(this.Certificatebtn_Click_1);
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(282, 81);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(923, 649);
            this.panelControl.TabIndex = 4;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 730);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Text = "Dash Board";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelControl;
        private Guna.UI2.WinForms.Guna2Button Homebtn;
        private Guna.UI2.WinForms.Guna2Button Chemicalbtn;
        private Guna.UI2.WinForms.Guna2Button Supplierbtn;
        private Guna.UI2.WinForms.Guna2Button Apparatusbtn;
        private Guna.UI2.WinForms.Guna2Button Formbtn;
        private Guna.UI2.WinForms.Guna2Button Guidelinebtn;
        private Guna.UI2.WinForms.Guna2Button Certificatebtn;
    }
}