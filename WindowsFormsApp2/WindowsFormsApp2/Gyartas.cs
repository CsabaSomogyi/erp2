using PdfSharp;
using PdfSharp.Pdf;
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
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace erp
{
    public partial class Gyartas : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;";

        public Gyartas()
        {
            InitializeComponent();
            dgvEmployee.AllowUserToAddRows = false;
            dataGridView1.AllowUserToAddRows = false;
            checkBox2.Checked = true;
            feltolt();

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            /* TreeNode node = new TreeNode("Parent");
             node.Nodes.Add("Child1");
             node.Nodes.Add("Child2");
             TreeNode node2 = new TreeNode("Parent2");
             node2.Nodes.Add("Child3");

             node.Nodes.Add(node2);
             treeView1.Nodes.Add("asd");
             treeView1.Nodes.Add(node);*/

            feltolt();



        }
        void feltolt()
        {
            treeView1.Nodes.Clear();
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";
            int kesz = checkBox2.Checked ? 0 : 1;
            sql = "select * from GyartasTermekek a " +
                "inner join Termek b on a.TermekId = b.Id " +
                "where a.Kesz = " + kesz + " and szuloid is null";
            command = new SqlCommand(sql, cnn);
            reader = command.ExecuteReader();
            //  MessageBox.Show("ITT");
            while (reader.Read())
            {
                string abc = reader.GetValue(reader.GetOrdinal("Azonosito")).ToString();
                TreeNode node = new TreeNode(abc);
                node.Name = reader.GetValue(reader.GetOrdinal("Id")).ToString();
                rekurziv(Int32.Parse(reader.GetValue(reader.GetOrdinal("Id")).ToString()), node);
                treeView1.Nodes.Add(node);
            }
            cnn.Close();
        }
        void rekurziv(int id, TreeNode node)
        {
            // MessageBox.Show(id.ToString());
            SqlConnection cnn;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader reader;
            string sql = "";
            sql = "select * from GyartasTermekek a	inner join Termek b on a.TermekId = b.Id 	where szuloid =" + id;
            command = new SqlCommand(sql, cnn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                //   MessageBox.Show(reader.GetValue(3).ToString());
                //    if (bool.Parse(reader.GetValue(3).ToString()) == true)
                //   {
                // new TreeNode( )
                TreeNode node2 = new TreeNode(reader.GetValue(reader.GetOrdinal("Azonosito")).ToString());
                node2.Name = reader.GetValue(reader.GetOrdinal("Id")).ToString();
                //  node.Tag = reader.GetValue(reader.GetOrdinal("Id")).ToString();
                node.Nodes.Add(node2);
                // node2.ke
                //                    node2.Nodes.Add()
                rekurziv(Int32.Parse(reader.GetValue(0).ToString()), node2);
                //   }
                //  else
                // {
                //     node.Nodes.Add(reader.GetValue(1).ToString());
                // }
            }



            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            TreeNode node2 = new TreeNode("EGY");
            node2.Name = "1";
            TreeNode node3 = new TreeNode("KETTO");
            node3.Name = "2";
            node2.Nodes.Add(node3);
            treeView1.Nodes.Add(node2); */


        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string output = saveFileDialog1.FileName;
            MessageBox.Show(output);
            saveFileDialog1.FileName = null;
            // MessageBox.Show(treeView1.SelectedNode.Name.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            /*  TreeNode node2 = new TreeNode("EGY");
               node2.Name = "1";
               TreeNode node3 = new TreeNode("KETTO");
               node3.Name = "2";
               node2.Nodes.Add(node3);
               treeView1.Nodes.Add(node2); */

            PopulateDataGridView();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView dgv = sender as DataGridView;
            //  if (dgv != null)
            // {
            //   DataGridViewButtonCell b = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
            //  MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            //    MessageBox.Show(dgvEmployee[Int32.Parse(e.ColumnIndex.ToString())+1, Int32.Parse(e.RowIndex.ToString())].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                if (dgvEmployee[Int32.Parse(e.ColumnIndex.ToString()) + 4, Int32.Parse(e.RowIndex.ToString())].Value.ToString() != "")
                {
                    //  MessageBox.Show(dgvEmployee[Int32.Parse(e.ColumnIndex.ToString()) + 4, Int32.Parse(e.RowIndex.ToString())].Value.ToString());
                    MessageBox.Show("Ez a folyamat már el van végezve!");
                }
                else
                {
                    string id = dgvEmployee[Int32.Parse(e.ColumnIndex.ToString()) + 1, Int32.Parse(e.RowIndex.ToString())].Value.ToString();
                    MunkaKesz(id);
                    PopulateDataGridView();
                }
            }


        }
        public void MunkaKesz(string id)
        {

            Nev dialogus = new Nev();

            dialogus.ShowDialog();
            string nev = dialogus.textBox1Text;


            if (dialogus.mentes)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("update gyartasifolyamat set nev = @nev , mikor = GETDATE() where id = @id", sqlCon);

                    cmd.Parameters.AddWithValue("@nev", nev);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    // ha minden kész akkor készre rakni
                    /*     cmd = new SqlCommand("IF " +
                            "(select count(*) from GyartasiFolyamat where GyartasId = @id and mikor is  null ) = 0 " +
                            "BEGIN " +
                                "update[GyartasTermekek] set Kesz = 1 where id = @id; " +
                            "END", sqlCon);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();*/
                }
                MessageBox.Show(id.ToString());
                SqlCommand sqlCmd = new SqlCommand("GyartasiFolyamatKesz");
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Id", id);
                DbManagment.SqlCommandRun(sqlCmd);

            }



        }
        void PopulateDataGridView()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                try
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("select a.id,b.Munkafolyamat,b.Sorrend ,a.Nev,a.Mikor from gyartasifolyamat a " +
                        "inner join GyartasiTerv b on a.GyartasiTervId = b.Id" +
                        " where a.GyartasId = " + treeView1.SelectedNode.Name.ToString() +
                        " order by b.Sorrend", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvEmployee.DataSource = dtbl;



                    sqlDa = new SqlDataAdapter("select a.Id,b.Nev,a.ElrendeloNeve,a.Darab,a.Kesz FROM[erp].[dbo].[GyartasTermekek] a " +
                    "inner join termek b on a.TermekId = b.Id where a.id = " + treeView1.SelectedNode.Name.ToString(), sqlCon);
                    dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dataGridView1.DataSource = dtbl;
                }
                catch (Exception)
                {
                    MessageBox.Show("Válasz ki egy elemet!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var FormHtml = @"<!DOCTYPE html>
                            <html>
                            <head>
                            <style>
                            .center {
                              text-align: center;
                              }
                            .date {
                            text-align: right;
                             margin : 5%;
                            }
                            table {
                              border-collapse: collapse;
                              margin : 5%;
                              width: 80%
                            }
                            table, td, th {
                              border: 1px solid black;
                            }
                            th, td {
                              padding: 5px;
                            }
                            h2 {
                            margin : 5%;
                            }
                            </style>
                            </head>
                            <body>";
            FormHtml += "<h1 class=\"center\">Cégnév</h1>";
            FormHtml += @"<h2>Termék</h2>
                            <table >
                              <tr>
                                <th>Név</th>
                                <th>Elrendelő neve</th>
                                <th>Darab</th>
                                <th>Elkészült</th>
                              </tr>
                              <tr>";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                FormHtml += "<td>" + row.Cells["Nev"].Value + "</td>";
                FormHtml += "<td>" + row.Cells["ElrendeloNeve"].Value + "</td>";
                FormHtml += "<td>" + row.Cells["Darab"].Value + "</td>";
                FormHtml += "<td>" + row.Cells["Kesz"].Value + "</td>";
            }
            FormHtml += @"</tr>
                        </table>
                        <h2>Gyártási folyamat:</h2>
                        <table >
                          <tr>
                            <th>Munkafolyamat</th>
                            <th>Sorrend</th>
                            <th>Név</th>
                            <th>Dátum</th>
                          </tr> ";
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                FormHtml += "<tr><td>" + row.Cells["Munkafolyamat"].Value + "</td>";
                FormHtml += "<td>" + row.Cells["Sorrend"].Value + "</td>";
                FormHtml += "<td>" + row.Cells["Nev"].Value + "</td>";
                FormHtml += "<td>" + row.Cells["Mikor"].Value + "</td></tr>";
            }
            FormHtml += "</tr></table><div class=\"date\">Dátum: " + DateTime.UtcNow.ToString() + "</div></body></html>";

            //    IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            PdfDocument pdf = PdfGenerator.GeneratePdf(FormHtml, PageSize.A4);
            //   var pdf = Renderer.RenderHtmlAsPdf(FormHtml);

            saveFileDialog1.ShowDialog();
            string output = saveFileDialog1.FileName;

            saveFileDialog1.FileName = null;

            pdf.Save(output);

        }

        private void AsdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Termek();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click_1(object sender, MouseEventArgs e)
        {
            //   MessageBox.Show(treeView1.SelectedImageKey.ToString());
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            UjGyartas dialogus = new UjGyartas();

            dialogus.ShowDialog();
        }
    }
}
