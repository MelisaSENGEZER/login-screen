namespace Login_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            string Kullanici_Adi=textBox_kullanici.Text;
            string Sifre=textBox_sifre.Text;
            
            if(Kullanici_Adi=="melisa" && Sifre == "123456")
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.Show();
            }
            else if(Kullanici_Adi=="" && Sifre == "")
            {
                string mesaj = "Bo�luklar� doldurunuz.";
                string baslik = "Uyar�";
                MessageBoxButtons buton = MessageBoxButtons.OK;
                MessageBox.Show(mesaj, baslik, buton, MessageBoxIcon.Warning);
          

            }

            else
            {
                string mesaj2 = "�ifre Yanl��";
                string baslik2 = "Uyar�";
                MessageBoxButtons buton2= MessageBoxButtons.OK;
                MessageBox.Show(mesaj2 , baslik2, buton2, MessageBoxIcon.Error);

            }

        }

        private void linkLabel_sifremi_unuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mesaj3 = "SMS yoluyla ge�ici �ifreniz taraf�n�za iletilmi�tir.";
            string baslik3 = "Bilgilendirme";
            MessageBoxButtons buton3 = MessageBoxButtons.OK;
            MessageBox.Show(mesaj3, baslik3, buton3);



        }

        private void label1_kullanici_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_sifre.UseSystemPasswordChar = false; //sistemin kendi gizleme karakteri oldu�u i�in true false �eklinde �al���yor, g�r�n�r olmas� i�in false yazd�k

            }

            else
            {
                textBox_sifre.UseSystemPasswordChar = true;
            }


        }
    }
}