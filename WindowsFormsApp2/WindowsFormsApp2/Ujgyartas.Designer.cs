﻿namespace erp
{
    partial class UjGyartas
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
            this.CBTermekek = new System.Windows.Forms.ComboBox();
            this.NDarab = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.TBNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NDarab)).BeginInit();
            this.SuspendLayout();
            // 
            // CBTermekek
            // 
            this.CBTermekek.FormattingEnabled = true;
            this.CBTermekek.Location = new System.Drawing.Point(111, 112);
            this.CBTermekek.Name = "CBTermekek";
            this.CBTermekek.Size = new System.Drawing.Size(121, 21);
            this.CBTermekek.TabIndex = 16;
            // 
            // NDarab
            // 
            this.NDarab.Location = new System.Drawing.Point(313, 113);
            this.NDarab.Name = "NDarab";
            this.NDarab.Size = new System.Drawing.Size(120, 20);
            this.NDarab.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Gyártás megkezdése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TBNev
            // 
            this.TBNev.Location = new System.Drawing.Point(554, 112);
            this.TBNev.Name = "TBNev";
            this.TBNev.Size = new System.Drawing.Size(100, 20);
            this.TBNev.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(579, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "nev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Termek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Darab";
            // 
            // UjGyartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBNev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NDarab);
            this.Controls.Add(this.CBTermekek);
            this.Name = "UjGyartas";
            this.Text = "UjGyartas";
            ((System.ComponentModel.ISupportInitialize)(this.NDarab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTermekek;
        private System.Windows.Forms.NumericUpDown NDarab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}