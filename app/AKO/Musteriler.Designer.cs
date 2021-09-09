namespace AKO
{
    partial class Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlstl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txttcnosorgu = new System.Windows.Forms.TextBox();
            this.btngnclle = new System.Windows.Forms.Button();
            this.btntmz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtehlytnmr = new System.Windows.Forms.TextBox();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.txttelno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnresimsec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1548, 459);
            this.dataGridView1.TabIndex = 111111;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnlstl
            // 
            this.btnlstl.Location = new System.Drawing.Point(1444, 263);
            this.btnlstl.Name = "btnlstl";
            this.btnlstl.Size = new System.Drawing.Size(92, 43);
            this.btnlstl.TabIndex = 10;
            this.btnlstl.Text = "Listele";
            this.btnlstl.UseVisualStyleBackColor = true;
            this.btnlstl.Click += new System.EventHandler(this.btnlstl_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "TC No Sorgula";
            // 
            // txttcnosorgu
            // 
            this.txttcnosorgu.Location = new System.Drawing.Point(113, 283);
            this.txttcnosorgu.Name = "txttcnosorgu";
            this.txttcnosorgu.Size = new System.Drawing.Size(100, 20);
            this.txttcnosorgu.TabIndex = 11;
            this.txttcnosorgu.TextChanged += new System.EventHandler(this.txttcnosorgu_TextChanged);
            this.txttcnosorgu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcno_KeyPress);
            // 
            // btngnclle
            // 
            this.btngnclle.Location = new System.Drawing.Point(1034, 65);
            this.btngnclle.Name = "btngnclle";
            this.btngnclle.Size = new System.Drawing.Size(92, 42);
            this.btngnclle.TabIndex = 8;
            this.btngnclle.Text = "Güncelle";
            this.btngnclle.UseVisualStyleBackColor = true;
            this.btngnclle.Click += new System.EventHandler(this.btngnclle_Click);
            // 
            // btntmz
            // 
            this.btntmz.Location = new System.Drawing.Point(1034, 117);
            this.btntmz.Name = "btntmz";
            this.btntmz.Size = new System.Drawing.Size(92, 43);
            this.btntmz.TabIndex = 9;
            this.btntmz.Text = "Temizle";
            this.btntmz.UseVisualStyleBackColor = true;
            this.btntmz.Click += new System.EventHandler(this.btntmz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtehlytnmr);
            this.groupBox1.Controls.Add(this.txttcno);
            this.groupBox1.Controls.Add(this.txttelno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(514, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 193);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtehlytnmr
            // 
            this.txtehlytnmr.Location = new System.Drawing.Point(379, 137);
            this.txtehlytnmr.MaxLength = 6;
            this.txtehlytnmr.Name = "txtehlytnmr";
            this.txtehlytnmr.Size = new System.Drawing.Size(100, 20);
            this.txtehlytnmr.TabIndex = 6;
            this.txtehlytnmr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcno_KeyPress);
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(154, 55);
            this.txttcno.MaxLength = 11;
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(100, 20);
            this.txttcno.TabIndex = 0;
            this.txttcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcno_KeyPress);
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(154, 133);
            this.txttelno.Mask = "(999) 000-0000";
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(100, 20);
            this.txttelno.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Ehliyet Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Telefon Numarası";
            // 
            // txtadres
            // 
            this.txtadres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtadres.Location = new System.Drawing.Point(379, 77);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(100, 54);
            this.txtadres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Adres";
            // 
            // txtmail
            // 
            this.txtmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmail.Location = new System.Drawing.Point(379, 51);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Email";
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsoyadi.Location = new System.Drawing.Point(154, 107);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtsoyadi.TabIndex = 2;
            this.txtsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Soyadı";
            // 
            // txtadi
            // 
            this.txtadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtadi.Location = new System.Drawing.Point(154, 81);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(100, 20);
            this.txtadi.TabIndex = 1;
            this.txtadi.TextChanged += new System.EventHandler(this.txtadi_TextChanged);
            this.txtadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "TC Kimlik Numarası";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(1304, 263);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(92, 43);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(319, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // btnresimsec
            // 
            this.btnresimsec.Location = new System.Drawing.Point(348, 208);
            this.btnresimsec.Name = "btnresimsec";
            this.btnresimsec.Size = new System.Drawing.Size(75, 23);
            this.btnresimsec.TabIndex = 7;
            this.btnresimsec.Text = "Resim Seç";
            this.btnresimsec.UseVisualStyleBackColor = true;
            this.btnresimsec.Click += new System.EventHandler(this.btnresimsec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(338, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 111112;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadi_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(253, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 111113;
            this.label9.Text = "İsim Sorgula";
            // 
            // Musteriler
            // 
            this.AcceptButton = this.btngnclle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1548, 771);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnresimsec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntmz);
            this.Controls.Add(this.btngnclle);
            this.Controls.Add(this.txttcnosorgu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnlstl);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Otomasyonu";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlstl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttcnosorgu;
        private System.Windows.Forms.Button btngnclle;
        private System.Windows.Forms.Button btntmz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txttelno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtehlytnmr;
        private System.Windows.Forms.TextBox txttcno;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnresimsec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}