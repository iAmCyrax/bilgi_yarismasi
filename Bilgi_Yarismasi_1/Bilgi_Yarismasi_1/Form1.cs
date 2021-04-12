using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi_1
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

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogrus.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanliss.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogrus.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanliss.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;

            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogrus.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanliss.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblsoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                btnSonraki.Text = "Sonraki";
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1923";
                btnD.Text = "1922";
                label4.Text = "1923";
            }
            
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bölgemizde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir?";
                btnA.Text = "Sait Faik Abasıyanık";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Namık Kemal";
                label4.Text = "Sait Faik Abasıyanık";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Hangi programlama dilinde satırların sonu MUTLAKA noktalı virgül (;) ile bitirilmelidir?";
                btnA.Text = "C#";
                btnB.Text = "Ruby";
                btnC.Text = "Python";
                btnD.Text = "JSON";
                label4.Text = "C#";
                btnSonraki.Text = "Testi Bitir";
            }

            if (soruno > 4)
            {
                richTextBox1.Text = "Sorular Bitti.";
                btnA.Text = "A";
                btnB.Text = "B";
                btnC.Text = "C";
                btnD.Text = "D";

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;

                MessageBox.Show("Sonuçlar: \n Doğru Sayısı: " + dogru + "\n Yanlış Sayısı: " + yanlis);
            }
        }
        
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogrus.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanliss.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
// Bilgi Yarışması