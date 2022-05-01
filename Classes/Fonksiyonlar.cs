using Guna.UI2.WinForms;
using InsanKaynaklariYonetimi.Forms.ChildForm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariYonetimi.Classes
{
    internal class Fonksiyonlar : Form
    {
        public static SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);

        //Personel Listeleme
        public static void PersonelProfilBiglileri(string tcno)
        {
            SQLBaglanti.Open();
            string sorgu = ("SELECT * FROM personel as p INNER JOIN login_informationes as li on li.personel_id = p.personel_id INNER JOIN personel_auth as pa on pa.personel_id = p.personel_id WHERE p.tc_no = '" + tcno + "'");
            SqlCommand pid = new SqlCommand(sorgu, SQLBaglanti);
            SqlDataReader dr = pid.ExecuteReader();


            if (dr.Read())
            {
                Ayarlar.pad = dr["name"].ToString().Trim();
                Ayarlar.psoyad = dr["surname"].ToString().Trim();
                Ayarlar.pposition = dr["position"].ToString().Trim();
                Ayarlar.pemail = dr["email"].ToString().Trim();
                Ayarlar.ptel_no = dr["tel_no"].ToString().Trim();
                Ayarlar.ptc_no = dr["tc_no"].ToString().Trim();
                Ayarlar.pise_baslama_tarihi = dr["ise_baslama_tarihi"].ToString().Trim();
                Ayarlar.pdogum_tarihi = dr["dogum_tarihi"].ToString().Trim();
                Ayarlar.padres = dr["adres"].ToString().Trim();
                Ayarlar.resim = (byte[])dr["fotograf"];
            }

            dr.Close();
            pid.Dispose();
            SQLBaglanti.Close();
        }
        public static void PersonelProfilGuncelle()
        {

            Profil.profilAd.Text = "test";
            Profil.profilSoyad.Text = Ayarlar.psoyad;
            Profil.profilPosition.Text = Ayarlar.pposition;
            Profil.profilEmail.Text = Ayarlar.pemail;
            Profil.profilTel_No.Text = Ayarlar.ptel_no;
            Profil.profilTc_No.Text = Ayarlar.ptc_no;
            Profil.profilIse_Baslama_Tarihi.Text = Ayarlar.pise_baslama_tarihi;
            Profil.profilDogum_Tarihi.Text = Ayarlar.pdogum_tarihi;
            Profil.profilAdres.Text = Ayarlar.padres;

            MemoryStream memoryStream = new MemoryStream(Ayarlar.resim);
            Profil.profilResim.Image = Image.FromStream(memoryStream);

        }
        public static void ProfilBiglileri()
        {
            SQLBaglanti.Open();
            string sorgu = ("SELECT * FROM personel as p INNER JOIN login_informationes as li on li.personel_id = p.personel_id INNER JOIN personel_auth as pa on pa.personel_id = p.personel_id WHERE li.username = '" + Ayarlar.KullaniciAdi + "' and li.password = '" + Ayarlar.Sifre + "'");
            SqlCommand pid = new SqlCommand(sorgu, SQLBaglanti);
            SqlDataReader dr = pid.ExecuteReader();


            if (dr.Read())
            {
                Ayarlar.pad = dr["name"].ToString().Trim();
                Ayarlar.psoyad = dr["surname"].ToString().Trim();
                Ayarlar.pposition = dr["position"].ToString().Trim();
                Ayarlar.pemail = dr["email"].ToString().Trim();
                Ayarlar.ptel_no = dr["tel_no"].ToString().Trim();
                Ayarlar.ptc_no = dr["tc_no"].ToString().Trim();
                Ayarlar.pise_baslama_tarihi = dr["ise_baslama_tarihi"].ToString().Trim();
                Ayarlar.pdogum_tarihi = dr["dogum_tarihi"].ToString().Trim();
                Ayarlar.padres = dr["adres"].ToString().Trim();
                Ayarlar.resim = (byte[])dr["fotograf"];
            }

            dr.Close();
            pid.Dispose();
            SQLBaglanti.Close();
        }
        public static void ProfilGuncelle(Guna2HtmlLabel ad, Guna2HtmlLabel soyad, Label pozisyon, Label mail, Label telno, Label tcno, Label iseBaslamaTarihi, Label dogumTarihi, Label adres, PictureBox pbImage)
        {
            ad.Text = Ayarlar.pad;
            soyad.Text = Ayarlar.psoyad;
            pozisyon.Text = Ayarlar.pposition;
            mail.Text = Ayarlar.pemail;
            telno.Text = Ayarlar.ptel_no;
            tcno.Text = Ayarlar.ptc_no;
            iseBaslamaTarihi.Text = Ayarlar.pise_baslama_tarihi;
            dogumTarihi.Text = Ayarlar.pdogum_tarihi;
            adres.Text = Ayarlar.padres;
            MemoryStream memoryStream = new MemoryStream(Ayarlar.resim);
            pbImage.Image = Image.FromStream(memoryStream);
        }
        public static void ProfilBilgileriniSifirla()
        {
            Ayarlar.pad = "";
            Ayarlar.psoyad = "";
            Ayarlar.pposition = "";
            Ayarlar.pemail = "";
            Ayarlar.ptel_no = "";
            Ayarlar.ptc_no = "";
            Ayarlar.pise_baslama_tarihi = "";
            Ayarlar.pdogum_tarihi = "";
            Ayarlar.padres = "";
            Ayarlar.resim = null;
        }
    }
}
