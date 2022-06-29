using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ogrenci_Takip_Programı
{
    public partial class Form4 : Form
    {
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=data.mdb");
        OleDbCommand kmt = new OleDbCommand();
        public Form1 frm1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtNo.Enabled = false;
            txtNo.Text = frm1.frm2.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = frm1.frm2.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSinif.Text = frm1.frm2.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = frm1.frm2.dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNo.Text.Trim() != "" && txtAdSoyad.Text.Trim() != "" && txtSinif.Text.Trim() != "" &&
                   txtAdres.Text.Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "UPDATE ogrBil SET adSoyad='"+txtAdSoyad.Text+"',sinifi='"+txtSinif.Text+"',adres='"+txtAdres.Text+"' " +
                        "WHERE ogrNo="+frm1.frm2.dataGridView1.CurrentRow.Cells[0].Value+"";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    frm1.frm2.listele();
                    this.Close();
                    MessageBox.Show("güncelleme başarılı");
                }
                else
                {
                    MessageBox.Show("tüm alanlara bilgi girmelisiniz");
                }
            }
            catch
            {
                bag.Close();

            }
        }
    }
}
