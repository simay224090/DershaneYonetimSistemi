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
    public partial class FormOgrMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        KullaniciYetkileri kullaniciYetkileri;
        public FormOgrMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            this.AutoScroll = true;
            kullaniciYetkileri = yetkiler;
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

                // Öğeleri bir listeye kaydediyoruz
                List<string> studentIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    studentIDs.Add(reader["StudentID"].ToString());
                }

                comboBoxTemporaryStudentID.Items.Clear();
                comboBoxTemporaryStudentID.Items.AddRange(studentIDs.ToArray());

                comboBoxOgrenciNo.Items.Clear();
                comboBoxOgrenciNo.Items.AddRange(studentIDs.ToArray());

                comboBoxOgrenciID.Items.Clear();
                comboBoxOgrenciID.Items.AddRange(studentIDs.ToArray());
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

        private void studentCourseIDYukle()
        {
            try
            {

                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentCourseID FROM OgrenciDers", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> studentCourseIDs = new List<string>();


                while (reader.Read())
                {
                    studentCourseIDs.Add(reader["StudentCourseID"].ToString());
                }

                comboBoxTemporaryOgrenciDersID.Items.Clear();
                comboBoxTemporaryOgrenciDersID.Items.AddRange(studentCourseIDs.ToArray());

                comboBoxOgrenciDersID.Items.Clear();
                comboBoxOgrenciDersID.Items.AddRange(studentCourseIDs.ToArray());

                comboBoxStudentLessonID.Items.Clear();
                comboBoxStudentLessonID.Items.AddRange(studentCourseIDs.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Student Course ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void CourseIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT CourseID FROM Ders", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxDersID.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxDersID.Items.Add(reader["CourseID"].ToString());
                }

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
        private void AttendanceIdYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT AttendanceId FROM Devamsizlik", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> attendanceIDs = new List<string>();


                while (reader.Read())
                {
                    attendanceIDs.Add(reader["AttendanceId"].ToString());
                }

                comboBoxTemporaryDevamsizlikID.Items.Clear();
                comboBoxTemporaryDevamsizlikID.Items.AddRange(attendanceIDs.ToArray());

                comboBoxDevamsizlikID.Items.Clear();
                comboBoxDevamsizlikID.Items.AddRange(attendanceIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void ogrencileriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Ogrenci";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewOgrenciler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Öğrencileri görüntüleme yetkiniz yok. " +
                    "Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogrenciDersleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM OgrenciDers";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewOgrenciDersleri.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Öğrenci Dersleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void devamsizliklariGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Devamsizlik";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewDevamsizliklar.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Devamsızlıkları görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void ogrenciEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ogrenci (StudentID ,FirstName, LastName, DateOfBirth, Gender, RegistrationDate, Adres, OgrenciAlan) VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxStudentID.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxOgrenciAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxOgrenciSoyadi.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", dateTimePickerDogumTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P5", textBoxOgrenciCinsiyet.Text);
                    sqlCommand.Parameters.AddWithValue("@P6", dateTimePickerKayitTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P7", richTextBoxOgrenciAdres.Text);
                    sqlCommand.Parameters.AddWithValue("@P8", textBoxOgrenciAlan.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                studentIDYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogrenciGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Ogrenci SET StudentID = @P1, FirstName = @P2, LastName = @P3, DateOfBirth = @P4, Gender = @P5, RegistrationDate = @P6, Adres = @P7, OgrenciAlan = @P8 WHERE StudentID = @P9", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxStudentID.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxOgrenciAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxOgrenciSoyadi.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", dateTimePickerDogumTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P5", textBoxOgrenciCinsiyet.Text);
                    sqlCommand.Parameters.AddWithValue("@P6", dateTimePickerKayitTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P7", richTextBoxOgrenciAdres.Text);
                    sqlCommand.Parameters.AddWithValue("@P8", textBoxOgrenciAlan.Text);
                    sqlCommand.Parameters.AddWithValue("@P9", comboBoxTemporaryStudentID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                studentIDYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogrenciSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ogrenci WHERE StudentID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                studentIDYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogrenciDersEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO OgrenciDers (StudentID, CourseID, DerseKayitTarihi) VALUES (@P1, @P2, @P3)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxDersID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDerseKayitTarihi.Value);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci Ders eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                studentCourseIDYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci ders ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogrenciDersGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE OgrenciDers SET StudentID = @P1, CourseID = @P2, DerseKayitTarihi = @P3 WHERE StudentCourseID = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxDersID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDerseKayitTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporaryOgrenciDersID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci Ders güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                studentCourseIDYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci ders güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogrenciDersSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM OgrenciDers WHERE StudentCourseID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxStudentLessonID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğrenci ders silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                studentCourseIDYukle();
            }
            else
            {
                MessageBox.Show("Öğrenci ders silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void devamsizlikEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Devamsizlik (StudentCourseID, Durum, AttendanceDate) VALUES (@P1, @P2, @P3)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciDersID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", checkBoxDevamsizlikBilgisi.Checked ? 1 : 0);
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDevamsizlikTarihi.Value);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla eklendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Devamsızlık eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                AttendanceIdYukle();
            }
            else
            {
                MessageBox.Show("Devamsızlık ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void devamsizlikGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Devamsizlik SET StudentCourseID = @P1, Durum = @P2, AttendanceDate = @P3 WHERE AttendanceId = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciDersID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", checkBoxDevamsizlikBilgisi.Checked ? 1 : 0);
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDevamsizlikTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporaryDevamsizlikID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla güncellendi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Devamsızlık güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                AttendanceIdYukle();
            }
            else
            {
                MessageBox.Show("Devamsızlık güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void devamsizlikSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Devamsizlik WHERE AttendanceId = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxDevamsizlikID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("--------- Başarıyla silindi ---------");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Devamsızlık silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                AttendanceIdYukle();
            }
            else
            {
                MessageBox.Show("Devamsızlık silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void FormOgrMenu_Load(object sender, EventArgs e)
        {
            studentIDYukle();
            studentCourseIDYukle();
            CourseIDYukle();
            AttendanceIdYukle();
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            ogrenciEkle();
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            ogrenciGuncelle();
        }

        private void buttonOgrenciSil_Click(object sender, EventArgs e)
        {
            ogrenciSil();
        }

        private void buttonOgrenciDersEkle_Click(object sender, EventArgs e)
        {
            ogrenciDersEkle();
        }

        private void buttonOgrenciDersGuncelle_Click(object sender, EventArgs e)
        {
            ogrenciDersGuncelle();
        }

        private void buttonOgrenciDersSil_Click(object sender, EventArgs e)
        {
            ogrenciDersSil();
        }

        private void buttonOgrenciDevamsizlikEkle_Click(object sender, EventArgs e)
        {
            devamsizlikEkle();
        }
        private void buttonSinavDevamsizlikGuncelle_Click(object sender, EventArgs e)
        {
            devamsizlikGuncelle();
        }

        private void buttonDevamsızlıkSil_Click(object sender, EventArgs e)
        {
            devamsizlikSil();
        }



        private void buttonOgrencileriGoruntule_Click(object sender, EventArgs e)
        {
            ogrencileriGoster();
        }

        private void buttonOgrenciDersleriGoruntule_Click(object sender, EventArgs e)
        {
            ogrenciDersleriGoster();
        }

        private void buttonDevamsizlikGoruntule_Click(object sender, EventArgs e)
        {
            devamsizliklariGoster();
        }





        // NuGet => DocX ile  verileri word dosyası halinde kaydedebilme kodları
        private void SaveAsWordStudents(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewOgrenciler.Rows.Count;
                int colCount = dataGridViewOgrenciler.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewOgrenciler.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewOgrenciler.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordStudentLessons(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewOgrenciDersleri.Rows.Count;
                int colCount = dataGridViewOgrenciDersleri.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewOgrenciDersleri.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewOgrenciDersleri.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordDevamsizliklar(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewDevamsizliklar.Rows.Count;
                int colCount = dataGridViewDevamsizliklar.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewDevamsizliklar.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewDevamsizliklar.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }

        private void buttonSaveWordDevamsizliklar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordDevamsizliklar(filePath);
            }
        }
        private void buttonSaveWordStudents_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordStudents(filePath);
            }
        }
        private void buttonSaveWordStudentLessons_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordStudentLessons(filePath);
            }
        }




        private void ImportStudents(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("StudentID", typeof(string));
                dataTable.Columns.Add("FirstName", typeof(string));
                dataTable.Columns.Add("LastName", typeof(string));
                dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
                dataTable.Columns.Add("Gender", typeof(string));
                dataTable.Columns.Add("RegistrationDate", typeof(DateTime));
                dataTable.Columns.Add("Adres", typeof(string));
                dataTable.Columns.Add("OgrenciAlan", typeof(string));

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["StudentID"] = worksheet.Cells[row, 1].Text;
                    dataRow["FirstName"] = worksheet.Cells[row, 2].Text;
                    dataRow["LastName"] = worksheet.Cells[row, 3].Text;
                    dataRow["DateOfBirth"] = DateTime.Parse(worksheet.Cells[row, 4].Text);
                    dataRow["Gender"] = worksheet.Cells[row, 5].Text;
                    dataRow["RegistrationDate"] = DateTime.Parse(worksheet.Cells[row, 6].Text);
                    dataRow["Adres"] = worksheet.Cells[row, 7].Text;
                    dataRow["OgrenciAlan"] = worksheet.Cells[row, 8].Text;
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewOgrenciler.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewOgrenciler.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewOgrenciler.DataSource = existingTable;
                }
                else
                {
                    dataGridViewOgrenciler.DataSource = dataTable;
                }

                AddStudentsToDatabase(dataTable);
                studentIDYukle();
            }
        }
        private void AddStudentsToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO Ogrenci (StudentID, FirstName, LastName, DateOfBirth, Gender, RegistrationDate, Adres, OgrenciAlan) VALUES (@StudentID, @FirstName, @LastName, @DateOfBirth, @Gender, @RegistrationDate, @Adres, @OgrenciAlan)", baglanti);
                        command.Parameters.AddWithValue("@StudentID", row["StudentID"]);
                        command.Parameters.AddWithValue("@FirstName", row["FirstName"]);
                        command.Parameters.AddWithValue("@LastName", row["LastName"]);
                        command.Parameters.AddWithValue("@DateOfBirth", row["DateOfBirth"]);
                        command.Parameters.AddWithValue("@Gender", row["Gender"]);
                        command.Parameters.AddWithValue("@RegistrationDate", row["RegistrationDate"]);
                        command.Parameters.AddWithValue("@Adres", row["Adres"]);
                        command.Parameters.AddWithValue("@OgrenciAlan", row["OgrenciAlan"]);
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
        private void buttonVeriAlOgrenci_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportStudents(openFileDialog.FileName);
            }
        }

        private void ExportToExcelOgrenciler(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewOgrenciler.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewOgrenciler.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewOgrenciler.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewOgrenciler.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewOgrenciler.Rows[row].Cells[col].Value;
                        }
                    }

                    // Excel dosyasını kaydet
                    package.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı!", "Başarılı", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveExcelOgrenciler_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelOgrenciler(saveFileDialog.FileName);
            }
        }




        private void ImportStudentCourses(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("StudentID", typeof(string));
                dataTable.Columns.Add("CourseID", typeof(short));
                dataTable.Columns.Add("DerseKayitTarihi", typeof(DateTime));

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["StudentID"] = worksheet.Cells[row, 1].Text;
                    dataRow["CourseID"] = short.Parse(worksheet.Cells[row, 2].Text);
                    dataRow["DerseKayitTarihi"] = DateTime.Parse(worksheet.Cells[row, 3].Text);
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewOgrenciDersleri.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewOgrenciDersleri.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewOgrenciDersleri.DataSource = existingTable;
                }
                else
                {
                    dataGridViewOgrenciDersleri.DataSource = dataTable;
                }

                AddStudentCoursesToDatabase(dataTable);
                studentCourseIDYukle();
            }
        }    //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddStudentCoursesToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO OgrenciDers (StudentID, CourseID, DerseKayitTarihi, SinifDersID) VALUES (@StudentID, @CourseID, @DerseKayitTarihi, @SinifDersID)", baglanti);
                        command.Parameters.AddWithValue("@StudentID", row["StudentID"]);
                        command.Parameters.AddWithValue("@CourseID", row["CourseID"]);
                        command.Parameters.AddWithValue("@DerseKayitTarihi", row["DerseKayitTarihi"]);

                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["StudentID"]}, {row["CourseID"]}, {row["DerseKayitTarihi"]}",
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
        private void buttonVeriAlOgrenciDers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportStudentCourses(openFileDialog.FileName);
            }
        }

        private void ExportToExcelOgrenciDersler(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewOgrenciDersleri.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewOgrenciDersleri.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewOgrenciDersleri.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewOgrenciDersleri.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewOgrenciDersleri.Rows[row].Cells[col].Value;
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
        private void buttonSaveExcelOgrenciDers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelOgrenciDersler(saveFileDialog.FileName);
            }

        }




        private void ImportAttendance(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("StudentCourseID", typeof(int));
                dataTable.Columns.Add("Durum", typeof(bool));
                dataTable.Columns.Add("AttendanceDate", typeof(DateTime));

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["StudentCourseID"] = int.Parse(worksheet.Cells[row, 1].Text);
                    dataRow["Durum"] = bool.Parse(worksheet.Cells[row, 2].Text);
                    dataRow["AttendanceDate"] = DateTime.Parse(worksheet.Cells[row, 3].Text);
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewDevamsizliklar.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewDevamsizliklar.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewDevamsizliklar.DataSource = existingTable;
                }
                else
                {
                    dataGridViewDevamsizliklar.DataSource = dataTable;
                }

                AddAttendanceToDatabase(dataTable);
                AttendanceIdYukle();
            }
        } //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddAttendanceToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO Devamsizlik (StudentCourseID, Durum, AttendanceDate) VALUES (@StudentCourseID, @Durum, @AttendanceDate)", baglanti);
                        command.Parameters.AddWithValue("@StudentCourseID", row["StudentCourseID"]);
                        command.Parameters.AddWithValue("@Durum", row["Durum"]);
                        command.Parameters.AddWithValue("@AttendanceDate", row["AttendanceDate"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["StudentCourseID"]}, {row["Durum"]}, {row["AttendanceDate"]}",
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
        private void buttonVeriAlDevamsizlik_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportAttendance(openFileDialog.FileName);
            }
        }

        private void ExportToExcelDevamsizliklar(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewDevamsizliklar.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewDevamsizliklar.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewDevamsizliklar.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewDevamsizliklar.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewDevamsizliklar.Rows[row].Cells[col].Value;
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
        private void buttonSaveExcelDevamsizliklar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelDevamsizliklar(saveFileDialog.FileName);
            }
        }



    }
}
