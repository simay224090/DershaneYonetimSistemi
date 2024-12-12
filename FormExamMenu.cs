using DershaneYonetimSistemi.Models;
using OfficeOpenXml;
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
using Xceed.Words.NET;

namespace DershaneYonetimSistemi
{
    public partial class FormExamMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");

        private KullaniciYetkileri kullaniciYetkileri;
        public FormExamMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            this.AutoScroll = true;
            kullaniciYetkileri = yetkiler;
        }

        private void courseIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT CourseID FROM Ders", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> courseIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    courseIDs.Add(reader["CourseID"].ToString());
                }

                comboBoxCourseID.Items.Clear();
                comboBoxCourseID.Items.AddRange(courseIDs.ToArray());

                comboBoxCourseID2.Items.Clear();
                comboBoxCourseID2.Items.AddRange(courseIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Course ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void sinavIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT ExamID FROM Sinav", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> examIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    examIDs.Add(reader["ExamID"].ToString());
                }

                comboBoxSinavIDforSınavSonuc.Items.Clear();
                comboBoxSinavIDforSınavSonuc.Items.AddRange(examIDs.ToArray());

                comboBoxSilinecekSinavID.Items.Clear();
                comboBoxSilinecekSinavID.Items.AddRange(examIDs.ToArray());

                comboBoxTemporarySinavID.Items.Clear();
                comboBoxTemporarySinavID.Items.AddRange(examIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exam ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void sinavSonucIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT ResultID FROM SinavSonuc", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> examResultIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    examResultIDs.Add(reader["ResultID"].ToString());
                }

                comboBoxSilinecekSinavSonucID.Items.Clear();
                comboBoxSilinecekSinavSonucID.Items.AddRange(examResultIDs.ToArray());

                comboBoxTemporarySinavSonucID.Items.Clear();
                comboBoxTemporarySinavSonucID.Items.AddRange(examResultIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exam ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void studentIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentID FROM Ogrenci", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxStudentID.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxStudentID.Items.Add(reader["StudentID"].ToString());
                }

                // İlk seçili öğeyi belirtebilirsiniz (opsiyonel)
                if (comboBoxStudentID.Items.Count > 0)
                {
                    comboBoxStudentID.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }


        private void sinavlariGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Sinav";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewSinavlar.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Sınavları görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinavSonuclariGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM SinavSonuc";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewSinavSonuclari.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Sınav sonuçlarını görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }


        private void sinavEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sinav (CourseID, ExamName, ExamDate) VALUES (@P1, @P2, @P3)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxCourseID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxSinavIsmi.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerSinavTarihi.Value);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinavGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Sinav SET CourseID = @P1, ExamName = @P2, ExamDate = @P3 WHERE ExamID = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxCourseID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxSinavIsmi.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerSinavTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporarySinavID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void sinavSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sinav WHERE ExamID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekSinavID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }

        private void sinavSonucEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO SinavSonuc (ExamID, StudentID, AlinanPuan, CourseID) VALUES (@P1, @P2, @P3, @P4)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinavIDforSınavSonuc.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxStudentID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxAlinanPuan.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxCourseID2.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav sonucu eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavSonucIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav sonuç ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void sinavSonucGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE SinavSonuc SET ExamID = @P1, StudentID = @P2, AlinanPuan = @P3, CourseID = @P4 WHERE ResultID = @P5", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinavIDforSınavSonuc.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxStudentID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxAlinanPuan.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxCourseID2.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P5", comboBoxTemporarySinavSonucID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav sonucu güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavSonucIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav sonuç güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinavSonucSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM SinavSonuc WHERE ResultID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekSinavSonucID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav sonucu silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavSonucIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav sonuç silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }




        private void FormExamMenu_Load(object sender, EventArgs e)
        {
            sinavSonucIDYukle();
            courseIDYukle();
            sinavIDYukle();
            studentIDYukle();

        }

        private void buttonSinavEkle_Click(object sender, EventArgs e)
        {
            sinavEkle();
        }
        private void buttonSinavGuncelle_Click(object sender, EventArgs e)
        {
            sinavGuncelle();
        }

        private void buttonSinavSil_Click(object sender, EventArgs e)
        {
            sinavSil();
        }

        private void buttonSinavSonucEkle_Click(object sender, EventArgs e)
        {
            sinavSonucEkle();
        }

        private void buttonSinavSonucGuncelle_Click(object sender, EventArgs e)
        {
            sinavSonucGuncelle();
        }

        private void buttonSinavSonucSil_Click(object sender, EventArgs e)
        {
            sinavSonucSil();
        }

        private void buttonSinavlariGoruntule_Click(object sender, EventArgs e)
        {
            sinavlariGoster();
        }

        private void buttonSinavSonucGoruntule_Click(object sender, EventArgs e)
        {
            sinavSonuclariGoster();
        }






        private void SaveAsWordExams(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewSinavlar.Rows.Count;
                int colCount = dataGridViewSinavlar.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewSinavlar.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewSinavlar.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordExamResults(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewSinavSonuclari.Rows.Count;
                int colCount = dataGridViewSinavSonuclari.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewSinavSonuclari.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewSinavSonuclari.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }



        private void buttonSaveAsWordExams_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordExams(filePath);
            }
        }
        private void buttonSaveAsWordExamResults_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordExamResults(filePath);
            }
        }






        private void ImportExams(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CourseID", typeof(short));
                dataTable.Columns.Add("ExamName", typeof(string));
                dataTable.Columns.Add("ExamDate", typeof(DateTime));



                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["CourseID"] = short.Parse(worksheet.Cells[row, 1].Text);
                    dataRow["ExamName"] = worksheet.Cells[row, 2].Text;
                    dataRow["ExamDate"] = DateTime.Parse(worksheet.Cells[row, 3].Text);
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewSinavlar.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewSinavlar.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewSinavlar.DataSource = existingTable;
                }
                else
                {
                    dataGridViewSinavlar.DataSource = dataTable;
                }

                AddExamToDatabase(dataTable);
                sinavIDYukle();
            }
        } //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddExamToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO Sinav (CourseID, ExamName, ExamDate) VALUES (@CourseID, @ExamName, @ExamDate)", baglanti);
                        command.Parameters.AddWithValue("@CourseID", row["CourseID"]);
                        command.Parameters.AddWithValue("@ExamName", row["ExamName"]);
                        command.Parameters.AddWithValue("@ExamDate", row["ExamDate"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["CourseID"]}, {row["ExamName"]}, {row["ExamDate"]}",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Genel hataları yakala
                MessageBox.Show($"Veritabanı bağlantısı sırasında bir hata oluştu: {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void buttonVeriAlSinav_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportExams(openFileDialog.FileName);
            }
        }
        private void ExportToExcelSinavlar(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewSinavlar.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewSinavlar.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewSinavlar.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewSinavlar.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewSinavlar.Rows[row].Cells[col].Value;
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
        private void buttonSaveExcelSinav_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelSinavlar(saveFileDialog.FileName);
            }
        }





        private void ImportExamResults(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ExamID", typeof(int));
                dataTable.Columns.Add("StudentID", typeof(string));
                dataTable.Columns.Add("AlinanPuan", typeof(byte));
                dataTable.Columns.Add("CourseID", typeof(short));

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["ExamID"] = int.Parse(worksheet.Cells[row, 1].Text);
                    dataRow["StudentID"] = worksheet.Cells[row, 2].Text;
                    dataRow["AlinanPuan"] = byte.Parse(worksheet.Cells[row, 3].Text);
                    dataRow["CourseID"] = short.Parse(worksheet.Cells[row, 4].Text);
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewSinavSonuclari.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewSinavSonuclari.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewSinavSonuclari.DataSource = existingTable;
                }
                else
                {
                    dataGridViewSinavSonuclari.DataSource = dataTable;
                }

                AddSinavSonucToDatabase(dataTable);
                sinavSonucIDYukle();
            }
        } //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddSinavSonucToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO SinavSonuc (ExamID, StudentID, AlinanPuan, CourseID) VALUES (@ExamID, @StudentID, @AlinanPuan, @CourseID)", baglanti);
                        command.Parameters.AddWithValue("@ExamID", row["ExamID"]);
                        command.Parameters.AddWithValue("@StudentID", row["StudentID"]);
                        command.Parameters.AddWithValue("@AlinanPuan", row["AlinanPuan"]);
                        command.Parameters.AddWithValue("@CourseID", row["CourseID"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["ExamID"]}, {row["StudentID"]}, {row["AlinanPuan"]}, {row["CourseID"]}",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Genel hataları yakala
                MessageBox.Show($"Veritabanı bağlantısı sırasında bir hata oluştu: {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void buttonVeriAlSinavSonuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportExamResults(openFileDialog.FileName);
            }
        }
        private void ExportToExcelSinavSonuc(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewSinavSonuclari.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewSinavSonuclari.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewSinavSonuclari.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewSinavSonuclari.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewSinavSonuclari.Rows[row].Cells[col].Value;
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
        private void buttonSaveExcelSinavSonuc_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelSinavSonuc(saveFileDialog.FileName);
            }
        }
    }
}

