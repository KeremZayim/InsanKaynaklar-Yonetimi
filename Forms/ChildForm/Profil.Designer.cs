using InsanKaynaklariYonetimi.Classes;

namespace InsanKaynaklariYonetimi.Forms.ChildForm
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            this.pnlKullaniciBilgileri = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblSoyad = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pbImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIseBaslamaTarihi = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.KullaniciBiglileriEllipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pnlKullaniciBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKullaniciBilgileri
            // 
            this.pnlKullaniciBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(102)))), ((int)(((byte)(226)))));
            this.pnlKullaniciBilgileri.Controls.Add(this.lblSoyad);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblAd);
            this.pnlKullaniciBilgileri.Controls.Add(this.guna2Separator1);
            this.pnlKullaniciBilgileri.Controls.Add(this.pbImage);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblAdres);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblIseBaslamaTarihi);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblDogumTarihi);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblTelNo);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblTcNo);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblmail);
            this.pnlKullaniciBilgileri.Controls.Add(this.lblPozisyon);
            this.pnlKullaniciBilgileri.Location = new System.Drawing.Point(52, 26);
            this.pnlKullaniciBilgileri.Name = "pnlKullaniciBilgileri";
            this.pnlKullaniciBilgileri.ShadowDecoration.Depth = 20;
            this.pnlKullaniciBilgileri.ShadowDecoration.Enabled = true;
            this.pnlKullaniciBilgileri.ShadowDecoration.Parent = this.pnlKullaniciBilgileri;
            this.pnlKullaniciBilgileri.Size = new System.Drawing.Size(316, 439);
            this.pnlKullaniciBilgileri.TabIndex = 0;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = false;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Enabled = false;
            this.lblSoyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSoyad.Location = new System.Drawing.Point(81, 191);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(160, 19);
            this.lblSoyad.TabIndex = 9;
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
            this.lblAd.Location = new System.Drawing.Point(81, 170);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(160, 19);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "Name";
            this.lblAd.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(96, 214);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(129, 10);
            this.guna2Separator1.TabIndex = 12;
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(94, 30);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(128, 128);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 11;
            this.pbImage.TabStop = false;
            // 
            // lblAdres
            // 
            this.lblAdres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAdres.Location = new System.Drawing.Point(8, 375);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(299, 57);
            this.lblAdres.TabIndex = 8;
            this.lblAdres.Text = "Adres";
            this.lblAdres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIseBaslamaTarihi
            // 
            this.lblIseBaslamaTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIseBaslamaTarihi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIseBaslamaTarihi.Location = new System.Drawing.Point(8, 352);
            this.lblIseBaslamaTarihi.Name = "lblIseBaslamaTarihi";
            this.lblIseBaslamaTarihi.Size = new System.Drawing.Size(299, 19);
            this.lblIseBaslamaTarihi.TabIndex = 8;
            this.lblIseBaslamaTarihi.Text = "İşe Başlama Tarihi";
            this.lblIseBaslamaTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDogumTarihi.Location = new System.Drawing.Point(8, 329);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(299, 19);
            this.lblDogumTarihi.TabIndex = 8;
            this.lblDogumTarihi.Text = "DogumTarihi";
            this.lblDogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelNo
            // 
            this.lblTelNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelNo.Location = new System.Drawing.Point(8, 306);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(299, 19);
            this.lblTelNo.TabIndex = 8;
            this.lblTelNo.Text = "TelNo";
            this.lblTelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTcNo
            // 
            this.lblTcNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTcNo.Location = new System.Drawing.Point(8, 283);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(299, 19);
            this.lblTcNo.TabIndex = 8;
            this.lblTcNo.Text = "TcNo";
            this.lblTcNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmail
            // 
            this.lblmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblmail.Location = new System.Drawing.Point(8, 260);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(299, 19);
            this.lblmail.TabIndex = 8;
            this.lblmail.Text = "Mail";
            this.lblmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPozisyon.Location = new System.Drawing.Point(8, 237);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(299, 19);
            this.lblPozisyon.TabIndex = 8;
            this.lblPozisyon.Text = "Pozisyon: ";
            this.lblPozisyon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KullaniciBiglileriEllipse
            // 
            this.KullaniciBiglileriEllipse.BorderRadius = 20;
            this.KullaniciBiglileriEllipse.TargetControl = this.pnlKullaniciBilgileri;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::InsanKaynaklariYonetimi.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1002, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 50);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1048, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 50);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 14;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(226)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pnlKullaniciBilgileri);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Profil_Load);
            this.pnlKullaniciBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoyad;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbImage;
        private System.Windows.Forms.Label lblPozisyon;
        private Guna.UI2.WinForms.Guna2Elipse KullaniciBiglileriEllipse;
        private System.Windows.Forms.Label lblIseBaslamaTarihi;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnExit;
        protected internal Guna.UI2.WinForms.Guna2GradientPanel pnlKullaniciBilgileri;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lblAd;
    }
}