namespace AKO
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sözleşmeGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçTeslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatisliklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkirabtnarc = new System.Windows.Forms.Button();
            this.btnsozlesmelistele = new System.Windows.Forms.Button();
            this.btnaraclistele = new System.Windows.Forms.Button();
            this.btnmusterilistele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.sözleşmelerToolStripMenuItem,
            this.istatisliklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1604, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem1,
            this.müşteriGüncelleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriEkleToolStripMenuItem1
            // 
            this.müşteriEkleToolStripMenuItem1.Name = "müşteriEkleToolStripMenuItem1";
            this.müşteriEkleToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.müşteriEkleToolStripMenuItem1.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem1.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem1_Click);
            // 
            // müşteriGüncelleToolStripMenuItem
            // 
            this.müşteriGüncelleToolStripMenuItem.Name = "müşteriGüncelleToolStripMenuItem";
            this.müşteriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.müşteriGüncelleToolStripMenuItem.Text = "Müşteri Güncelle";
            this.müşteriGüncelleToolStripMenuItem.Click += new System.EventHandler(this.müşteriGüncelleToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem,
            this.araçGüncelleToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // araçEkleToolStripMenuItem
            // 
            this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
            this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.araçEkleToolStripMenuItem.Text = "Araç Ekle";
            this.araçEkleToolStripMenuItem.Click += new System.EventHandler(this.araçEkleToolStripMenuItem_Click);
            // 
            // araçGüncelleToolStripMenuItem
            // 
            this.araçGüncelleToolStripMenuItem.Name = "araçGüncelleToolStripMenuItem";
            this.araçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.araçGüncelleToolStripMenuItem.Text = "Araç Güncelle";
            this.araçGüncelleToolStripMenuItem.Click += new System.EventHandler(this.araçGüncelleToolStripMenuItem_Click);
            // 
            // sözleşmelerToolStripMenuItem
            // 
            this.sözleşmelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sözleşmeEkleToolStripMenuItem,
            this.sözleşmeGüncelleToolStripMenuItem,
            this.araçTeslimAlToolStripMenuItem});
            this.sözleşmelerToolStripMenuItem.Name = "sözleşmelerToolStripMenuItem";
            this.sözleşmelerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.sözleşmelerToolStripMenuItem.Text = "Sözleşmeler";
            // 
            // sözleşmeEkleToolStripMenuItem
            // 
            this.sözleşmeEkleToolStripMenuItem.Name = "sözleşmeEkleToolStripMenuItem";
            this.sözleşmeEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sözleşmeEkleToolStripMenuItem.Text = "Sözleşme Ekle";
            this.sözleşmeEkleToolStripMenuItem.Click += new System.EventHandler(this.sözleşmeEkleToolStripMenuItem_Click);
            // 
            // sözleşmeGüncelleToolStripMenuItem
            // 
            this.sözleşmeGüncelleToolStripMenuItem.Name = "sözleşmeGüncelleToolStripMenuItem";
            this.sözleşmeGüncelleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sözleşmeGüncelleToolStripMenuItem.Text = "Sözleşme Güncelle";
            this.sözleşmeGüncelleToolStripMenuItem.Click += new System.EventHandler(this.sözleşmeGüncelleToolStripMenuItem_Click);
            // 
            // araçTeslimAlToolStripMenuItem
            // 
            this.araçTeslimAlToolStripMenuItem.Name = "araçTeslimAlToolStripMenuItem";
            this.araçTeslimAlToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.araçTeslimAlToolStripMenuItem.Text = "Araç Teslim Al";
            this.araçTeslimAlToolStripMenuItem.Click += new System.EventHandler(this.araçTeslimAlToolStripMenuItem_Click);
            // 
            // istatisliklerToolStripMenuItem
            // 
            this.istatisliklerToolStripMenuItem.Name = "istatisliklerToolStripMenuItem";
            this.istatisliklerToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.istatisliklerToolStripMenuItem.Text = "Raporlar";
            this.istatisliklerToolStripMenuItem.Click += new System.EventHandler(this.istatisliklerToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkirabtnarc);
            this.groupBox1.Controls.Add(this.btnsozlesmelistele);
            this.groupBox1.Controls.Add(this.btnaraclistele);
            this.groupBox1.Controls.Add(this.btnmusterilistele);
            this.groupBox1.Location = new System.Drawing.Point(30, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 360);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listele";
            // 
            // btnkirabtnarc
            // 
            this.btnkirabtnarc.Location = new System.Drawing.Point(49, 270);
            this.btnkirabtnarc.Name = "btnkirabtnarc";
            this.btnkirabtnarc.Size = new System.Drawing.Size(91, 45);
            this.btnkirabtnarc.TabIndex = 9;
            this.btnkirabtnarc.Text = "Kiralaması Biten Araçlar";
            this.btnkirabtnarc.UseVisualStyleBackColor = true;
            this.btnkirabtnarc.Click += new System.EventHandler(this.btnkirabtnarc_Click);
            // 
            // btnsozlesmelistele
            // 
            this.btnsozlesmelistele.Location = new System.Drawing.Point(49, 189);
            this.btnsozlesmelistele.Name = "btnsozlesmelistele";
            this.btnsozlesmelistele.Size = new System.Drawing.Size(91, 45);
            this.btnsozlesmelistele.TabIndex = 8;
            this.btnsozlesmelistele.Text = "Sözleşmeleri Listele";
            this.btnsozlesmelistele.UseVisualStyleBackColor = true;
            this.btnsozlesmelistele.Click += new System.EventHandler(this.btnsozlesmelistele_Click);
            // 
            // btnaraclistele
            // 
            this.btnaraclistele.Location = new System.Drawing.Point(49, 113);
            this.btnaraclistele.Name = "btnaraclistele";
            this.btnaraclistele.Size = new System.Drawing.Size(91, 44);
            this.btnaraclistele.TabIndex = 7;
            this.btnaraclistele.Text = "Araçları Listele";
            this.btnaraclistele.UseVisualStyleBackColor = true;
            this.btnaraclistele.Click += new System.EventHandler(this.btnaraclistele_Click);
            // 
            // btnmusterilistele
            // 
            this.btnmusterilistele.Location = new System.Drawing.Point(49, 36);
            this.btnmusterilistele.Name = "btnmusterilistele";
            this.btnmusterilistele.Size = new System.Drawing.Size(91, 44);
            this.btnmusterilistele.TabIndex = 6;
            this.btnmusterilistele.Text = "Müşterileri Listele";
            this.btnmusterilistele.UseVisualStyleBackColor = true;
            this.btnmusterilistele.Click += new System.EventHandler(this.btnmusterilistele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 605);
            this.dataGridView1.TabIndex = 6;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1604, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Araç Kiralama Otomasyonu";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sözleşmeGüncelleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsozlesmelistele;
        private System.Windows.Forms.Button btnaraclistele;
        private System.Windows.Forms.Button btnmusterilistele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem istatisliklerToolStripMenuItem;
        private System.Windows.Forms.Button btnkirabtnarc;
        private System.Windows.Forms.ToolStripMenuItem araçTeslimAlToolStripMenuItem;
    }
}