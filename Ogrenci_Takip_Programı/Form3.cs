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
    public partial class Form3 : Form
    {
        public Form1 frm1;

        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=data.mdb");
        OleDbCommand kmt = new OleDbCommand();
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (txtNo.Text.Trim()!="" && txtAdSoyad.Text.Trim() != "" && cmbSinif.SelectedItem.ToString() != "" &&
                    txtAdres.Text.Trim() != "")
                {
                    bag.Open();
                    kmt.Connection = bag;
                    kmt.CommandText = "INSERT INTO ogrBil(ogrNo,adSoyad,sinifi,adres) VALUES('"+txtNo.Text+ "'," +
                    "'" + txtAdSoyad.Text + "','" + cmbSinif.SelectedItem.ToString() + "','" + txtAdres.Text + "')";
                    kmt.ExecuteNonQuery();
                    bag.Close();
                    frm1.frm2.listele();
                    MessageBox.Show("Kayıt Eklendi.");
                }
                else
                {
                    MessageBox.Show("Öğrenci numarası,Ad Soyad,Sınıf,Adres alanlarını boş bırakmayınız!");
                }




                for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
            }
            catch 
            {
                MessageBox.Show("Kayıtlı öğrenci numarası girişi yapmayınız!");
                bag.Close();
            }
        }

        private void txtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char) 08)
            {
                e.Handled = true;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAdSyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != (char) 08 && e.KeyChar != (char) 32)
            {
                e.Handled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbSinif.Items.Clear();
            OleDbDataReader dr;
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "SELECT sinif FROM sinifBil";
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmbSinif.Items.Add(dr[0]);
            }
            bag.Close();
        }
    }
}
