
namespace Ogrenci_Takip_Programı
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.öğrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soyadaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numarayaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öğrenciEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.txtAraNo = new System.Windows.Forms.TextBox();
            this.txtAraAdres = new System.Windows.Forms.TextBox();
            this.txtAraSinif = new System.Windows.Forms.TextBox();
            this.txtAraAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(432, 335);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.veriİşlemleriToolStripMenuItem,
            this.raporİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciSilToolStripMenuItem,
            this.toolStripSeparator1,
            this.öğrenciToolStripMenuItem});
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciEkleToolStripMenuItem.Image")));
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.öğrenciEkleToolStripMenuItem.Text = "öğrenci ekle";
            this.öğrenciEkleToolStripMenuItem.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem_Click);
            // 
            // öğrenciSilToolStripMenuItem
            // 
            this.öğrenciSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öğrenciSilToolStripMenuItem.Image")));
            this.öğrenciSilToolStripMenuItem.Name = "öğrenciSilToolStripMenuItem";
            this.öğrenciSilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.öğrenciSilToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.öğrenciSilToolStripMenuItem.Text = "öğrenci sil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // öğrenciToolStripMenuItem
            // 
            this.öğrenciToolStripMenuItem.Name = "öğrenciToolStripMenuItem";
            this.öğrenciToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.öğrenciToolStripMenuItem.Text = "öğrenci düzenle ";
            // 
            // veriİşlemleriToolStripMenuItem
            // 
            this.veriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriEkleToolStripMenuItem,
            this.veriSilToolStripMenuItem,
            this.veriDüzenleToolStripMenuItem});
            this.veriİşlemleriToolStripMenuItem.Name = "veriİşlemleriToolStripMenuItem";
            this.veriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.veriİşlemleriToolStripMenuItem.Text = "Veri İşlemleri";
            // 
            // veriEkleToolStripMenuItem
            // 
            this.veriEkleToolStripMenuItem.Name = "veriEkleToolStripMenuItem";
            this.veriEkleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.veriEkleToolStripMenuItem.Text = "veri ekle";
            // 
            // veriSilToolStripMenuItem
            // 
            this.veriSilToolStripMenuItem.Name = "veriSilToolStripMenuItem";
            this.veriSilToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.veriSilToolStripMenuItem.Text = "veri sil";
            // 
            // veriDüzenleToolStripMenuItem
            // 
            this.veriDüzenleToolStripMenuItem.Name = "veriDüzenleToolStripMenuItem";
            this.veriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.veriDüzenleToolStripMenuItem.Text = "veri düzenle";
            // 
            // raporİşlemleriToolStripMenuItem
            // 
            this.raporİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciToolStripMenuItem1,
            this.veliToolStripMenuItem,
            this.öğretmenToolStripMenuItem});
            this.raporİşlemleriToolStripMenuItem.Name = "raporİşlemleriToolStripMenuItem";
            this.raporİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.raporİşlemleriToolStripMenuItem.Text = "Rapor İşlemleri";
            // 
            // öğrenciToolStripMenuItem1
            // 
            this.öğrenciToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaGöreToolStripMenuItem,
            this.soyadaGöreToolStripMenuItem,
            this.sınıfaGöreToolStripMenuItem,
            this.numarayaGöreToolStripMenuItem});
            this.öğrenciToolStripMenuItem1.Name = "öğrenciToolStripMenuItem1";
            this.öğrenciToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.öğrenciToolStripMenuItem1.Text = "öğrenci";
            // 
            // adaGöreToolStripMenuItem
            // 
            this.adaGöreToolStripMenuItem.Name = "adaGöreToolStripMenuItem";
            this.adaGöreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.adaGöreToolStripMenuItem.Text = "ada göre";
            // 
            // soyadaGöreToolStripMenuItem
            // 
            this.soyadaGöreToolStripMenuItem.Name = "soyadaGöreToolStripMenuItem";
            this.soyadaGöreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.soyadaGöreToolStripMenuItem.Text = "soyada göre";
            // 
            // sınıfaGöreToolStripMenuItem
            // 
            this.sınıfaGöreToolStripMenuItem.Name = "sınıfaGöreToolStripMenuItem";
            this.sınıfaGöreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sınıfaGöreToolStripMenuItem.Text = "sınıfa göre";
            // 
            // numarayaGöreToolStripMenuItem
            // 
            this.numarayaGöreToolStripMenuItem.Name = "numarayaGöreToolStripMenuItem";
            this.numarayaGöreToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.numarayaGöreToolStripMenuItem.Text = "numaraya göre";
            // 
            // veliToolStripMenuItem
            // 
            this.veliToolStripMenuItem.Name = "veliToolStripMenuItem";
            this.veliToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.veliToolStripMenuItem.Text = "veli";
            // 
            // öğretmenToolStripMenuItem
            // 
            this.öğretmenToolStripMenuItem.Name = "öğretmenToolStripMenuItem";
            this.öğretmenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.öğretmenToolStripMenuItem.Text = "öğretmen";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem1,
            this.öğrenciSilToolStripMenuItem1,
            this.öğrenciDüzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 70);
            // 
            // öğrenciEkleToolStripMenuItem1
            // 
            this.öğrenciEkleToolStripMenuItem1.Name = "öğrenciEkleToolStripMenuItem1";
            this.öğrenciEkleToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.öğrenciEkleToolStripMenuItem1.Text = "öğrenci ekle";
            this.öğrenciEkleToolStripMenuItem1.Click += new System.EventHandler(this.öğrenciEkleToolStripMenuItem1_Click);
            // 
            // öğrenciSilToolStripMenuItem1
            // 
            this.öğrenciSilToolStripMenuItem1.Name = "öğrenciSilToolStripMenuItem1";
            this.öğrenciSilToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.öğrenciSilToolStripMenuItem1.Text = "öğrenci sil";
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.öğrenciDüzenleToolStripMenuItem.Text = "öğrenci düzenle";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(89, 52);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(116, 42);
            this.btnOgrenciEkle.TabIndex = 9;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 194);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(211, 52);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(116, 42);
            this.btnOgrenciSil.TabIndex = 11;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(333, 52);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(116, 42);
            this.btnOgrenciGuncelle.TabIndex = 12;
            this.btnOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // txtAraNo
            // 
            this.txtAraNo.Location = new System.Drawing.Point(89, 109);
            this.txtAraNo.Name = "txtAraNo";
            this.txtAraNo.Size = new System.Drawing.Size(100, 20);
            this.txtAraNo.TabIndex = 13;
            this.txtAraNo.TextChanged += new System.EventHandler(this.txtAraNo_TextChanged);
            // 
            // txtAraAdres
            // 
            this.txtAraAdres.Location = new System.Drawing.Point(407, 109);
            this.txtAraAdres.Name = "txtAraAdres";
            this.txtAraAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAraAdres.TabIndex = 14;
            this.txtAraAdres.TextChanged += new System.EventHandler(this.txtAraAdres_TextChanged);
            // 
            // txtAraSinif
            // 
            this.txtAraSinif.Location = new System.Drawing.Point(301, 109);
            this.txtAraSinif.Name = "txtAraSinif";
            this.txtAraSinif.Size = new System.Drawing.Size(100, 20);
            this.txtAraSinif.TabIndex = 15;
            this.txtAraSinif.TextChanged += new System.EventHandler(this.txtAraSinif_TextChanged);
            // 
            // txtAraAdSoyad
            // 
            this.txtAraAdSoyad.Location = new System.Drawing.Point(195, 109);
            this.txtAraAdSoyad.Name = "txtAraAdSoyad";
            this.txtAraAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAraAdSoyad.TabIndex = 16;
            this.txtAraAdSoyad.TextChanged += new System.EventHandler(this.txtAraAdSoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arama Ölçütü";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 370);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAraAdSoyad);
            this.Controls.Add(this.txtAraSinif);
            this.Controls.Add(this.txtAraAdres);
            this.Controls.Add(this.txtAraNo);
            this.Controls.Add(this.btnOgrenciGuncelle);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soyadaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numarayaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğretmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAraNo;
        private System.Windows.Forms.TextBox txtAraAdres;
        private System.Windows.Forms.TextBox txtAraSinif;
        private System.Windows.Forms.TextBox txtAraAdSoyad;
        private System.Windows.Forms.Label label2;
    }
}