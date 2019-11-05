using erp;
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

namespace WindowsFormsApp2
{
    public partial class GyartasiTervFelvitel : Form
    {
        int id;
        int TermekId;
        public GyartasiTervFelvitel(int id, int termekid)
        {
            InitializeComponent();
            this.id = id;
            TermekId = termekid;
        }

        public GyartasiTervFelvitel(int id, int termekid, string munkafolyamat, int sorrend)
        {
            InitializeComponent();
            this.id = id;
            TermekId = termekid;
            NSorrend.Value = sorrend;
            TBMunka.Text = munkafolyamat;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (TBMunka.TextLength < 3 || TBMunka.TextLength >50 || NSorrend.Value < 1 ||  NSorrend.Value > 1000)
            {
                MessageBox.Show("Hibás adatok!");
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("GyartasiTervModosit");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                if (id == 0)//Insert
                    sqlCmd.Parameters.AddWithValue("@Id", 0);
                else//update
                    sqlCmd.Parameters.AddWithValue("@Id", id);
                sqlCmd.Parameters.AddWithValue("@TermekId", TermekId);
                sqlCmd.Parameters.AddWithValue("@Munkafolyamat", TBMunka.Text.ToString());
                sqlCmd.Parameters.AddWithValue("@Sorrend", NSorrend.Value);
                try
                {
                    DbManagment.SqlCommandRun(sqlCmd);
                    Close();
                }
                catch (Exception exp)
                {
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
