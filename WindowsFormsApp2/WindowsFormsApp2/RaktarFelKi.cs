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
    public partial class RaktarFelKi : Form
    {
        bool novel;
        public RaktarFelKi(bool novel)
        {
            InitializeComponent();
            ComboBoxFill();
            this.novel = novel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand("RaktarModosit");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", Int32.Parse(CBTermekek.SelectedValue.ToString()));
                sqlCmd.Parameters.AddWithValue("@Novel", 1);
                sqlCmd.Parameters.AddWithValue("@Darab", NDarab.Value);
                DbManagment.SqlCommandRun(sqlCmd);
                Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message.ToString());
            }
        }
        void ComboBoxFill()
        {
            string query = "SELECT [Id],[Azonosito] +'  '+ Nev  as Azon FROM[erp].[dbo].[Termek] ";
            string tablename = "Termek";

            DataSet ds = DbManagment.SqlDataSetCreate(query, tablename);
            CBTermekek.DisplayMember = "Azon";
            CBTermekek.ValueMember = "Id";
            CBTermekek.DataSource = ds.Tables["Termek"];


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
