using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Takip_Programı
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public string adSoyad;
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToLower() == "admin" && textBox2.Text.Trim() == "1234")
            {
                adSoyad = txtAdSoyad.Text;
                this.Hide();
                frm2.Show();
            }
            else
            {
                label3.Text = "kullanıcı adı veya şifre yanlış";
                textBox1.Text = "";
                textBox2.Clear();
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnGiris;
            this.CancelButton = btnCikis;
            textBox1.TabIndex = 5;
        }
    }
}
