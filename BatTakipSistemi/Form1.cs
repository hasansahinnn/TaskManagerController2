using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;
using System.ServiceProcess;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
namespace BatTakipSistemi
{

    public partial class Form1 : Form
    {
        public int id,sersayac=1,uysayac=1,kır;
        private static DateTime lastTime;
        private static TimeSpan lastTotalProcessorTime;
        private static DateTime curTime;
        private static TimeSpan curTotalProcessorTime;
        public string DosyaYolu;
        public string VeriTabani,user;
        public string[,] Dizi = { { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "explorer", "0", "0", "0", "0", "0", "0" } };
        public string[] Dizi2 = {"","","",""};
        
        public string[,] ser = { { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "0", "0", "0", "0", "0", "0", "0" }, { "explorer", "0", "0", "0", "0", "0", "0" } };
        public long totalGBRam = Convert.ToInt32((new ComputerInfo().TotalPhysicalMemory / (Math.Pow(1024, 3))) + 0.5);
        public int p,id3;
        SqlConnection conn3 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        SqlConnection conn4 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");

        SqlConnection conn2 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
        duzenle duz = new duzenle();
        public Form1()
        {
            InitializeComponent();
        }


        //-------------------------------------------- FORMLOAD ------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //guncellemekontrol();
            simpleButton1.Visible = false;
            int maxram = Convert.ToInt16(totalGBRam * 1000);  
            p = 1;
            //OpenFile();
           
            timer1.Stop();
        }



        //-------------------------------------------- SERVİSLER -----------------------------------------------------

