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
using WindowsFormsApp2;

namespace erp
{
    public partial class GyartasiTerv : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";

     //   int Idd = 0;
        public GyartasiTerv()
        {
            InitializeComponent();
            ComboBoxFill();
            PopulateDataGridView();
            dgvEmployee.AllowUserToAddRows = false;
        }


    /*  private void BtnOk_Click(object sender, EventArgs e)
        {
            if (CBTermekek.SelectedValue.ToString() == null || NSorrend.Value < 1 || TBMunka.Text.Length < 3)
            {
                MessageBox.Show("Hibás adatok!");
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("GyartasiTervModosit");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (Idd == 0)//Insert
                    sqlCmd.Parameters.AddWithValue("@Id", 0);
                else//update
                    sqlCmd.Parameters.AddWithValue("@Id", Idd);
                sqlCmd.Parameters.AddWithValue("@TermekId", CBTermekek.SelectedValue.ToString());
                sqlCmd.Parameters.AddWithValue("@Munkafolyamat", TBMunka.Text.ToString());
                sqlCmd.Parameters.AddWithValue("@Sorrend", NSorrend.Value);
                DbManagment.SqlCommandRun(sqlCmd);

                Idd = 0;
                TBMunka.Text = null;
                NSorrend.Value = 0;
                PopulateDataGridView();
            }


        }*/

        void ComboBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                string query = "SELECT [Id],[Azonosito] +'  '+ Nev  as Azon FROM[erp].[dbo].[Termek] where Gyartando = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Termek");
                CBTermekek.DisplayMember = "Azon";
                CBTermekek.ValueMember = "Id";
                CBTermekek.DataSource = ds.Tables["Termek"];
            }


        }
        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select	a.id, a.Munkafolyamat, a.Sorrend from gyartasiterv  a inner join termek  b on a.termekid = b.id " +
                     "where TermekId = " + CBTermekek.SelectedValue.ToString() + "order by Sorrend", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
            }
        }

        private void CBTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

     /*   private void BtnModosit_Click(object sender, EventArgs e)
        {

            int a = dgvEmployee.CurrentCell.RowIndex;
            if (a != -1)
            {
                Idd = Int32.Parse(dgvEmployee[0, a].Value.ToString());
                TBMunka.Text = dgvEmployee[1, a].Value.ToString();
                NSorrend.Value = Int32.Parse(dgvEmployee[2, a].Value.ToString());

            }

        }
        */
        private void Button3_Click(object sender, EventArgs e)
        {
            GyartasiTervFelvitel dialogus = new GyartasiTervFelvitel(0,Int32.Parse(CBTermekek.SelectedValue.ToString()));

            dialogus.ShowDialog();
            PopulateDataGridView();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int a = dgvEmployee.CurrentCell.RowIndex;
            GyartasiTervFelvitel dialogus = new GyartasiTervFelvitel(Int32.Parse(dgvEmployee[0, a].Value.ToString()), Int32.Parse(CBTermekek.SelectedValue.ToString()), dgvEmployee[1, a].Value.ToString(), Int32.Parse(dgvEmployee[2, a].Value.ToString()));

            dialogus.ShowDialog();
            PopulateDataGridView();
        }
    }
}
