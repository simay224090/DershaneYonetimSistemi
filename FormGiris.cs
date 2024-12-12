using DershaneYonetimSistemi.Models;
using System.Data.SqlClient;

namespace DershaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormAnaMenu formAnamenu;
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        private KullaniciYetkileri YetkileriGetir(string rol)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT CanRead, CanInsert, CanDelete, CanUpdate FROM Yetki WHERE Rol = @Rol", baglanti);
                komut.Parameters.AddWithValue("@Rol", rol);
                SqlDataReader reader = komut.ExecuteReader();

                if (reader.Read())
                {
                    return new KullaniciYetkileri
                    {
                        CanRead = Convert.ToBoolean(reader["CanRead"]),
                        CanInsert = Convert.ToBoolean(reader["CanInsert"]),
                        CanDelete = Convert.ToBoolean(reader["CanDelete"]),
                        CanUpdate = Convert.ToBoolean(reader["CanUpdate"])
                    };
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yetkiler al�n�rken hata: " + ex.Message);
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }
        private bool KullaniciDogrula(string kullaniciAdi, string sifre, out string rol)  //Kullan�c� ad� ve �ifrenin do�rulanmas�, out olarak kullanc�� rol�n� al�yoruz
        {
            rol = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre,Rol FROM DershaneSistemiYonetici WHERE KullaniciAdi = @p1", baglanti);  //Ba�lant� yapt���m�z veritaban�na parametreli sorgu yaz�yoruz
                sqlKomut.Parameters.AddWithValue("@p1", kullaniciAdi); //Parametreyi veriyoruz
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader(); //Yazd���m�z SQL kodunu okuyoruz yani i�liyoruz.
                string dbSifre = "";


                while (sqlDataReader.Read())
                {
                    dbSifre = sqlDataReader[0].ToString();
                    rol = sqlDataReader[1].ToString(); // Rol bilgisini out parametresine at�yoruz
                }

                return dbSifre == sifre; // �ifre e�le�iyorsa true d�ner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� hatas�: " + ex.Message);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LogGirisDenemesi(string kullaniciAdi, bool basarili) //Log bilgilerini tabloya yazmas�n� yapan fonksiyon
        {
            try
            {
                baglanti.Open();
                SqlCommand logKomut = new SqlCommand("INSERT INTO GirisLog (KullaniciAdi, Basarili) VALUES (@kullaniciAdi, @basarili)", baglanti);
                logKomut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                logKomut.Parameters.AddWithValue("@basarili", basarili ? 1 : 0);
                logKomut.ExecuteNonQuery(); //SQL komutunu �al��t�rmak i�in kullan�lan bir metottur ve genellikle veritaban�nda veri de�i�tiren (INSERT, UPDATE, DELETE) i�lemleri i�in kullan�l�r
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loglama hatas�: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void YedektenYeniVeritabaniOlustur()
        {
            string connectionString = "Data Source=DESKTOP-T90QPC7\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";
            string sql = @"RESTORE DATABASE [DERSHANE] 
                   FROM DISK = 'C:\\DershaneVeritabaniYedekler\\DershaneYedek.bak' 
                   WITH MOVE 'DERSHANE' TO 'C:\\DershaneVeritabaniYedekler\\DERSHANE.mdf',
                        MOVE 'DERSHANE_log' TO 'C:\\DershaneVeritabaniYedekler\\DERSHANE_log.ldf',
                        REPLACE;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Yedekten yeni veritaban� ba�ar�yla olu�turuldu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yedekten yeni veritaban� olu�turma s�ras�nda hata: " + ex.Message);
            }


        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {

            string rol;
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string sifre = textBoxSifre.Text;

            // Giri� do�rulama
            bool basarili = KullaniciDogrula(kullaniciAdi, sifre, out rol);


            // Giri� loglama
            LogGirisDenemesi(kullaniciAdi, basarili);


            if (basarili)
            {
                // Yetkileri �ek
                KullaniciYetkileri yetkiler = YetkileriGetir(rol);

                if (yetkiler != null)
                {
                    // Ana men� formuna yetkileri g�nder
                    formAnamenu = new FormAnaMenu(rol, yetkiler);
                    formAnamenu.Show();

                }
                else
                {
                    MessageBox.Show("Yetkiler al�namad�!");
                }


            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�");
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            YedektenYeniVeritabaniOlustur();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        //UseSystemPasswordChar = True  yaparsak ilgili textBox �zerine girilen string �ifreli g�z�k�r.
    }
}