        public static String GetWindowsServiceStatus(String SERVICENAME)
        {

            ServiceController sc = new ServiceController(SERVICENAME);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "True";
                case ServiceControllerStatus.Stopped:
                    return "False";
                case ServiceControllerStatus.Paused:
                    return "False";
                case ServiceControllerStatus.StopPending:
                    return "False";
                case ServiceControllerStatus.StartPending:
                    return "True";
                default:
                    return "False";
            }
        }
        void servisler()
        {
            ProgramlariListele();
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();
            
                for (int i = 1; i < sersayac; i++)
                {



                    foreach (ServiceController scTemp in scServices)
                    {
                        if (scTemp.ServiceName == ser[i, 0])
                        {

                        ser[i, 3] = GetWindowsServiceStatus(ser[i, 0]);    //SERVİS DURUMU
                        
                            uint processId = 0;
                            string qry = "SELECT PROCESSID FROM WIN32_SERVICE WHERE NAME = '" + ser[i, 0] + "'";
                            System.Management.ManagementObjectSearcher searcher = new System.Management.ManagementObjectSearcher(qry);
                            foreach (System.Management.ManagementObject mngntObj in searcher.Get())
                            {
                                processId = (uint)mngntObj["PROCESSID"];

                            }
                            int idno = Convert.ToInt32(processId);
                            Process t2 = Process.GetProcessById(idno);
                            string name = t2.ProcessName;
                            foreach (Process p in Process.GetProcesses("."))
                            {
                                if (name != "Idle")
                                {
                                    if (p.ProcessName == name)
                                    {
                                        
                                        ser[i, 4] = p.StartTime.ToString();
                                        string t = ser[i, 4];
                                       //RAM DURUMU
                                        ser[i, 2] = ((Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1024))) / 2000)).ToString();
                                      

                                       //CPU DURUMU
                                        int j = 0;
                                        while (j < 2)
                                        {
                                            try
                                            {
                                                Process[] pp = Process.GetProcessesByName(ser[i, 0]);


                                                Process t1 = pp[0];
                                                if (lastTime == null || lastTime == new DateTime())
                                                {
                                                    lastTime = DateTime.Now;
                                                    lastTotalProcessorTime = t1.TotalProcessorTime;
                                                }
                                                else
                                                {
                                                    curTime = DateTime.Now;
                                                    curTotalProcessorTime = t1.TotalProcessorTime;

                                                    double CPUUsage = (curTotalProcessorTime.TotalMilliseconds - lastTotalProcessorTime.TotalMilliseconds) / curTime.Subtract(lastTime).TotalMilliseconds / Convert.ToDouble(Environment.ProcessorCount);
                                                    ser[i, 1] = Convert.ToInt32((CPUUsage * 100)).ToString();

                                                    lastTime = curTime;
                                                    lastTotalProcessorTime = curTotalProcessorTime;
                                                }



                                            }
                                            catch
                                            {
                                               
                                                //MessageBox.Show("Bir Sorun oluştu. Lütfen Programı Yeniden Başlatın!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            j++;
                                        }
                                        Thread.Sleep(250);
                                        conn2.Close();





                                        //_----------------------------------------------------------------------------YAZDIRMA İŞLEMİ------------------------------------------------------------------------------

                                        kır = 1;
                                        break;
                                    }
                                    else
                                    {
                                        
                                    
                                    if (ser[i, 3] == "True")
                                    {
                                        ser[i, 5] = "" + DateTime.Now;kır = 1; 
                                    }


                                    ser[i, 2] = "-";
                                    ser[i, 1] = "-";

                                }
                                }
                                else
                                {
                                ser[i, 3] = "False";
                                if (ser[i, 3] == "True")
                                {
                                    ser[i, 5] = "" + DateTime.Now; 
                                }
                                ser[i, 2] = "-"; kır = 1;
                                ser[i, 1] = "-"; break;
                                
                            }



                            }

                        }
                        if(kır==1)
                        {
                            
                            kır = 0; break;
                        }
                        

                    }



                   
                }










            yaz2();
        }

        //-------------------------------------------- SERVİSLER -----------------------------------------------------






        //-------------------------------------------- Güncelleme Haberi ---------------------------------------------

        void guncellemekontrol()
        {
            conn2.Open();
            SqlCommand kmt33 = new SqlCommand("select * from Logins where ID="+id3+"", conn2);
            SqlDataReader dr = kmt33.ExecuteReader();
            if (dr.Read())
            {
                if(dr["Guncelleme"].ToString()!="")
                {
                    MessageBox.Show(dr["Guncelleme"].ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn2.Close();
                    conn2.Open();
                    SqlCommand kmt43 = new SqlCommand("update Logins set Guncelleme='' where ID="+id3+"", conn2);
                    kmt43.ExecuteNonQuery();conn2.Close();
                }
            }
            }

        //-------------------------------------------- Güncelleme Haberi ---------------------------------------------





        //-------------------------------------------- KAYITLARI DÜZENLE ---------------------------------------------

        private void button3_Click(object sender, EventArgs e)  
        {
            duz.id4 = id3;
            duz.username = user;
            duz.ShowDialog();
        }
        //-------------------------------------------- KAYITLARI DÜZENLE ---------------------------------------------





        //-------------------------------------------- UYGULAMALAR ---------------------------------------------------

        private void ProgramlariListele()
        {
            
            int a = 1;
            uygulamacalistir();

            for (int t = 1; t < uysayac; t++)
            {
                foreach (Process p in Process.GetProcesses("."))
                {
                    if (p.ProcessName == Dizi[t, 0])
                    {
                        //BAŞLANGIÇ ZAMANI
                        Dizi[t, 4] = p.StartTime.ToString();

                        //RAM
                        Dizi[t, 2] = ((Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1024))) / 2000)).ToString();
                        // ON/OFF
                        Dizi[t, 3] = (p.Responding.ToString());
                        //CPU
                        int i = 0;
                        while (i < 2)
                        {
                            try
                            {
                                Process[] pp = Process.GetProcessesByName(Dizi[t, 0]);


                                Process t1 = pp[0];
                                if (lastTime == null || lastTime == new DateTime())
                                {
                                    lastTime = DateTime.Now;
                                    lastTotalProcessorTime = t1.TotalProcessorTime;
                                }
                                else
                                {
                                    curTime = DateTime.Now;
                                    curTotalProcessorTime = t1.TotalProcessorTime;

                                    double CPUUsage = (curTotalProcessorTime.TotalMilliseconds - lastTotalProcessorTime.TotalMilliseconds) / curTime.Subtract(lastTime).TotalMilliseconds / Convert.ToDouble(Environment.ProcessorCount);
                                    Dizi[t, 1] = Convert.ToInt32((CPUUsage * 100)).ToString();

                                    lastTime = curTime;
                                    lastTotalProcessorTime = curTotalProcessorTime;
                                }


                                Thread.Sleep(200);
                            }
                            catch
                            {

                            }
                            i++;
                        }
                      

                       
                        Thread.Sleep(250);

                        //_----------------------------------------------------------------------------YAZDIRMA İŞLEMİ------------------------------------------------------------------------------
                        
                        a++;                       
                        break;
                    }
                    else
                    {
                        if(Dizi[t,3]=="True")
                        {
                            
                            Dizi[t, 5] = "" + DateTime.Now;
                        }
                        Dizi[t, 3] = "FALSE";
                        Dizi[t, 2] = "-";
                        Dizi[t, 1] = "-";
                        
                    }
                   

                }
            }
            yaz1();
            conn3.Close();
        }

        //-------------------------------------------- UYGULAMALAR ---------------------------------------------------





        //-------------------------------------------- UYGULAMALARI YAZ ----------------------------------------------

        public void yaz1()
        {
            try
            {
                conn3.Close();
            
                for (int i = 1; i < uysayac; i++)
                {
               
                        conn3.Open();
                        SqlCommand kmt3 = new SqlCommand("update Uygulamalars set Cpu='" + Dizi[i, 1] + "',Ram='" + Dizi[i, 2] + "',IsAcik='" + Dizi[i, 3] + "',AcilmaZamani='" + Dizi[i, 4] + "',KapanmaZamani='" + Dizi[i, 5] + "' where Userid = " + id3 + " and UygulamaAdi='" + Dizi[i, 0] + "' and IsServis='False'", conn3);
                        kmt3.ExecuteNonQuery(); conn3.Close();
                        conn4.Close();
                   
                }
            }
            catch (Exception)
            {
                conn3.Close();
                conn4.Close();
            }

        }

        //-------------------------------------------- UYGULAMALARI YAZ ----------------------------------------------





        //-------------------------------------------- SERVİSLERİ YAZ ------------------------------------------------

        public void yaz2()
        {
            



            for (int i = 0; i < sersayac; i++)
            {
                try
                {
                    string t = ser[1, 3]; string f = ser[2, 3];
                    conn3.Close();
                    conn3.Open();

                    SqlCommand kmt3 = new SqlCommand("update Uygulamalars set Cpu='" + ser[i, 1] + "',Ram='" + ser[i, 2] + "',IsAcik='" + ser[i, 3] + "',AcilmaZamani='" + ser[i, 4] + "',KapanmaZamani='" + ser[i, 5] + "' where Userid = " + id3 + " and UygulamaAdi='" + ser[i, 0] + "' and IsServis='True'", conn3);
                    kmt3.ExecuteNonQuery(); conn3.Close();
                }
                catch (Exception)
                {
                    
                }
               



            }
            //}
            //catch (Exception)
            //{
            //    conn3.Close();
            //    conn4.Close();
            //}

        }

        //-------------------------------------------- SERVİSLERİ YAZ ------------------------------------------------







        //-------------------------------------------- TİMER ---------------------------------------------------------

        private void timer1_Tick(object sender, EventArgs e)
        {
            servisler();
            //Thread thread = new Thread(new ThreadStart(servisler));
            //thread.Start();
            //Thread thread2 = new Thread(new ThreadStart(ProgramlariListele));
            //thread2.Start();
            //Thread thread3 = new Thread(new ThreadStart(uygulamacalistir));
            //thread3.Start();
            //Thread.Sleep(2000);
            //Thread thread3 = new Thread(new ThreadStart(yaz));
            //thread3.Start();
            //ProgramlariListele();
        }

        //-------------------------------------------- TİMER ---------------------------------------------------------






        //-------------------------------------------- VERİLERİ ÇEK --------------------------------------------------

        public void OpenFile()       
        {
            try
            {
                sersayac = 1; uysayac = 1;
                SqlConnection baglanti = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                SqlCommand komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select * from Uygulamalars where Userid=" + id3 + " and IsServis='False'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();int b=1;
                while (dr.Read())
                {
                    Dizi[b, 0]=dr["UygulamaAdi"].ToString();b++;uysayac++;
                }
                baglanti.Close();
                baglanti.Open();
                komut.CommandText = "select * from Uygulamalars where Userid=" + id3 + " and IsServis='True'";
                komut.ExecuteNonQuery();
                SqlDataReader dr2 = komut.ExecuteReader();b = 1;
                while (dr2.Read())
                {
                    ser[b, 0] = dr2["UygulamaAdi"].ToString(); b++; sersayac++;
                }
                baglanti.Close();
            }
            catch (Exception)
            {
               
                //MessageBox.Show("Bir Sorun oluştu. Lütfen İnternetinizi Kontrol Edin!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        //-------------------------------------------- VERİLERİ ÇEK --------------------------------------------------






        
        //-------------------------------------------- PROGRAMI BAŞLAT -----------------------------------------------

       

        //-------------------------------------------- PROGRAMI BAŞLAT -----------------------------------------------





        //-------------------------------------------- NOTIFYICONS  --------------------------------------------------

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
                this.Show();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn2.Open();
            SqlCommand kmt4 = new SqlCommand("update Uygulamas set IsAcik='False' where Userid=" + id3 + "", conn2);
            kmt4.ExecuteNonQuery();
            conn2.Close();
            Application.Exit();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Yazılım Hasan Şahin Tarafından,Ücretsiz Kullanım İçin Yapılmıştır!", "Merhaba!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void programıGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void programıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void programıGizleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hakkındaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Yazılım Hasan Şahin Tarafından,Ücretsiz Kullanım İçin Yapılmıştır!Yaşadığınız sorunlar  ve Önerileriniz için hasan@shngroup.net'e mail atabilirsiniz.", "Merhaba!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFile();

            //ProgramlariListele();
            timer1.Enabled = true;
            timer1.Start(); simpleButton2.Visible = false; simpleButton1.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           simpleButton1.Visible = false;
            simpleButton2.Visible = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            duzenle duz = new duzenle();
            duz.id4 = id3;
            duz.username = user;
            duz.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();uyegirisi uye = new uyegirisi();uye.Show();
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conn2.Close();
            conn2.Open();
            SqlCommand kmt4 = new SqlCommand("update Uygulamalars set IsAcik='False' where Userid=" + id3 + "", conn2);
            kmt4.ExecuteNonQuery();
            conn2.Close();
            Application.Exit();


        }


        //-------------------------------------------- NOTIFYICONS  --------------------------------------------------






        //-------------------------------------------- EKRAN GÖRÜNTÜSÜ  ----------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {

            
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save("C://test.jpg", ImageFormat.Jpeg);
            }
        }

        //-------------------------------------------- EKRAN GÖRÜNTÜSÜ  ----------------------------------------------




        //-------------------------------------------- PROGRAMI DURDUR  ----------------------------------------------

        
        //-------------------------------------------- PROGRAMI DURDUR  ----------------------------------------------





        //-------------------------------------------- UYGULAMA-SERVİS-KOD ÇALIŞTIR  ---------------------------------

        void uygulamacalistir()
        {
            try
            {
                SqlConnection conn42 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                conn42.Open();
                SqlCommand kmt33 = new SqlCommand("select * from Logins where ID=" + id3 + "", conn42);
                SqlDataReader dr = kmt33.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["ProgramAdi"].ToString() != "" && dr["PKomut"].ToString() != "" && dr["yedek1"].ToString() =="0")
                    {
                        SqlConnection conn422 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                        conn422.Open();
                        SqlCommand kmt332 = new SqlCommand("select * from Uygulamalars where Userid=" + id3 + " and UygulamaAdi='"+ dr["ProgramAdi"]+"'", conn422);
                        SqlDataReader dr2 = kmt332.ExecuteReader();
                        if (dr2.Read())
                        {
                            if(dr["PKomut"].ToString()=="baslat")
                            {
                                System.Diagnostics.Process.Start(@"" + dr2["PUzanti"].ToString() + "");
                                SqlConnection conn43 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                                conn43.Open();
                                SqlCommand kmt43 = new SqlCommand("update Logins set ProgramAdi='',PKomut='',yedek1='' where ID=" + id3 + "", conn43); kmt43.ExecuteNonQuery(); conn43.Close();
                            }
                            else
                            {
                                foreach (var process in Process.GetProcessesByName(@"" + dr["ProgramAdi"].ToString() + ""))
                                {
                                    process.Kill();
                                    SqlConnection conn43 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                                    conn43.Open();
                                    SqlCommand kmt43 = new SqlCommand("update Logins set ProgramAdi='',PKomut='',yedek1='' where ID=" + id3 + "", conn43); kmt43.ExecuteNonQuery(); conn43.Close();
                                }
                            }
                        }
                    }
                   
                    if (dr["ProgramAdi"].ToString() != "" && dr["PKomut"].ToString() != "" && dr["yedek1"].ToString() =="1")
                    {
                        ServiceController service = new ServiceController(dr["ProgramAdi"].ToString());
                        if (dr["PKomut"].ToString() == "baslat")
                        {
                            
                            service.Start();
                            SqlConnection conn43 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                            conn43.Open();
                            SqlCommand kmt43 = new SqlCommand("update Logins set ProgramAdi='',PKomut='',yedek1='' where ID=" + id3 + "", conn43); kmt43.ExecuteNonQuery(); conn43.Close();
                        }
                        else
                        {
                            service.Stop();
                            SqlConnection conn43 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                            conn43.Open();
                            SqlCommand kmt43 = new SqlCommand("update Logins set ProgramAdi='',PKomut='',yedek1='' where ID=" + id3 + "", conn43); kmt43.ExecuteNonQuery(); conn43.Close();
                        }
                    }
                    if (dr["CKomut"].ToString()!="" )
                    {
                        string strCmdText;
                        strCmdText = "/C" + dr["CKomut"].ToString();
                        System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                        SqlConnection conn43 = new SqlConnection("Data Source=(local);Initial Catalog=usage;Integrated Security=True;Persist Security Info=True;User ID=hasan;Encrypt=True;TrustServerCertificate=True;Context Connection=False");
                        conn43.Open();
                        SqlCommand kmt43 = new SqlCommand("update Logins set CKomut='' where ID=" + id3 + "", conn43); kmt43.ExecuteNonQuery(); conn43.Close();
                    }
                }
                conn42.Close();
            }
            catch (Exception)
            {

            }

        }

        //-------------------------------------------- UYGULAMA-SERVİS-KOD ÇALIŞTIR  ---------------------------------


    }

}
