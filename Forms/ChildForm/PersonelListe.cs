using Guna.UI2.WinForms;
using InsanKaynaklariYonetimi.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariYonetimi.Forms.ChildForm
{
    public partial class PersonelListe : Form
    {
        public PersonelListe()
        {
            InitializeComponent();
        }
        private void PersonelListe_Load(object sender, EventArgs e)
        {
            PersonelleriButonaListele(pnlPersoneller);
        }
        void PersonelleriButonaListele(Panel panel)
        {
            SqlCommand listele = new SqlCommand("SELECT name,surname,fotograf,tc_no FROM personel", Fonksiyonlar.SQLBaglanti);
            SqlDataReader dr;
            Fonksiyonlar.SQLBaglanti.Open();

            //Tanımlamalar
            string ad, soyad, tcno;
            byte[] resim = new byte[0];

            dr = listele.ExecuteReader();

            while (dr.Read())
            {
                ad = dr["name"].ToString().Trim();
                soyad = dr["surname"].ToString().Trim();
                resim = (byte[])dr["fotograf"];
                tcno = dr["tc_no"].ToString().Trim();

                Guna.UI2.WinForms.Guna2Button btn = new Guna.UI2.WinForms.Guna2Button();
                //Ozellikleri
                btn.Text = ad + " " + soyad;
                btn.Name = "prsnl" + tcno;
                btn.Size = new Size(260, 63);
                btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;
                btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                btn.ImageSize = new System.Drawing.Size(54, 54);
                btn.CustomImages.Image = global::InsanKaynaklariYonetimi.Properties.Resources.more_than;

                btn.Click += new System.EventHandler(this.btn_Click);
                //Konum
                
                btn.Location = new Point(Ayarlar.sonGenislik, Ayarlar.sonYukseklik);
                Ayarlar.sonYukseklik += Ayarlar.personelButonBosluk;

                //Ekleme
                panel.Controls.Add(btn);

                //Butona Resimi Ekletme
                MemoryStream memoryStream = new MemoryStream(resim);
                btn.Image = Image.FromStream(memoryStream);
            }
            Fonksiyonlar.SQLBaglanti.Close();
            Ayarlar.sonYukseklik = 25;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string btnAdi, tcno;

            btnAdi = ((Guna2Button)sender).Name;
            tcno = btnAdi.Substring(5);
            Fonksiyonlar.PersonelProfilBiglileri(tcno);

        }


        private void btnTest_Click(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
