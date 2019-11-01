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
    public partial class GyartasiTerv : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";

        int Idd = 0;
        public GyartasiTerv()
        {
            InitializeComponent();
            ComboBoxFill();
            PopulateDataGridView();
            dgvEmployee.AllowUserToAddRows = false;
            inserteszt();
        }

        void inserteszt()
        {
            /*  using (SqlConnection sqlCon = new SqlConnection(connectionString))
              {
                  SqlCommand sqlCmd = new SqlCommand("BEGIN TRANSACTION insert into teszt values(111)");

                  sqlCon.Open();
                //  SqlTransaction sqlt = sqlCon.BeginTransaction("t1");
               //   sqlCmd.Transaction = sqlt;
                  sqlCmd.Connection = sqlCon;
                  sqlCmd.ExecuteNonQuery();


                //  sqlCmd = new SqlCommand("commit TRANSACTION");
            //      sqlCmd.Transaction = sqlt;
                  //sqlCon.Open();
                  sqlCmd.Connection = sqlCon;
                  sqlCmd.ExecuteNonQuery();



              }*/


            //  sqlCmd.Transaction = "tr1";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand sqlCmd = new SqlCommand("BEGIN TRANSACTION a insert into teszt values(432)", sqlCon);
            //sqlCmd.Connection = sqlCon;
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            ComboBoxFill();
            sqlCon.Open();
            sqlCmd = new SqlCommand("commit TRANSACTION a", sqlCon);
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

        }


        private void BtnOk_Click(object sender, EventArgs e)
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


        }

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

        private void BtnModosit_Click(object sender, EventArgs e)
        {

            int a = dgvEmployee.CurrentCell.RowIndex;
            if (a != -1)
            {
                Idd = Int32.Parse(dgvEmployee[0, a].Value.ToString());
                TBMunka.Text = dgvEmployee[1, a].Value.ToString();
                NSorrend.Value = Int32.Parse(dgvEmployee[2, a].Value.ToString());

            }

        }
    }
}
