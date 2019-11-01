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
    public partial class TermekAlkatreszFelvitel : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";
        public int Id { get; }
        public int TermekId { get; }
        public int AlkatreszId { get; }

        bool Beszuras;
        public TermekAlkatreszFelvitel(int TermekId)
        {
            InitializeComponent();
            this.TermekId = TermekId;
            Beszuras = true;
            ComboBoxFill();
        }
        public TermekAlkatreszFelvitel(int Id, int TermekId, int AlkatreszId, int Darab)
        {
            InitializeComponent();
            this.Id = Id;
            this.TermekId = TermekId;
            this.AlkatreszId = AlkatreszId;
            Beszuras = false;
            NDarab.Value = Darab;
            ComboBoxFill();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            if (CBTermekek.SelectedValue.ToString() == null || NDarab.Value < 1)
            {
                MessageBox.Show("Hibás adatok!");
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("TermekAlkatreszModosit");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (Id == 0)//Insert
                    sqlCmd.Parameters.AddWithValue("@Id", 0);
                else//update
                    sqlCmd.Parameters.AddWithValue("@Id", Id);
                sqlCmd.Parameters.AddWithValue("@TermekId", TermekId);
                sqlCmd.Parameters.AddWithValue("@AlkatreszId", Int32.Parse(CBTermekek.SelectedValue.ToString()));
                sqlCmd.Parameters.AddWithValue("@AlkatreszMennyiseg", NDarab.Value);
                try
                {
                    DbManagment.SqlCommandRun(sqlCmd);
                }
                catch (Exception exp)
                {
                    //MessageBox.Show(exp.Message.ToString());
                    MessageBox.Show(exp.Message.ToString(), "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        void ComboBoxFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                string query = "SELECT [Id],[Azonosito] +'  '+ Nev  as Azon FROM[erp].[dbo].[Termek] where id = " + AlkatreszId;
                if (Beszuras)
                {
                    query = "SELECT [Id],[Azonosito] +'  '+ Nev  as Azon FROM[erp].[dbo].[Termek] where id != " + TermekId;
                }
                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                sqlCon.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Termek");
                CBTermekek.DisplayMember = "Azon";
                CBTermekek.ValueMember = "Id";
                CBTermekek.DataSource = ds.Tables["Termek"];

            }
        }
    }
}

