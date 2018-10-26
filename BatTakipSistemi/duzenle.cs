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
    public partial class duzenle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        SqlConnection baglanti2 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        SqlConnection baglanti3 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        SqlConnection baglanti4 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");

        SqlConnection baglanti5 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        SqlConnection baglanti6 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");

        public int id4,id5;
        string[] dostdizi = { "", "", "", "","" };
        string[] dostad = { "", "", "", "", "" };
        string[] dostsifre = { "", "", "", "", "" };
        public string username,DosyaYolu;

       

        private void button15_Click(object sender, EventArgs e)
        {

        }



        //----------------------------------- KEY PRESS -------------------------------------------------

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '"') || (e.KeyChar == '=') || (e.KeyChar == '/'))
            {
                MessageBox.Show("Bu karakteri Kullanamazsınız!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
        }

        //----------------------------------- KEY PRESS -------------------------------------------------







        //----------------------------------- CLIENTLER -------------------------------------------------

        private void button24_Click(object sender, EventArgs e)
        {
          


        }

        private void button15_Click_1(object sender, EventArgs e)
        {
         

        }

        private void button21_Click(object sender, EventArgs e)
        {
        }

        private void button22_Click(object sender, EventArgs e)
        {
        }

        private void button23_Click(object sender, EventArgs e)
        {
        }

        //----------------------------------- CLIENTLER -------------------------------------------------













        //----------------------------------- CLIENT SIL ------------------------------------------------

        private void button16_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
          
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        //----------------------------------- CLIENT SIL ------------------------------------------------







        //----------------------------------- lİSTBOX ---------------------------------------------------

        private void button27_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
           

        }

        //----------------------------------- lİSTBOX ---------------------------------------------------




        //----------------------------------- SERVİSLERİ GÜNCELLE ---------------------------------------

        private void button26_Click(object sender, EventArgs e)
        {
           


        }

        //----------------------------------- SERVİSLERİ GÜNCELLE ---------------------------------------


        //----------------------------------- ADMİN ŞİFRE GÜNCELLE --------------------------------------
        private void button25_Click(object sender, EventArgs e)
        {
           

        }
        //----------------------------------- ADMİN ŞİFRE GÜNCELLE --------------------------------------









        //------------------------------------ DOSYA SEÇ-------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
         
        }
        

        //------------------------------------ DOSYA SEÇ-------------------------------------------------






        public duzenle()
        {
            InitializeComponent();
        }


        //----------------------------------- SAYFAYI DOLDUR --------------------------------------------

        private void duzenle_Load(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select * from Uygulamalars where Userid=" + id4 + " and IsServis='True'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    listBox1.Items.Add(dr["UygulamaAdi"].ToString());
                }
                baglanti.Close();

                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select * from Uygulamalars where Userid=" + id4 + " and IsServis='False'";
                komut.ExecuteNonQuery();
                SqlDataReader dr2 = komut.ExecuteReader();

                while (dr2.Read())
                {
                    listBox2.Items.Add(dr2["UygulamaAdi"].ToString());
                    listBox3.Items.Add(dr2["PUzanti"].ToString());
                }
                baglanti.Close();

                SqlCommand komut3 = new SqlCommand();
                baglanti.Open();
                komut3.Connection = baglanti;
                komut3.CommandText = "select * from Logins where ID=" + id4 + "";
                komut3.ExecuteNonQuery(); SqlDataReader dr3 = komut3.ExecuteReader();
                if (dr3.Read())
                {
                    baglanti2.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where ID='" + dr3["Client1"] + "'", baglanti2);
                    SqlDataReader dr5 = kmt33.ExecuteReader();
                    if (dr5.Read())
                    {dostad[0]= dr5["KullaniciAdi"].ToString();
                        textBox3.Text = dr5["KullaniciAdi"].ToString();
                        textBox15.Text = "**********";
                        textBox29.Text = "**********"; baglanti2.Close();
                    }
                    baglanti3.Open();
                    SqlCommand kmt34 = new SqlCommand("select * from Logins where ID='" + dr3["Client2"] + "'", baglanti3);
                    SqlDataReader dr34 = kmt34.ExecuteReader();
                    if (dr34.Read())
                    {
                        dostad[1] = dr34["KullaniciAdi"].ToString();
                        textBox16.Text = dr34["KullaniciAdi"].ToString();
                        textBox17.Text = "**********";
                        textBox28.Text = "**********"; baglanti3.Close();
                    }
                    baglanti4.Open();
                    SqlCommand kmt35 = new SqlCommand("select * from Logins where ID='" + dr3["Client3"] + "'", baglanti4);
                    SqlDataReader dr35 = kmt35.ExecuteReader();
                    if (dr35.Read())
                    {
                        dostad[2] = dr35["KullaniciAdi"].ToString();
                        textBox18.Text = dr35["KullaniciAdi"].ToString();
                        textBox19.Text = "**********";
                        textBox27.Text = "**********"; baglanti4.Close();
                    }
                    baglanti5.Open();
                    SqlCommand kmt36 = new SqlCommand("select * from Logins where ID='" + dr3["Client4"] + "'", baglanti5);
                    SqlDataReader dr36 = kmt36.ExecuteReader();
                    if (dr36.Read())
                    {
                        dostad[3] = dr36["KullaniciAdi"].ToString();
                        textBox20.Text = dr36["KullaniciAdi"].ToString();
                        textBox21.Text = "**********";
                        textBox26.Text = "**********"; baglanti5.Close();
                    }
                    baglanti6.Open();
                    SqlCommand kmt37 = new SqlCommand("select * from Logins where ID='" + dr3["Client5"] + "'", baglanti6);
                    SqlDataReader dr37 = kmt37.ExecuteReader();
                    if (dr37.Read())
                    {
                        dostad[4] = dr37["KullaniciAdi"].ToString();
                        textBox22.Text = dr37["KullaniciAdi"].ToString();
                        textBox23.Text = "**********";
                        textBox25.Text = "**********"; baglanti6.Close();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Sorun oluştu. Lütfen İnternetinizi Kontrol Edin!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            //-----------SAYFAYI Doldur-----------\\




        }
        //----------------------------------- SAYFAYI DOLDUR ----------------------------------------








        //----------------------------------- CLIENTLER BİLGİLERİ ---------------------------------------
        void al()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");

               
                for (int i = 0; i < 5; i++)
                {
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where Id=" + Convert.ToInt16(dostdizi[i]) + "", baglanti);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {
                        dostad[i] = dr["Username"].ToString();
                        dostsifre[i] = dr["Password"].ToString();
                    }
                    baglanti.Close();
                }
               
            }
            catch (Exception)
            {
            }
           
        }
        //----------------------------------- CLIENTLER BİLGİLERİ ---------------------------------------


        //----------------------------------- UYGULAMALARI GÜNCELLE -------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {


        }
        //----------------------------------- UYGULAMALARI GÜNCELLE -------------------------------------





        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {

                baglanti.Close();
                baglanti.Open();
                SqlCommand kmt5 = new SqlCommand("delete from  Uygulamalars  where Userid=" + id4 + " and IsServis='False'", baglanti);
                kmt5.ExecuteNonQuery();
                baglanti.Close();
                int b, c;
                c = listBox2.Items.Count;

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    b = i + 1; baglanti2.Close();
                    baglanti2.Open();
                    SqlCommand kmt4 = new SqlCommand("insert into Uygulamalars (UygulamaAdi,Cpu,Ram,IsAcik,IsServis,Userid,PUzanti)VALUES('" + listBox2.Items[i].ToString() + "','','','False','False','" + id4 + "','" + listBox3.Items[i].ToString() + "')", baglanti2);
                    kmt4.ExecuteNonQuery();
                    baglanti.Close(); baglanti2.Close();

                }
                MessageBox.Show("Başarıyla Güncellendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Sorun oluştu. Lütfen İnternetinizi Kontrol Edin!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int a = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(a);
            listBox3.Items.RemoveAt(a);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            baglanti.Open();
            SqlCommand kmt5 = new SqlCommand("delete from  Uygulamalars  where Userid=" + id4 + " and IsServis='True'", baglanti);
            kmt5.ExecuteNonQuery();
            baglanti.Close();
            int b, c;
            c = listBox1.Items.Count;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                b = i + 1;
                baglanti.Open();
                SqlCommand kmt4 = new SqlCommand("insert into Uygulamalars (UygulamaAdi,Cpu,Ram,IsAcik,IsServis,Userid)VALUES('" + listBox1.Items[i].ToString() + "','','','False','True'," + id4 + ")", baglanti);
                kmt4.ExecuteNonQuery();
                baglanti.Close();

            }
            MessageBox.Show("Başarıyla Güncellendi!");




            Form1 frm1 = new Form1();
            frm1.OpenFile();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox2.Items.Add(textBox1.Text);
                if (DosyaYolu == null)
                    DosyaYolu = "";
                listBox3.Items.Add(DosyaYolu);
                DosyaYolu = "";
                textBox1.Text = "";
            }
            else
            { }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (textBox30.Text != "")
            {
                listBox1.Items.Add(textBox30.Text);
                textBox30.Text = "";
            }
            else
            { }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Bat Dosyası | *.exe; | Bat Dosyası | *.bat; | Tüm Dosyalar | *.* ";
            dosya.Title = "Uygulamalars Uzantı Ekle";
            dosya.ShowDialog();
            DosyaYolu = dosya.FileName;
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kmt4 = new SqlCommand("update Logins set Sifre='" + textBox4.Text.Trim() + "' where KullaniciAdi='" + username + "'", baglanti);
                kmt4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Şifre Başarıyla Güncellendi!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Sorun oluştu. Lütfen İnternetinizi Kontrol Edin!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                SqlCommand kmt4 = new SqlCommand("update Logins set AdminYetki='" + textBox24.Text.Trim() + "' where ID=" + id4 + "", baglanti);
                kmt4.ExecuteNonQuery();
                baglanti.Close(); MessageBox.Show("Admin Şifreniz Güncellendi!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Sorun oluştu. Lütfen İnternetinizi Kontrol Edin!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox15.Text == "")
                    MessageBox.Show("Boş Bırakmayın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {

                    SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                    conn53.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where KullaniciAdi='" + textBox3.Text.Trim() + "' and Sifre='" + textBox15.Text.Trim() + "'", conn53);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox29.Text.Trim() != "")
                        {
                            if (dr["AdminYetki"].ToString() == textBox29.Text.Trim())
                            {
                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand kmt34 = new SqlCommand("update Logins set ClientYetki1='" + dr["AdminYetki"] + "',Client1='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                                kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                                MessageBox.Show("Admin Yetkili Kullanıcı Ekleme İşlemi Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dostad[0] = textBox3.Text.Trim(); baglanti.Close(); conn53.Close();
                            }
                            else
                            {
                                conn53.Close();
                                MessageBox.Show("Admin Yetki Şifresi Yanlış! Burayı Boş Geçebilirsiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            baglanti.Close();
                            baglanti.Open();
                            SqlCommand kmt34 = new SqlCommand("update Logins set Client1='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                            kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                            MessageBox.Show("Kullanıcı Ekleme Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dostad[0] = textBox3.Text.Trim(); baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand kmt4 = new SqlCommand("update Logins set Client1='',ClientYetki1='' where ID=" + id4 + "", baglanti);
                kmt4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("CLIENT Kaldırıldı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dostad[0] = ""; dostsifre[0] = ""; textBox3.Text = ""; textBox15.Text = ""; textBox29.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox15.Text == "")
                    MessageBox.Show("Boş Bırakmayın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                    conn53.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where KullaniciAdi='" + textBox16.Text.Trim() + "' and Sifre='" + textBox17.Text.Trim() + "'", conn53);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox28.Text.Trim() != "")
                        {
                            if (dr["AdminYetki"].ToString() == textBox28.Text.Trim())
                            {
                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand kmt34 = new SqlCommand("update Logins set ClientYetki2='" + dr["AdminYetki"] + "',Client2='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                                kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                                MessageBox.Show("Admin Yetkili Kullanıcı Ekleme İşlemi Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dostad[1] = textBox16.Text.Trim();
                            }
                            else
                            {
                                conn53.Close();
                                MessageBox.Show("Admin Yetki Şifresi Yanlış! Burayı Boş Geçebilirsiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            baglanti.Close();
                            baglanti.Open();
                            SqlCommand kmt34 = new SqlCommand("update Logins set Client2='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                            kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                            MessageBox.Show("Kullanıcı Ekleme Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dostad[1] = textBox16.Text.Trim(); baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            try
            {
  baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("update Logins set Client2='',ClientYetki2='' where ID=" + id4 + "", baglanti);
            kmt4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("CLIENT Kaldırıldı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dostad[1] = ""; dostsifre[1] = ""; textBox16.Text = ""; textBox17.Text = ""; textBox28.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox15.Text == "")
                    MessageBox.Show("Boş Bırakmayın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {


                    SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                    conn53.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where KullaniciAdi='" + textBox18.Text.Trim() + "' and Sifre='" + textBox19.Text.Trim() + "'", conn53);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox27.Text.Trim() != "")
                        {
                            if (dr["AdminYetki"].ToString() == textBox27.Text.Trim())
                            {
                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand kmt34 = new SqlCommand("update Logins set ClientYetki3='" + dr["AdminYetki"] + "',Client3='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                                kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                                MessageBox.Show("Admin Yetkili Kullanıcı Ekleme İşlemi Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dostad[2] = textBox18.Text.Trim();
                            }
                            else
                            {
                                conn53.Close();
                                MessageBox.Show("Admin Yetki Şifresi Yanlış! Burayı Boş Geçebilirsiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            baglanti.Close();
                            baglanti.Open();
                            SqlCommand kmt34 = new SqlCommand("update Logins set Client3='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                            kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                            MessageBox.Show("Kullanıcı Ekleme Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dostad[2] = textBox18.Text.Trim(); baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
          
            try
            {
  baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("update Logins set Client3='',ClientYetki3='' where ID=" + id4 + "", baglanti);
            kmt4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("CLIENT Kaldırıldı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dostad[2] = ""; dostsifre[2] = ""; textBox18.Text = ""; textBox19.Text = ""; textBox27.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox15.Text == "")
                    MessageBox.Show("Boş Bırakmayın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {


                    SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                    conn53.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where KullaniciAdi='" + textBox20.Text.Trim() + "' and Sifre='" + textBox21.Text.Trim() + "'", conn53);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox26.Text.Trim() != "")
                        {
                            if (dr["AdminYetki"].ToString() == textBox26.Text.Trim())
                            {
                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand kmt34 = new SqlCommand("update Logins set ClientYetki4='" + dr["AdminYetki"] + "',Client4='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                                kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                                MessageBox.Show("Admin Yetkili Kullanıcı Ekleme İşlemi Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dostad[3] = textBox20.Text.Trim();
                            }
                            else
                            {
                                conn53.Close();
                                MessageBox.Show("Admin Yetki Şifresi Yanlış! Burayı Boş Geçebilirsiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            baglanti.Close();
                            baglanti.Open();
                            SqlCommand kmt34 = new SqlCommand("update Logins set Client4='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                            kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                            MessageBox.Show("Kullanıcı Ekleme Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dostad[3] = textBox3.Text.Trim(); baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            
            try
            {
            baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("update Logins set Client4='',ClientYetki4='' where ID=" + id4 + "", baglanti);
            kmt4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("CLIENT Kaldırıldı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dostad[3] = ""; dostsifre[3] = ""; textBox20.Text = ""; textBox21.Text = ""; textBox26.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == "" || textBox15.Text == "")
                    MessageBox.Show("Boş Bırakmayın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {


                    SqlConnection conn53 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                    conn53.Open();
                    SqlCommand kmt33 = new SqlCommand("select * from Logins where KullaniciAdi='" + textBox22.Text.Trim() + "' and Sifre='" + textBox23.Text.Trim() + "'", conn53);
                    SqlDataReader dr = kmt33.ExecuteReader();
                    if (dr.Read())
                    {
                        if (textBox25.Text.Trim() != "")
                        {
                            if (dr["AdminYetki"].ToString() == textBox25.Text.Trim())
                            {
                                baglanti.Close();
                                baglanti.Open();
                                SqlCommand kmt34 = new SqlCommand("update Logins set ClientYetki5='" + dr["AdminYetki"] + "',Client5='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                                kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                                MessageBox.Show("Admin Yetkili Kullanıcı Ekleme İşlemi Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dostad[4] = textBox22.Text.Trim();
                            }
                            else
                            {
                                conn53.Close();
                                MessageBox.Show("Admin Yetki Şifresi Yanlış! Burayı Boş Geçebilirsiniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            baglanti.Close();
                            baglanti.Open();
                            SqlCommand kmt34 = new SqlCommand("update Logins set Client5='" + dr["ID"] + "' where ID=" + id4 + "", baglanti);
                            kmt34.ExecuteNonQuery(); baglanti.Close(); conn53.Close();
                            MessageBox.Show("Kullanıcı Ekleme Başarılı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dostad[4] = textBox3.Text.Trim(); baglanti.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
           
            try
            {
            baglanti.Open();
            SqlCommand kmt4 = new SqlCommand("update Logins set Client5='',ClientYetki5='' where ID=" + id4 + "", baglanti);
            kmt4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("CLIENT Kaldırıldı!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dostad[4] = ""; dostsifre[4] = ""; textBox22.Text = ""; textBox23.Text = ""; textBox25.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen İnternetinizi Kontrol Ediniz!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox29.Text = "";
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox28.Text = "";
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox27.Text = "";
            textBox19.Text = "";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox21.Text = "";
            textBox26.Text = "";
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = "";
            textBox25.Text = "";
        }

       


        //----------------------------------- CLIENTLER Doldur ------------------------------------------

        private void button13_Click(object sender, EventArgs e)     
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox3.Items.Remove(listBox2.SelectedItem);
        }

        //----------------------------------- CLIENTLER Doldur ------------------------------------------








        //----------------------------------- Şifreyi Güncelle ------------------------------------------
        private void button14_Click(object sender, EventArgs e)    
        {
                   
        }
        //----------------------------------- Şifreyi Güncelle ------------------------------------------

    }
}
