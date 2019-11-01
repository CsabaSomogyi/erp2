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

        public UjGyartas()
        {
            InitializeComponent();
            ComboBoxFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                //                SqlCommand cmd = new SqlCommand("select count(*) from GyartasRaktarEllenorzes where termekid =  @TermekId", sqlCon);

                SqlCommand cmd = new SqlCommand("INSERT INTO GyartasTermekek(SzuloId,TermekId,ElrendeloNeve,Darab,Kesz) output INSERTED.Id VALUES(@SzuloId,@TermekId,@ElrendeloNeve,@Darab,@Kesz)", sqlCon);

                cmd.Parameters.AddWithValue("@SzuloId", DBNull.Value);
                cmd.Parameters.AddWithValue("@TermekId", Int32.Parse(CBTermekek.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@ElrendeloNeve", TBNev.Text);
                cmd.Parameters.AddWithValue("@Darab", NDarab.Value);
                cmd.Parameters.AddWithValue("@Kesz", 0);
                //  sqlCon.Open();
                int gyId = (int)cmd.ExecuteScalar();

                if (sqlCon.State == System.Data.ConnectionState.Open)


                    insertGyF(gyId, Int32.Parse(CBTermekek.SelectedValue.ToString()));
                sqlCon.Close();
                // MessageBox.Show(modified.ToString());
                //      }
                rekurziv(gyId, Int32.Parse(CBTermekek.SelectedValue.ToString()), Convert.ToInt32(NDarab.Value));

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
                SqlConnection cnn2;

                cnn2 = new SqlConnection(connectionString);
                cnn2.Open();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO GyartasTermekek(SzuloId,TermekId,ElrendeloNeve,Darab,Kesz) output INSERTED.Id VALUES(@SzuloId,@TermekId,@ElrendeloNeve,@Darab,@Kesz)", cnn2);

                cmd2.Parameters.AddWithValue("@SzuloId", gyId);
                cmd2.Parameters.AddWithValue("@TermekId", Int32.Parse(reader.GetValue(0).ToString()));
                cmd2.Parameters.AddWithValue("@ElrendeloNeve", TBNev.Text);
                cmd2.Parameters.AddWithValue("@Darab", darab * Int32.Parse(reader.GetValue(1).ToString()));
                cmd2.Parameters.AddWithValue("@Kesz", 0);


                int gyId2 = (int)cmd2.ExecuteScalar();
                insertGyF(gyId2, Int32.Parse(reader.GetValue(0).ToString()));
                rekurziv(gyId2, Int32.Parse(reader.GetValue(0).ToString()), darab * Int32.Parse(reader.GetValue(1).ToString()));
                cnn2.Close();
            }



            cnn.Close();
        }
        public void insertGyF(int gyId, int pId)
        {
            string query = "insert into gyartasiFolyamat (gyartasId, gyartasitervId)  select @gyId,id from[GyartasiTerv] where TermekId = @pId";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@gyId", gyId);
                cmd.Parameters.AddWithValue("@pId", pId);

                sqlCon.Open();
                cmd.ExecuteScalar();
                sqlCon.Close();
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
