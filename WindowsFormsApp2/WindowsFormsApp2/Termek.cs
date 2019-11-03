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
    public partial class Termek : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";

        public Termek()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Termek] where azonosito like '%" + TBAzon.Text + "%' and  nev like '%" + TBNev.Text + "%' ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Termek] where azonosito like '%" + TBAzon.Text + "%'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
            }
        }
        private void dgvEmployee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnnn;
            connetionString = @"Data Source=localhost\\SQLEXPRESS;Initial Catalog=erp;Integrated Security = true";
            cnnn = new SqlConnection(connetionString);
            cnnn.Open();
            MessageBox.Show("Connection Open  !");
            cnnn.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //     DbManagment.adap = new SqlDataAdapter();

            //  DbManagment  .Save(dgvEmployee);

            //   this.rscan_queueTableAdapter.Fill(this.rscanDataSet.rscan_queue);

            //     dgv_queue.refresh();

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            //         MessageBox.Show(dgvEmployee.CurrentCell.RowIndex.ToString());
            //string test = dgvEmployee.SelectedRows[1].Cells[1].Value.ToString();
            // string test = dgvEmployee[0, 2].Value.ToString();// = "new value";
            ///  string test2 = dgvEmployee.SelectedCells[2].ColumnIndex .ToString();
            //    MessageBox.Show(test);

            int a = dgvEmployee.CurrentCell.RowIndex;
            if (a != -1)
            {
                int Id = Int32.Parse(dgvEmployee[0, a].Value.ToString());
                string Azonosito = dgvEmployee[1, a].Value.ToString();
                string Nev = dgvEmployee[2, a].Value.ToString();
                //   MessageBox.Show(dgvEmployee[3, a].Value.ToString());
                bool Gyartando = bool.Parse(dgvEmployee[3, a].Value.ToString());
                TermekFelvitel dialogus = new TermekFelvitel(Id, Azonosito, Nev, Gyartando);
                dialogus.ShowDialog();
            }
            PopulateDataGridView();

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            TermekFelvitel dialogus = new TermekFelvitel();
            dialogus.ShowDialog();
            PopulateDataGridView();
        }



        private void GyártásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Gyartas();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
