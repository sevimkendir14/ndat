using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ndatubys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String KimlikNumarası = textBox1.Text;
            String Parola = textBox2.Text;

            if (KimlikNumarası == "student" && Parola == "student")
            {
                // Doğrulama başarılı ise, ana formu aç
                ogrenciekrani mainForm = new ogrenciekrani();
                mainForm.Show();
                this.Hide(); // Giriş formunu gizle
            }
            else if (KimlikNumarası == "idareci" && Parola == "idareci")
            {
                
                idareci mainForm = new idareci();
                mainForm.Show();
                this.Hide(); 
            }
            else if (KimlikNumarası == "ogretimeleman" && Parola == "ogretimeleman")
            {
                
                ogretimeleman mainForm = new ogretimeleman();
                mainForm.Show();
                this.Hide(); 
            }
            else if (KimlikNumarası == "sistemyoneticisi" && Parola == "sistemyoneticisi")
            {
                
                SistemYoneticisi mainForm = new SistemYoneticisi();
                mainForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya parola.");
            }
        }
    }
}

