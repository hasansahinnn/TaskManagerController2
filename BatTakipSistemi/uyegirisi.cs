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

namespace BatTakipSistemi
{
    public partial class uyegirisi : Form
    {
        public uyegirisi()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        uyeol uyeoll = new uyeol();
        duzenle duzen = new duzenle();
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }






        //------------------------------------------ KARAKTER KISITLAMASI---------------------------------

        private void uyegirisi_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeoll.ShowDialog();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
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
                if ((textBox3.Text.Trim() == "") || (textBox4.Text.Trim() == ""))

                {
                    if (textBox3.Text == "")
                        errorProvider1.SetError(textBox3, "Bu alan boş geçilemez");
                    else
                        errorProvider1.SetError(textBox3, "");
                    if (textBox4.Text == "")
                        errorProvider1.SetError(textBox4, "Bu alan boş geçilemez");
                    else
                        errorProvider1.SetError(textBox4, "");
                }
                else
                {
                    SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                    conn53.Open();
                    SqlCommand kmt33 = new SqlCommand("select ID from Logins where KullaniciAdi='" + textBox3.Text.Trim() + "' and Sifre='" + textBox4.Text.Trim() + "'", conn53);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {

                        string id = dr["ID"].ToString(); int id2 = Convert.ToInt16(id); frm1.id3 = id2; conn53.Close();
                        frm1.user = textBox3.Text.Trim();
                        frm1.Show(); this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
            uyeoll.ShowDialog();
        }
    }
}
