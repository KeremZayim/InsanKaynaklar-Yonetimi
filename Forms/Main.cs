using Guna.UI2.WinForms;
using InsanKaynaklarıYonetimi;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklariYonetimi.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        string ad, soyad;
        byte[] resim = new byte[0];
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        private void Main_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ChildForm.PersonelListe());
            lblTitleChildForm.Text = "Personel Listesi";
            lblPozisyon.Text = (Ayarlar.pozisyon);
            
            SQLBaglanti.Open();
            string sorgu = ("SELECT p.fotograf,p.name,p.surname FROM personel as p INNER JOIN login_informationes as li on li.personel_id = p.personel_id WHERE li.username = '" + Ayarlar.KullaniciAdi + "' and li.password = '" + Ayarlar.Sifre + "'");
            SqlCommand pid = new SqlCommand(sorgu, SQLBaglanti);
            SqlDataReader dr = pid.ExecuteReader();


            if (dr.Read())
            {
                ad = dr["name"].ToString();
                soyad = dr["surname"].ToString();
                resim = (byte[])dr["fotograf"];
            }

            MemoryStream memoryStream = new MemoryStream(resim);
            pbImage.Image = Image.FromStream(memoryStream);
            dr.Close();
            pid.Dispose();
            SQLBaglanti.Close();

            lblAd.Text = ad;
            lblSoyad.Text = soyad;
        }
        // Taşınabilir Form Ayarları
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MoveForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            imgSlide.SendToBack();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login giris = new Login();
            this.Hide();
            giris.Show();
            Ayarlar.KullaniciAdi = "";
            Ayarlar.Sifre = "";
            Ayarlar.pozisyon = "";
        }

        private void menuButtons_CheckedChanged(object sender, EventArgs e)
        {
            Guna2Button b = (Guna2Button)sender;
            moveImageBox(sender);

            switch (b.Text)
            {
                case "Personel Listesi":
                    OpenChildForm(new Forms.ChildForm.PersonelListe());
                    lblTitleChildForm.Text = "Personel Listesi";
                    break;
                case "Mesai İşlemleri":
                    OpenChildForm(new Forms.ChildForm.MesaiIslemleri());
                    lblTitleChildForm.Text = "Mesai İşlemleri";
                    break;
                case "İzin İşlemleri":
                    OpenChildForm(new Forms.ChildForm.IzinIslemleri());
                    lblTitleChildForm.Text = "İzin İşlemleri";
                    break;
                case "Profilim":
                    OpenChildForm(new Forms.ChildForm.Profil());
                    lblTitleChildForm.Text = "Profilim";
                    break;

                default:
                    lblTitleChildForm.Text = "";
                    break;
            }
        }

        //Child Form Ayarları MDI Degil
        public static Form currentChildForm;

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

    }
}
