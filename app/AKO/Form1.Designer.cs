namespace AKO
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngrs = new System.Windows.Forms.Button();
            this.btncks = new System.Windows.Forms.Button();
            this.txtklnad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsfre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btngrs
            // 
            this.btngrs.Location = new System.Drawing.Point(170, 152);
            this.btngrs.Name = "btngrs";
            this.btngrs.Size = new System.Drawing.Size(75, 34);
            this.btngrs.TabIndex = 2;
            this.btngrs.Text = "Giriş";
            this.btngrs.UseVisualStyleBackColor = true;
            this.btngrs.Click += new System.EventHandler(this.btngrs_Click);
            // 
            // btncks
            // 
            this.btncks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncks.Location = new System.Drawing.Point(251, 152);
            this.btncks.Name = "btncks";
            this.btncks.Size = new System.Drawing.Size(75, 34);
            this.btncks.TabIndex = 3;
            this.btncks.Text = "Çıkış";
            this.btncks.UseVisualStyleBackColor = true;
            this.btncks.Click += new System.EventHandler(this.btncks_Click);
            // 
            // txtklnad
            // 
            this.txtklnad.Location = new System.Drawing.Point(185, 68);
            this.txtklnad.Name = "txtklnad";
            this.txtklnad.Size = new System.Drawing.Size(124, 20);
            this.txtklnad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // txtsfre
            // 
            this.txtsfre.Location = new System.Drawing.Point(185, 107);
            this.txtsfre.Name = "txtsfre";
            this.txtsfre.PasswordChar = '*';
            this.txtsfre.Size = new System.Drawing.Size(124, 20);
            this.txtsfre.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btngrs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btncks;
            this.ClientSize = new System.Drawing.Size(453, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsfre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtklnad);
            this.Controls.Add(this.btncks);
            this.Controls.Add(this.btngrs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngrs;
        private System.Windows.Forms.Button btncks;
        private System.Windows.Forms.TextBox txtklnad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsfre;
    }
}

