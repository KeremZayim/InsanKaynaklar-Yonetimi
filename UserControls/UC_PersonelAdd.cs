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
using System.Text.RegularExpressions;

namespace InsanKaynaklariYonetimi.UserControls
{
    public partial class UC_PersonelAdd : UserControl
    {

        string statu;
        string DosyaYolu;
        int personelin_id;
        SqlConnection SQLBaglanti = new SqlConnection(SqlSunucu.SQLSunucuStr);
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PersonelAdd));

        public UC_PersonelAdd()
        {
            InitializeComponent();
            cbYetki.Text = "Yönetici";
            statu = "manager";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYetki.Text == "Yönetici")
            {
                statu = "manager";
            }
            else if (cbYetki.Text == "Şef")
            {
                statu = "chief";
            }
            else if (cbYetki.Text == "Takım Lideri")
            {
                statu = "team_leader";
            }
            else if (cbYetki.Text == "İşçi")
            {
                statu = "worker";
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btnFotografSec_Click(object sender, EventArgs e)
        {
            ofd.Title = "Fotoğraf Seç";
            ofd.Filter = "Resim Dosyası |*.png|Resim Dosyası|*.jpg";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFotograf.Image = Image.FromFile(ofd.FileName);
                DosyaYolu = ofd.FileName;
            }
        }
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (tbPersonelAd.Text == "" || tbPersonelSoyad.Text == "" | tbPersonelTcNo.Text == "" | tbPersonelTelNo.Text == "" | tbStatu.Text == "" || tbPersonelAdres.Text == "" || dtpDogumTarihi.Text == "" || cbYetki.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DosyaYolu == null)
            {
                MessageBox.Show("Lütfen Fotoğraf Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream filestream = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(filestream);
                byte[] resim = binaryReader.ReadBytes((int)filestream.Length);
                binaryReader.Close();
                filestream.Close();

                SQLBaglanti.Open();

                SqlCommand cmd = new SqlCommand("insert into personel(name,surname,tel_no,tc_no,fotograf,dogum_tarihi,adres,email,ise_baslama_tarihi) values(@name,@surname,@tel_no,@tc_no,@fotograf,@dogum_tarihi,@adres,@email,@ise_baslama_tarihi)", SQLBaglanti);
                cmd.Parameters.AddWithValue("@name", tbPersonelAd.Text);
                cmd.Parameters.AddWithValue("@surname", tbPersonelSoyad.Text);
                cmd.Parameters.AddWithValue("@tel_no", tbPersonelTelNo.Text);
                cmd.Parameters.AddWithValue("@tc_no", tbPersonelTcNo.Text);
                cmd.Parameters.AddWithValue("@adres", tbPersonelAdres.Text);
                cmd.Parameters.AddWithValue("@dogum_tarihi", dtpDogumTarihi.Value);
                cmd.Parameters.AddWithValue("@ise_baslama_tarihi", dtpIseBaslamaTarihi.Value);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.Add("@fotograf", SqlDbType.Image, resim.Length).Value = resim;
                cmd.ExecuteNonQuery();

                SqlCommand pid = new SqlCommand("SELECT MAX(personel_id) AS [pid] FROM personel", SQLBaglanti);
                SqlDataReader dr = pid.ExecuteReader();

                try
                {
                    if (dr.Read())
                    {
                        personelin_id = (int)dr["pid"];
                    }

                }
                catch (Exception)
                {
                    personelin_id = 1;
                }
                SQLBaglanti.Close();

                SQLBaglanti.Open();

                SqlCommand cmd2 = new SqlCommand("insert into personel_auth(authority,position_name,personel_id) values(@authority,@position_name,@personel_id)", SQLBaglanti);
                cmd2.Parameters.AddWithValue("@authority", cbYetki.Text);
                cmd2.Parameters.AddWithValue("@position_name", tbStatu.Text);
                cmd2.Parameters.AddWithValue("@personel_id", personelin_id);
                cmd2.ExecuteNonQuery();

                SQLBaglanti.Close();

                MessageBox.Show(tbPersonelAd.Text + " " + tbPersonelSoyad.Text + "Adlı Personel Başarıyla Eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Sıfırlama
                tbPersonelAd.Text = "";
                tbPersonelSoyad.Text = "";
                tbPersonelTcNo.Text = "";
                tbPersonelTelNo.Text = "";
                tbPersonelAdres.Text = "";
                tbEmail.Text = "";
                tbStatu.Text = "";
                pbFotograf.Image = ((System.Drawing.Image)(resources.GetObject("pbFotograf.Image")));

            }
        }
    }
}
