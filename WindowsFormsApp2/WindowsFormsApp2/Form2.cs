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
using System.Windows.Forms.DataVisualization.Charting;

namespace erp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DiagramFeltolt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new TermekAlkatresz();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Termek();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        void DiagramFeltolt()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=erp; Integrated Security=True;");
            con.Open();
            // SqlCommand cmd = new SqlCommand("select id, nev name, id salary from Termek", con);
            SqlCommand cmd = new SqlCommand("select * from LegaktivabbDolgozok", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet st = new DataSet();
            sda.Fill(st, "LegaktivabbDolgozok");

            chart1.DataSource = st.Tables["LegaktivabbDolgozok"];
            chart1.Series["Series1"].XValueMember = "nev";
            chart1.Series["Series1"].YValueMembers = "db";

            this.chart1.Titles.Add("Legaktívabb dolgozók!");
            //      chart1.Series["Series1"].ChartType = SeriesChartType.Bar;

            chart1.Series["Series1"].IsValueShownAsLabel = true;

            cmd = new SqlCommand("select * from LegaktivabbTermekek", con);
            sda = new SqlDataAdapter(cmd);

            sda.Fill(st, "LegaktivabbTermekek");

            chart2.DataSource = st.Tables["LegaktivabbTermekek"];

            chart2.Series["Series1"].XValueMember = "Azonosito";
            chart2.Series["Series1"].YValueMembers = "db";

            this.chart2.Titles.Add("Legaktívabb termékek!");
            chart2.Series["Series1"].IsValueShownAsLabel = true;
            con.Close();
        }

        private void btnKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnGyT_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new GyartasiTerv();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnGyartas_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Gyartas();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnRaktar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Raktar();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
