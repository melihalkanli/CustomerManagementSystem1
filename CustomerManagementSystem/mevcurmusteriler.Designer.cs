
namespace CustomerManagementSystem
{
    partial class mevcurmusteriler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.buttonLoadCustomers = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxSearchText);
            this.panel1.Controls.Add(this.buttonLoadCustomers);
            this.panel1.Controls.Add(this.dataGridViewCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 350);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Aramak istediğiniz müşterinin adı";
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.textBoxSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchText.ForeColor = System.Drawing.Color.White;
            this.textBoxSearchText.Location = new System.Drawing.Point(189, 12);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(455, 23);
            this.textBoxSearchText.TabIndex = 16;
            this.textBoxSearchText.TextChanged += new System.EventHandler(this.textBoxSearchText_TextChanged);
            // 
            // buttonLoadCustomers
            // 
            this.buttonLoadCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLoadCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadCustomers.ForeColor = System.Drawing.Color.White;
            this.buttonLoadCustomers.Location = new System.Drawing.Point(533, 59);
            this.buttonLoadCustomers.Name = "buttonLoadCustomers";
            this.buttonLoadCustomers.Size = new System.Drawing.Size(114, 28);
            this.buttonLoadCustomers.TabIndex = 15;
            this.buttonLoadCustomers.Text = "Müşterileri Yükle";
            this.buttonLoadCustomers.UseVisualStyleBackColor = true;
            this.buttonLoadCustomers.Click += new System.EventHandler(this.buttonLoadCustomers_Click);
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.dataGridViewCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 117);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowTemplate.Height = 25;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(647, 233);
            this.dataGridViewCustomers.TabIndex = 1;
            // 
            // mevcurmusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 350);
            this.Controls.Add(this.panel1);
            this.Name = "mevcurmusteriler";
            this.Text = "mevcutmusteriler";
            this.Load += new System.EventHandler(this.mevcurmusteriler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonLoadCustomers;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.Label label6;
    }
}