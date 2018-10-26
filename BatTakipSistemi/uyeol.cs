using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BatTakipSistemi
{
    public partial class uyeol : Form
    {
        SqlConnection conn2 =new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        public uyeol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uyeol_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }







        //------------------------------------------ KARAKTER KISITLAMASI---------------------------------

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (char.IsPunctuation(e.KeyChar))
                {
                MessageBox.Show("Bu karakteri Kullanamazsınız!");
                e.Handled = true;
                }
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!");
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') ||(e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!");
                e.Handled = true;
               
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!");
                e.Handled = true;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rastgele = new Random();
                int sayi = rastgele.Next(1000000);
                SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                conn53.Open();
                SqlCommand kmt33 = new SqlCommand("select KullaniciAdi from Logins where KullaniciAdi='" + textBox3.Text.Trim() + "'", conn53);
                SqlDataReader dr = kmt33.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Kullanıcı Mevcut!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if ((textBox1.Text.Trim() == "") || (textBox2.Text.Trim() == "") || (textBox3.Text.Trim() == "") || (textBox4.Text.Trim() == "") || (textBox5.Text.Trim() == ""))

                    {
                        if (textBox1.Text == "")
                            errorProvider1.SetError(textBox1, "Bu alan boş geçilemez");
                        else
                            errorProvider1.SetError(textBox1, "");
                        if (textBox2.Text == "")
                            errorProvider1.SetError(textBox2, "Bu alan boş geçilemez");
                        else
                            errorProvider1.SetError(textBox2, "");
                        if (textBox3.Text == "")
                            errorProvider1.SetError(textBox3, "Bu alan boş geçilemez");
                        else
                            errorProvider1.SetError(textBox3, "");
                        if (textBox4.Text == "")
                            errorProvider1.SetError(textBox4, "Bu alan boş geçilemez");
                        else
                            errorProvider1.SetError(textBox4, "");
                        if (textBox5.Text == "")
                            errorProvider1.SetError(textBox5, "Bu alan boş geçilemez");
                        else
                            errorProvider1.SetError(textBox5, "");

                    }
                    else
                    {
                        errorProvider1.SetError(textBox1, "");
                        errorProvider1.SetError(textBox2, "");
                        errorProvider1.SetError(textBox3, "");
                        errorProvider1.SetError(textBox4, "");

                        if (textBox4.Text.Trim() == textBox5.Text.Trim())
                        {
                            errorProvider1.SetError(textBox5, "");
                            conn2.Open();
                            SqlCommand kmt3 = new SqlCommand("insert into Logins(FirmaAdi,EPosta,KullaniciAdi,Sifre,AdminYetki) VALUES('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','" + sayi + "')", conn2);
                            kmt3.ExecuteNonQuery();
                            //------------------------------- UYE Oluşturma ----------------------------
                            conn2.Close();
                            MessageBox.Show("Tebrikler! Hesabınız Başarıyla Oluşturuldu! Admin Yetki Şifrenizi Giriş Yaptıktan Sonra Düzenle Kısmından Değiştirebilirsiniz.Site üzerinden Giriş Ekranında  Admin Yetki Şifresini Giren Kişiler Uzaktan Kontrole Sahip Olurlar!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            errorProvider1.SetError(textBox5, "Şifreler Aynı Olmalıdır!");
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sorun oluştu. Lütfen İnternetinizi Kontrol Edin!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
