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
    public partial class UjGyartas : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";
        bool commit = true;

        public UjGyartas()
        {
            InitializeComponent();
            ComboBoxFill();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (TBNev.TextLength < 3 || TBNev.TextLength > 40 || NDarab.Value < 1 || NDarab.Value > 1000000)
            {
                MessageBox.Show("Hibás név vagy mennyiség!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GyartasInditasa();
            }

        }
        void GyartasInditasa()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                //                SqlCommand cmd = new SqlCommand("select count(*) from GyartasRaktarEllenorzes where termekid =  @TermekId", sqlCon);

                SqlCommand cmd = new SqlCommand("select COUNT(*) from[GyartasRaktarEllenorzes] where[termekid] = 2", sqlCon);
                Int32 count = (Int32)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Nincs elég alapanyag!");
                }

                else
                {
                    cmd = new SqlCommand("begin tran INSERT INTO GyartasTermekek(SzuloId,TermekId,ElrendeloNeve,Darab,Kesz) output INSERTED.Id VALUES(@SzuloId,@TermekId,@ElrendeloNeve,@Darab,@Kesz)", sqlCon);

                    cmd.Parameters.AddWithValue("@SzuloId", DBNull.Value);
                    cmd.Parameters.AddWithValue("@TermekId", Int32.Parse(CBTermekek.SelectedValue.ToString()));
                    cmd.Parameters.AddWithValue("@ElrendeloNeve", TBNev.Text);
                    cmd.Parameters.AddWithValue("@Darab", NDarab.Value);
                    cmd.Parameters.AddWithValue("@Kesz", 0);
                    //  sqlCon.Open();
                    int gyId = (int)cmd.ExecuteScalar();

                    //   if (sqlCon.State == System.Data.ConnectionState.Open)
                    TermekAlkatreszEllenorzes(Int32.Parse(CBTermekek.SelectedValue.ToString()));

                    if (commit)
                    {
                        insertGyF(gyId, Int32.Parse(CBTermekek.SelectedValue.ToString()), sqlCon);

                        rekurziv(gyId, Int32.Parse(CBTermekek.SelectedValue.ToString()), Convert.ToInt32(NDarab.Value));
                    }



                    if (commit)
                    {
                        cmd = new SqlCommand("commit tran", sqlCon);
                        cmd.ExecuteScalar();
                    }
                    else
                    {
                        cmd = new SqlCommand("rollback tran", sqlCon);
                        cmd.ExecuteScalar();
                    }
                    sqlCon.Close();
                }
            }

        }
        void rekurziv(int gyId, int pId, int darab)
        {
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";

            sql = "select c.id, a.AlkatreszMennyiseg from  termek b " +
            "left join termekalkatresz a on a.termekid = b.id " +
            "left join termek c on a.alkatreszid = c.id " +
             "where b.id = @id " +
             "and c.Gyartando = 1";

            command = new SqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@id", pId);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                int termekid = Int32.Parse(reader.GetValue(0).ToString());
                TermekAlkatreszEllenorzes(termekid);

                SqlConnection cnn2;

                cnn2 = new SqlConnection(connectionString);
                cnn2.Open();
                SqlCommand cmd2 = new SqlCommand("begin tran INSERT INTO GyartasTermekek(SzuloId,TermekId,ElrendeloNeve,Darab,Kesz) output INSERTED.Id VALUES(@SzuloId,@TermekId,@ElrendeloNeve,@Darab,@Kesz)", cnn2);

                cmd2.Parameters.AddWithValue("@SzuloId", gyId);
                cmd2.Parameters.AddWithValue("@TermekId", termekid);
                cmd2.Parameters.AddWithValue("@ElrendeloNeve", TBNev.Text);
                cmd2.Parameters.AddWithValue("@Darab", darab * Int32.Parse(reader.GetValue(1).ToString()));
                cmd2.Parameters.AddWithValue("@Kesz", 0);


                int gyId2 = (int)cmd2.ExecuteScalar();
                if (commit)
                {
                    insertGyF(gyId2, Int32.Parse(reader.GetValue(0).ToString()), cnn2);
                    rekurziv(gyId2, Int32.Parse(reader.GetValue(0).ToString()), darab * Int32.Parse(reader.GetValue(1).ToString()));
                }
                if (commit)
                {

                    cmd2 = new SqlCommand("commit tran", cnn2);
                    cmd2.ExecuteScalar();
                }
                else
                {
                    cmd2 = new SqlCommand("rollback tran", cnn2);
                    cmd2.ExecuteScalar();
                
                }
                cnn2.Close();
            }



            cnn.Close();
        }
        // sqlconnectiont át kell adni hogy lehetséges legyen a rollback
        public void insertGyF(int gyId, int pId,SqlConnection sqlCon)
        {
            string query = "insert into gyartasiFolyamat (gyartasId, gyartasitervId)  select @gyId,id from[GyartasiTerv] where TermekId = @pId";
         //   using (SqlConnection sqlCon = new SqlConnection(connectionString))
          //  {
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@gyId", gyId);
                cmd.Parameters.AddWithValue("@pId", pId);

            //     sqlCon.Open();
            int rowsAffected = cmd.ExecuteNonQuery();// cmd.ExecuteScalar();
            if (rowsAffected < 1)
            {
                MessageBox.Show("Gyártási terv nincs beállítva!" );
                commit = false;
            }
           //     sqlCon.Close();
         //   }

        }
       void TermekAlkatreszEllenorzes (int termekid)
        {
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
           string sql = "select COUNT(*) from TermekAlkatresz where TermekId = @termekid";

                 command = new SqlCommand(sql, cnn);
                 command.Parameters.AddWithValue("@termekid", termekid);

                 int rowsAffected = (Int32)command.ExecuteScalar();
                 if (rowsAffected < 1)
                 {
                     MessageBox.Show("Nincs alkatrész beállítva!");
                     commit = false;
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
    }
}
