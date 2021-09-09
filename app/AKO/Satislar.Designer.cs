namespace AKO
{
    partial class Satislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satislar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttcsrg = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtplksrg = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblhslt = new System.Windows.Forms.Label();
            this.lblhasılat = new System.Windows.Forms.Label();
            this.btnlstle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1548, 682);
            this.dataGridView1.TabIndex = 0;
            // 
            // txttcsrg
            // 
            this.txttcsrg.Location = new System.Drawing.Point(267, 51);
            this.txttcsrg.Name = "txttcsrg";
            this.txttcsrg.Size = new System.Drawing.Size(100, 20);
            this.txttcsrg.TabIndex = 148;
            this.txttcsrg.TextChanged += new System.EventHandler(this.txttcsrg_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(201, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 147;
            this.label25.Text = "TC Sorgula";
            // 
            // txtplksrg
            // 
            this.txtplksrg.Location = new System.Drawing.Point(83, 51);
            this.txtplksrg.Name = "txtplksrg";
            this.txtplksrg.Size = new System.Drawing.Size(100, 20);
            this.txtplksrg.TabIndex = 146;
            this.txtplksrg.TextChanged += new System.EventHandler(this.txtplksrg_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 54);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 145;
            this.label24.Text = "Plaka Sorgula";
            // 
            // lblhslt
            // 
            this.lblhslt.AutoSize = true;
            this.lblhslt.Location = new System.Drawing.Point(518, 58);
            this.lblhslt.Name = "lblhslt";
            this.lblhslt.Size = new System.Drawing.Size(19, 13);
            this.lblhslt.TabIndex = 144;
            this.lblhslt.Text = "00";
            // 
            // lblhasılat
            // 
            this.lblhasılat.AutoSize = true;
            this.lblhasılat.Location = new System.Drawing.Point(470, 58);
            this.lblhasılat.Name = "lblhasılat";
            this.lblhasılat.Size = new System.Drawing.Size(42, 13);
            this.lblhasılat.TabIndex = 143;
            this.lblhasılat.Text = "Hasılat:";
            // 
            // btnlstle
            // 
            this.btnlstle.Location = new System.Drawing.Point(1444, 41);
            this.btnlstle.Name = "btnlstle";
            this.btnlstle.Size = new System.Drawing.Size(92, 42);
            this.btnlstle.TabIndex = 149;
            this.btnlstle.Text = "Listele";
            this.btnlstle.UseVisualStyleBackColor = true;
            this.btnlstle.Click += new System.EventHandler(this.btnlstle_Click);
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1548, 771);
            this.Controls.Add(this.btnlstle);
            this.Controls.Add(this.txttcsrg);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtplksrg);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblhslt);
            this.Controls.Add(this.lblhasılat);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Satislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Otomasyonu";
            this.Load += new System.EventHandler(this.Satislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttcsrg;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtplksrg;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblhslt;
        private System.Windows.Forms.Label lblhasılat;
        private System.Windows.Forms.Button btnlstle;
    }
}