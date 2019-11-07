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
    public partial class TermekFelvitel : Form
    {


        public TermekFelvitel(int Id, string Azonosito, string Nev, bool Gyartando)
        {
            InitializeComponent();
            TBId.Text = Id.ToString();
            TBNev.Text = Nev;
            TBAzon.Text = Azonosito;
            CBGyart.Checked = Gyartando;


        }
        public TermekFelvitel()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(CBGyart.Checked.ToString());

            if (TBAzon.Text.Length < 3 || TBNev.Text.Length < 3)
            {
                MessageBox.Show("Hiányzó adat(ok)!");
            }
            else
            {

                SqlCommand sqlCmd = new SqlCommand("TermekModosit");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (TBId.Text is null)//Insert
                    sqlCmd.Parameters.AddWithValue("@Id", 0);
                else//update
                    sqlCmd.Parameters.AddWithValue("@Id", TBId.Text);
                sqlCmd.Parameters.AddWithValue("@Azonosito", TBAzon.Text);
                sqlCmd.Parameters.AddWithValue("@Nev", TBNev.Text);
                sqlCmd.Parameters.AddWithValue("@Gyartando", CBGyart.Checked.ToString());
                try
                {
                    DbManagment.SqlCommandRun(sqlCmd);
                    Close();
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
    }
}
