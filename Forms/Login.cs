using InsanKaynaklariYonetimi.Classes;
using InsanKaynaklariYonetimi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsanKaynaklarıYonetimi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select *From login_informationes Where username = '" + tbUsername.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'";
                
                SqlDataAdapter sda = new SqlDataAdapter(query, Fonksiyonlar.SQLBaglanti);

                DataTable dtbl = new DataTable();

                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    //Pozisyon Yazısı
                    string queryposition = "Select position From login_informationes Where username = '" + tbUsername.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(queryposition,Fonksiyonlar.SQLBaglanti);
                    Fonksiyonlar.SQLBaglanti.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Ayarlar.pozisyon = dr["position"].ToString().Trim();
                    }
                    Fonksiyonlar.SQLBaglanti.Close();
                    Ayarlar.KullaniciAdi = tbUsername.Text;
                    Ayarlar.Sifre = tbPassword.Text;

                    //Login Formunu Kapatıp Main Formu Açtırma
                    Main AnaForm = new Main();
                    this.Hide();
                    AnaForm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adın veya şifren yanlış!", "Giriş Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Tabanı Bağlantısı Kurulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbPassword_IconRightClick(object sender, EventArgs e)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            if (tbPassword.UseSystemPasswordChar == false)
            {
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("tbPassword.IconRight")));
            }
            else if (tbPassword.UseSystemPasswordChar == true)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("pbVisible.Image")));
            }
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
