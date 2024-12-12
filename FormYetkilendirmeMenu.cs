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
    public partial class FormYetkilendirmeMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        public FormYetkilendirmeMenu()
        {
            InitializeComponent();
        }
        private void RolleriYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT Rol FROM Yetki", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxKullaniciRolleri.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxKullaniciRolleri.Items.Add(reader["Rol"].ToString());
                }

                // İlk seçili öğeyi belirtebilirsiniz (opsiyonel)
                if (comboBoxKullaniciRolleri.Items.Count > 0)
                {
                    comboBoxKullaniciRolleri.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Roller yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        } // Sadece Yetki tablosundan rolleri çeker

        private void rolleriGoster() // Yetki tablosundaki verilerin tamamını çeker dataGridView'da sergiler
        {
            string queryForYetki = "SELECT * FROM Yetki";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryForYetki, baglanti); //SqlDataAdapter ve DataTable kullanarak gridview'da veri gösteririz.
            DataTable dataTable = new DataTable(); //GridView'da verilerimizi göstermek için bir araç, DataTable oluşturmak lazım
            dataAdapter.Fill(dataTable);


            if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
            {
                dataGridViewRoller.DataSource = dataTable;
            }
        }
        private void kullanicilariGoster()
        {
            string queryFormYoneticiler = "SELECT * FROM DershaneSistemiYonetici";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(queryFormYoneticiler, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
            {
                dataGridViewKullanicilar.DataSource = dataTable;
            }
        }

        private void rolEkle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Yetki (Rol, CanRead, CanInsert, CanDelete ,CanUpdate) " +
                                                   "VALUES (@P1, @P2, @P3, @P4 ,@P5)", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxRol.Text);
                sqlCommand.Parameters.AddWithValue("@P2", checkBoxCanRead.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P3", checkBoxCanInsert.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P4", checkBoxCanDelete.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P5", checkBoxCanUpdate.Checked ? 1 : 0);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("--------- Başarıyla eklendi ---------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            rolleriGoster();
        }
        private void rolGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Yetki SET Rol = @P1, CanRead = @P2, CanInsert = @P3, CanDelete = @P4 ,CanUpdate = @P5 WHERE Rol = @P6", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxRol.Text);
                sqlCommand.Parameters.AddWithValue("@P2", checkBoxCanRead.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P3", checkBoxCanInsert.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P4", checkBoxCanDelete.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P5", checkBoxCanUpdate.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P6", textBoxTemporaryRol.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("--------- Başarıyla güncellendi ---------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol güncellenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            rolleriGoster();
            textBoxTemporaryRol.Text = "";
        }
        private void rolSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Yetki WHERE Rol = @P1 ", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxsilinecekRol.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("--------- Başarıyla silindi ---------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol silinirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            rolleriGoster();
        }

        private void kullaniciEkle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO DershaneSistemiYonetici (KullaniciAdi, Sifre, Rol) " +
                                                   "VALUES (@P1, @P2, @P3)", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKullanıcıAdı.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxSifre.Text);
                sqlCommand.Parameters.AddWithValue("@P3", comboBoxKullaniciRolleri.SelectedItem.ToString());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("--------- Başarıyla eklendi ---------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            kullanicilariGoster();
        }
        private void kullaniciGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE DershaneSistemiYonetici SET KullaniciAdi = @P1, Sifre = @P2, Rol = @P3 WHERE YoneticiID = @P4", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKullanıcıAdı.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxSifre.Text);
                sqlCommand.Parameters.AddWithValue("@P3", comboBoxKullaniciRolleri.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P4", textBoxTemporaryYoneticiID.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("--------- Başarıyla güncellendi ---------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncellenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            kullanicilariGoster();
            textBoxTemporaryYoneticiID.Text = "";
        }
        private void kullaniciSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM DershaneSistemiYonetici WHERE YoneticiID = @P1 ", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxSilinecekKullanici.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("--------- Başarıyla silindi ---------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            kullanicilariGoster();
        }
        private void FormYetkilendirmeMenu_Load(object sender, EventArgs e)
        {
            rolleriGoster();
            kullanicilariGoster();
            RolleriYukle();
        }

        private void buttonRolEkle_Click(object sender, EventArgs e)
        {
            rolEkle();
        }

        private void dataGridViewRoller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewRoller.SelectedCells[0].RowIndex;
            textBoxRol.Text = dataGridViewRoller.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxTemporaryRol.Text = dataGridViewRoller.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxsilinecekRol.Text = dataGridViewRoller.Rows[secilenSatir].Cells[0].Value.ToString();
            checkBoxCanRead.Checked = Convert.ToBoolean(dataGridViewRoller.Rows[secilenSatir].Cells[1].Value);
            checkBoxCanInsert.Checked = Convert.ToBoolean(dataGridViewRoller.Rows[secilenSatir].Cells[2].Value);
            checkBoxCanDelete.Checked = Convert.ToBoolean(dataGridViewRoller.Rows[secilenSatir].Cells[3].Value);
            checkBoxCanUpdate.Checked = Convert.ToBoolean(dataGridViewRoller.Rows[secilenSatir].Cells[4].Value);


        }

        private void buttonRolGuncelle_Click(object sender, EventArgs e)
        {
            rolGuncelle();

        }

        private void dataGridViewKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenSatir = dataGridViewKullanicilar.SelectedCells[0].RowIndex;
            labelYonetici.Text = dataGridViewKullanicilar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxTemporaryYoneticiID.Text = dataGridViewKullanicilar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxSilinecekKullanici.Text = dataGridViewKullanicilar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKullanıcıAdı.Text = dataGridViewKullanicilar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxSifre.Text = dataGridViewKullanicilar.Rows[secilenSatir].Cells[2].Value.ToString();
            comboBoxKullaniciRolleri.SelectedItem = dataGridViewKullanicilar.Rows[secilenSatir].Cells[3].Value.ToString();

        }

        private void buttonKullaniciEkle_Click(object sender, EventArgs e)
        {
            kullaniciEkle();
        }

        private void buttonKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle();
        }

        private void buttonRolSil_Click(object sender, EventArgs e)
        {
            rolSil();
        }

        private void buttonKullaniciSil_Click(object sender, EventArgs e)
        {
            kullaniciSil();
        }
    }
}
