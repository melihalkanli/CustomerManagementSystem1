
namespace CustomerManagementSystem
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelCustomersSubMenu = new System.Windows.Forms.Panel();
            this.buttonCustomersÜlkelerForm = new System.Windows.Forms.Button();
            this.buttonCustomersÜlkeEkleForm = new System.Windows.Forms.Button();
            this.buttonCustomersGetAllForm = new System.Windows.Forms.Button();
            this.buttonCustomersAddForm = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelCustomersSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.buttonCustomers);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 189);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::CustomerManagementSystem.Properties.Resources.User_80_icon_icons_com_57249__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.buttonCustomers.FlatAppearance.BorderSize = 0;
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.ForeColor = System.Drawing.Color.White;
            this.buttonCustomers.Location = new System.Drawing.Point(0, 123);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonCustomers.Size = new System.Drawing.Size(233, 66);
            this.buttonCustomers.TabIndex = 1;
            this.buttonCustomers.Text = "Müşteriler";
            this.buttonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.UseVisualStyleBackColor = false;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.panelSideMenu.Controls.Add(this.panelCustomersSubMenu);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(233, 503);
            this.panelSideMenu.TabIndex = 0;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // panelCustomersSubMenu
            // 
            this.panelCustomersSubMenu.Controls.Add(this.buttonCustomersÜlkelerForm);
            this.panelCustomersSubMenu.Controls.Add(this.buttonCustomersÜlkeEkleForm);
            this.panelCustomersSubMenu.Controls.Add(this.buttonCustomersGetAllForm);
            this.panelCustomersSubMenu.Controls.Add(this.buttonCustomersAddForm);
            this.panelCustomersSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomersSubMenu.Location = new System.Drawing.Point(0, 189);
            this.panelCustomersSubMenu.Name = "panelCustomersSubMenu";
            this.panelCustomersSubMenu.Size = new System.Drawing.Size(233, 275);
            this.panelCustomersSubMenu.TabIndex = 2;
            this.panelCustomersSubMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomersSubMenu_Paint);
            // 
            // buttonCustomersÜlkelerForm
            // 
            this.buttonCustomersÜlkelerForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomersÜlkelerForm.FlatAppearance.BorderSize = 0;
            this.buttonCustomersÜlkelerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomersÜlkelerForm.ForeColor = System.Drawing.Color.White;
            this.buttonCustomersÜlkelerForm.Location = new System.Drawing.Point(0, 150);
            this.buttonCustomersÜlkelerForm.Name = "buttonCustomersÜlkelerForm";
            this.buttonCustomersÜlkelerForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCustomersÜlkelerForm.Size = new System.Drawing.Size(233, 44);
            this.buttonCustomersÜlkelerForm.TabIndex = 4;
            this.buttonCustomersÜlkelerForm.Text = "Ülkeler";
            this.buttonCustomersÜlkelerForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomersÜlkelerForm.UseVisualStyleBackColor = true;
            this.buttonCustomersÜlkelerForm.Click += new System.EventHandler(this.buttonCustomersÜlkelerForm_Click);
            // 
            // buttonCustomersÜlkeEkleForm
            // 
            this.buttonCustomersÜlkeEkleForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomersÜlkeEkleForm.FlatAppearance.BorderSize = 0;
            this.buttonCustomersÜlkeEkleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomersÜlkeEkleForm.ForeColor = System.Drawing.Color.White;
            this.buttonCustomersÜlkeEkleForm.Location = new System.Drawing.Point(0, 98);
            this.buttonCustomersÜlkeEkleForm.Name = "buttonCustomersÜlkeEkleForm";
            this.buttonCustomersÜlkeEkleForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCustomersÜlkeEkleForm.Size = new System.Drawing.Size(233, 52);
            this.buttonCustomersÜlkeEkleForm.TabIndex = 3;
            this.buttonCustomersÜlkeEkleForm.Text = "Ülke Ekle";
            this.buttonCustomersÜlkeEkleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomersÜlkeEkleForm.UseVisualStyleBackColor = true;
            this.buttonCustomersÜlkeEkleForm.Click += new System.EventHandler(this.buttonCustomersÜlkeEkleForm_Click);
            // 
            // buttonCustomersGetAllForm
            // 
            this.buttonCustomersGetAllForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomersGetAllForm.FlatAppearance.BorderSize = 0;
            this.buttonCustomersGetAllForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomersGetAllForm.ForeColor = System.Drawing.Color.White;
            this.buttonCustomersGetAllForm.Location = new System.Drawing.Point(0, 54);
            this.buttonCustomersGetAllForm.Name = "buttonCustomersGetAllForm";
            this.buttonCustomersGetAllForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCustomersGetAllForm.Size = new System.Drawing.Size(233, 44);
            this.buttonCustomersGetAllForm.TabIndex = 2;
            this.buttonCustomersGetAllForm.Text = "Mevcut Müşteriler";
            this.buttonCustomersGetAllForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomersGetAllForm.UseVisualStyleBackColor = true;
            this.buttonCustomersGetAllForm.Click += new System.EventHandler(this.ButtonCustomersGetAllForm_Click);
            // 
            // buttonCustomersAddForm
            // 
            this.buttonCustomersAddForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCustomersAddForm.FlatAppearance.BorderSize = 0;
            this.buttonCustomersAddForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomersAddForm.ForeColor = System.Drawing.Color.White;
            this.buttonCustomersAddForm.Location = new System.Drawing.Point(0, 0);
            this.buttonCustomersAddForm.Name = "buttonCustomersAddForm";
            this.buttonCustomersAddForm.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCustomersAddForm.Size = new System.Drawing.Size(233, 54);
            this.buttonCustomersAddForm.TabIndex = 0;
            this.buttonCustomersAddForm.Text = "Müşteri Ekle";
            this.buttonCustomersAddForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomersAddForm.UseVisualStyleBackColor = true;
            this.buttonCustomersAddForm.Click += new System.EventHandler(this.buttonCustomersAddForm_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(233, 0);
            this.panelForm.MinimumSize = new System.Drawing.Size(500, 300);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(751, 503);
            this.panelForm.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 503);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(1000, 200);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelCustomersSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelCustomersSubMenu;
        private System.Windows.Forms.Button buttonCustomersAddForm;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCustomersGetAllForm;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonCustomersÜlkelerForm;
        private System.Windows.Forms.Button buttonCustomersÜlkeEkleForm;
    }
}

