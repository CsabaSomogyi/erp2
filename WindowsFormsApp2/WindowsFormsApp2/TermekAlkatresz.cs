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
    public partial class TermekAlkatresz : Form
    {
     //   string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";

        public TermekAlkatresz()
        {
            InitializeComponent();
            ComboBoxFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TermekAlkatreszFelvitel dialogus = new TermekAlkatreszFelvitel(Int32.Parse(CBTermekek.SelectedValue.ToString()));

            dialogus.ShowDialog();
            PopulateDataGridView();
        }
        void ComboBoxFill()
        {
            string query = "SELECT [Id],[Azonosito] +'  '+ Nev  as Azon FROM[erp].[dbo].[Termek] where Gyartando = 1";
 
            DataSet ds = DbManagment.SqlDataSetCreate(query, "Termek");
            CBTermekek.DisplayMember = "Azon";
            CBTermekek.ValueMember = "Id";
            CBTermekek.DataSource = ds.Tables["Termek"];
        }

        private void CBTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
        void PopulateDataGridView()
        {
            string query = "SELECT ta.[Id] as 'AlkatreszId' ,t.Id, t.Azonosito , t.Nev , ta.AlkatreszMennyiseg as 'darab'" +
                 "FROM[erp].[dbo].[TermekAlkatresz] ta  " +
                 "inner join Termek  t on ta.AlkatreszId = t.Id " +
                  "where TermekId = " + CBTermekek.SelectedValue.ToString();

            dgvEmployee.DataSource = DbManagment.SqlDataAdRun(query);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //   public TermekAlkatreszFelvitel(int Id, int TermekId, int AlkatreszId, int Darab)

            int a = dgvEmployee.CurrentCell.RowIndex;
            if (a != -1)
            {
                int Id = Int32.Parse(dgvEmployee[0, a].Value.ToString());
                int AlkatreszId = Int32.Parse(dgvEmployee[1, a].Value.ToString());
                int Darab = Int32.Parse(dgvEmployee[4, a].Value.ToString());

                TermekAlkatreszFelvitel dialogus = new TermekAlkatreszFelvitel(Id, Int32.Parse(CBTermekek.SelectedValue.ToString()), AlkatreszId, Darab);
                dialogus.ShowDialog();
            }

            PopulateDataGridView();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = dgvEmployee.CurrentCell.RowIndex;
            MessageBox.Show(dgvEmployee[1, a].Value.ToString());
        }
    }
}
