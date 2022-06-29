using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Takip_Programı
{
    public partial class Form2 : Form
    {
        public Form1 frm1;

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=data.mdb");
        DataTable tablo = new DataTable();
        OleDbCommand kmt = new OleDbCommand();

        public void listele()
        {
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil", bag);
            adtr.Fill(tablo);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Merhaba " + frm1.adSoyad;
            listele();
            dataGridView1.DataSource = tablo;
            dataGridView1.Columns[0].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Sınıfı";
            dataGridView1.Columns[3].HeaderText = "Adresi";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frm1.frm3.ShowDialog();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            frm1.frm3.ShowDialog();
        }

        private void öğrenciEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm1.frm3.ShowDialog();
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Emin Misiniz ?",
              "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap==DialogResult.Yes)
            {
                bag.Open();
                kmt.Connection = bag;
                kmt.CommandText = "DELETE FROM ogrBil WHERE ogrNo=" +
                Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value) + "";
                kmt.ExecuteNonQuery();
                bag.Close();
                listele();
            }  
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            frm1.frm4.ShowDialog();
        }

        private void txtAraNo_TextChanged(object sender, EventArgs e)
        {
            if (txtAraNo.Text.Trim()=="")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil WHERE ogrNO=" + txtAraNo.Text , bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void txtAraAdSoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtAraAdSoyad.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil WHERE AdSoyad LIKE '%" + txtAraAdSoyad.Text+"%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void txtAraSinif_TextChanged(object sender, EventArgs e)
        {
            if (txtAraSinif.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil WHERE Sinifi LIKE '%" + txtAraSinif.Text + "%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }

        private void txtAraAdres_TextChanged(object sender, EventArgs e)
        {
            if (txtAraAdres.Text.Trim() == "")
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            else
            {
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("SELECT * FROM ogrBil WHERE Adres LIKE '%" + txtAraAdres.Text + "%'", bag);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
    }
}
