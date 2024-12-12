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
                MessageBox.Show("Yetkiler alýnýrken hata: " + ex.Message);
                return null;
            }
            finally
            {
                baglanti.Close();
            }
        }
        private bool KullaniciDogrula(string kullaniciAdi, string sifre, out string rol)  //Kullanýcý adý ve þifrenin doðrulanmasý, out olarak kullancýý rolünü alýyoruz
        {
            rol = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre,Rol FROM DershaneSistemiYonetici WHERE KullaniciAdi = @p1", baglanti);  //Baðlantý yaptýðýmýz veritabanýna parametreli sorgu yazýyoruz
                sqlKomut.Parameters.AddWithValue("@p1", kullaniciAdi); //Parametreyi veriyoruz
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader(); //Yazdýðýmýz SQL kodunu okuyoruz yani iþliyoruz.
                string dbSifre = "";


                while (sqlDataReader.Read())
                {
                    dbSifre = sqlDataReader[0].ToString();
                    rol = sqlDataReader[1].ToString(); // Rol bilgisini out parametresine atýyoruz
                }

                return dbSifre == sifre; // Þifre eþleþiyorsa true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý: " + ex.Message);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LogGirisDenemesi(string kullaniciAdi, bool basarili) //Log bilgilerini tabloya yazmasýný yapan fonksiyon
        {
            try
            {
                baglanti.Open();
                SqlCommand logKomut = new SqlCommand("INSERT INTO GirisLog (KullaniciAdi, Basarili) VALUES (@kullaniciAdi, @basarili)", baglanti);
                logKomut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                logKomut.Parameters.AddWithValue("@basarili", basarili ? 1 : 0);
                logKomut.ExecuteNonQuery(); //SQL komutunu çalýþtýrmak için kullanýlan bir metottur ve genellikle veritabanýnda veri deðiþtiren (INSERT, UPDATE, DELETE) iþlemleri için kullanýlýr
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loglama hatasý: " + ex.Message);
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
                    MessageBox.Show("Yedekten yeni veritabaný baþarýyla oluþturuldu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yedekten yeni veritabaný oluþturma sýrasýnda hata: " + ex.Message);
            }


        }
        private void buttonGiris_Click(object sender, EventArgs e)
        {

            string rol;
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string sifre = textBoxSifre.Text;

            // Giriþ doðrulama
            bool basarili = KullaniciDogrula(kullaniciAdi, sifre, out rol);


            // Giriþ loglama
            LogGirisDenemesi(kullaniciAdi, basarili);


            if (basarili)
            {
                // Yetkileri çek
                KullaniciYetkileri yetkiler = YetkileriGetir(rol);

                if (yetkiler != null)
                {
                    // Ana menü formuna yetkileri gönder
                    formAnamenu = new FormAnaMenu(rol, yetkiler);
                    formAnamenu.Show();

                }
                else
                {
                    MessageBox.Show("Yetkiler alýnamadý!");
                }


            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya Þifre hatalý");
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            YedektenYeniVeritabaniOlustur();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        //UseSystemPasswordChar = True  yaparsak ilgili textBox üzerine girilen string þifreli gözükür.
    }
}