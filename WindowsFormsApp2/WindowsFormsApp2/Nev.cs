using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class Nev : Form
    {
        public string textBox1Text;
        public bool mentes;

        public Nev()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  teszt.MunkaKesz("ASd");
            textBox1Text = textBox1.Text;
            mentes = true;
            Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
