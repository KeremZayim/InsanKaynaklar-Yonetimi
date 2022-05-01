namespace InsanKaynaklariYonetimi.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainEllipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlPersonelInfo = new System.Windows.Forms.Panel();
            this.lblSoyad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pbImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfil = new Guna.UI2.WinForms.Guna2Button();
            this.btnIzınIslemleri = new Guna.UI2.WinForms.Guna2Button();
            this.btnMesaiIslemleri = new Guna.UI2.WinForms.Guna2Button();
            this.btnPersonelListesi = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.insanKaynaklariYonetimSistemiDataSet = new InsanKaynaklariYonetimi.InsanKaynaklariYonetimSistemiDataSet();
            this.insanKaynaklariYonetimSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlLeft.SuspendLayout();
            this.pnlPersonelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insanKaynaklariYonetimSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insanKaynaklariYonetimSistemiDataSetBindingSource)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainEllipse
            // 
            this.MainEllipse.BorderRadius = 25;
            this.MainEllipse.TargetControl = this;
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPozisyon.Location = new System.Drawing.Point(10, 226);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(160, 19);
            this.lblPozisyon.TabIndex = 3;
            this.lblPozisyon.Text = "Pozisyon: ";
            this.lblPozisyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPozisyon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.pnlLeft.Controls.Add(this.lblPozisyon);
            this.pnlLeft.Controls.Add(this.pnlPersonelInfo);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.guna2Button5);
            this.pnlLeft.Controls.Add(this.btnProfil);
            this.pnlLeft.Controls.Add(this.btnIzınIslemleri);
            this.pnlLeft.Controls.Add(this.btnMesaiIslemleri);
            this.pnlLeft.Controls.Add(this.btnPersonelListesi);
            this.pnlLeft.Controls.Add(this.imgSlide);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(180, 720);
            this.pnlLeft.TabIndex = 4;
            this.pnlLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // pnlPersonelInfo
            // 
            this.pnlPersonelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(206)))));
            this.pnlPersonelInfo.Controls.Add(this.lblSoyad);
            this.pnlPersonelInfo.Controls.Add(this.lblAd);
            this.pnlPersonelInfo.Controls.Add(this.guna2Separator1);
            this.pnlPersonelInfo.Controls.Add(this.pbImage);
            this.pnlPersonelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPersonelInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonelInfo.Name = "pnlPersonelInfo";
            this.pnlPersonelInfo.Size = new System.Drawing.Size(180, 223);
            this.pnlPersonelInfo.TabIndex = 6;
            this.pnlPersonelInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = false;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Enabled = false;
            this.lblSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoyad.Location = new System.Drawing.Point(10, 185);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(160, 19);
            this.lblSoyad.TabIndex = 6;
            this.lblSoyad.Text = "Surname";
            this.lblSoyad.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = false;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Enabled = false;
            this.lblAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAd.Location = new System.Drawing.Point(10, 164);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(160, 19);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Name";
            this.lblAd.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(25, 208);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(129, 10);
            this.guna2Separator1.TabIndex = 7;
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(23, 24);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(128, 128);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(14, 673);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(45, 38);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 22;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.CheckedState.Image")));
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button5.Location = new System.Drawing.Point(23, 554);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.Empty;
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(149, 43);
            this.guna2Button5.TabIndex = 2;
            this.guna2Button5.UseTransparentBackground = true;
            this.guna2Button5.CheckedChanged += new System.EventHandler(this.menuButtons_CheckedChanged);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.BorderRadius = 22;
            this.btnProfil.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProfil.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.btnProfil.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnProfil.CheckedState.Image = global::InsanKaynaklariYonetimi.Properties.Resources.profile_purple;
            this.btnProfil.CheckedState.Parent = this.btnProfil;
            this.btnProfil.CustomImages.Parent = this.btnProfil;
            this.btnProfil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.btnProfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.HoverState.Parent = this.btnProfil;
            this.btnProfil.Image = global::InsanKaynaklariYonetimi.Properties.Resources.profile_white;
            this.btnProfil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProfil.ImageSize = new System.Drawing.Size(32, 32);
            this.btnProfil.Location = new System.Drawing.Point(23, 491);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.PressedColor = System.Drawing.Color.Empty;
            this.btnProfil.ShadowDecoration.Parent = this.btnProfil;
            this.btnProfil.Size = new System.Drawing.Size(149, 43);
            this.btnProfil.TabIndex = 2;
            this.btnProfil.Text = "Profilim";
            this.btnProfil.UseTransparentBackground = true;
            this.btnProfil.CheckedChanged += new System.EventHandler(this.menuButtons_CheckedChanged);
            // 
            // btnIzınIslemleri
            // 
            this.btnIzınIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btnIzınIslemleri.BorderRadius = 22;
            this.btnIzınIslemleri.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnIzınIslemleri.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.btnIzınIslemleri.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnIzınIslemleri.CheckedState.Image = global::InsanKaynaklariYonetimi.Properties.Resources.airplane_purple;
            this.btnIzınIslemleri.CheckedState.Parent = this.btnIzınIslemleri;
            this.btnIzınIslemleri.CustomImages.Parent = this.btnIzınIslemleri;
            this.btnIzınIslemleri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.btnIzınIslemleri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnIzınIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnIzınIslemleri.HoverState.Parent = this.btnIzınIslemleri;
            this.btnIzınIslemleri.Image = global::InsanKaynaklariYonetimi.Properties.Resources.airplane_white;
            this.btnIzınIslemleri.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIzınIslemleri.ImageSize = new System.Drawing.Size(32, 32);
            this.btnIzınIslemleri.Location = new System.Drawing.Point(23, 428);
            this.btnIzınIslemleri.Name = "btnIzınIslemleri";
            this.btnIzınIslemleri.PressedColor = System.Drawing.Color.Empty;
            this.btnIzınIslemleri.ShadowDecoration.Parent = this.btnIzınIslemleri;
            this.btnIzınIslemleri.Size = new System.Drawing.Size(149, 43);
            this.btnIzınIslemleri.TabIndex = 2;
            this.btnIzınIslemleri.Text = "İzin İşlemleri";
            this.btnIzınIslemleri.TextOffset = new System.Drawing.Point(10, 0);
            this.btnIzınIslemleri.UseTransparentBackground = true;
            this.btnIzınIslemleri.CheckedChanged += new System.EventHandler(this.menuButtons_CheckedChanged);
            // 
            // btnMesaiIslemleri
            // 
            this.btnMesaiIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.btnMesaiIslemleri.BorderRadius = 22;
            this.btnMesaiIslemleri.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMesaiIslemleri.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.btnMesaiIslemleri.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMesaiIslemleri.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMesaiIslemleri.CheckedState.Image")));
            this.btnMesaiIslemleri.CheckedState.Parent = this.btnMesaiIslemleri;
            this.btnMesaiIslemleri.CustomImages.Parent = this.btnMesaiIslemleri;
            this.btnMesaiIslemleri.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.btnMesaiIslemleri.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnMesaiIslemleri.ForeColor = System.Drawing.Color.White;
            this.btnMesaiIslemleri.HoverState.Parent = this.btnMesaiIslemleri;
            this.btnMesaiIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnMesaiIslemleri.Image")));
            this.btnMesaiIslemleri.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMesaiIslemleri.ImageSize = new System.Drawing.Size(32, 32);
            this.btnMesaiIslemleri.Location = new System.Drawing.Point(23, 365);
            this.btnMesaiIslemleri.Name = "btnMesaiIslemleri";
            this.btnMesaiIslemleri.PressedColor = System.Drawing.Color.Empty;
            this.btnMesaiIslemleri.ShadowDecoration.Parent = this.btnMesaiIslemleri;
            this.btnMesaiIslemleri.Size = new System.Drawing.Size(149, 43);
            this.btnMesaiIslemleri.TabIndex = 2;
            this.btnMesaiIslemleri.Text = "Mesai İşlemleri";
            this.btnMesaiIslemleri.TextOffset = new System.Drawing.Point(13, 0);
            this.btnMesaiIslemleri.UseTransparentBackground = true;
            this.btnMesaiIslemleri.CheckedChanged += new System.EventHandler(this.menuButtons_CheckedChanged);
            // 
            // btnPersonelListesi
            // 
            this.btnPersonelListesi.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelListesi.BorderRadius = 22;
            this.btnPersonelListesi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPersonelListesi.Checked = true;
            this.btnPersonelListesi.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.btnPersonelListesi.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnPersonelListesi.CheckedState.Image = global::InsanKaynaklariYonetimi.Properties.Resources.personel_purple;
            this.btnPersonelListesi.CheckedState.Parent = this.btnPersonelListesi;
            this.btnPersonelListesi.CustomImages.Parent = this.btnPersonelListesi;
            this.btnPersonelListesi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.btnPersonelListesi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnPersonelListesi.ForeColor = System.Drawing.Color.White;
            this.btnPersonelListesi.HoverState.Parent = this.btnPersonelListesi;
            this.btnPersonelListesi.Image = global::InsanKaynaklariYonetimi.Properties.Resources.personel_white;
            this.btnPersonelListesi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPersonelListesi.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPersonelListesi.Location = new System.Drawing.Point(23, 302);
            this.btnPersonelListesi.Name = "btnPersonelListesi";
            this.btnPersonelListesi.PressedColor = System.Drawing.Color.Empty;
            this.btnPersonelListesi.ShadowDecoration.Parent = this.btnPersonelListesi;
            this.btnPersonelListesi.Size = new System.Drawing.Size(149, 43);
            this.btnPersonelListesi.TabIndex = 2;
            this.btnPersonelListesi.Text = "Personel Listesi";
            this.btnPersonelListesi.TextOffset = new System.Drawing.Point(10, 0);
            this.btnPersonelListesi.UseTransparentBackground = true;
            this.btnPersonelListesi.CheckedChanged += new System.EventHandler(this.menuButtons_CheckedChanged);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(141, 272);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 0;
            this.imgSlide.TabStop = false;
            // 
            // insanKaynaklariYonetimSistemiDataSet
            // 
            this.insanKaynaklariYonetimSistemiDataSet.DataSetName = "InsanKaynaklariYonetimSistemiDataSet";
            this.insanKaynaklariYonetimSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insanKaynaklariYonetimSistemiDataSetBindingSource
            // 
            this.insanKaynaklariYonetimSistemiDataSetBindingSource.DataSource = this.insanKaynaklariYonetimSistemiDataSet;
            this.insanKaynaklariYonetimSistemiDataSetBindingSource.Position = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Transparent;
            this.panelDesktop.Controls.Add(this.lblTitleChildForm);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(180, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1100, 720);
            this.panelDesktop.TabIndex = 5;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = false;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Enabled = false;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleChildForm.Location = new System.Drawing.Point(18, 12);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(194, 22);
            this.lblTitleChildForm.TabIndex = 6;
            this.lblTitleChildForm.Text = null;
            this.lblTitleChildForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            this.pnlLeft.ResumeLayout(false);
            this.pnlPersonelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insanKaynaklariYonetimSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insanKaynaklariYonetimSistemiDataSetBindingSource)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse MainEllipse;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnProfil;
        private Guna.UI2.WinForms.Guna2Button btnIzınIslemleri;
        private Guna.UI2.WinForms.Guna2Button btnMesaiIslemleri;
        private Guna.UI2.WinForms.Guna2Button btnPersonelListesi;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbImage;
        private System.Windows.Forms.Panel pnlPersonelInfo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAd;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoyad;
        private System.Windows.Forms.BindingSource insanKaynaklariYonetimSistemiDataSetBindingSource;
        private InsanKaynaklariYonetimSistemiDataSet insanKaynaklariYonetimSistemiDataSet;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleChildForm;
        public System.Windows.Forms.Panel panelDesktop;
    }
}