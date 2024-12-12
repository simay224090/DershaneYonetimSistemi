using DershaneYonetimSistemi.Models;
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

namespace DershaneYonetimSistemi
{

    public partial class FormAnaMenu : Form
    {
        FormGiris formGiris;
        FormOgrMenu formStdDersTch;
        FormExamMenu formExamMenu;
        FormYetkilendirmeMenu formYetkilendirmeMenu;
        FormTchANDLessonMenu formTchANDLessonMenu;
        FormOdemeMenu formOdemeMenu;
        FormRaporMenu formRaporMenu;
        private string kullaniciRol;
        private KullaniciYetkileri kullaniciYetkileri;
        public FormAnaMenu(string rol, KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            kullaniciRol = rol; //FormGiris'den gelen rolü constructor aracılığya aldık.
            kullaniciYetkileri = yetkiler; // Yetkileri saklıyoruz
        }



        private void Yedekle()
        {

            string connectionString = "Data Source=SIMAY\\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True";
            string sql = "BACKUP DATABASE [DERSHANE] TO DISK = 'C:\\DershaneVeritabaniYedekler\\DershaneYedek.bak' WITH INIT;";
            if (kullaniciRol == "Admin")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Veritabanı başarıyla yedeklendi!");
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yedekleme sırasında hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu işlem için yetkiniz yoktur. Yöneticinizle iletişime geçiniz!");
            }
        }
        private void YedektenDon()
        {
            string connectionString = "Data Source=SIMAY\\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True";
            string sql = @" ALTER DATABASE [DERSHANE] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                            RESTORE DATABASE [DERSHANE] FROM DISK = 'C:\\DershaneVeritabaniYedekler\\DershaneYedek.bak' WITH REPLACE;
                            ALTER DATABASE [DERSHANE] SET MULTI_USER;";
            if (kullaniciRol == "Admin")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Veritabanı başarıyla geri yüklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Geri yükleme sırasında hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu işlem için yetkiniz yoktur. Yöneticinizle iletişime geçiniz!");
            }
        }

        private void VeritabaniSil()
        {
            string connectionString = "Data Source=SIMAY\\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True";
            string sql = @"IF EXISTS(SELECT * FROM sys.databases WHERE name = 'DERSHANE')
                   BEGIN
                       ALTER DATABASE [DERSHANE] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                       DROP DATABASE [DERSHANE];
                   END";


            if (kullaniciRol == "Admin")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Veritabanı başarıyla silindi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanını silme sırasında hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu işlem için yetkiniz yoktur. Yöneticinizle iletişime geçiniz!");
            }
        }

        private void YedektenYeniVeritabaniOlustur()
        {
            string connectionString = "Data Source=SIMAY\\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True";
            string sql = @"RESTORE DATABASE [DERSHANE] 
                   FROM DISK = 'C:\\DershaneVeritabaniYedekler\\DershaneYedek.bak' 
                   WITH MOVE 'DERSHANE' TO 'C:\\DershaneVeritabaniYedekler\\DERSHANE.mdf',
                        MOVE 'DERSHANE_log' TO 'C:\\DershaneVeritabaniYedekler\\DERSHANE_log.ldf',
                        REPLACE;";
            if (kullaniciRol == "Admin")
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Yedekten yeni veritabanı başarıyla oluşturuldu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yedekten yeni veritabanı oluşturma sırasında hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Bu işlem için yetkiniz yoktur. Yöneticinizle iletişime geçiniz!");
            }

        }



        private void buttonQuit_Click(object sender, EventArgs e)
        {
            formGiris = new FormGiris();
            formGiris.Show();
            this.Close();
        }

        private void buttonStdDersTch_Click(object sender, EventArgs e)
        {
            formStdDersTch = new FormOgrMenu(kullaniciYetkileri);
            formStdDersTch.Show();
        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            formExamMenu = new FormExamMenu(kullaniciYetkileri);
            formExamMenu.Show();
        }

        private void buttonYetkiIslemleri_Click(object sender, EventArgs e)
        {
            if (kullaniciRol == "Admin") //Yetki işlemlerini sadece admin olanlar yapabilir diye düzenledik
            {
                formYetkilendirmeMenu = new FormYetkilendirmeMenu();
                formYetkilendirmeMenu.Show();
            }
            else
            {
                MessageBox.Show("Yönetici ve Yetki işlemleri için admin kullanıcısı olmanız gerekmektedir!");
            }
        }

        private void buttonOgretmenDers_Click(object sender, EventArgs e)
        {
            formTchANDLessonMenu = new FormTchANDLessonMenu(kullaniciYetkileri);
            formTchANDLessonMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formOdemeMenu = new FormOdemeMenu(kullaniciYetkileri);
            formOdemeMenu.Show();
        }
        private void buttonRaporMenu_Click(object sender, EventArgs e)
        {
            formRaporMenu = new FormRaporMenu(kullaniciYetkileri);
            formRaporMenu.Show();
        }
        private void FormAnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonYedekle_Click(object sender, EventArgs e)
        {
            Yedekle();
        }

        private void buttonYedekdenDon_Click(object sender, EventArgs e)
        {
            YedektenDon();
        }

        private void buttonDbSil_Click(object sender, EventArgs e)
        {
            VeritabaniSil();
        }

        private void buttonDbFullDon_Click(object sender, EventArgs e)
        {
            YedektenYeniVeritabaniOlustur();
        }
    }
}
