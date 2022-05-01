namespace InsanKaynaklariYonetimi.UserControls
{
    partial class UC_PersonelAdd
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PersonelAdd));
            this.dtpDogumTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbPersonelTcNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPersonelTelNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPersonelSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPersonelAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pbFotograf = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnFotografSec = new Guna.UI2.WinForms.Guna2Button();
            this.tbPersonelAdres = new Guna.UI2.WinForms.Guna2TextBox();
            this.opdFotograf = new System.Windows.Forms.OpenFileDialog();
            this.btnPersonelEkle = new Guna.UI2.WinForms.Guna2Button();
            this.cbYetki = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStatu = new Guna.UI2.WinForms.Guna2TextBox();
            this.YetkiEllipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIseBaslamaTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pnlBilgiler = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.BilgilerEllipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLogin = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).BeginInit();
            this.pnlBilgiler.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.BorderRadius = 5;
            this.dtpDogumTarihi.CheckedState.Parent = this.dtpDogumTarihi;
            this.dtpDogumTarihi.FillColor = System.Drawing.SystemColors.Control;
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDogumTarihi.HoverState.Parent = this.dtpDogumTarihi;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(224, 365);
            this.dtpDogumTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDogumTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.ShadowDecoration.Parent = this.dtpDogumTarihi;
            this.dtpDogumTarihi.Size = new System.Drawing.Size(177, 28);
            this.dtpDogumTarihi.TabIndex = 6;
            this.dtpDogumTarihi.Value = new System.DateTime(2022, 4, 28, 11, 2, 57, 428);
            // 
            // tbPersonelTcNo
            // 
            this.tbPersonelTcNo.BorderRadius = 5;
            this.tbPersonelTcNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPersonelTcNo.DefaultText = "";
            this.tbPersonelTcNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPersonelTcNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPersonelTcNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelTcNo.DisabledState.Parent = this.tbPersonelTcNo;
            this.tbPersonelTcNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelTcNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelTcNo.FocusedState.Parent = this.tbPersonelTcNo;
            this.tbPersonelTcNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelTcNo.HoverState.Parent = this.tbPersonelTcNo;
            this.tbPersonelTcNo.Location = new System.Drawing.Point(224, 304);
            this.tbPersonelTcNo.MaxLength = 11;
            this.tbPersonelTcNo.Name = "tbPersonelTcNo";
            this.tbPersonelTcNo.PasswordChar = '\0';
            this.tbPersonelTcNo.PlaceholderText = "TC Kimlik Numarası";
            this.tbPersonelTcNo.SelectedText = "";
            this.tbPersonelTcNo.ShadowDecoration.Parent = this.tbPersonelTcNo;
            this.tbPersonelTcNo.Size = new System.Drawing.Size(177, 24);
            this.tbPersonelTcNo.TabIndex = 4;
            // 
            // tbPersonelTelNo
            // 
            this.tbPersonelTelNo.BorderRadius = 5;
            this.tbPersonelTelNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPersonelTelNo.DefaultText = "";
            this.tbPersonelTelNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPersonelTelNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPersonelTelNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelTelNo.DisabledState.Parent = this.tbPersonelTelNo;
            this.tbPersonelTelNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelTelNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelTelNo.FocusedState.Parent = this.tbPersonelTelNo;
            this.tbPersonelTelNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelTelNo.HoverState.Parent = this.tbPersonelTelNo;
            this.tbPersonelTelNo.Location = new System.Drawing.Point(224, 274);
            this.tbPersonelTelNo.MaxLength = 13;
            this.tbPersonelTelNo.Name = "tbPersonelTelNo";
            this.tbPersonelTelNo.PasswordChar = '\0';
            this.tbPersonelTelNo.PlaceholderText = "0(xxx)(xxx)(xxxx)";
            this.tbPersonelTelNo.SelectedText = "";
            this.tbPersonelTelNo.ShadowDecoration.Parent = this.tbPersonelTelNo;
            this.tbPersonelTelNo.Size = new System.Drawing.Size(177, 24);
            this.tbPersonelTelNo.TabIndex = 3;
            // 
            // tbPersonelSoyad
            // 
            this.tbPersonelSoyad.BorderRadius = 5;
            this.tbPersonelSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPersonelSoyad.DefaultText = "";
            this.tbPersonelSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPersonelSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPersonelSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelSoyad.DisabledState.Parent = this.tbPersonelSoyad;
            this.tbPersonelSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelSoyad.FocusedState.Parent = this.tbPersonelSoyad;
            this.tbPersonelSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelSoyad.HoverState.Parent = this.tbPersonelSoyad;
            this.tbPersonelSoyad.Location = new System.Drawing.Point(224, 244);
            this.tbPersonelSoyad.MaxLength = 30;
            this.tbPersonelSoyad.Name = "tbPersonelSoyad";
            this.tbPersonelSoyad.PasswordChar = '\0';
            this.tbPersonelSoyad.PlaceholderText = "Soyad";
            this.tbPersonelSoyad.SelectedText = "";
            this.tbPersonelSoyad.ShadowDecoration.Parent = this.tbPersonelSoyad;
            this.tbPersonelSoyad.Size = new System.Drawing.Size(177, 24);
            this.tbPersonelSoyad.TabIndex = 2;
            // 
            // tbPersonelAd
            // 
            this.tbPersonelAd.BorderRadius = 5;
            this.tbPersonelAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPersonelAd.DefaultText = "";
            this.tbPersonelAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPersonelAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPersonelAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelAd.DisabledState.Parent = this.tbPersonelAd;
            this.tbPersonelAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelAd.FocusedState.Parent = this.tbPersonelAd;
            this.tbPersonelAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelAd.HoverState.Parent = this.tbPersonelAd;
            this.tbPersonelAd.Location = new System.Drawing.Point(224, 214);
            this.tbPersonelAd.MaxLength = 30;
            this.tbPersonelAd.Name = "tbPersonelAd";
            this.tbPersonelAd.PasswordChar = '\0';
            this.tbPersonelAd.PlaceholderText = "Ad";
            this.tbPersonelAd.SelectedText = "";
            this.tbPersonelAd.ShadowDecoration.Parent = this.tbPersonelAd;
            this.tbPersonelAd.Size = new System.Drawing.Size(177, 24);
            this.tbPersonelAd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(145, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(78, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC Kimlik Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(52, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personel Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personel Adı:";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1057, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 15;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbFotograf
            // 
            this.pbFotograf.Image = ((System.Drawing.Image)(resources.GetObject("pbFotograf.Image")));
            this.pbFotograf.Location = new System.Drawing.Point(162, 20);
            this.pbFotograf.Name = "pbFotograf";
            this.pbFotograf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFotograf.ShadowDecoration.Parent = this.pbFotograf;
            this.pbFotograf.Size = new System.Drawing.Size(128, 128);
            this.pbFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotograf.TabIndex = 16;
            this.pbFotograf.TabStop = false;
            // 
            // btnFotografSec
            // 
            this.btnFotografSec.BorderRadius = 15;
            this.btnFotografSec.CheckedState.Parent = this.btnFotografSec;
            this.btnFotografSec.CustomImages.Parent = this.btnFotografSec;
            this.btnFotografSec.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotografSec.ForeColor = System.Drawing.Color.White;
            this.btnFotografSec.HoverState.Parent = this.btnFotografSec;
            this.btnFotografSec.Location = new System.Drawing.Point(162, 154);
            this.btnFotografSec.Name = "btnFotografSec";
            this.btnFotografSec.ShadowDecoration.Parent = this.btnFotografSec;
            this.btnFotografSec.Size = new System.Drawing.Size(128, 32);
            this.btnFotografSec.TabIndex = 17;
            this.btnFotografSec.Text = "Fotoğraf Seç";
            this.btnFotografSec.Click += new System.EventHandler(this.btnFotografSec_Click);
            // 
            // tbPersonelAdres
            // 
            this.tbPersonelAdres.BorderRadius = 5;
            this.tbPersonelAdres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPersonelAdres.DefaultText = "";
            this.tbPersonelAdres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPersonelAdres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPersonelAdres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelAdres.DisabledState.Parent = this.tbPersonelAdres;
            this.tbPersonelAdres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPersonelAdres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelAdres.FocusedState.Parent = this.tbPersonelAdres;
            this.tbPersonelAdres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPersonelAdres.HoverState.Parent = this.tbPersonelAdres;
            this.tbPersonelAdres.Location = new System.Drawing.Point(224, 435);
            this.tbPersonelAdres.Multiline = true;
            this.tbPersonelAdres.Name = "tbPersonelAdres";
            this.tbPersonelAdres.PasswordChar = '\0';
            this.tbPersonelAdres.PlaceholderText = "Ev Adresi";
            this.tbPersonelAdres.SelectedText = "";
            this.tbPersonelAdres.ShadowDecoration.Parent = this.tbPersonelAdres;
            this.tbPersonelAdres.Size = new System.Drawing.Size(304, 139);
            this.tbPersonelAdres.TabIndex = 8;
            // 
            // opdFotograf
            // 
            this.opdFotograf.FileName = "openFileDialog1";
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BorderRadius = 15;
            this.btnPersonelEkle.CheckedState.Parent = this.btnPersonelEkle;
            this.btnPersonelEkle.CustomImages.Parent = this.btnPersonelEkle;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelEkle.HoverState.Parent = this.btnPersonelEkle;
            this.btnPersonelEkle.Location = new System.Drawing.Point(178, 621);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.ShadowDecoration.Parent = this.btnPersonelEkle;
            this.btnPersonelEkle.Size = new System.Drawing.Size(128, 32);
            this.btnPersonelEkle.TabIndex = 17;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // cbYetki
            // 
            this.cbYetki.BackColor = System.Drawing.Color.Transparent;
            this.cbYetki.BorderRadius = 5;
            this.cbYetki.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYetki.FocusedColor = System.Drawing.Color.Empty;
            this.cbYetki.FocusedState.Parent = this.cbYetki;
            this.cbYetki.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbYetki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbYetki.FormattingEnabled = true;
            this.cbYetki.HoverState.Parent = this.cbYetki;
            this.cbYetki.IntegralHeight = false;
            this.cbYetki.ItemHeight = 16;
            this.cbYetki.Items.AddRange(new object[] {
            "Yönetici",
            "Şef",
            "Takım Lideri",
            "İşçi"});
            this.cbYetki.ItemsAppearance.Parent = this.cbYetki;
            this.cbYetki.Location = new System.Drawing.Point(92, 147);
            this.cbYetki.Name = "cbYetki";
            this.cbYetki.ShadowDecoration.Parent = this.cbYetki;
            this.cbYetki.Size = new System.Drawing.Size(140, 22);
            this.cbYetki.TabIndex = 11;
            this.cbYetki.SelectedIndexChanged += new System.EventHandler(this.cbYetki_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(8, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pozisyon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Yetkisi:";
            // 
            // tbStatu
            // 
            this.tbStatu.BorderRadius = 5;
            this.tbStatu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStatu.DefaultText = "";
            this.tbStatu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStatu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStatu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStatu.DisabledState.Parent = this.tbStatu;
            this.tbStatu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStatu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStatu.FocusedState.Parent = this.tbStatu;
            this.tbStatu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStatu.HoverState.Parent = this.tbStatu;
            this.tbStatu.Location = new System.Drawing.Point(108, 201);
            this.tbStatu.Name = "tbStatu";
            this.tbStatu.PasswordChar = '\0';
            this.tbStatu.PlaceholderText = "Pozisyon";
            this.tbStatu.SelectedText = "";
            this.tbStatu.ShadowDecoration.Parent = this.tbStatu;
            this.tbStatu.Size = new System.Drawing.Size(143, 24);
            this.tbStatu.TabIndex = 12;
            // 
            // YetkiEllipse
            // 
            this.YetkiEllipse.BorderRadius = 20;
            this.YetkiEllipse.TargetControl = this.pnlLogin;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(145, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderRadius = 5;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(224, 334);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Mail Adresi";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(177, 24);
            this.tbEmail.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(32, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "İşe Başlama Tarihi:";
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.BorderRadius = 5;
            this.dtpIseBaslamaTarihi.CheckedState.Parent = this.dtpIseBaslamaTarihi;
            this.dtpIseBaslamaTarihi.FillColor = System.Drawing.SystemColors.Control;
            this.dtpIseBaslamaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpIseBaslamaTarihi.HoverState.Parent = this.dtpIseBaslamaTarihi;
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(224, 401);
            this.dtpIseBaslamaTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpIseBaslamaTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.ShadowDecoration.Parent = this.dtpIseBaslamaTarihi;
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(177, 28);
            this.dtpIseBaslamaTarihi.TabIndex = 7;
            this.dtpIseBaslamaTarihi.Value = new System.DateTime(2022, 4, 28, 11, 2, 57, 428);
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.BackColor = System.Drawing.Color.Transparent;
            this.pnlBilgiler.Controls.Add(this.pbFotograf);
            this.pnlBilgiler.Controls.Add(this.label1);
            this.pnlBilgiler.Controls.Add(this.label2);
            this.pnlBilgiler.Controls.Add(this.btnFotografSec);
            this.pnlBilgiler.Controls.Add(this.label3);
            this.pnlBilgiler.Controls.Add(this.label4);
            this.pnlBilgiler.Controls.Add(this.label9);
            this.pnlBilgiler.Controls.Add(this.dtpIseBaslamaTarihi);
            this.pnlBilgiler.Controls.Add(this.label5);
            this.pnlBilgiler.Controls.Add(this.dtpDogumTarihi);
            this.pnlBilgiler.Controls.Add(this.label6);
            this.pnlBilgiler.Controls.Add(this.tbPersonelAdres);
            this.pnlBilgiler.Controls.Add(this.label10);
            this.pnlBilgiler.Controls.Add(this.tbEmail);
            this.pnlBilgiler.Controls.Add(this.tbPersonelAd);
            this.pnlBilgiler.Controls.Add(this.tbPersonelTcNo);
            this.pnlBilgiler.Controls.Add(this.tbPersonelSoyad);
            this.pnlBilgiler.Controls.Add(this.tbPersonelTelNo);
            this.pnlBilgiler.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.pnlBilgiler.Location = new System.Drawing.Point(15, 20);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.ShadowColor = System.Drawing.Color.Black;
            this.pnlBilgiler.Size = new System.Drawing.Size(575, 595);
            this.pnlBilgiler.TabIndex = 21;
            // 
            // BilgilerEllipse
            // 
            this.BilgilerEllipse.BorderRadius = 20;
            this.BilgilerEllipse.TargetControl = this.pnlBilgiler;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.tbStatu);
            this.pnlLogin.Controls.Add(this.tbUsername);
            this.pnlLogin.Controls.Add(this.cbYetki);
            this.pnlLogin.Controls.Add(this.label7);
            this.pnlLogin.Controls.Add(this.tbPassword);
            this.pnlLogin.Controls.Add(this.label8);
            this.pnlLogin.FillColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(629, 289);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowColor = System.Drawing.Color.Black;
            this.pnlLogin.Size = new System.Drawing.Size(273, 326);
            this.pnlLogin.TabIndex = 22;
            // 
            // tbUsername
            // 
            this.tbUsername.BorderRadius = 15;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbUsername.IconLeft")));
            this.tbUsername.IconLeftSize = new System.Drawing.Size(32, 32);
            this.tbUsername.Location = new System.Drawing.Point(36, 33);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "Kullanıcı Adı";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(200, 36);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.BorderRadius = 15;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbPassword.IconLeft")));
            this.tbPassword.IconLeftSize = new System.Drawing.Size(32, 32);
            this.tbPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("tbPassword.IconRight")));
            this.tbPassword.IconRightOffset = new System.Drawing.Point(5, 0);
            this.tbPassword.IconRightSize = new System.Drawing.Size(15, 15);
            this.tbPassword.Location = new System.Drawing.Point(36, 85);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Sifre";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(200, 36);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // UC_PersonelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlBilgiler);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnExit);
            this.Name = "UC_PersonelAdd";
            this.Size = new System.Drawing.Size(1100, 720);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).EndInit();
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDogumTarihi;
        private Guna.UI2.WinForms.Guna2TextBox tbPersonelTcNo;
        private Guna.UI2.WinForms.Guna2TextBox tbPersonelTelNo;
        private Guna.UI2.WinForms.Guna2TextBox tbPersonelSoyad;
        private Guna.UI2.WinForms.Guna2TextBox tbPersonelAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnExit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFotograf;
        private Guna.UI2.WinForms.Guna2Button btnFotografSec;
        private Guna.UI2.WinForms.Guna2TextBox tbPersonelAdres;
        private System.Windows.Forms.OpenFileDialog opdFotograf;
        private Guna.UI2.WinForms.Guna2Button btnPersonelEkle;
        private Guna.UI2.WinForms.Guna2ComboBox cbYetki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox tbStatu;
        private Guna.UI2.WinForms.Guna2Elipse YetkiEllipse;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpIseBaslamaTarihi;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlBilgiler;
        private Guna.UI2.WinForms.Guna2Elipse BilgilerEllipse;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
    }
}
