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
using System.IO;
using Xceed.Words.NET;
using OfficeOpenXml;

namespace DershaneYonetimSistemi
{
    public partial class FormOdemeMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        private KullaniciYetkileri kullaniciYetkileri;

        public FormOdemeMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            kullaniciYetkileri = yetkiler;
        }
        private void odemeIDYukle()
        {

            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT PaymentID FROM Odemeler", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> paymentIDs = new List<string>();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    paymentIDs.Add(reader["PaymentID"].ToString());
                }

                comboBoxTemporaryPaymentD.Items.Clear();
                comboBoxTemporaryPaymentD.Items.AddRange(paymentIDs.ToArray());

                comboBoxSilinecekOdemeID.Items.Clear();
                comboBoxSilinecekOdemeID.Items.AddRange(paymentIDs.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void ogrenciIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentID FROM Ogrenci", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxOgrenciNo.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxOgrenciNo.Items.Add(reader["StudentID"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ogrenci ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void odemeTuruYukle()
        {
            string[] odemeTurleri = { "Nakit", "Kredi Kartı", "Banka Transfer" };
            comboBoxOdemeTuru.Items.AddRange(odemeTurleri);
        }

        private void odemeleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Odemeler";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewOdemeler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Ödemeleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }


        private void odemeEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Odemeler (StudentID ,PaymentDate, Amount, PaymentType) VALUES (@P1, @P2, @P3, @P4)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", dateTimePickerOdemeTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", numericUpDownOdemeMiktari.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxOdemeTuru.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                odemeIDYukle();
            }
            else
            {
                MessageBox.Show("Ödeme ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void odemeGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Odemeler SET StudentID = @P1, PaymentDate = @P2, Amount = @P3, PaymentType = @P4 WHERE PaymentID = @P5", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", dateTimePickerOdemeTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", numericUpDownOdemeMiktari.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxOdemeTuru.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P5", comboBoxTemporaryPaymentD.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                odemeIDYukle();
            }
            else
            {
                MessageBox.Show("Ödeme güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void odemeSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Odemeler WHERE PaymentID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekOdemeID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ÖDeme silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                odemeIDYukle();
            }
            else
            {
                MessageBox.Show("Ödeme silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }


        private void FormOdemeMenu_Load(object sender, EventArgs e)
        {
            odemeTuruYukle();
            odemeIDYukle();
            ogrenciIDYukle();

        }

        private void buttonOdemeEkle_Click(object sender, EventArgs e)
        {
            odemeEkle();
        }

        private void buttonOdemeGuncelle_Click(object sender, EventArgs e)
        {
            odemeGuncelle();
        }

        private void buttonOdemeSil_Click(object sender, EventArgs e)
        {
            odemeSil();
        }

        private void buttonOdemeleriGoruntule_Click(object sender, EventArgs e)
        {
            odemeleriGoster();
        }





        // BURASI WORD OLARAK KAYDETMEYE YARAYAN FONKSİYON VE BUTON
        private void SaveAsWord(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewOdemeler.Rows.Count;
                int colCount = dataGridViewOdemeler.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewOdemeler.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewOdemeler.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void buttonSavePdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWord(filePath);
            }
        }









        //Aşağıdaki 3 Fonksiyon Dışarıdan excel dosyasını alıp mevcut tabloya yazmayı datagridView'da göstermeyi sağlar
        private void ImportExcelAndAppend(string filePath)
        {
            // Excel verisini oku
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // DataTable oluştur ve kolonları aynı sırada tanımla
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("PaymentID", typeof(int)); // Bu kolon identity, Excel'den eklenmeyecek
                dataTable.Columns.Add("StudentID", typeof(string));
                dataTable.Columns.Add("PaymentDate", typeof(DateTime));
                dataTable.Columns.Add("Amount", typeof(decimal));
                dataTable.Columns.Add("PaymentType", typeof(string));

                // Yeni satırları ekle (PaymentID hariç)
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["StudentID"] = worksheet.Cells[row, 1].Text;
                    dataRow["PaymentDate"] = DateTime.Parse(worksheet.Cells[row, 2].Text);
                    dataRow["Amount"] = decimal.Parse(worksheet.Cells[row, 3].Text);
                    dataRow["PaymentType"] = worksheet.Cells[row, 4].Text;
                    dataTable.Rows.Add(dataRow);
                }

                // Mevcut DataGridView'e veri ekle
                if (dataGridViewOdemeler.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewOdemeler.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewOdemeler.DataSource = existingTable;
                }
                else
                {
                    dataGridViewOdemeler.DataSource = dataTable;
                }

                // Veritabanına ekleme (isteğe bağlı)
                AddDataToDatabase(dataTable);
                odemeIDYukle();
            }
        }
        private void AddDataToDatabase(DataTable dataTable)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                foreach (DataRow row in dataTable.Rows)
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO Odemeler (StudentID, PaymentDate, Amount, PaymentType) VALUES (@StudentID, @PaymentDate, @Amount, @PaymentType)", connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", row["StudentID"]);
                        command.Parameters.AddWithValue("@PaymentDate", row["PaymentDate"]);
                        command.Parameters.AddWithValue("@Amount", row["Amount"]);
                        command.Parameters.AddWithValue("@PaymentType", row["PaymentType"]);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        private void buttonVeriAl_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportExcelAndAppend(openFileDialog.FileName);
            }
        }


        //Veriyi Excel türünde export etmek(kaydetmek)
        private void ExportToExcel(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewOdemeler.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewOdemeler.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewOdemeler.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewOdemeler.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewOdemeler.Rows[row].Cells[col].Value;
                        }
                    }

                    // Excel dosyasını kaydet
                    package.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveExcelOdemeler_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(saveFileDialog.FileName);
            }
        }
    }
}
