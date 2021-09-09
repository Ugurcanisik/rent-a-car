namespace AKO
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
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
            this.btniptal = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txttelno = new System.Windows.Forms.MaskedTextBox();
            this.btntmzl = new System.Windows.Forms.Button();
            this.txttcno = new System.Windows.Forms.TextBox();
            this.txtehlytnmr = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Ehliyet Numarası";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Telefon Numarası";
            // 
            // txtadres
            // 
            this.txtadres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtadres.Location = new System.Drawing.Point(204, 156);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(100, 54);
            this.txtadres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Adres";
            // 
            // txtmail
            // 
            this.txtmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmail.Location = new System.Drawing.Point(204, 130);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Email";
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsoyadi.Location = new System.Drawing.Point(204, 78);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtsoyadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Soyadı";
            // 
            // txtadi
            // 
            this.txtadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtadi.Location = new System.Drawing.Point(204, 52);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(100, 20);
            this.txtadi.TabIndex = 1;
            this.txtadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "TC Kimlik Numarası";
            // 
            // btniptal
            // 
            this.btniptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btniptal.Location = new System.Drawing.Point(205, 265);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(89, 31);
            this.btniptal.TabIndex = 29;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(110, 265);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(89, 31);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txttelno
            // 
            this.txttelno.Location = new System.Drawing.Point(204, 104);
            this.txttelno.Mask = "(999) 000-0000";
            this.txttelno.Name = "txttelno";
            this.txttelno.Size = new System.Drawing.Size(100, 20);
            this.txttelno.TabIndex = 3;
            // 
            // btntmzl
            // 
            this.btntmzl.Location = new System.Drawing.Point(300, 265);
            this.btntmzl.Name = "btntmzl";
            this.btntmzl.Size = new System.Drawing.Size(89, 31);
            this.btntmzl.TabIndex = 47;
            this.btntmzl.Text = "Temizle";
            this.btntmzl.UseVisualStyleBackColor = true;
            this.btntmzl.Click += new System.EventHandler(this.btntmzl_Click);
            // 
            // txttcno
            // 
            this.txttcno.Location = new System.Drawing.Point(204, 26);
            this.txttcno.MaxLength = 11;
            this.txttcno.Name = "txttcno";
            this.txttcno.Size = new System.Drawing.Size(100, 20);
            this.txttcno.TabIndex = 0;
            this.txttcno.TextChanged += new System.EventHandler(this.txttcno_TextChanged);
            this.txttcno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcno_KeyPress);
            // 
            // txtehlytnmr
            // 
            this.txtehlytnmr.Location = new System.Drawing.Point(204, 216);
            this.txtehlytnmr.MaxLength = 6;
            this.txtehlytnmr.Name = "txtehlytnmr";
            this.txtehlytnmr.Size = new System.Drawing.Size(100, 20);
            this.txtehlytnmr.TabIndex = 6;
            this.txtehlytnmr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttcno_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnresimekle
            // 
            this.btnresimekle.Location = new System.Drawing.Point(436, 216);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(75, 23);
            this.btnresimekle.TabIndex = 7;
            this.btnresimekle.Text = "Resim Ekle";
            this.btnresimekle.UseVisualStyleBackColor = true;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(388, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 184);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // MusteriEkle
            // 
            this.AcceptButton = this.btnekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btniptal;
            this.ClientSize = new System.Drawing.Size(577, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnresimekle);
            this.Controls.Add(this.txtehlytnmr);
            this.Controls.Add(this.txttcno);
            this.Controls.Add(this.btntmzl);
            this.Controls.Add(this.txttelno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Otomasyonu";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.MaskedTextBox txttelno;
        private System.Windows.Forms.Button btntmzl;
        private System.Windows.Forms.TextBox txttcno;
        private System.Windows.Forms.TextBox txtehlytnmr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}