using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinavDurumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int vizeNot = Convert.ToInt16(txbVizeNot.Text);
            int finalNot=Convert.ToInt16(txbFinalNot.Text);
            int projeNot=Convert.ToInt16(txbProjeNot.Text);
            double ortalama = (vizeNot*40/100)+(finalNot*50/100)+(projeNot*10/100);
            listBox1.Items.Add("Adı Soyadı= " + txbAdSoyad.Text + " olan öğrencinin not ortalaması= " + ortalama);

            if (ortalama > 50)
                listBox1.Items.Add("Sınav Sonucu Başarılı!");
            else
                listBox1.Items.Add("Sınav Sonucu Başarısız!");
        }
    }
}
