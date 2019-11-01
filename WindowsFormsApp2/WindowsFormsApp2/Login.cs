using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{

    public partial class Login : Form
    {
        static string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";

        public Login()
        {
            InitializeComponent();
            tboxPass.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("select * from felhasznalok where felhasznalonev = @user and jelszo = @pass");
            sqlCmd.Parameters.AddWithValue("@user", tboxUser.Text);
            sqlCmd.Parameters.AddWithValue("@pass", GenerateSHA256String(tboxPass.Text));
            int count = 0;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;
                SqlDataReader sqlreader = sqlCmd.ExecuteReader();
                // SqlDataReader reader = DbManagment.SqlDataRead(sqlCmd);


                while (sqlreader.Read())
                {
                    count++;
                }
            }

            if (count > 0)
            {
                count = 0;
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Felhasználónév vagy Jelszó helytelen!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string GenerateSHA256String(string inputString)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Reg();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
