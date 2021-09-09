namespace AKO
{
    partial class AracTeslimAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AracTeslimAl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnteslimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtalckvrckdrm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtplakasorgu = new System.Windows.Forms.TextBox();
            this.txttcsorgu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1548, 655);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnteslimal
            // 
            this.btnteslimal.Location = new System.Drawing.Point(865, 56);
            this.btnteslimal.Name = "btnteslimal";
            this.btnteslimal.Size = new System.Drawing.Size(109, 43);
            this.btnteslimal.TabIndex = 2;
            this.btnteslimal.Text = "Arac Teslim Al";
            this.btnteslimal.UseVisualStyleBackColor = true;
            this.btnteslimal.Click += new System.EventHandler(this.btnteslimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alacak/Verecek Durumu";
            // 
            // txtalckvrckdrm
            // 
            this.txtalckvrckdrm.Enabled = false;
            this.txtalckvrckdrm.Location = new System.Drawing.Point(651, 75);
            this.txtalckvrckdrm.Name = "txtalckvrckdrm";
            this.txtalckvrckdrm.Size = new System.Drawing.Size(100, 20);
            this.txtalckvrckdrm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Plaka Sorgu";
            // 
            // txtplakasorgu
            // 
            this.txtplakasorgu.Location = new System.Drawing.Point(93, 79);
            this.txtplakasorgu.Name = "txtplakasorgu";
            this.txtplakasorgu.Size = new System.Drawing.Size(100, 20);
            this.txtplakasorgu.TabIndex = 0;
            this.txtplakasorgu.TextChanged += new System.EventHandler(this.txtplakasorgu_TextChanged);
            // 
            // txttcsorgu
            // 
            this.txttcsorgu.Location = new System.Drawing.Point(307, 78);
            this.txttcsorgu.Name = "txttcsorgu";
            this.txttcsorgu.Size = new System.Drawing.Size(100, 20);
            this.txttcsorgu.TabIndex = 1;
            this.txttcsorgu.TextChanged += new System.EventHandler(this.txttcsorgu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC Sorgu";
            // 
            // AracTeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1548, 771);
            this.Controls.Add(this.txttcsorgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtplakasorgu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtalckvrckdrm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnteslimal);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AracTeslimAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Otomasyonu";
            this.Load += new System.EventHandler(this.AracTeslimAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnteslimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtalckvrckdrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtplakasorgu;
        private System.Windows.Forms.TextBox txttcsorgu;
        private System.Windows.Forms.Label label3;
    }
}