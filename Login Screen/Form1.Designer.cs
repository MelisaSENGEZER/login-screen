namespace Login_Screen
{
    partial class Form1
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
            this.button_giris = new System.Windows.Forms.Button();
            this.label1_kullanici = new System.Windows.Forms.Label();
            this.label2_sifre = new System.Windows.Forms.Label();
            this.linkLabel_sifremi_unuttum = new System.Windows.Forms.LinkLabel();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.textBox_kullanici = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_giris
            // 
            this.button_giris.BackColor = System.Drawing.Color.SeaShell;
            this.button_giris.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_giris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_giris.Location = new System.Drawing.Point(195, 327);
            this.button_giris.Name = "button_giris";
            this.button_giris.Size = new System.Drawing.Size(139, 66);
            this.button_giris.TabIndex = 0;
            this.button_giris.Text = "Oturum Aç";
            this.button_giris.UseVisualStyleBackColor = false;
            this.button_giris.Click += new System.EventHandler(this.button_giris_Click);
            // 
            // label1_kullanici
            // 
            this.label1_kullanici.AutoSize = true;
            this.label1_kullanici.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_kullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1_kullanici.Location = new System.Drawing.Point(186, 49);
            this.label1_kullanici.Name = "label1_kullanici";
            this.label1_kullanici.Size = new System.Drawing.Size(183, 34);
            this.label1_kullanici.TabIndex = 1;
            this.label1_kullanici.Text = "Kullanıcı Adı:";
            this.label1_kullanici.Click += new System.EventHandler(this.label1_kullanici_Click);
            // 
            // label2_sifre
            // 
            this.label2_sifre.AutoSize = true;
            this.label2_sifre.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2_sifre.Location = new System.Drawing.Point(232, 148);
            this.label2_sifre.Name = "label2_sifre";
            this.label2_sifre.Size = new System.Drawing.Size(83, 34);
            this.label2_sifre.TabIndex = 2;
            this.label2_sifre.Text = "Şifre:";
            // 
            // linkLabel_sifremi_unuttum
            // 
            this.linkLabel_sifremi_unuttum.AutoSize = true;
            this.linkLabel_sifremi_unuttum.Location = new System.Drawing.Point(151, 245);
            this.linkLabel_sifremi_unuttum.Name = "linkLabel_sifremi_unuttum";
            this.linkLabel_sifremi_unuttum.Size = new System.Drawing.Size(113, 20);
            this.linkLabel_sifremi_unuttum.TabIndex = 3;
            this.linkLabel_sifremi_unuttum.TabStop = true;
            this.linkLabel_sifremi_unuttum.Text = "şifremi unuttum";
            this.linkLabel_sifremi_unuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_sifremi_unuttum_LinkClicked);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Location = new System.Drawing.Point(151, 196);
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(230, 27);
            this.textBox_sifre.TabIndex = 4;
            this.textBox_sifre.UseSystemPasswordChar = true;
            // 
            // textBox_kullanici
            // 
            this.textBox_kullanici.Location = new System.Drawing.Point(151, 99);
            this.textBox_kullanici.Name = "textBox_kullanici";
            this.textBox_kullanici.Size = new System.Drawing.Size(230, 27);
            this.textBox_kullanici.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(284, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "şifreyi gör";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_kullanici);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.linkLabel_sifremi_unuttum);
            this.Controls.Add(this.label2_sifre);
            this.Controls.Add(this.label1_kullanici);
            this.Controls.Add(this.button_giris);
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_giris;
        private Label label1_kullanici;
        private Label label2_sifre;
        private LinkLabel linkLabel_sifremi_unuttum;
        private TextBox textBox_sifre;
        private TextBox textBox_kullanici;
        private CheckBox checkBox1;
    }
}