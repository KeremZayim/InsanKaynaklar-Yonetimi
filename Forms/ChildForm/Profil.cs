using Guna.UI2.WinForms;
using InsanKaynaklariYonetimi.Classes;
using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace InsanKaynaklariYonetimi.Forms.ChildForm
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }
        public static Guna2HtmlLabel profilAd, profilSoyad;
        public static Label profilPosition, profilEmail, profilTel_No, profilTc_No, profilIse_Baslama_Tarihi, profilDogum_Tarihi, profilAdres;
        public static PictureBox profilResim;

        private void Profil_Load(object sender, EventArgs e)
        {
            profilAd = lblAd;
            profilSoyad = lblSoyad;
            profilPosition = lblPozisyon;
            profilEmail = lblmail;
            profilTel_No = lblTelNo;
            profilTc_No = lblTcNo;
            profilIse_Baslama_Tarihi = lblIseBaslamaTarihi;
            profilDogum_Tarihi = lblDogumTarihi;
            profilAdres = lblAdres;
            profilResim = pbImage;

            try
            {
                Fonksiyonlar.PersonelProfilGuncelle();

            }
            catch (Exception)
            {
                Fonksiyonlar.ProfilBiglileri();
                Fonksiyonlar.ProfilGuncelle(lblAd, lblSoyad, lblPozisyon, lblmail, lblTelNo, lblTcNo, lblIseBaslamaTarihi, lblDogumTarihi, lblAdres, pbImage);

            }
            Fonksiyonlar.ProfilBilgileriniSifirla();
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
