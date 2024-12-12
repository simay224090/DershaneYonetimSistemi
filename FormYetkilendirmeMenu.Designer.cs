namespace DershaneYonetimSistemi
{
    partial class FormYetkilendirmeMenu
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
            groupBox1 = new GroupBox();
            textBoxTemporaryRol = new TextBox();
            buttonRolGuncelle = new Button();
            labelTemporaryRol = new Label();
            checkBoxCanUpdate = new CheckBox();
            checkBoxCanDelete = new CheckBox();
            checkBoxCanInsert = new CheckBox();
            buttonRolEkle = new Button();
            checkBoxCanRead = new CheckBox();
            textBoxRol = new TextBox();
            labelCanInsert = new Label();
            label4 = new Label();
            labelCanUpdate = new Label();
            labelCanRead = new Label();
            labelCanDelete = new Label();
            groupBox2 = new GroupBox();
            comboBoxKullaniciRolleri = new ComboBox();
            textBoxTemporaryYoneticiID = new TextBox();
            labelYonetici = new Label();
            labelTemporaryYoneticiID = new Label();
            label1 = new Label();
            buttonKullaniciGuncelle = new Button();
            buttonKullaniciEkle = new Button();
            textBoxSifre = new TextBox();
            textBoxKullanıcıAdı = new TextBox();
            label3 = new Label();
            labelKullaniciAdi = new Label();
            labelYoneticiId = new Label();
            labelRol = new Label();
            groupBox3 = new GroupBox();
            dataGridViewRoller = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridViewKullanicilar = new DataGridView();
            labelSilinecekRol = new Label();
            textBoxsilinecekRol = new TextBox();
            buttonRolSil = new Button();
            buttonKullaniciSil = new Button();
            textBoxSilinecekKullanici = new TextBox();
            labelSilinecekKullanici = new Label();
            treeView1 = new TreeView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoller).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTemporaryRol);
            groupBox1.Controls.Add(buttonRolGuncelle);
            groupBox1.Controls.Add(labelTemporaryRol);
            groupBox1.Controls.Add(checkBoxCanUpdate);
            groupBox1.Controls.Add(checkBoxCanDelete);
            groupBox1.Controls.Add(checkBoxCanInsert);
            groupBox1.Controls.Add(buttonRolEkle);
            groupBox1.Controls.Add(checkBoxCanRead);
            groupBox1.Controls.Add(textBoxRol);
            groupBox1.Controls.Add(labelCanInsert);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelCanUpdate);
            groupBox1.Controls.Add(labelCanRead);
            groupBox1.Controls.Add(labelCanDelete);
            groupBox1.Font = new Font("Imprint MT Shadow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(68, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rol İşlemleri";
            // 
            // textBoxTemporaryRol
            // 
            textBoxTemporaryRol.Location = new Point(254, 48);
            textBoxTemporaryRol.Name = "textBoxTemporaryRol";
            textBoxTemporaryRol.Size = new Size(100, 25);
            textBoxTemporaryRol.TabIndex = 21;
            // 
            // buttonRolGuncelle
            // 
            buttonRolGuncelle.BackColor = Color.Lavender;
            buttonRolGuncelle.Font = new Font("Imprint MT Shadow", 9F);
            buttonRolGuncelle.Location = new Point(39, 231);
            buttonRolGuncelle.Name = "buttonRolGuncelle";
            buttonRolGuncelle.Size = new Size(96, 39);
            buttonRolGuncelle.TabIndex = 20;
            buttonRolGuncelle.Text = "Rol Güncelle";
            buttonRolGuncelle.UseVisualStyleBackColor = false;
            buttonRolGuncelle.Click += buttonRolGuncelle_Click;
            // 
            // labelTemporaryRol
            // 
            labelTemporaryRol.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemporaryRol.Location = new Point(221, 13);
            labelTemporaryRol.Name = "labelTemporaryRol";
            labelTemporaryRol.Size = new Size(185, 32);
            labelTemporaryRol.TabIndex = 19;
            labelTemporaryRol.Text = "Güncelleme yapmak istediğiniz rol adının mevcut halini giriniz";
            labelTemporaryRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxCanUpdate
            // 
            checkBoxCanUpdate.AutoSize = true;
            checkBoxCanUpdate.Location = new Point(164, 196);
            checkBoxCanUpdate.Name = "checkBoxCanUpdate";
            checkBoxCanUpdate.Size = new Size(15, 14);
            checkBoxCanUpdate.TabIndex = 18;
            checkBoxCanUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanDelete
            // 
            checkBoxCanDelete.AutoSize = true;
            checkBoxCanDelete.Location = new Point(143, 160);
            checkBoxCanDelete.Name = "checkBoxCanDelete";
            checkBoxCanDelete.Size = new Size(15, 14);
            checkBoxCanDelete.TabIndex = 17;
            checkBoxCanDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanInsert
            // 
            checkBoxCanInsert.AutoSize = true;
            checkBoxCanInsert.Location = new Point(143, 124);
            checkBoxCanInsert.Name = "checkBoxCanInsert";
            checkBoxCanInsert.Size = new Size(15, 14);
            checkBoxCanInsert.TabIndex = 16;
            checkBoxCanInsert.UseVisualStyleBackColor = true;
            // 
            // buttonRolEkle
            // 
            buttonRolEkle.BackColor = Color.Lavender;
            buttonRolEkle.Font = new Font("Imprint MT Shadow", 9F);
            buttonRolEkle.Location = new Point(164, 231);
            buttonRolEkle.Name = "buttonRolEkle";
            buttonRolEkle.Size = new Size(98, 39);
            buttonRolEkle.TabIndex = 15;
            buttonRolEkle.Text = "Yeni Rol Ekle";
            buttonRolEkle.UseVisualStyleBackColor = false;
            buttonRolEkle.Click += buttonRolEkle_Click;
            // 
            // checkBoxCanRead
            // 
            checkBoxCanRead.AutoSize = true;
            checkBoxCanRead.Location = new Point(143, 84);
            checkBoxCanRead.Name = "checkBoxCanRead";
            checkBoxCanRead.Size = new Size(15, 14);
            checkBoxCanRead.TabIndex = 4;
            checkBoxCanRead.UseVisualStyleBackColor = true;
            // 
            // textBoxRol
            // 
            textBoxRol.Location = new Point(61, 48);
            textBoxRol.Name = "textBoxRol";
            textBoxRol.Size = new Size(118, 25);
            textBoxRol.TabIndex = 13;
            // 
            // labelCanInsert
            // 
            labelCanInsert.AutoSize = true;
            labelCanInsert.Font = new Font("Century", 9F);
            labelCanInsert.Location = new Point(9, 122);
            labelCanInsert.Name = "labelCanInsert";
            labelCanInsert.Size = new Size(126, 16);
            labelCanInsert.TabIndex = 6;
            labelCanInsert.Text = "Veri Ekleme Yetkisi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9F);
            label4.Location = new Point(9, 49);
            label4.Name = "label4";
            label4.Size = new Size(35, 16);
            label4.TabIndex = 10;
            label4.Text = "Rol : ";
            // 
            // labelCanUpdate
            // 
            labelCanUpdate.AutoSize = true;
            labelCanUpdate.Font = new Font("Century", 9F);
            labelCanUpdate.Location = new Point(9, 194);
            labelCanUpdate.Name = "labelCanUpdate";
            labelCanUpdate.Size = new Size(149, 16);
            labelCanUpdate.TabIndex = 5;
            labelCanUpdate.Text = "Veri Güncelleme Yetkisi :";
            // 
            // labelCanRead
            // 
            labelCanRead.AutoSize = true;
            labelCanRead.Font = new Font("Century", 9F);
            labelCanRead.Location = new Point(9, 82);
            labelCanRead.Name = "labelCanRead";
            labelCanRead.Size = new Size(125, 16);
            labelCanRead.TabIndex = 3;
            labelCanRead.Text = "Veri Okuma Yetkisi :";
            // 
            // labelCanDelete
            // 
            labelCanDelete.AutoSize = true;
            labelCanDelete.Font = new Font("Century", 9F);
            labelCanDelete.Location = new Point(9, 160);
            labelCanDelete.Name = "labelCanDelete";
            labelCanDelete.Size = new Size(117, 16);
            labelCanDelete.TabIndex = 4;
            labelCanDelete.Text = "Veri Silme Yetkisi :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxKullaniciRolleri);
            groupBox2.Controls.Add(textBoxTemporaryYoneticiID);
            groupBox2.Controls.Add(labelYonetici);
            groupBox2.Controls.Add(labelTemporaryYoneticiID);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonKullaniciGuncelle);
            groupBox2.Controls.Add(buttonKullaniciEkle);
            groupBox2.Controls.Add(textBoxSifre);
            groupBox2.Controls.Add(textBoxKullanıcıAdı);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(labelKullaniciAdi);
            groupBox2.Controls.Add(labelYoneticiId);
            groupBox2.Controls.Add(labelRol);
            groupBox2.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(755, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 253);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // comboBoxKullaniciRolleri
            // 
            comboBoxKullaniciRolleri.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxKullaniciRolleri.FormattingEnabled = true;
            comboBoxKullaniciRolleri.Location = new Point(107, 140);
            comboBoxKullaniciRolleri.Name = "comboBoxKullaniciRolleri";
            comboBoxKullaniciRolleri.Size = new Size(121, 22);
            comboBoxKullaniciRolleri.TabIndex = 22;
            // 
            // textBoxTemporaryYoneticiID
            // 
            textBoxTemporaryYoneticiID.Location = new Point(263, 47);
            textBoxTemporaryYoneticiID.Name = "textBoxTemporaryYoneticiID";
            textBoxTemporaryYoneticiID.Size = new Size(118, 26);
            textBoxTemporaryYoneticiID.TabIndex = 21;
            // 
            // labelYonetici
            // 
            labelYonetici.AutoSize = true;
            labelYonetici.Location = new Point(123, 36);
            labelYonetici.Name = "labelYonetici";
            labelYonetici.Size = new Size(16, 19);
            labelYonetici.TabIndex = 19;
            labelYonetici.Text = "-";
            // 
            // labelTemporaryYoneticiID
            // 
            labelTemporaryYoneticiID.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemporaryYoneticiID.Location = new Point(234, 10);
            labelTemporaryYoneticiID.Name = "labelTemporaryYoneticiID";
            labelTemporaryYoneticiID.Size = new Size(209, 44);
            labelTemporaryYoneticiID.TabIndex = 20;
            labelTemporaryYoneticiID.Text = "Güncelleme yapmak istediğiniz yöneticinin mevcut ID değerini girniz.";
            labelTemporaryYoneticiID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 18;
            // 
            // buttonKullaniciGuncelle
            // 
            buttonKullaniciGuncelle.BackColor = Color.Lavender;
            buttonKullaniciGuncelle.Font = new Font("Imprint MT Shadow", 9F);
            buttonKullaniciGuncelle.Location = new Point(42, 194);
            buttonKullaniciGuncelle.Name = "buttonKullaniciGuncelle";
            buttonKullaniciGuncelle.Size = new Size(98, 43);
            buttonKullaniciGuncelle.TabIndex = 17;
            buttonKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            buttonKullaniciGuncelle.UseVisualStyleBackColor = false;
            buttonKullaniciGuncelle.Click += buttonKullaniciGuncelle_Click;
            // 
            // buttonKullaniciEkle
            // 
            buttonKullaniciEkle.BackColor = Color.Lavender;
            buttonKullaniciEkle.Font = new Font("Imprint MT Shadow", 9F);
            buttonKullaniciEkle.Location = new Point(163, 193);
            buttonKullaniciEkle.Name = "buttonKullaniciEkle";
            buttonKullaniciEkle.Size = new Size(98, 44);
            buttonKullaniciEkle.TabIndex = 16;
            buttonKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            buttonKullaniciEkle.UseVisualStyleBackColor = false;
            buttonKullaniciEkle.Click += buttonKullaniciEkle_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(108, 107);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(118, 26);
            textBoxSifre.TabIndex = 12;
            // 
            // textBoxKullanıcıAdı
            // 
            textBoxKullanıcıAdı.Location = new Point(108, 74);
            textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            textBoxKullanıcıAdı.Size = new Size(118, 26);
            textBoxKullanıcıAdı.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F);
            label3.Location = new Point(17, 109);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 9;
            label3.Text = "Şifre :";
            // 
            // labelKullaniciAdi
            // 
            labelKullaniciAdi.AutoSize = true;
            labelKullaniciAdi.Font = new Font("Century", 9F);
            labelKullaniciAdi.Location = new Point(17, 76);
            labelKullaniciAdi.Name = "labelKullaniciAdi";
            labelKullaniciAdi.Size = new Size(87, 16);
            labelKullaniciAdi.TabIndex = 8;
            labelKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // labelYoneticiId
            // 
            labelYoneticiId.AutoSize = true;
            labelYoneticiId.Font = new Font("Century", 9F);
            labelYoneticiId.Location = new Point(17, 38);
            labelYoneticiId.Name = "labelYoneticiId";
            labelYoneticiId.Size = new Size(77, 16);
            labelYoneticiId.TabIndex = 7;
            labelYoneticiId.Text = "Yonetici ID : ";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Century", 9F);
            labelRol.Location = new Point(17, 142);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(86, 16);
            labelRol.TabIndex = 2;
            labelRol.Text = "Kullanıcı Rol :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewRoller);
            groupBox3.Location = new Point(21, 370);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(612, 251);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rol Listesi";
            // 
            // dataGridViewRoller
            // 
            dataGridViewRoller.AllowUserToAddRows = false;
            dataGridViewRoller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoller.Dock = DockStyle.Fill;
            dataGridViewRoller.Location = new Point(3, 18);
            dataGridViewRoller.Name = "dataGridViewRoller";
            dataGridViewRoller.RowTemplate.Height = 25;
            dataGridViewRoller.Size = new Size(606, 230);
            dataGridViewRoller.TabIndex = 0;
            dataGridViewRoller.CellClick += dataGridViewRoller_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKullanicilar);
            groupBox4.Location = new Point(651, 370);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(556, 248);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kullanıcı Listesi";
            // 
            // dataGridViewKullanicilar
            // 
            dataGridViewKullanicilar.AllowUserToAddRows = false;
            dataGridViewKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKullanicilar.Dock = DockStyle.Fill;
            dataGridViewKullanicilar.Location = new Point(3, 18);
            dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            dataGridViewKullanicilar.RowTemplate.Height = 25;
            dataGridViewKullanicilar.Size = new Size(550, 227);
            dataGridViewKullanicilar.TabIndex = 0;
            dataGridViewKullanicilar.CellClick += dataGridViewKullanicilar_CellClick;
            // 
            // labelSilinecekRol
            // 
            labelSilinecekRol.AutoSize = true;
            labelSilinecekRol.Font = new Font("Century", 9F);
            labelSilinecekRol.Location = new Point(87, 329);
            labelSilinecekRol.Name = "labelSilinecekRol";
            labelSilinecekRol.Size = new Size(160, 16);
            labelSilinecekRol.TabIndex = 6;
            labelSilinecekRol.Text = "Silinecek Rol adını giriniz : ";
            // 
            // textBoxsilinecekRol
            // 
            textBoxsilinecekRol.Location = new Point(265, 328);
            textBoxsilinecekRol.Name = "textBoxsilinecekRol";
            textBoxsilinecekRol.Size = new Size(118, 22);
            textBoxsilinecekRol.TabIndex = 14;
            // 
            // buttonRolSil
            // 
            buttonRolSil.BackColor = Color.SteelBlue;
            buttonRolSil.Font = new Font("Imprint MT Shadow", 9F);
            buttonRolSil.Location = new Point(406, 316);
            buttonRolSil.Name = "buttonRolSil";
            buttonRolSil.Size = new Size(98, 44);
            buttonRolSil.TabIndex = 16;
            buttonRolSil.Text = "Rolü sil";
            buttonRolSil.UseVisualStyleBackColor = false;
            buttonRolSil.Click += buttonRolSil_Click;
            // 
            // buttonKullaniciSil
            // 
            buttonKullaniciSil.BackColor = Color.SteelBlue;
            buttonKullaniciSil.Font = new Font("Imprint MT Shadow", 9F);
            buttonKullaniciSil.Location = new Point(1065, 296);
            buttonKullaniciSil.Name = "buttonKullaniciSil";
            buttonKullaniciSil.Size = new Size(98, 43);
            buttonKullaniciSil.TabIndex = 19;
            buttonKullaniciSil.Text = "Kullanıcıyı sil";
            buttonKullaniciSil.UseVisualStyleBackColor = false;
            buttonKullaniciSil.Click += buttonKullaniciSil_Click;
            // 
            // textBoxSilinecekKullanici
            // 
            textBoxSilinecekKullanici.Location = new Point(932, 306);
            textBoxSilinecekKullanici.Name = "textBoxSilinecekKullanici";
            textBoxSilinecekKullanici.Size = new Size(118, 22);
            textBoxSilinecekKullanici.TabIndex = 18;
            // 
            // labelSilinecekKullanici
            // 
            labelSilinecekKullanici.AutoSize = true;
            labelSilinecekKullanici.Font = new Font("Century", 9F);
            labelSilinecekKullanici.Location = new Point(693, 308);
            labelSilinecekKullanici.Name = "labelSilinecekKullanici";
            labelSilinecekKullanici.Size = new Size(233, 16);
            labelSilinecekKullanici.TabIndex = 17;
            labelSilinecekKullanici.Text = "Silinecek Yoneticinin ID değerini giriniz :";
            // 
            // treeView1
            // 
            treeView1.BackColor = SystemColors.GradientActiveCaption;
            treeView1.Location = new Point(638, 2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(10, 640);
            treeView1.TabIndex = 20;
            // 
            // FormYetkilendirmeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1241, 632);
            Controls.Add(treeView1);
            Controls.Add(buttonKullaniciSil);
            Controls.Add(textBoxSilinecekKullanici);
            Controls.Add(labelSilinecekKullanici);
            Controls.Add(buttonRolSil);
            Controls.Add(textBoxsilinecekRol);
            Controls.Add(labelSilinecekRol);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Imprint MT Shadow", 9F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormYetkilendirmeMenu";
            Text = "Yönetici ve Yetki İşlemleri Menüsü";
            Load += FormYetkilendirmeMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoller).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelRol;
        private Label labelCanRead;
        private Label labelCanDelete;
        private GroupBox groupBox2;
        private Label labelCanUpdate;
        private Label labelCanInsert;
        private Label label3;
        private Label label4;
        private Label labelKullaniciAdi;
        private Label labelYoneticiId;
        private TextBox textBoxRol;
        private TextBox textBoxSifre;
        private TextBox textBoxKullanıcıAdı;
        private GroupBox groupBox3;
        private DataGridView dataGridViewRoller;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKullanicilar;
        private Button buttonRolEkle;
        private Button buttonKullaniciGuncelle;
        private Button buttonKullaniciEkle;
        private CheckBox checkBoxCanUpdate;
        private CheckBox checkBoxCanDelete;
        private CheckBox checkBoxCanInsert;
        private CheckBox checkBoxCanRead;
        private Label label1;
        private Label labelYonetici;
        private Button buttonRolGuncelle;
        private TextBox textBoxTemporaryRol;
        private Label labelTemporaryRol;
        private Label labelSilinecekRol;
        private TextBox textBoxsilinecekRol;
        private Button buttonRolSil;
        private Button buttonKullaniciSil;
        private TextBox textBoxSilinecekKullanici;
        private Label labelSilinecekKullanici;
        private TextBox textBoxTemporaryYoneticiID;
        private Label labelTemporaryYoneticiID;
        private ComboBox comboBoxKullaniciRolleri;
        private TreeView treeView1;
    }
}