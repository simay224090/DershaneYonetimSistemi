namespace DershaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGiris = new Button();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = Color.Teal;
            buttonGiris.Font = new Font("Ravie", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            buttonGiris.Location = new Point(381, 446);
            buttonGiris.Margin = new Padding(3, 4, 3, 4);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(151, 61);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.BackColor = Color.DarkSeaGreen;
            textBoxKullaniciAdi.Location = new Point(458, 42);
            textBoxKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(125, 27);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // textBoxSifre
            // 
            textBoxSifre.BackColor = Color.DarkSeaGreen;
            textBoxSifre.Location = new Point(458, 78);
            textBoxSifre.Margin = new Padding(3, 4, 3, 4);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(125, 27);
            textBoxSifre.TabIndex = 2;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 51);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(381, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            button1.Location = new Point(218, 448);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 59);
            button1.TabIndex = 7;
            button1.Text = "Yedekten Full Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.logo;
            ClientSize = new Size(595, 649);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(buttonGiris);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGiris";
            Text = "Giriş Ekranı";
            Load += FormGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}