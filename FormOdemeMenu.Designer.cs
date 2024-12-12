namespace DershaneYonetimSistemi
{
    partial class FormOdemeMenu
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
            comboBoxSilinecekOdemeID = new ComboBox();
            buttonOdemeSil = new Button();
            labelOdemeCRUD = new Label();
            label3 = new Label();
            groupBox6 = new GroupBox();
            comboBoxOdemeTuru = new ComboBox();
            buttonOdemeEkle = new Button();
            buttonOdemeGuncelle = new Button();
            dateTimePickerOdemeTarihi = new DateTimePicker();
            numericUpDownOdemeMiktari = new NumericUpDown();
            labelOdemeTuru = new Label();
            labelAmount = new Label();
            comboBoxTemporaryPaymentD = new ComboBox();
            labelTemporaryOgrenciDersID = new Label();
            comboBoxOgrenciNo = new ComboBox();
            labelOgrenciID = new Label();
            labelOdemeTarihi = new Label();
            buttonOdemeleriGoruntule = new Button();
            groupBox4 = new GroupBox();
            dataGridViewOdemeler = new DataGridView();
            buttonSaveWord = new Button();
            buttonVeriAl = new Button();
            buttonSaveExcelOdemeler = new Button();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOdemeMiktari).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdemeler).BeginInit();
            SuspendLayout();
            // 
            // comboBoxSilinecekOdemeID
            // 
            comboBoxSilinecekOdemeID.FormattingEnabled = true;
            comboBoxSilinecekOdemeID.Location = new Point(196, 397);
            comboBoxSilinecekOdemeID.Name = "comboBoxSilinecekOdemeID";
            comboBoxSilinecekOdemeID.Size = new Size(121, 23);
            comboBoxSilinecekOdemeID.TabIndex = 103;
            // 
            // buttonOdemeSil
            // 
            buttonOdemeSil.BackColor = Color.SteelBlue;
            buttonOdemeSil.Location = new Point(336, 388);
            buttonOdemeSil.Name = "buttonOdemeSil";
            buttonOdemeSil.Size = new Size(87, 38);
            buttonOdemeSil.TabIndex = 102;
            buttonOdemeSil.Text = "Ödeme Sil";
            buttonOdemeSil.UseVisualStyleBackColor = false;
            buttonOdemeSil.Click += buttonOdemeSil_Click;
            // 
            // labelOdemeCRUD
            // 
            labelOdemeCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold);
            labelOdemeCRUD.Location = new Point(12, 26);
            labelOdemeCRUD.Name = "labelOdemeCRUD";
            labelOdemeCRUD.Size = new Size(446, 18);
            labelOdemeCRUD.TabIndex = 97;
            labelOdemeCRUD.Text = "Ödeme Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // label3
            // 
            label3.Font = new Font("Century", 9F);
            label3.Location = new Point(19, 388);
            label3.Name = "label3";
            label3.Size = new Size(161, 36);
            label3.TabIndex = 101;
            label3.Text = "Silinecek ödemenin ID değerini seçiniz :";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(comboBoxOdemeTuru);
            groupBox6.Controls.Add(buttonOdemeEkle);
            groupBox6.Controls.Add(buttonOdemeGuncelle);
            groupBox6.Controls.Add(dateTimePickerOdemeTarihi);
            groupBox6.Controls.Add(numericUpDownOdemeMiktari);
            groupBox6.Controls.Add(labelOdemeTuru);
            groupBox6.Controls.Add(labelAmount);
            groupBox6.Controls.Add(comboBoxTemporaryPaymentD);
            groupBox6.Controls.Add(labelTemporaryOgrenciDersID);
            groupBox6.Controls.Add(comboBoxOgrenciNo);
            groupBox6.Controls.Add(labelOgrenciID);
            groupBox6.Controls.Add(labelOdemeTarihi);
            groupBox6.Location = new Point(12, 47);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(449, 325);
            groupBox6.TabIndex = 100;
            groupBox6.TabStop = false;
            // 
            // comboBoxOdemeTuru
            // 
            comboBoxOdemeTuru.FormattingEnabled = true;
            comboBoxOdemeTuru.Location = new Point(104, 199);
            comboBoxOdemeTuru.Name = "comboBoxOdemeTuru";
            comboBoxOdemeTuru.Size = new Size(121, 23);
            comboBoxOdemeTuru.TabIndex = 99;
            // 
            // buttonOdemeEkle
            // 
            buttonOdemeEkle.BackColor = Color.Lavender;
            buttonOdemeEkle.Location = new Point(305, 266);
            buttonOdemeEkle.Name = "buttonOdemeEkle";
            buttonOdemeEkle.Size = new Size(99, 38);
            buttonOdemeEkle.TabIndex = 97;
            buttonOdemeEkle.Text = "Yeni Ödeme Ekle";
            buttonOdemeEkle.UseVisualStyleBackColor = false;
            buttonOdemeEkle.Click += buttonOdemeEkle_Click;
            // 
            // buttonOdemeGuncelle
            // 
            buttonOdemeGuncelle.BackColor = Color.Lavender;
            buttonOdemeGuncelle.Location = new Point(186, 266);
            buttonOdemeGuncelle.Name = "buttonOdemeGuncelle";
            buttonOdemeGuncelle.Size = new Size(99, 38);
            buttonOdemeGuncelle.TabIndex = 98;
            buttonOdemeGuncelle.Text = "Ödeme Güncelle";
            buttonOdemeGuncelle.UseVisualStyleBackColor = false;
            buttonOdemeGuncelle.Click += buttonOdemeGuncelle_Click;
            // 
            // dateTimePickerOdemeTarihi
            // 
            dateTimePickerOdemeTarihi.Location = new Point(158, 130);
            dateTimePickerOdemeTarihi.Name = "dateTimePickerOdemeTarihi";
            dateTimePickerOdemeTarihi.Size = new Size(191, 23);
            dateTimePickerOdemeTarihi.TabIndex = 80;
            // 
            // numericUpDownOdemeMiktari
            // 
            numericUpDownOdemeMiktari.Location = new Point(174, 166);
            numericUpDownOdemeMiktari.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownOdemeMiktari.Name = "numericUpDownOdemeMiktari";
            numericUpDownOdemeMiktari.Size = new Size(120, 23);
            numericUpDownOdemeMiktari.TabIndex = 79;
            // 
            // labelOdemeTuru
            // 
            labelOdemeTuru.AutoSize = true;
            labelOdemeTuru.Font = new Font("Century", 9F);
            labelOdemeTuru.Location = new Point(15, 201);
            labelOdemeTuru.Name = "labelOdemeTuru";
            labelOdemeTuru.Size = new Size(82, 16);
            labelOdemeTuru.TabIndex = 77;
            labelOdemeTuru.Text = "Ödeme Türü :";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Century", 9F);
            labelAmount.Location = new Point(15, 167);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(146, 16);
            labelAmount.TabIndex = 75;
            labelAmount.Text = "Yapılan Ödeme Miktarı :";
            // 
            // comboBoxTemporaryPaymentD
            // 
            comboBoxTemporaryPaymentD.FormattingEnabled = true;
            comboBoxTemporaryPaymentD.Location = new Point(195, 39);
            comboBoxTemporaryPaymentD.Name = "comboBoxTemporaryPaymentD";
            comboBoxTemporaryPaymentD.Size = new Size(121, 23);
            comboBoxTemporaryPaymentD.TabIndex = 72;
            // 
            // labelTemporaryOgrenciDersID
            // 
            labelTemporaryOgrenciDersID.Font = new Font("Century", 9F);
            labelTemporaryOgrenciDersID.Location = new Point(10, 19);
            labelTemporaryOgrenciDersID.Name = "labelTemporaryOgrenciDersID";
            labelTemporaryOgrenciDersID.Size = new Size(168, 67);
            labelTemporaryOgrenciDersID.TabIndex = 71;
            labelTemporaryOgrenciDersID.Text = "Bu alana sadece güncelleme yapacağınız zaman, güncelleyeceğiniz ödemenin mevcut ID değerini seçiniz :";
            labelTemporaryOgrenciDersID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxOgrenciNo
            // 
            comboBoxOgrenciNo.FormattingEnabled = true;
            comboBoxOgrenciNo.Location = new Point(104, 98);
            comboBoxOgrenciNo.Name = "comboBoxOgrenciNo";
            comboBoxOgrenciNo.Size = new Size(121, 23);
            comboBoxOgrenciNo.TabIndex = 26;
            // 
            // labelOgrenciID
            // 
            labelOgrenciID.AutoSize = true;
            labelOgrenciID.Font = new Font("Century", 9F);
            labelOgrenciID.Location = new Point(11, 100);
            labelOgrenciID.Name = "labelOgrenciID";
            labelOgrenciID.Size = new Size(74, 16);
            labelOgrenciID.TabIndex = 8;
            labelOgrenciID.Text = "Öğrenci No :";
            // 
            // labelOdemeTarihi
            // 
            labelOdemeTarihi.AutoSize = true;
            labelOdemeTarihi.Font = new Font("Century", 9F);
            labelOdemeTarihi.Location = new Point(11, 135);
            labelOdemeTarihi.Name = "labelOdemeTarihi";
            labelOdemeTarihi.Size = new Size(141, 16);
            labelOdemeTarihi.TabIndex = 2;
            labelOdemeTarihi.Text = "Ödeme Yapılma Tarihi :";
            // 
            // buttonOdemeleriGoruntule
            // 
            buttonOdemeleriGoruntule.BackColor = Color.Lavender;
            buttonOdemeleriGoruntule.Location = new Point(483, 321);
            buttonOdemeleriGoruntule.Name = "buttonOdemeleriGoruntule";
            buttonOdemeleriGoruntule.Size = new Size(113, 38);
            buttonOdemeleriGoruntule.TabIndex = 99;
            buttonOdemeleriGoruntule.Text = "Ödemeleri Görüntüle";
            buttonOdemeleriGoruntule.UseVisualStyleBackColor = false;
            buttonOdemeleriGoruntule.Click += buttonOdemeleriGoruntule_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewOdemeler);
            groupBox4.Location = new Point(483, 47);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(505, 268);
            groupBox4.TabIndex = 98;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ödeme Listesi";
            // 
            // dataGridViewOdemeler
            // 
            dataGridViewOdemeler.AllowUserToAddRows = false;
            dataGridViewOdemeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOdemeler.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewOdemeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOdemeler.Dock = DockStyle.Fill;
            dataGridViewOdemeler.Location = new Point(3, 19);
            dataGridViewOdemeler.Name = "dataGridViewOdemeler";
            dataGridViewOdemeler.RowTemplate.Height = 25;
            dataGridViewOdemeler.Size = new Size(499, 246);
            dataGridViewOdemeler.TabIndex = 0;
            // 
            // buttonSaveWord
            // 
            buttonSaveWord.BackColor = Color.Lavender;
            buttonSaveWord.Location = new Point(621, 321);
            buttonSaveWord.Name = "buttonSaveWord";
            buttonSaveWord.Size = new Size(113, 38);
            buttonSaveWord.TabIndex = 104;
            buttonSaveWord.Text = "Word dosyası olarak kaydet";
            buttonSaveWord.UseVisualStyleBackColor = false;
            buttonSaveWord.Click += buttonSavePdf_Click;
            // 
            // buttonVeriAl
            // 
            buttonVeriAl.BackColor = Color.Lavender;
            buttonVeriAl.Location = new Point(756, 321);
            buttonVeriAl.Name = "buttonVeriAl";
            buttonVeriAl.Size = new Size(113, 38);
            buttonVeriAl.TabIndex = 105;
            buttonVeriAl.Text = "Veri al";
            buttonVeriAl.UseVisualStyleBackColor = false;
            buttonVeriAl.Click += buttonVeriAl_Click;
            // 
            // buttonSaveExcelOdemeler
            // 
            buttonSaveExcelOdemeler.BackColor = Color.Lavender;
            buttonSaveExcelOdemeler.Location = new Point(884, 321);
            buttonSaveExcelOdemeler.Name = "buttonSaveExcelOdemeler";
            buttonSaveExcelOdemeler.Size = new Size(113, 38);
            buttonSaveExcelOdemeler.TabIndex = 106;
            buttonSaveExcelOdemeler.Text = "Excel dosyası olarak kaydet";
            buttonSaveExcelOdemeler.UseVisualStyleBackColor = false;
            buttonSaveExcelOdemeler.Click += buttonSaveExcelOdemeler_Click;
            // 
            // FormOdemeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1000, 568);
            Controls.Add(buttonSaveExcelOdemeler);
            Controls.Add(buttonVeriAl);
            Controls.Add(buttonSaveWord);
            Controls.Add(comboBoxSilinecekOdemeID);
            Controls.Add(buttonOdemeSil);
            Controls.Add(labelOdemeCRUD);
            Controls.Add(label3);
            Controls.Add(groupBox6);
            Controls.Add(buttonOdemeleriGoruntule);
            Controls.Add(groupBox4);
            Name = "FormOdemeMenu";
            Text = "FormOdemeMenu";
            Load += FormOdemeMenu_Load;
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOdemeMiktari).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdemeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxSilinecekOdemeID;
        private Button buttonOdemeSil;
        private Label labelOdemeCRUD;
        private Label label3;
        private GroupBox groupBox6;
        private Button buttonOdemeEkle;
        private Button buttonOdemeGuncelle;
        private DateTimePicker dateTimePickerOdemeTarihi;
        private NumericUpDown numericUpDownOdemeMiktari;
        private Label labelOdemeTuru;
        private Label labelAmount;
        private ComboBox comboBoxTemporaryPaymentD;
        private Label labelTemporaryOgrenciDersID;
        private ComboBox comboBoxOgrenciNo;
        private Label labelOgrenciID;
        private Label labelOdemeTarihi;
        private Button buttonOdemeleriGoruntule;
        private GroupBox groupBox4;
        private DataGridView dataGridViewOdemeler;
        private ComboBox comboBoxOdemeTuru;
        private Button buttonSaveWord;
        private Button buttonVeriAl;
        private Button buttonSaveExcelOdemeler;
    }
}