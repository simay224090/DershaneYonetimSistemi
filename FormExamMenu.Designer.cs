namespace DershaneYonetimSistemi
{
    partial class FormExamMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSinavSonucSil = new Button();
            labelSilinecekSinavSonucID = new Label();
            buttonSinavSil = new Button();
            labelSilinecekSinavID = new Label();
            groupBox4 = new GroupBox();
            dataGridViewSinavSonuclari = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridViewSinavlar = new DataGridView();
            groupBox2 = new GroupBox();
            comboBoxCourseID2 = new ComboBox();
            label1 = new Label();
            labelOgrenciID = new Label();
            label2 = new Label();
            textBoxAlinanPuan = new TextBox();
            comboBoxTemporarySinavSonucID = new ComboBox();
            comboBoxStudentID = new ComboBox();
            comboBoxSinavIDforSınavSonuc = new ComboBox();
            labelTemporarySonucID = new Label();
            buttonSinavSonucGuncelle = new Button();
            buttonSinavSonucEkle = new Button();
            labelExamID = new Label();
            labelAlinanPuan = new Label();
            groupBox1 = new GroupBox();
            comboBoxTemporarySinavID = new ComboBox();
            comboBoxCourseID = new ComboBox();
            textBoxSinavIsmi = new TextBox();
            dateTimePickerSinavTarihi = new DateTimePicker();
            buttonSinavGuncelle = new Button();
            labelTemporarySinavID = new Label();
            buttonSinavEkle = new Button();
            labelSinavIsmi = new Label();
            labelCourseID = new Label();
            labelSinavTarihi = new Label();
            buttonSinavlariGoruntule = new Button();
            buttonSinavSonucGoruntule = new Button();
            labelSinavCRUD = new Label();
            comboBoxSilinecekSinavID = new ComboBox();
            comboBoxSilinecekSinavSonucID = new ComboBox();
            labelSinavSonucCRUD = new Label();
            buttonSaveAsWordExamResults = new Button();
            buttonSaveAsWordExams = new Button();
            buttonSaveExcelSinav = new Button();
            buttonVeriAlSinav = new Button();
            buttonSaveExcelSinavSonuc = new Button();
            buttonVeriAlSinavSonuc = new Button();
            treeView1 = new TreeView();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavSonuclari).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavlar).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSinavSonucSil
            // 
            buttonSinavSonucSil.BackColor = Color.SteelBlue;
            buttonSinavSonucSil.Location = new Point(1196, 361);
            buttonSinavSonucSil.Name = "buttonSinavSonucSil";
            buttonSinavSonucSil.Size = new Size(87, 38);
            buttonSinavSonucSil.TabIndex = 29;
            buttonSinavSonucSil.Text = "Sınav sonucunu sil";
            buttonSinavSonucSil.UseVisualStyleBackColor = false;
            buttonSinavSonucSil.Click += buttonSinavSonucSil_Click;
            // 
            // labelSilinecekSinavSonucID
            // 
            labelSilinecekSinavSonucID.AutoSize = true;
            labelSilinecekSinavSonucID.Font = new Font("Century", 9F);
            labelSilinecekSinavSonucID.Location = new Point(798, 372);
            labelSilinecekSinavSonucID.Name = "labelSilinecekSinavSonucID";
            labelSilinecekSinavSonucID.Size = new Size(264, 16);
            labelSilinecekSinavSonucID.TabIndex = 27;
            labelSilinecekSinavSonucID.Text = "Silinecek sınav sonucunun ID değerini seçiniz :";
            // 
            // buttonSinavSil
            // 
            buttonSinavSil.BackColor = Color.SteelBlue;
            buttonSinavSil.Location = new Point(427, 364);
            buttonSinavSil.Name = "buttonSinavSil";
            buttonSinavSil.Size = new Size(87, 38);
            buttonSinavSil.TabIndex = 26;
            buttonSinavSil.Text = "Sınavı Sil";
            buttonSinavSil.UseVisualStyleBackColor = false;
            buttonSinavSil.Click += buttonSinavSil_Click;
            // 
            // labelSilinecekSinavID
            // 
            labelSilinecekSinavID.AutoSize = true;
            labelSilinecekSinavID.Font = new Font("Century", 9F);
            labelSilinecekSinavID.Location = new Point(67, 372);
            labelSilinecekSinavID.Name = "labelSilinecekSinavID";
            labelSilinecekSinavID.Size = new Size(215, 16);
            labelSilinecekSinavID.TabIndex = 24;
            labelSilinecekSinavID.Text = "Silinecek Sınavın ID değerini seçiniz :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewSinavSonuclari);
            groupBox4.Location = new Point(738, 432);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(597, 266);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Sonuç Listesi";
            // 
            // dataGridViewSinavSonuclari
            // 
            dataGridViewSinavSonuclari.AllowUserToAddRows = false;
            dataGridViewSinavSonuclari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSinavSonuclari.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewSinavSonuclari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinavSonuclari.Dock = DockStyle.Fill;
            dataGridViewSinavSonuclari.Location = new Point(3, 19);
            dataGridViewSinavSonuclari.Name = "dataGridViewSinavSonuclari";
            dataGridViewSinavSonuclari.RowTemplate.Height = 25;
            dataGridViewSinavSonuclari.Size = new Size(591, 244);
            dataGridViewSinavSonuclari.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewSinavlar);
            groupBox3.Location = new Point(38, 445);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(650, 269);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Listesi";
            // 
            // dataGridViewSinavlar
            // 
            dataGridViewSinavlar.AllowUserToAddRows = false;
            dataGridViewSinavlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSinavlar.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewSinavlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinavlar.Dock = DockStyle.Fill;
            dataGridViewSinavlar.Location = new Point(3, 19);
            dataGridViewSinavlar.Name = "dataGridViewSinavlar";
            dataGridViewSinavlar.RowTemplate.Height = 25;
            dataGridViewSinavlar.Size = new Size(644, 247);
            dataGridViewSinavlar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxCourseID2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(labelOgrenciID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxAlinanPuan);
            groupBox2.Controls.Add(comboBoxTemporarySinavSonucID);
            groupBox2.Controls.Add(comboBoxStudentID);
            groupBox2.Controls.Add(comboBoxSinavIDforSınavSonuc);
            groupBox2.Controls.Add(labelTemporarySonucID);
            groupBox2.Controls.Add(buttonSinavSonucGuncelle);
            groupBox2.Controls.Add(buttonSinavSonucEkle);
            groupBox2.Controls.Add(labelExamID);
            groupBox2.Controls.Add(labelAlinanPuan);
            groupBox2.Location = new Point(831, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 289);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Sonuç İşlemleri";
            // 
            // comboBoxCourseID2
            // 
            comboBoxCourseID2.FormattingEnabled = true;
            comboBoxCourseID2.Location = new Point(110, 214);
            comboBoxCourseID2.Name = "comboBoxCourseID2";
            comboBoxCourseID2.Size = new Size(121, 23);
            comboBoxCourseID2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 9F);
            label1.Location = new Point(17, 216);
            label1.Name = "label1";
            label1.Size = new Size(68, 16);
            label1.TabIndex = 34;
            label1.Text = "Course ID :";
            // 
            // labelOgrenciID
            // 
            labelOgrenciID.AutoSize = true;
            labelOgrenciID.Font = new Font("Century", 9F);
            labelOgrenciID.Location = new Point(17, 122);
            labelOgrenciID.Name = "labelOgrenciID";
            labelOgrenciID.Size = new Size(71, 16);
            labelOgrenciID.TabIndex = 32;
            labelOgrenciID.Text = "Öğrenci ID :";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 6.75F);
            label2.Location = new Point(6, 176);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 32;
            label2.Text = "(Lütfen 0-100 arasında bir sayı giriniz)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAlinanPuan
            // 
            textBoxAlinanPuan.Location = new Point(113, 158);
            textBoxAlinanPuan.Name = "textBoxAlinanPuan";
            textBoxAlinanPuan.Size = new Size(118, 23);
            textBoxAlinanPuan.TabIndex = 28;
            // 
            // comboBoxTemporarySinavSonucID
            // 
            comboBoxTemporarySinavSonucID.FormattingEnabled = true;
            comboBoxTemporarySinavSonucID.Location = new Point(235, 41);
            comboBoxTemporarySinavSonucID.Name = "comboBoxTemporarySinavSonucID";
            comboBoxTemporarySinavSonucID.Size = new Size(121, 23);
            comboBoxTemporarySinavSonucID.TabIndex = 33;
            // 
            // comboBoxStudentID
            // 
            comboBoxStudentID.FormattingEnabled = true;
            comboBoxStudentID.Location = new Point(110, 120);
            comboBoxStudentID.Name = "comboBoxStudentID";
            comboBoxStudentID.Size = new Size(121, 23);
            comboBoxStudentID.TabIndex = 27;
            // 
            // comboBoxSinavIDforSınavSonuc
            // 
            comboBoxSinavIDforSınavSonuc.FormattingEnabled = true;
            comboBoxSinavIDforSınavSonuc.Location = new Point(110, 79);
            comboBoxSinavIDforSınavSonuc.Name = "comboBoxSinavIDforSınavSonuc";
            comboBoxSinavIDforSınavSonuc.Size = new Size(121, 23);
            comboBoxSinavIDforSınavSonuc.TabIndex = 26;
            // 
            // labelTemporarySonucID
            // 
            labelTemporarySonucID.Location = new Point(17, 30);
            labelTemporarySonucID.Name = "labelTemporarySonucID";
            labelTemporarySonucID.Size = new Size(229, 43);
            labelTemporarySonucID.TabIndex = 20;
            labelTemporarySonucID.Text = "Güncelleme yapmak istediğiniz sınav sonucunun mevcut ID değerini seçiniz :";
            labelTemporarySonucID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSinavSonucGuncelle
            // 
            buttonSinavSonucGuncelle.BackColor = Color.Lavender;
            buttonSinavSonucGuncelle.Location = new Point(235, 245);
            buttonSinavSonucGuncelle.Name = "buttonSinavSonucGuncelle";
            buttonSinavSonucGuncelle.Size = new Size(87, 38);
            buttonSinavSonucGuncelle.TabIndex = 17;
            buttonSinavSonucGuncelle.Text = "Sınav Sonuç Güncelle";
            buttonSinavSonucGuncelle.UseVisualStyleBackColor = false;
            buttonSinavSonucGuncelle.Click += buttonSinavSonucGuncelle_Click;
            // 
            // buttonSinavSonucEkle
            // 
            buttonSinavSonucEkle.BackColor = Color.Lavender;
            buttonSinavSonucEkle.Location = new Point(347, 245);
            buttonSinavSonucEkle.Name = "buttonSinavSonucEkle";
            buttonSinavSonucEkle.Size = new Size(87, 38);
            buttonSinavSonucEkle.TabIndex = 16;
            buttonSinavSonucEkle.Text = "Sınav Sonuç Ekle";
            buttonSinavSonucEkle.UseVisualStyleBackColor = false;
            buttonSinavSonucEkle.Click += buttonSinavSonucEkle_Click;
            // 
            // labelExamID
            // 
            labelExamID.AutoSize = true;
            labelExamID.Font = new Font("Century", 9F);
            labelExamID.Location = new Point(17, 81);
            labelExamID.Name = "labelExamID";
            labelExamID.Size = new Size(61, 16);
            labelExamID.TabIndex = 8;
            labelExamID.Text = "Sınav ID :";
            // 
            // labelAlinanPuan
            // 
            labelAlinanPuan.AutoSize = true;
            labelAlinanPuan.Font = new Font("Century", 9F);
            labelAlinanPuan.Location = new Point(17, 160);
            labelAlinanPuan.Name = "labelAlinanPuan";
            labelAlinanPuan.Size = new Size(83, 16);
            labelAlinanPuan.TabIndex = 2;
            labelAlinanPuan.Text = "Alınan Puan :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxTemporarySinavID);
            groupBox1.Controls.Add(comboBoxCourseID);
            groupBox1.Controls.Add(textBoxSinavIsmi);
            groupBox1.Controls.Add(dateTimePickerSinavTarihi);
            groupBox1.Controls.Add(buttonSinavGuncelle);
            groupBox1.Controls.Add(labelTemporarySinavID);
            groupBox1.Controls.Add(buttonSinavEkle);
            groupBox1.Controls.Add(labelSinavIsmi);
            groupBox1.Controls.Add(labelCourseID);
            groupBox1.Controls.Add(labelSinavTarihi);
            groupBox1.Location = new Point(67, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 280);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınav İşlemleri";
            // 
            // comboBoxTemporarySinavID
            // 
            comboBoxTemporarySinavID.FormattingEnabled = true;
            comboBoxTemporarySinavID.Location = new Point(219, 44);
            comboBoxTemporarySinavID.Name = "comboBoxTemporarySinavID";
            comboBoxTemporarySinavID.Size = new Size(121, 23);
            comboBoxTemporarySinavID.TabIndex = 27;
            // 
            // comboBoxCourseID
            // 
            comboBoxCourseID.FormattingEnabled = true;
            comboBoxCourseID.Location = new Point(95, 89);
            comboBoxCourseID.Name = "comboBoxCourseID";
            comboBoxCourseID.Size = new Size(121, 23);
            comboBoxCourseID.TabIndex = 25;
            // 
            // textBoxSinavIsmi
            // 
            textBoxSinavIsmi.Location = new Point(98, 122);
            textBoxSinavIsmi.Name = "textBoxSinavIsmi";
            textBoxSinavIsmi.Size = new Size(118, 23);
            textBoxSinavIsmi.TabIndex = 23;
            // 
            // dateTimePickerSinavTarihi
            // 
            dateTimePickerSinavTarihi.Location = new Point(98, 155);
            dateTimePickerSinavTarihi.Name = "dateTimePickerSinavTarihi";
            dateTimePickerSinavTarihi.Size = new Size(191, 23);
            dateTimePickerSinavTarihi.TabIndex = 22;
            // 
            // buttonSinavGuncelle
            // 
            buttonSinavGuncelle.BackColor = Color.Lavender;
            buttonSinavGuncelle.Location = new Point(179, 219);
            buttonSinavGuncelle.Name = "buttonSinavGuncelle";
            buttonSinavGuncelle.Size = new Size(90, 38);
            buttonSinavGuncelle.TabIndex = 20;
            buttonSinavGuncelle.Text = "Sınav Güncelle";
            buttonSinavGuncelle.UseVisualStyleBackColor = false;
            buttonSinavGuncelle.Click += buttonSinavGuncelle_Click;
            // 
            // labelTemporarySinavID
            // 
            labelTemporarySinavID.Location = new Point(16, 37);
            labelTemporarySinavID.Name = "labelTemporarySinavID";
            labelTemporarySinavID.Size = new Size(199, 34);
            labelTemporarySinavID.TabIndex = 19;
            labelTemporarySinavID.Text = "Güncelleme yapmak istediğiniz sınavın mevcut ID değerini seçiniz :";
            labelTemporarySinavID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSinavEkle
            // 
            buttonSinavEkle.BackColor = Color.Lavender;
            buttonSinavEkle.Location = new Point(306, 219);
            buttonSinavEkle.Name = "buttonSinavEkle";
            buttonSinavEkle.Size = new Size(87, 38);
            buttonSinavEkle.TabIndex = 15;
            buttonSinavEkle.Text = "Yeni Sınav Ekle";
            buttonSinavEkle.UseVisualStyleBackColor = false;
            buttonSinavEkle.Click += buttonSinavEkle_Click;
            // 
            // labelSinavIsmi
            // 
            labelSinavIsmi.AutoSize = true;
            labelSinavIsmi.Font = new Font("Century", 9F);
            labelSinavIsmi.Location = new Point(16, 124);
            labelSinavIsmi.Name = "labelSinavIsmi";
            labelSinavIsmi.Size = new Size(76, 16);
            labelSinavIsmi.TabIndex = 6;
            labelSinavIsmi.Text = "Sınav İsmi : ";
            // 
            // labelCourseID
            // 
            labelCourseID.AutoSize = true;
            labelCourseID.Font = new Font("Century", 9F);
            labelCourseID.Location = new Point(16, 91);
            labelCourseID.Name = "labelCourseID";
            labelCourseID.Size = new Size(68, 16);
            labelCourseID.TabIndex = 3;
            labelCourseID.Text = "Course ID :";
            // 
            // labelSinavTarihi
            // 
            labelSinavTarihi.AutoSize = true;
            labelSinavTarihi.Font = new Font("Century", 9F);
            labelSinavTarihi.Location = new Point(16, 157);
            labelSinavTarihi.Name = "labelSinavTarihi";
            labelSinavTarihi.Size = new Size(83, 16);
            labelSinavTarihi.TabIndex = 4;
            labelSinavTarihi.Text = "Sınav Tarihi :";
            // 
            // buttonSinavlariGoruntule
            // 
            buttonSinavlariGoruntule.BackColor = Color.Lavender;
            buttonSinavlariGoruntule.Location = new Point(38, 720);
            buttonSinavlariGoruntule.Name = "buttonSinavlariGoruntule";
            buttonSinavlariGoruntule.Size = new Size(108, 38);
            buttonSinavlariGoruntule.TabIndex = 30;
            buttonSinavlariGoruntule.Text = "Sınavları Görüntüle";
            buttonSinavlariGoruntule.UseVisualStyleBackColor = false;
            buttonSinavlariGoruntule.Click += buttonSinavlariGoruntule_Click;
            // 
            // buttonSinavSonucGoruntule
            // 
            buttonSinavSonucGoruntule.BackColor = Color.Lavender;
            buttonSinavSonucGoruntule.Location = new Point(763, 716);
            buttonSinavSonucGoruntule.Name = "buttonSinavSonucGoruntule";
            buttonSinavSonucGoruntule.Size = new Size(115, 42);
            buttonSinavSonucGoruntule.TabIndex = 31;
            buttonSinavSonucGoruntule.Text = "Sınav Sonuçlarını Görüntüle";
            buttonSinavSonucGoruntule.UseVisualStyleBackColor = false;
            buttonSinavSonucGoruntule.Click += buttonSinavSonucGoruntule_Click;
            // 
            // labelSinavCRUD
            // 
            labelSinavCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold);
            labelSinavCRUD.Location = new Point(67, 26);
            labelSinavCRUD.Name = "labelSinavCRUD";
            labelSinavCRUD.Size = new Size(411, 18);
            labelSinavCRUD.TabIndex = 92;
            labelSinavCRUD.Text = "Sınav Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // comboBoxSilinecekSinavID
            // 
            comboBoxSilinecekSinavID.FormattingEnabled = true;
            comboBoxSilinecekSinavID.Location = new Point(288, 370);
            comboBoxSilinecekSinavID.Name = "comboBoxSilinecekSinavID";
            comboBoxSilinecekSinavID.Size = new Size(121, 23);
            comboBoxSilinecekSinavID.TabIndex = 93;
            // 
            // comboBoxSilinecekSinavSonucID
            // 
            comboBoxSilinecekSinavSonucID.FormattingEnabled = true;
            comboBoxSilinecekSinavSonucID.Location = new Point(1066, 370);
            comboBoxSilinecekSinavSonucID.Name = "comboBoxSilinecekSinavSonucID";
            comboBoxSilinecekSinavSonucID.Size = new Size(121, 23);
            comboBoxSilinecekSinavSonucID.TabIndex = 94;
            // 
            // labelSinavSonucCRUD
            // 
            labelSinavSonucCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold);
            labelSinavSonucCRUD.Location = new Point(831, 21);
            labelSinavSonucCRUD.Name = "labelSinavSonucCRUD";
            labelSinavSonucCRUD.Size = new Size(449, 23);
            labelSinavSonucCRUD.TabIndex = 95;
            labelSinavSonucCRUD.Text = "Sınav Sonuç Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // buttonSaveAsWordExamResults
            // 
            buttonSaveAsWordExamResults.BackColor = Color.Lavender;
            buttonSaveAsWordExamResults.Location = new Point(895, 716);
            buttonSaveAsWordExamResults.Name = "buttonSaveAsWordExamResults";
            buttonSaveAsWordExamResults.Size = new Size(114, 42);
            buttonSaveAsWordExamResults.TabIndex = 96;
            buttonSaveAsWordExamResults.Text = "Word dosyası olarak kaydet";
            buttonSaveAsWordExamResults.UseVisualStyleBackColor = false;
            buttonSaveAsWordExamResults.Click += buttonSaveAsWordExamResults_Click;
            // 
            // buttonSaveAsWordExams
            // 
            buttonSaveAsWordExams.BackColor = Color.Lavender;
            buttonSaveAsWordExams.Location = new Point(179, 720);
            buttonSaveAsWordExams.Name = "buttonSaveAsWordExams";
            buttonSaveAsWordExams.Size = new Size(113, 38);
            buttonSaveAsWordExams.TabIndex = 97;
            buttonSaveAsWordExams.Text = "Word dosyası olarak kaydet";
            buttonSaveAsWordExams.UseVisualStyleBackColor = false;
            buttonSaveAsWordExams.Click += buttonSaveAsWordExams_Click;
            // 
            // buttonSaveExcelSinav
            // 
            buttonSaveExcelSinav.BackColor = Color.Lavender;
            buttonSaveExcelSinav.Location = new Point(471, 720);
            buttonSaveExcelSinav.Name = "buttonSaveExcelSinav";
            buttonSaveExcelSinav.Size = new Size(113, 38);
            buttonSaveExcelSinav.TabIndex = 113;
            buttonSaveExcelSinav.Text = "Excel dosyası olarak kaydet";
            buttonSaveExcelSinav.UseVisualStyleBackColor = false;
            buttonSaveExcelSinav.Click += buttonSaveExcelSinav_Click;
            // 
            // buttonVeriAlSinav
            // 
            buttonVeriAlSinav.BackColor = Color.Lavender;
            buttonVeriAlSinav.Location = new Point(322, 720);
            buttonVeriAlSinav.Name = "buttonVeriAlSinav";
            buttonVeriAlSinav.Size = new Size(113, 38);
            buttonVeriAlSinav.TabIndex = 112;
            buttonVeriAlSinav.Text = "Veri Al";
            buttonVeriAlSinav.UseVisualStyleBackColor = false;
            buttonVeriAlSinav.Click += buttonVeriAlSinav_Click;
            // 
            // buttonSaveExcelSinavSonuc
            // 
            buttonSaveExcelSinavSonuc.BackColor = Color.Lavender;
            buttonSaveExcelSinavSonuc.Location = new Point(1189, 718);
            buttonSaveExcelSinavSonuc.Name = "buttonSaveExcelSinavSonuc";
            buttonSaveExcelSinavSonuc.Size = new Size(113, 38);
            buttonSaveExcelSinavSonuc.TabIndex = 115;
            buttonSaveExcelSinavSonuc.Text = "Excel dosyası olarak kaydet";
            buttonSaveExcelSinavSonuc.UseVisualStyleBackColor = false;
            buttonSaveExcelSinavSonuc.Click += buttonSaveExcelSinavSonuc_Click;
            // 
            // buttonVeriAlSinavSonuc
            // 
            buttonVeriAlSinavSonuc.BackColor = Color.Lavender;
            buttonVeriAlSinavSonuc.Location = new Point(1040, 718);
            buttonVeriAlSinavSonuc.Name = "buttonVeriAlSinavSonuc";
            buttonVeriAlSinavSonuc.Size = new Size(113, 38);
            buttonVeriAlSinavSonuc.TabIndex = 114;
            buttonVeriAlSinavSonuc.Text = "Veri Al";
            buttonVeriAlSinavSonuc.UseVisualStyleBackColor = false;
            buttonVeriAlSinavSonuc.Click += buttonVeriAlSinavSonuc_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.Thistle;
            treeView1.Location = new Point(706, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(10, 783);
            treeView1.TabIndex = 116;
            // 
            // FormExamMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1356, 766);
            Controls.Add(treeView1);
            Controls.Add(buttonSaveExcelSinavSonuc);
            Controls.Add(buttonVeriAlSinavSonuc);
            Controls.Add(buttonSaveExcelSinav);
            Controls.Add(buttonVeriAlSinav);
            Controls.Add(buttonSaveAsWordExams);
            Controls.Add(buttonSaveAsWordExamResults);
            Controls.Add(labelSinavSonucCRUD);
            Controls.Add(comboBoxSilinecekSinavSonucID);
            Controls.Add(comboBoxSilinecekSinavID);
            Controls.Add(labelSinavCRUD);
            Controls.Add(buttonSinavSonucGoruntule);
            Controls.Add(buttonSinavlariGoruntule);
            Controls.Add(buttonSinavSonucSil);
            Controls.Add(labelSilinecekSinavSonucID);
            Controls.Add(buttonSinavSil);
            Controls.Add(labelSilinecekSinavID);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormExamMenu";
            Text = "Sınav İşlemleri Menüsü";
            Load += FormExamMenu_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavSonuclari).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavlar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSinavSonucSil;
        private Label labelSilinecekSinavSonucID;
        private Button buttonSinavSil;
        private Label labelSilinecekSinavID;
        private GroupBox groupBox4;
        private DataGridView dataGridViewSinavSonuclari;
        private GroupBox groupBox3;
        private DataGridView dataGridViewSinavlar;
        private GroupBox groupBox2;
        private Label labelTemporarySonucID;
        private Button buttonSinavSonucGuncelle;
        private Button buttonSinavSonucEkle;
        private TextBox textBoxSifre;
        private TextBox textBoxKullanıcıAdı;
        private Label labelSinavSonucCRUD;
        private Label labelExamID;
        private Label labelAlinanPuan;
        private GroupBox groupBox1;
        private Button buttonSinavGuncelle;
        private Label labelTemporarySinavID;
        private CheckBox checkBoxCanUpdate;
        private CheckBox checkBoxCanDelete;
        private CheckBox checkBoxCanInsert;
        private CheckBox checkBoxCanRead;
        private Button buttonSinavEkle;
        private Label labelSinavIsmi;
        private Label labelCanUpdate;
        private Label labelCourseID;
        private Label labelSinavTarihi;
        private ComboBox comboBoxCourseID;
        private TextBox textBoxSinavIsmi;
        private DateTimePicker dateTimePickerSinavTarihi;
        private ComboBox comboBoxStudentID;
        private ComboBox comboBoxSinavIDforSınavSonuc;
        private TextBox textBoxAlinanPuan;
        private Button buttonSinavlariGoruntule;
        private Button buttonSinavSonucGoruntule;
        private Label label2;
        private Label labelOgrenciID;
        private Label labelSinavCRUD;
        private ComboBox comboBoxTemporarySinavID;
        private ComboBox comboBoxTemporarySinavSonucID;
        private ComboBox comboBoxSilinecekSinavID;
        private ComboBox comboBoxSilinecekSinavSonucID;
        private Button buttonSaveAsWordExamResults;
        private Button buttonSaveAsWordExams;
        private Button buttonSaveExcelSinav;
        private Button buttonVeriAlSinav;
        private Button buttonSaveExcelSinavSonuc;
        private Button buttonVeriAlSinavSonuc;
        private ComboBox comboBoxCourseID2;
        private Label label1;
        private TreeView treeView1;
    }
}