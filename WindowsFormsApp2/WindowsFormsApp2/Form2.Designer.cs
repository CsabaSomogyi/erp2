﻿namespace erp
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
            this.btnTA.Location = new System.Drawing.Point(12, 204);
            this.btnTA.Name = "btnTA";
            this.btnTA.Size = new System.Drawing.Size(143, 23);
            this.btnTA.TabIndex = 0;
            this.btnTA.Text = "Termék Alkatrész";
            this.btnTA.UseVisualStyleBackColor = true;
            this.btnTA.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(188, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(831, 293);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // btnTermek
            // 
            this.btnTermek.Location = new System.Drawing.Point(12, 156);
            this.btnTermek.Name = "btnTermek";
            this.btnTermek.Size = new System.Drawing.Size(143, 23);
            this.btnTermek.TabIndex = 2;
            this.btnTermek.Text = "Termék";
            this.btnTermek.UseVisualStyleBackColor = true;
            this.btnTermek.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGyT
            // 
            this.btnGyT.Location = new System.Drawing.Point(12, 262);
            this.btnGyT.Name = "btnGyT";
            this.btnGyT.Size = new System.Drawing.Size(143, 23);
            this.btnGyT.TabIndex = 4;
            this.btnGyT.Text = "Gyártási terv";
            this.btnGyT.UseVisualStyleBackColor = true;
            this.btnGyT.Click += new System.EventHandler(this.btnGyT_Click);
            // 
            // btnGyartas
            // 
            this.btnGyartas.Location = new System.Drawing.Point(12, 315);
            this.btnGyartas.Name = "btnGyartas";
            this.btnGyartas.Size = new System.Drawing.Size(143, 23);
            this.btnGyartas.TabIndex = 5;
            this.btnGyartas.Text = "Gyártás";
            this.btnGyartas.UseVisualStyleBackColor = true;
            this.btnGyartas.Click += new System.EventHandler(this.btnGyartas_Click);
            // 
            // btnRaktar
            // 
            this.btnRaktar.Location = new System.Drawing.Point(12, 357);
            this.btnRaktar.Name = "btnRaktar";
            this.btnRaktar.Size = new System.Drawing.Size(143, 23);
            this.btnRaktar.TabIndex = 6;
            this.btnRaktar.Text = "Raktár";
            this.btnRaktar.UseVisualStyleBackColor = true;
            this.btnRaktar.Click += new System.EventHandler(this.btnRaktar_Click);
            // 
            // btnKi
            // 
            this.btnKi.Location = new System.Drawing.Point(12, 12);
            this.btnKi.Name = "btnKi";
            this.btnKi.Size = new System.Drawing.Size(143, 23);
            this.btnKi.TabIndex = 7;
            this.btnKi.Text = "Kijelentkezés";
            this.btnKi.UseVisualStyleBackColor = true;
            this.btnKi.Click += new System.EventHandler(this.btnKi_Click);
            // 
            // chart2
            // 
            this.chart2.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(188, 315);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.EmptyPointStyle.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(831, 293);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 620);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnKi);
            this.Controls.Add(this.btnRaktar);
            this.Controls.Add(this.btnGyartas);
            this.Controls.Add(this.btnGyT);
            this.Controls.Add(this.btnTermek);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTA);
            this.Name = "Form2";
            this.Text = "Form2";
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