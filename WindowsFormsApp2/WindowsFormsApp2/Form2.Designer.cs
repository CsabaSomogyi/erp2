namespace erp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.btnTA = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTermek = new System.Windows.Forms.Button();
            this.btnGyT = new System.Windows.Forms.Button();
            this.btnGyartas = new System.Windows.Forms.Button();
            this.btnRaktar = new System.Windows.Forms.Button();
            this.btnKi = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTA
            // 
            resources.ApplyResources(this.btnTA, "btnTA");
            this.btnTA.Name = "btnTA";
            this.btnTA.UseVisualStyleBackColor = true;
            this.btnTA.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            resources.ApplyResources(this.chart1, "chart1");
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Lezárt folyamat db";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            // 
            // btnTermek
            // 
            resources.ApplyResources(this.btnTermek, "btnTermek");
            this.btnTermek.Name = "btnTermek";
            this.btnTermek.UseVisualStyleBackColor = true;
            this.btnTermek.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGyT
            // 
            resources.ApplyResources(this.btnGyT, "btnGyT");
            this.btnGyT.Name = "btnGyT";
            this.btnGyT.UseVisualStyleBackColor = true;
            this.btnGyT.Click += new System.EventHandler(this.btnGyT_Click);
            // 
            // btnGyartas
            // 
            resources.ApplyResources(this.btnGyartas, "btnGyartas");
            this.btnGyartas.Name = "btnGyartas";
            this.btnGyartas.UseVisualStyleBackColor = true;
            this.btnGyartas.Click += new System.EventHandler(this.btnGyartas_Click);
            // 
            // btnRaktar
            // 
            resources.ApplyResources(this.btnRaktar, "btnRaktar");
            this.btnRaktar.Name = "btnRaktar";
            this.btnRaktar.UseVisualStyleBackColor = true;
            this.btnRaktar.Click += new System.EventHandler(this.btnRaktar_Click);
            // 
            // btnKi
            // 
            resources.ApplyResources(this.btnKi, "btnKi");
            this.btnKi.Name = "btnKi";
            this.btnKi.UseVisualStyleBackColor = true;
            this.btnKi.Click += new System.EventHandler(this.btnKi_Click);
            // 
            // chart2
            // 
            this.chart2.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            resources.ApplyResources(this.chart2, "chart2");
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart2.Series.Add(series2);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnKi);
            this.Controls.Add(this.btnRaktar);
            this.Controls.Add(this.btnGyartas);
            this.Controls.Add(this.btnGyT);
            this.Controls.Add(this.btnTermek);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnTermek;
        private System.Windows.Forms.Button btnGyT;
        private System.Windows.Forms.Button btnGyartas;
        private System.Windows.Forms.Button btnRaktar;
        private System.Windows.Forms.Button btnKi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}