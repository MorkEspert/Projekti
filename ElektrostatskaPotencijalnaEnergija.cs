using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obrovac
{
    public partial class ElektrostatskaPotencijalnaEnergija : Form
    {
        public ElektrostatskaPotencijalnaEnergija()
        {
            InitializeComponent();
        }

        double naboj, potencijskaRazlika;                              //deklaracija varijabli
       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)  //cita i inicijalizira varijablu frekvencija
        {
            if (double.TryParse(textBox1.Text, out double unos))       //funkcija za inicijaliziranje varijable naboj
            {
                naboj = unos;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)  //cita i inicijalizira varijablu frekvencija
        {
            if (double.TryParse(textBox2.Text, out double unos))       //funkcija za inicijaliziranje varijable potencijskaRazlika
            {
                potencijskaRazlika = unos;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double rezultat = naboj * potencijskaRazlika;              //deklaracija i inicijalizacija varijable rezultat
            textBox3.Text = rezultat.ToString();                       //ispis varijable rezultat u textBox3
        }

        private void button2_Click(object sender, EventArgs e)     //zatvara formu
        {
            this.Close();
        }
    }
}
