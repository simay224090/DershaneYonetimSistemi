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
using Xceed.Words.NET;

namespace DershaneYonetimSistemi
{
    public partial class FormRaporMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=SIMAY\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");

        private KullaniciYetkileri kullaniciYetkileri;
        public FormRaporMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            this.AutoScroll = true;
            kullaniciYetkileri = yetkiler;
        }
        private void SearchGrades()
        {
            string firstName = textBoxOgrenciAd.Text;
            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentGradesByName", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);

                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetStudentGradesByName.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchPayments()
        {
            string firstName = textBoxOgrenciAd2.Text;
            string lastName = textBoxOgrenciSoyad.Text;
            string odemeTuru = textBoxOdemeTuru.Text;

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentsByPaymentDetails", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                sqlCommand.Parameters.AddWithValue("@PaymentType", odemeTuru);

                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetPayments.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchAttendances()
        {
            string firstName = textBoxOgrenciAd3.Text;
            string lastName = textBoxOgrenciSoyad2.Text;
            string dersAdi = textBoxDersAdi.Text;

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentAttendanceReport", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                sqlCommand.Parameters.AddWithValue("@CourseName", dersAdi);

                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetAttendances.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchTeachers()
        {
            string firstName = textBoxOgretmenAdi.Text;
            string ogretmenAlan = textBoxOgretmenAlan.Text;
            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetTeacherBranch", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TeacherName", firstName);
                sqlCommand.Parameters.AddWithValue("@OgretmenAlan", ogretmenAlan);
                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetTeachers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchStudentsByCoursePerformance()
        {
            string dersAdi = textBoxDersAdı2.Text;
            string minPuan = numericUpDownMinPuan.Value.ToString();
            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentsByCoursePerformance", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@CourseName", dersAdi);
                sqlCommand.Parameters.AddWithValue("@MinScore", minPuan);
                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewDerseGorePuanlar.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }


        private void buttonSearchGrades_Click(object sender, EventArgs e)
        {
            SearchGrades();
        }

        private void buttonSearchPayments_Click(object sender, EventArgs e)
        {
            SearchPayments();
        }

        private void buttonSearchAttendance_Click(object sender, EventArgs e)
        {
            SearchAttendances();
        }

        private void buttonSearchTeachers_Click(object sender, EventArgs e)
        {
            SearchTeachers();
        }

        private void buttonSearchExamResults_Click(object sender, EventArgs e)
        {
            SearchStudentsByCoursePerformance();
        }



        private void SaveAsWordRapor1(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewGetTeachers.Rows.Count;
                int colCount = dataGridViewGetTeachers.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewGetTeachers.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewGetTeachers.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }

        private void SaveAsWordRapor2(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewGetAttendances.Rows.Count;
                int colCount = dataGridViewGetAttendances.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewGetAttendances.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewGetAttendances.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordRapor3(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewDerseGorePuanlar.Rows.Count;
                int colCount = dataGridViewDerseGorePuanlar.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewDerseGorePuanlar.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewDerseGorePuanlar.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordRapor4(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewGetStudentGradesByName.Rows.Count;
                int colCount = dataGridViewGetStudentGradesByName.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewGetStudentGradesByName.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewGetStudentGradesByName.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordRapor5(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewGetPayments.Rows.Count;
                int colCount = dataGridViewGetPayments.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewGetPayments.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewGetPayments.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }

        private void buttonSaveAsWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordRapor1(filePath);
            }
        }

        private void buttonSaveAsWord2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordRapor2(filePath);
            }
        }

        private void buttonSaveAsWord3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordRapor3(filePath);
            }
        }

        private void buttonSaveAsWord4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordRapor4(filePath);
            }
        }

        private void buttonSaveAsWord5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordRapor5(filePath);
            }
        }
    }
}
