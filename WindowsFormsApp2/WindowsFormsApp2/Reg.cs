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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            tboxPass.PasswordChar = '*';
            tboxPass2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //     MessageBox.Show(GenerateSHA256String(tboxPass.Text).Length.ToString());
            //new DataTable();
            //    sqlDa.Fill(dtbl);

            if (TBoxCheck())
            {
                SqlCommand sqlCmd = new SqlCommand("insert into felhasznalok values(@user,@name,@pass)");
                sqlCmd.Parameters.AddWithValue("@user", tboxUser.Text);
                sqlCmd.Parameters.AddWithValue("@name", tboxName.Text);
                sqlCmd.Parameters.AddWithValue("@pass", GenerateSHA256String(tboxPass.Text));

                DbManagment.SqlCommandRun(sqlCmd);

                this.Hide();
                var form2 = new Login();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        bool TBoxCheck()
        {
            if (tboxUser.TextLength < 3 || tboxUser.TextLength > 20)
            {
                MessageBox.Show("Felhasználó név legalább 3 de maximum 50 karakter hosszú lehet!!");
                return false;
            }
            if (tboxName.TextLength < 3 || tboxName.TextLength > 50)
            {
                MessageBox.Show("Teljes név legalább 3 de maximum 50 karakter hosszú lehet!");
                return false;
            }
            if (tboxPass.TextLength < 8 || tboxPass.TextLength > 20 || tboxPass2.TextLength < 8 || tboxPass2.TextLength > 20)
            {
                MessageBox.Show("Jelszónak legalább 8 karakter hosszúnak kell lenni és maximum 20 karakter hosszú lehet!");
                return false;
            }
            if (tboxPass.Text != tboxPass2.Text)
            {
                MessageBox.Show("Nem egyeznek a jelszavak!");
                return false;
            }
            return true;
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
