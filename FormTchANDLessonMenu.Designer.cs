namespace DershaneYonetimSistemi
{
    partial class FormTchANDLessonMenu
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
            buttonDersleriGoruntule = new Button();
            groupBox5 = new GroupBox();
            dataGridViewDersler = new DataGridView();
            buttonDersSil = new Button();
            labelSilinecekDers = new Label();
            buttonOgretmenSil = new Button();
            labelSilinecekOgretmen = new Label();
            groupBox3 = new GroupBox();
            dataGridViewOgretmenler = new DataGridView();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBoxDersAdi = new ComboBox();
            numericUpDownHaftalikSaati = new NumericUpDown();
            labelDersAdi = new Label();
            comboBoxTemporaryDersID = new ComboBox();
            labelHaftalikSaatBilgisi = new Label();
            labelTemporaryDevamsizlikID = new Label();
            buttonDersGuncelle = new Button();
            buttonDersEkle = new Button();
            groupBox1 = new GroupBox();
            comboBoxOgretmenAlan = new ComboBox();
            comboBoxLessonID = new ComboBox();
            labelDersID = new Label();
            buttonOgretmenGuncelle = new Button();
            comboBoxTemporaryTeacherID = new ComboBox();
            textBoxTeacherID = new TextBox();
            labelTeacherID = new Label();
            labelOgretmenAlan = new Label();
            textBoxOgretmenAdi = new TextBox();
            textBoxOgretmenSoyadi = new TextBox();
            dateTimePickerBaslangicTarihi = new DateTimePicker();
            labelTemporaryTeacherID = new Label();
            buttonOgretmenEkle = new Button();
            labelSoyad = new Label();
            labelFirstName = new Label();
            labelIseAlimTarihi = new Label();
            labelOgretmenCRUD = new Label();
            labelDersCRUD = new Label();
            comboBoxSilinecekOgretmenID = new ComboBox();
            comboBoxSilinecekDersID = new ComboBox();
            buttonOgretmenleriGoruntule = new Button();
            buttonSaveWordTeachers = new Button();
            buttonSaveWordLessons = new Button();
            buttonVeriAlOgretmen = new Button();
            buttonVeriAlDers = new Button();
            buttonSaveExcelOgretmen = new Button();
            buttonSaveExcelDers = new Button();
            treeView1 = new TreeView();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgretmenler).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHaftalikSaati).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDersleriGoruntule
            // 
            buttonDersleriGoruntule.BackColor = Color.Lavender;
            buttonDersleriGoruntule.Location = new Point(868, 784);
            buttonDersleriGoruntule.Name = "buttonDersleriGoruntule";
            buttonDersleriGoruntule.Size = new Size(113, 38);
            buttonDersleriGoruntule.TabIndex = 88;
            buttonDersleriGoruntule.Text = "Dersleri Görüntüle";
            buttonDersleriGoruntule.UseVisualStyleBackColor = false;
            buttonDersleriGoruntule.Click += buttonDersleriGoruntule_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewDersler);
            groupBox5.Location = new Point(865, 506);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(552, 255);
            groupBox5.TabIndex = 82;
            groupBox5.TabStop = false;
            groupBox5.Text = "Ders Listesi";
            // 
            // dataGridViewDersler
            // 
            dataGridViewDersler.AllowUserToAddRows = false;
            dataGridViewDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDersler.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersler.Dock = DockStyle.Fill;
            dataGridViewDersler.Location = new Point(3, 19);
            dataGridViewDersler.Name = "dataGridViewDersler";
            dataGridViewDersler.RowTemplate.Height = 25;
            dataGridViewDersler.Size = new Size(546, 233);
            dataGridViewDersler.TabIndex = 0;
            // 
            // buttonDersSil
            // 
            buttonDersSil.BackColor = Color.SteelBlue;
            buttonDersSil.Location = new Point(1223, 403);
            buttonDersSil.Name = "buttonDersSil";
            buttonDersSil.Size = new Size(87, 38);
            buttonDersSil.TabIndex = 81;
            buttonDersSil.Text = "Ders Sil";
            buttonDersSil.UseVisualStyleBackColor = false;
            buttonDersSil.Click += buttonDersSil_Click;
            // 
            // labelSilinecekDers
            // 
            labelSilinecekDers.Font = new Font("Century", 9F);
            labelSilinecekDers.Location = new Point(891, 405);
            labelSilinecekDers.Name = "labelSilinecekDers";
            labelSilinecekDers.Size = new Size(162, 36);
            labelSilinecekDers.TabIndex = 79;
            labelSilinecekDers.Text = "Silinecek dersin ID değerini seçiniz :";
            // 
            // buttonOgretmenSil
            // 
            buttonOgretmenSil.BackColor = Color.SteelBlue;
            buttonOgretmenSil.Location = new Point(339, 409);
            buttonOgretmenSil.Name = "buttonOgretmenSil";
            buttonOgretmenSil.Size = new Size(87, 38);
            buttonOgretmenSil.TabIndex = 78;
            buttonOgretmenSil.Text = "Öğretmen Sil";
            buttonOgretmenSil.UseVisualStyleBackColor = false;
            buttonOgretmenSil.Click += buttonOgretmenSil_Click;
            // 
            // labelSilinecekOgretmen
            // 
            labelSilinecekOgretmen.Font = new Font("Century", 9F);
            labelSilinecekOgretmen.Location = new Point(51, 408);
            labelSilinecekOgretmen.Name = "labelSilinecekOgretmen";
            labelSilinecekOgretmen.Size = new Size(149, 39);
            labelSilinecekOgretmen.TabIndex = 76;
            labelSilinecekOgretmen.Text = "Silinecek Öğretmenin numarasını seçiniz :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOgretmenler);
            groupBox3.Location = new Point(32, 506);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(611, 255);
            groupBox3.TabIndex = 75;
            groupBox3.TabStop = false;
            groupBox3.Text = "Öğretmen Listesi";
            // 
            // dataGridViewOgretmenler
            // 
            dataGridViewOgretmenler.AllowUserToAddRows = false;
            dataGridViewOgretmenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOgretmenler.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewOgretmenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgretmenler.Dock = DockStyle.Fill;
            dataGridViewOgretmenler.Location = new Point(3, 19);
            dataGridViewOgretmenler.Name = "dataGridViewOgretmenler";
            dataGridViewOgretmenler.RowTemplate.Height = 25;
            dataGridViewOgretmenler.Size = new Size(605, 233);
            dataGridViewOgretmenler.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBoxDersAdi);
            groupBox2.Controls.Add(numericUpDownHaftalikSaati);
            groupBox2.Controls.Add(labelDersAdi);
            groupBox2.Controls.Add(comboBoxTemporaryDersID);
            groupBox2.Controls.Add(labelHaftalikSaatBilgisi);
            groupBox2.Controls.Add(labelTemporaryDevamsizlikID);
            groupBox2.Controls.Add(buttonDersGuncelle);
            groupBox2.Controls.Add(buttonDersEkle);
            groupBox2.Location = new Point(891, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 303);
            groupBox2.TabIndex = 74;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century", 6.75F);
            label1.Location = new Point(6, 117);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 96;
            label1.Text = "(Var olan ders eklenemez!)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDersAdi
            // 
            comboBoxDersAdi.FormattingEnabled = true;
            comboBoxDersAdi.Location = new Point(134, 99);
            comboBoxDersAdi.Name = "comboBoxDersAdi";
            comboBoxDersAdi.Size = new Size(121, 23);
            comboBoxDersAdi.TabIndex = 76;
            // 
            // numericUpDownHaftalikSaati
            // 
            numericUpDownHaftalikSaati.Location = new Point(135, 143);
            numericUpDownHaftalikSaati.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownHaftalikSaati.Name = "numericUpDownHaftalikSaati";
            numericUpDownHaftalikSaati.Size = new Size(120, 23);
            numericUpDownHaftalikSaati.TabIndex = 74;
            // 
            // labelDersAdi
            // 
            labelDersAdi.AutoSize = true;
            labelDersAdi.Font = new Font("Century", 9F);
            labelDersAdi.Location = new Point(17, 101);
            labelDersAdi.Name = "labelDersAdi";
            labelDersAdi.Size = new Size(62, 16);
            labelDersAdi.TabIndex = 72;
            labelDersAdi.Text = "Ders Adı :";
            // 
            // comboBoxTemporaryDersID
            // 
            comboBoxTemporaryDersID.FormattingEnabled = true;
            comboBoxTemporaryDersID.Location = new Point(212, 35);
            comboBoxTemporaryDersID.Name = "comboBoxTemporaryDersID";
            comboBoxTemporaryDersID.Size = new Size(121, 23);
            comboBoxTemporaryDersID.TabIndex = 71;
            // 
            // labelHaftalikSaatBilgisi
            // 
            labelHaftalikSaatBilgisi.AutoSize = true;
            labelHaftalikSaatBilgisi.Font = new Font("Century", 9F);
            labelHaftalikSaatBilgisi.Location = new Point(17, 146);
            labelHaftalikSaatBilgisi.Name = "labelHaftalikSaatBilgisi";
            labelHaftalikSaatBilgisi.Size = new Size(95, 16);
            labelHaftalikSaatBilgisi.TabIndex = 36;
            labelHaftalikSaatBilgisi.Text = "Haftalık Saati :";
            // 
            // labelTemporaryDevamsizlikID
            // 
            labelTemporaryDevamsizlikID.Font = new Font("Century", 9F);
            labelTemporaryDevamsizlikID.Location = new Point(17, 11);
            labelTemporaryDevamsizlikID.Name = "labelTemporaryDevamsizlikID";
            labelTemporaryDevamsizlikID.Size = new Size(189, 80);
            labelTemporaryDevamsizlikID.TabIndex = 33;
            labelTemporaryDevamsizlikID.Text = "Bu alana sadece güncelleme yapacağınız zaman, güncelleyeceğiniz dersin mevcut ID değerini seçiniz :";
            labelTemporaryDevamsizlikID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonDersGuncelle
            // 
            buttonDersGuncelle.BackColor = Color.Lavender;
            buttonDersGuncelle.Location = new Point(67, 232);
            buttonDersGuncelle.Name = "buttonDersGuncelle";
            buttonDersGuncelle.Size = new Size(107, 41);
            buttonDersGuncelle.TabIndex = 17;
            buttonDersGuncelle.Text = "Ders Güncelle";
            buttonDersGuncelle.UseVisualStyleBackColor = false;
            buttonDersGuncelle.Click += buttonDersGuncelle_Click;
            // 
            // buttonDersEkle
            // 
            buttonDersEkle.BackColor = Color.Lavender;
            buttonDersEkle.Location = new Point(201, 232);
            buttonDersEkle.Name = "buttonDersEkle";
            buttonDersEkle.Size = new Size(108, 41);
            buttonDersEkle.TabIndex = 16;
            buttonDersEkle.Text = "Yeni Ders Ekle";
            buttonDersEkle.UseVisualStyleBackColor = false;
            buttonDersEkle.Click += buttonDersEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxOgretmenAlan);
            groupBox1.Controls.Add(comboBoxLessonID);
            groupBox1.Controls.Add(labelDersID);
            groupBox1.Controls.Add(buttonOgretmenGuncelle);
            groupBox1.Controls.Add(comboBoxTemporaryTeacherID);
            groupBox1.Controls.Add(textBoxTeacherID);
            groupBox1.Controls.Add(labelTeacherID);
            groupBox1.Controls.Add(labelOgretmenAlan);
            groupBox1.Controls.Add(textBoxOgretmenAdi);
            groupBox1.Controls.Add(textBoxOgretmenSoyadi);
            groupBox1.Controls.Add(dateTimePickerBaslangicTarihi);
            groupBox1.Controls.Add(labelTemporaryTeacherID);
            groupBox1.Controls.Add(buttonOgretmenEkle);
            groupBox1.Controls.Add(labelSoyad);
            groupBox1.Controls.Add(labelFirstName);
            groupBox1.Controls.Add(labelIseAlimTarihi);
            groupBox1.Location = new Point(44, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 354);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            // 
            // comboBoxOgretmenAlan
            // 
            comboBoxOgretmenAlan.FormattingEnabled = true;
            comboBoxOgretmenAlan.Location = new Point(133, 273);
            comboBoxOgretmenAlan.Name = "comboBoxOgretmenAlan";
            comboBoxOgretmenAlan.Size = new Size(121, 23);
            comboBoxOgretmenAlan.TabIndex = 75;
            // 
            // comboBoxLessonID
            // 
            comboBoxLessonID.FormattingEnabled = true;
            comboBoxLessonID.Location = new Point(134, 142);
            comboBoxLessonID.Name = "comboBoxLessonID";
            comboBoxLessonID.Size = new Size(121, 23);
            comboBoxLessonID.TabIndex = 74;
            // 
            // labelDersID
            // 
            labelDersID.AutoSize = true;
            labelDersID.Font = new Font("Century", 9F);
            labelDersID.Location = new Point(16, 143);
            labelDersID.Name = "labelDersID";
            labelDersID.Size = new Size(55, 16);
            labelDersID.TabIndex = 73;
            labelDersID.Text = "Ders ID :";
            // 
            // buttonOgretmenGuncelle
            // 
            buttonOgretmenGuncelle.BackColor = Color.Lavender;
            buttonOgretmenGuncelle.Location = new Point(174, 307);
            buttonOgretmenGuncelle.Name = "buttonOgretmenGuncelle";
            buttonOgretmenGuncelle.Size = new Size(99, 38);
            buttonOgretmenGuncelle.TabIndex = 72;
            buttonOgretmenGuncelle.Text = "Öğretmen Güncelle";
            buttonOgretmenGuncelle.UseVisualStyleBackColor = false;
            buttonOgretmenGuncelle.Click += buttonOgretmenGuncelle_Click;
            // 
            // comboBoxTemporaryTeacherID
            // 
            comboBoxTemporaryTeacherID.FormattingEnabled = true;
            comboBoxTemporaryTeacherID.Location = new Point(198, 51);
            comboBoxTemporaryTeacherID.Name = "comboBoxTemporaryTeacherID";
            comboBoxTemporaryTeacherID.Size = new Size(121, 23);
            comboBoxTemporaryTeacherID.TabIndex = 70;
            // 
            // textBoxTeacherID
            // 
            textBoxTeacherID.Location = new Point(133, 110);
            textBoxTeacherID.Name = "textBoxTeacherID";
            textBoxTeacherID.Size = new Size(118, 23);
            textBoxTeacherID.TabIndex = 71;
            // 
            // labelTeacherID
            // 
            labelTeacherID.AutoSize = true;
            labelTeacherID.Font = new Font("Century", 9F);
            labelTeacherID.Location = new Point(13, 113);
            labelTeacherID.Name = "labelTeacherID";
            labelTeacherID.Size = new Size(84, 16);
            labelTeacherID.TabIndex = 70;
            labelTeacherID.Text = "Öğretmen ID :";
            // 
            // labelOgretmenAlan
            // 
            labelOgretmenAlan.AutoSize = true;
            labelOgretmenAlan.Font = new Font("Century", 9F);
            labelOgretmenAlan.Location = new Point(19, 275);
            labelOgretmenAlan.Name = "labelOgretmenAlan";
            labelOgretmenAlan.Size = new Size(98, 16);
            labelOgretmenAlan.TabIndex = 66;
            labelOgretmenAlan.Text = "Öğretmen Alan :";
            // 
            // textBoxOgretmenAdi
            // 
            textBoxOgretmenAdi.Location = new Point(137, 171);
            textBoxOgretmenAdi.Name = "textBoxOgretmenAdi";
            textBoxOgretmenAdi.Size = new Size(118, 23);
            textBoxOgretmenAdi.TabIndex = 26;
            // 
            // textBoxOgretmenSoyadi
            // 
            textBoxOgretmenSoyadi.Location = new Point(137, 202);
            textBoxOgretmenSoyadi.Name = "textBoxOgretmenSoyadi";
            textBoxOgretmenSoyadi.Size = new Size(118, 23);
            textBoxOgretmenSoyadi.TabIndex = 23;
            // 
            // dateTimePickerBaslangicTarihi
            // 
            dateTimePickerBaslangicTarihi.Location = new Point(118, 237);
            dateTimePickerBaslangicTarihi.Name = "dateTimePickerBaslangicTarihi";
            dateTimePickerBaslangicTarihi.Size = new Size(191, 23);
            dateTimePickerBaslangicTarihi.TabIndex = 22;
            // 
            // labelTemporaryTeacherID
            // 
            labelTemporaryTeacherID.Font = new Font("Century", 9F);
            labelTemporaryTeacherID.Location = new Point(15, 19);
            labelTemporaryTeacherID.Name = "labelTemporaryTeacherID";
            labelTemporaryTeacherID.Size = new Size(187, 84);
            labelTemporaryTeacherID.TabIndex = 19;
            labelTemporaryTeacherID.Text = "Bu alana sadece güncelleme yapacağınız zaman, güncellecemek istediğiniz öğretmenin mevcut numarasını seçiniz :";
            labelTemporaryTeacherID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonOgretmenEkle
            // 
            buttonOgretmenEkle.BackColor = Color.Lavender;
            buttonOgretmenEkle.Location = new Point(305, 307);
            buttonOgretmenEkle.Name = "buttonOgretmenEkle";
            buttonOgretmenEkle.Size = new Size(99, 38);
            buttonOgretmenEkle.TabIndex = 15;
            buttonOgretmenEkle.Text = "Yeni Öğretmen Ekle";
            buttonOgretmenEkle.UseVisualStyleBackColor = false;
            buttonOgretmenEkle.Click += buttonOgretmenEkle_Click;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Font = new Font("Century", 9F);
            labelSoyad.Location = new Point(15, 206);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(116, 16);
            labelSoyad.TabIndex = 6;
            labelSoyad.Text = "Öğretmen Soyismi :";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Century", 9F);
            labelFirstName.Location = new Point(15, 173);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(91, 16);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "Öğretmen Adı :";
            // 
            // labelIseAlimTarihi
            // 
            labelIseAlimTarihi.AutoSize = true;
            labelIseAlimTarihi.Font = new Font("Century", 9F);
            labelIseAlimTarihi.Location = new Point(18, 242);
            labelIseAlimTarihi.Name = "labelIseAlimTarihi";
            labelIseAlimTarihi.Size = new Size(98, 16);
            labelIseAlimTarihi.TabIndex = 4;
            labelIseAlimTarihi.Text = "İşe Alım Tarihi :";
            // 
            // labelOgretmenCRUD
            // 
            labelOgretmenCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold);
            labelOgretmenCRUD.Location = new Point(56, 6);
            labelOgretmenCRUD.Name = "labelOgretmenCRUD";
            labelOgretmenCRUD.Size = new Size(411, 18);
            labelOgretmenCRUD.TabIndex = 91;
            labelOgretmenCRUD.Text = "Öğretmen Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // labelDersCRUD
            // 
            labelDersCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold);
            labelDersCRUD.Location = new Point(899, 9);
            labelDersCRUD.Name = "labelDersCRUD";
            labelDersCRUD.Size = new Size(411, 18);
            labelDersCRUD.TabIndex = 92;
            labelDersCRUD.Text = "Ders Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // comboBoxSilinecekOgretmenID
            // 
            comboBoxSilinecekOgretmenID.FormattingEnabled = true;
            comboBoxSilinecekOgretmenID.Location = new Point(196, 418);
            comboBoxSilinecekOgretmenID.Name = "comboBoxSilinecekOgretmenID";
            comboBoxSilinecekOgretmenID.Size = new Size(121, 23);
            comboBoxSilinecekOgretmenID.TabIndex = 93;
            // 
            // comboBoxSilinecekDersID
            // 
            comboBoxSilinecekDersID.FormattingEnabled = true;
            comboBoxSilinecekDersID.Location = new Point(1059, 412);
            comboBoxSilinecekDersID.Name = "comboBoxSilinecekDersID";
            comboBoxSilinecekDersID.Size = new Size(121, 23);
            comboBoxSilinecekDersID.TabIndex = 94;
            // 
            // buttonOgretmenleriGoruntule
            // 
            buttonOgretmenleriGoruntule.BackColor = Color.Lavender;
            buttonOgretmenleriGoruntule.Location = new Point(44, 784);
            buttonOgretmenleriGoruntule.Name = "buttonOgretmenleriGoruntule";
            buttonOgretmenleriGoruntule.Size = new Size(113, 38);
            buttonOgretmenleriGoruntule.TabIndex = 95;
            buttonOgretmenleriGoruntule.Text = "Öğretmenleri Görüntüle";
            buttonOgretmenleriGoruntule.UseVisualStyleBackColor = false;
            buttonOgretmenleriGoruntule.Click += buttonOgretmenleriGoruntule_Click;
            // 
            // buttonSaveWordTeachers
            // 
            buttonSaveWordTeachers.BackColor = Color.Lavender;
            buttonSaveWordTeachers.Location = new Point(186, 784);
            buttonSaveWordTeachers.Name = "buttonSaveWordTeachers";
            buttonSaveWordTeachers.Size = new Size(113, 38);
            buttonSaveWordTeachers.TabIndex = 107;
            buttonSaveWordTeachers.Text = "Word dosyası olarak kaydet";
            buttonSaveWordTeachers.UseVisualStyleBackColor = false;
            buttonSaveWordTeachers.Click += buttonSaveWordTeachers_Click;
            // 
            // buttonSaveWordLessons
            // 
            buttonSaveWordLessons.BackColor = Color.Lavender;
            buttonSaveWordLessons.Location = new Point(1009, 784);
            buttonSaveWordLessons.Name = "buttonSaveWordLessons";
            buttonSaveWordLessons.Size = new Size(113, 38);
            buttonSaveWordLessons.TabIndex = 108;
            buttonSaveWordLessons.Text = "Word dosyası olarak kaydet";
            buttonSaveWordLessons.UseVisualStyleBackColor = false;
            buttonSaveWordLessons.Click += buttonSaveWordLessons_Click;
            // 
            // buttonVeriAlOgretmen
            // 
            buttonVeriAlOgretmen.BackColor = Color.Lavender;
            buttonVeriAlOgretmen.Location = new Point(339, 784);
            buttonVeriAlOgretmen.Name = "buttonVeriAlOgretmen";
            buttonVeriAlOgretmen.Size = new Size(113, 38);
            buttonVeriAlOgretmen.TabIndex = 109;
            buttonVeriAlOgretmen.Text = "Veri Al";
            buttonVeriAlOgretmen.UseVisualStyleBackColor = false;
            buttonVeriAlOgretmen.Click += buttonVeriAlOgretmen_Click;
            // 
            // buttonVeriAlDers
            // 
            buttonVeriAlDers.BackColor = Color.Lavender;
            buttonVeriAlDers.Location = new Point(1150, 784);
            buttonVeriAlDers.Name = "buttonVeriAlDers";
            buttonVeriAlDers.Size = new Size(113, 38);
            buttonVeriAlDers.TabIndex = 110;
            buttonVeriAlDers.Text = "Veri Al";
            buttonVeriAlDers.UseVisualStyleBackColor = false;
            buttonVeriAlDers.Click += buttonVeriAlDers_Click;
            // 
            // buttonSaveExcelOgretmen
            // 
            buttonSaveExcelOgretmen.BackColor = Color.Lavender;
            buttonSaveExcelOgretmen.Location = new Point(488, 784);
            buttonSaveExcelOgretmen.Name = "buttonSaveExcelOgretmen";
            buttonSaveExcelOgretmen.Size = new Size(113, 38);
            buttonSaveExcelOgretmen.TabIndex = 111;
            buttonSaveExcelOgretmen.Text = "Excel dosyası olarak kaydet";
            buttonSaveExcelOgretmen.UseVisualStyleBackColor = false;
            buttonSaveExcelOgretmen.Click += buttonSaveExcelOgretmen_Click;
            // 
            // buttonSaveExcelDers
            // 
            buttonSaveExcelDers.BackColor = Color.Lavender;
            buttonSaveExcelDers.Location = new Point(1301, 784);
            buttonSaveExcelDers.Name = "buttonSaveExcelDers";
            buttonSaveExcelDers.Size = new Size(113, 38);
            buttonSaveExcelDers.TabIndex = 112;
            buttonSaveExcelDers.Text = "Excel dosyası olarak kaydet";
            buttonSaveExcelDers.UseVisualStyleBackColor = false;
            buttonSaveExcelDers.Click += buttonSaveExcelDers_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.Thistle;
            treeView1.Location = new Point(749, 1);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(10, 941);
            treeView1.TabIndex = 113;
            // 
            // FormTchANDLessonMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1609, 926);
            Controls.Add(treeView1);
            Controls.Add(buttonSaveExcelDers);
            Controls.Add(buttonSaveExcelOgretmen);
            Controls.Add(buttonVeriAlDers);
            Controls.Add(buttonVeriAlOgretmen);
            Controls.Add(buttonSaveWordLessons);
            Controls.Add(buttonSaveWordTeachers);
            Controls.Add(buttonOgretmenleriGoruntule);
            Controls.Add(comboBoxSilinecekDersID);
            Controls.Add(comboBoxSilinecekOgretmenID);
            Controls.Add(labelDersCRUD);
            Controls.Add(labelOgretmenCRUD);
            Controls.Add(buttonDersleriGoruntule);
            Controls.Add(groupBox5);
            Controls.Add(buttonDersSil);
            Controls.Add(labelSilinecekDers);
            Controls.Add(buttonOgretmenSil);
            Controls.Add(labelSilinecekOgretmen);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormTchANDLessonMenu";
            Text = "Öğretmen ve Ders İşlemleri Menüsü";
            Load += FormTchANDLessonMenu_Load;
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgretmenler).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHaftalikSaati).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDersleriGoruntule;
        private Button buttonOgrenciDersGuncelle;
        private DateTimePicker dateTimePickerIseAlimTarihi;
        private Label labelDersID;
        private ComboBox comboBoxDersID;
        private Button buttonOgrenciDersEkle;
        private GroupBox groupBox5;
        private DataGridView dataGridViewDersler;
        private Button buttonDersSil;
        private Label labelSilinecekDers;
        private Button buttonOgretmenSil;
        private Label labelSilinecekOgretmen;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOgretmenler;
        private GroupBox groupBox2;
        private ComboBox comboBoxTemporaryDersID;
        private Label labelHaftalikSaatBilgisi;
        private Label labelTemporaryDevamsizlikID;
        private Button buttonDersGuncelle;
        private Button buttonDersEkle;
        private GroupBox groupBox1;
        private ComboBox comboBoxTemporaryTeacherID;
        private TextBox textBoxTeacherID;
        private Label labelTeacherID;
        private RichTextBox richTextBoxOgrenciAdres;
        private Label labelOgrenciAdres;
        private Label labelOgretmenAlan;
        private TextBox textBoxOgretmenAdi;
        private TextBox textBoxOgretmenSoyadi;
        private DateTimePicker dateTimePickerBaslangicTarihi;
        private Button buttonOgrenciGuncelle;
        private Label labelTemporaryTeacherID;
        private Button buttonOgretmenEkle;
        private Label labelSoyad;
        private Label labelFirstName;
        private Label labelIseAlimTarihi;
        private Label labelOgretmenCRUD;
        private Label labelDersCRUD;
        private ComboBox comboBoxSilinecekOgretmenID;
        private Label labelDersAdi;
        private NumericUpDown numericUpDownHaftalikSaati;
        private ComboBox comboBoxSilinecekDersID;
        private Button buttonOgretmenleriGoruntule;
        private Button buttonOgretmenGuncelle;
        private ComboBox comboBoxLessonID;
        private ComboBox comboBoxOgretmenAlan;
        private ComboBox comboBoxDersAdi;
        private Label label1;
        private Button buttonSaveWordTeachers;
        private Button buttonSaveWordLessons;
        private Button buttonVeriAlOgretmen;
        private Button buttonVeriAlDers;
        private Button buttonSaveExcelOgretmen;
        private Button buttonSaveExcelDers;
        private TreeView treeView1;
    }
}