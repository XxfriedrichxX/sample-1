
namespace sample_1.AdminControls
{
    partial class AC_Form
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
            this.Form1btn = new Guna.UI2.WinForms.Guna2Button();
            this.Form2btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Form1btn
            // 
            this.Form1btn.BorderRadius = 25;
            this.Form1btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Form1btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Form1btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Form1btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Form1btn.FillColor = System.Drawing.Color.DarkGreen;
            this.Form1btn.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.Form1btn.ForeColor = System.Drawing.Color.White;
            this.Form1btn.Location = new System.Drawing.Point(48, 48);
            this.Form1btn.Name = "Form1btn";
            this.Form1btn.Size = new System.Drawing.Size(241, 463);
            this.Form1btn.TabIndex = 0;
            this.Form1btn.Text = "Form 1";
            // 
            // Form2btn
            // 
            this.Form2btn.BorderRadius = 25;
            this.Form2btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Form2btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Form2btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Form2btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Form2btn.FillColor = System.Drawing.Color.DarkGreen;
            this.Form2btn.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.Form2btn.ForeColor = System.Drawing.Color.White;
            this.Form2btn.Location = new System.Drawing.Point(336, 48);
            this.Form2btn.Name = "Form2btn";
            this.Form2btn.Size = new System.Drawing.Size(241, 463);
            this.Form2btn.TabIndex = 1;
            this.Form2btn.Text = "Form 2";
            this.Form2btn.Click += new System.EventHandler(this.Form2btn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 25;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(634, 48);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(241, 463);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Form 3";
            // 
            // AC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.Form2btn);
            this.Controls.Add(this.Form1btn);
            this.Name = "AC_Form";
            this.Size = new System.Drawing.Size(913, 613);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Form1btn;
        private Guna.UI2.WinForms.Guna2Button Form2btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
