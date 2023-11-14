using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obrovac
{
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)    //klikom na button1 otvara se forma2
        {
            ElektrostatskaPotencijalnaEnergija form2 = new ElektrostatskaPotencijalnaEnergija();
            form2.Show();
        }


        private void button2_Click(object sender, EventArgs e)   //klikom na button2 otvara se forma3
        {
            BrzinaSvjetla form3=new BrzinaSvjetla();
            form3.Show();
        }

       
    }
}
