using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class Raktar : Form
    {

        public Raktar()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PopulateDataGridView();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RaktarFelKi dialogus = new RaktarFelKi(true);

            dialogus.ShowDialog();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            string query = "SELECT * FROM [RaktarView] where azonosito like '%" + TBAzon.Text + "%' and  nev like '%" + TBNev.Text + "%'";

            dgvEmployee.DataSource = DbManagment.SqlDataAdRun(query);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            RaktarFelKi dialogus = new RaktarFelKi(false);

            dialogus.ShowDialog();
            PopulateDataGridView();
        }
    }
}

