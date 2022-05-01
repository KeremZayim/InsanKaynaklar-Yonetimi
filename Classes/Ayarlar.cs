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
    public class Ayarlar : Form
    {
        
        public static string renkMor = "132; 102; 226";
        public static string renkArkaPlan = "235; 226; 253";
        public static System.Drawing.Color rgbMor = System.Drawing.Color.FromArgb(255, 132, 102, 226);
        public static System.Drawing.Color rgbArkaPlan = System.Drawing.Color.FromArgb(255, 235, 226, 253);


        //Personel Listelettirme

        public static int sonYukseklik = 25; // İlk Başta Butonun Konumu
        public static int sonGenislik = 5; // Değiştirmeyin!
        public static int personelButonBosluk = 64; // Değiştirmemenizi Tavsiye Ederiz 0'a 0 İsterseniz 63 Yapmalısınız!

        //Login Bilgileri
        public static SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        public static string pozisyon = "Error! Fix Bug"; //Eğer Çalışmazsa Hata Mesajı Çıkıcak
        public static string KullaniciAdi = "Error! Fix Bug";
        public static string Sifre = "Error! Fix Bug";

        //Profil
        public static string pad, psoyad, pposition, pemail, ptel_no, ptc_no, pise_baslama_tarihi, pdogum_tarihi, padres;
        public static byte[] resim = new byte[0];

    }
}
