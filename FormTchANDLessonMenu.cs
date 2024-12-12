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
    public partial class FormTchANDLessonMenu : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        KullaniciYetkileri kullaniciYetkileri;
        public FormTchANDLessonMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            this.AutoScroll = true;
            kullaniciYetkileri = yetkiler;
        }
        private void teacherIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT TeacherID FROM Ogretmen", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> teacherIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    teacherIDs.Add(reader["TeacherID"].ToString());
                }

                comboBoxTemporaryTeacherID.Items.Clear();
                comboBoxTemporaryTeacherID.Items.AddRange(teacherIDs.ToArray());

                comboBoxSilinecekOgretmenID.Items.Clear();
                comboBoxSilinecekOgretmenID.Items.AddRange(teacherIDs.ToArray());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void dersIDYukle()
        {
            try
            {

                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT CourseID FROM Ders", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> courseIDs = new List<string>();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    courseIDs.Add(reader["CourseID"].ToString());
                }

                comboBoxTemporaryDersID.Items.Clear();
                comboBoxTemporaryDersID.Items.AddRange(courseIDs.ToArray());

                comboBoxSilinecekDersID.Items.Clear();
                comboBoxSilinecekDersID.Items.AddRange(courseIDs.ToArray());

                comboBoxLessonID.Items.Clear();
                comboBoxLessonID.Items.AddRange(courseIDs.ToArray());

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
        private void ogretmenAlanYukle()
        {
            string[] ogretmenAlanlari = { "MATEMATİK", "FİZİK", "KİMYA", "TÜRKÇE", "TARİH", "COĞRAFYA", "DİN", "FELSEFE", "BİYOLOJİ", "DANIŞMAN" };
            comboBoxOgretmenAlan.Items.AddRange(ogretmenAlanlari);
        }
        private void dersAdYukle()
        {
            string[] dersAdlari = { "TYT-Matematik", "TYT-Fizik", "TYT-Kimya", "TYT-Türkçe", "TYT-Tarih", "TYT-Coğrafya", "TYT-Din", "TYT-Felsefe", "TYT-Biyoloji", "AYT-Matematik", "AYT-Fizik", "AYT-Kimya", "AYT-Türkçe", "AYT-Tarih", "AYT-Coğrafya", "AYT-Felsefe", "AYT-Biyoloji", "YDT-İngilizce" };
            comboBoxDersAdi.Items.AddRange(dersAdlari);
        }

        private void ogretmenleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Ogretmen";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewOgretmenler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Öğretmenleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void dersleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Ders";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewDersler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Dersleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void ogretmenEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ogretmen (TeacherID ,CourseID, FirstName, LastName, HireDate, Alan) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxTeacherID.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxLessonID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxOgretmenAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxOgretmenSoyadi.Text);
                    sqlCommand.Parameters.AddWithValue("@P5", dateTimePickerBaslangicTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P6", comboBoxOgretmenAlan.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmen eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                teacherIDYukle();
            }
            else
            {
                MessageBox.Show("Öğretmen eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogretmenGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Ogretmen SET TeacherID = @P1, CourseID = @P2, FirstName = @P3, LastName = @P4, HireDate = @P5, Alan = @P6 WHERE TeacherID = @P7", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxTeacherID.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxLessonID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxOgretmenAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxOgretmenSoyadi.Text);
                    sqlCommand.Parameters.AddWithValue("@P5", dateTimePickerBaslangicTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P6", comboBoxOgretmenAlan.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P7", comboBoxTemporaryTeacherID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmen güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                teacherIDYukle();
            }
            else
            {
                MessageBox.Show("Öğretmen güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void ogretmenSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ogretmen WHERE TeacherID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekOgretmenID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmen silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                teacherIDYukle();
            }
            else
            {
                MessageBox.Show("Öğretmen silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void dersEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ders (CourseName ,HaftalikSaat) VALUES (@P1, @P2)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxDersAdi.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", numericUpDownHaftalikSaati.Value);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                dersIDYukle();
            }
            else
            {
                MessageBox.Show("Ders eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void dersGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Ders SET CourseName = @P1, HaftalikSaat = @P2 WHERE CourseID = @P3", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxDersAdi.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", numericUpDownHaftalikSaati.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", comboBoxTemporaryDersID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                dersIDYukle();
            }
            else
            {
                MessageBox.Show("Ders güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void dersSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ders WHERE CourseID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekDersID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                dersIDYukle();
            }
            else
            {
                MessageBox.Show("Ders silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }


        private void FormTchANDLessonMenu_Load(object sender, EventArgs e)
        {
            dersAdYukle();
            ogretmenAlanYukle();
            teacherIDYukle();
            dersIDYukle();
        }

        private void buttonOgretmenEkle_Click(object sender, EventArgs e)
        {
            ogretmenEkle();
        }

        private void buttonOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            ogretmenGuncelle();
        }

        private void buttonOgretmenSil_Click(object sender, EventArgs e)
        {
            ogretmenSil();
        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            dersEkle();
        }

        private void buttonDersGuncelle_Click(object sender, EventArgs e)
        {
            dersGuncelle();
        }

        private void buttonDersSil_Click(object sender, EventArgs e)
        {
            dersSil();
        }

        private void buttonOgretmenleriGoruntule_Click(object sender, EventArgs e)
        {
            ogretmenleriGoster();
        }

        private void buttonDersleriGoruntule_Click(object sender, EventArgs e)
        {
            dersleriGoster();
        }







        private void SaveAsWordTeachers(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewOgretmenler.Rows.Count;
                int colCount = dataGridViewOgretmenler.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewOgretmenler.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewOgretmenler.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordLessons(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewDersler.Rows.Count;
                int colCount = dataGridViewDersler.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewDersler.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewDersler.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }

        private void buttonSaveWordTeachers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordTeachers(filePath);
            }
        }
        private void buttonSaveWordLessons_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordLessons(filePath);
            }
        }







        private void ImportTeachers(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TeacherID", typeof(string));
                dataTable.Columns.Add("CourseID", typeof(short));
                dataTable.Columns.Add("FirstName", typeof(string));
                dataTable.Columns.Add("LastName", typeof(string));
                dataTable.Columns.Add("HireDate", typeof(DateTime));
                dataTable.Columns.Add("Alan", typeof(string));

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["TeacherID"] = worksheet.Cells[row, 1].Text;
                    dataRow["CourseID"] = worksheet.Cells[row, 2].Text;
                    dataRow["FirstName"] = worksheet.Cells[row, 3].Text;
                    dataRow["LastName"] = worksheet.Cells[row, 4].Text;
                    dataRow["HireDate"] = DateTime.Parse(worksheet.Cells[row, 5].Text);
                    dataRow["Alan"] = worksheet.Cells[row, 6].Text; ;
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewOgretmenler.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewOgretmenler.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewOgretmenler.DataSource = existingTable;
                }
                else
                {
                    dataGridViewOgretmenler.DataSource = dataTable;
                }

                AddTeachersToDatabase(dataTable);
                teacherIDYukle();
            }
        }
        private void AddTeachersToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO OGretmen (TeacherID, CourseID, FirstName, LastName, HireDate, Alan) VALUES (@TeacherID, @CourseID, @FirstName, @LastName, @HireDate, @Alan)", baglanti);
                        command.Parameters.AddWithValue("@TeacherID", row["TeacherID"]);
                        command.Parameters.AddWithValue("@CourseID", row["CourseID"]);
                        command.Parameters.AddWithValue("@FirstName", row["FirstName"]);
                        command.Parameters.AddWithValue("@LastName", row["LastName"]);
                        command.Parameters.AddWithValue("@HireDate", row["HireDate"]);
                        command.Parameters.AddWithValue("@Alan", row["Alan"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show("Bir hata oluştu." + ex.Message);
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
        private void buttonVeriAlOgretmen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportTeachers(openFileDialog.FileName);
            }
        }
        private void ExportToExcelOgretmen(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewOgretmenler.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewOgretmenler.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewOgretmenler.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewOgretmenler.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewOgretmenler.Rows[row].Cells[col].Value;
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
        private void buttonSaveExcelOgretmen_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelOgretmen(saveFileDialog.FileName);
            }
        }




        private void ImportLessons(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("CourseName", typeof(string));
                dataTable.Columns.Add("HaftalikSaat", typeof(byte));


                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["CourseName"] = worksheet.Cells[row, 1].Text;
                    dataRow["HaftalikSaat"] = byte.Parse(worksheet.Cells[row, 2].Text);
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewDersler.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewDersler.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewDersler.DataSource = existingTable;
                }
                else
                {
                    dataGridViewDersler.DataSource = dataTable;
                }

                AddLessonToDatabase(dataTable);
                dersIDYukle();
            }
        } //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddLessonToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO Ders (CourseName, HaftalikSaat) VALUES (@CourseName, @HaftalikSaat)", baglanti);
                        command.Parameters.AddWithValue("@CourseName", row["CourseName"]);
                        command.Parameters.AddWithValue("@HaftalikSaat", row["HaftalikSaat"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["CourseName"]}, {row["HaftalikSaat"]}",
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
        private void buttonVeriAlDers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportLessons(openFileDialog.FileName);
            }
        }
        private void ExportToExcelDersler(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewDersler.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewDersler.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewDersler.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewDersler.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewDersler.Rows[row].Cells[col].Value;
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
        private void buttonSaveExcelDers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelDersler(saveFileDialog.FileName);
            }
        }
    }
}
