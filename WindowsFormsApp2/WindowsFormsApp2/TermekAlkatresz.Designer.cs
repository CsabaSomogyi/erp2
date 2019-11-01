namespace erp
{
    partial class TermekAlkatresz
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlkatreszId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Azonosito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Darab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBTermekek = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Új";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Módosít";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AlkatreszId,
            this.Azonosito,
            this.Nev,
            this.Darab});
            this.dgvEmployee.Location = new System.Drawing.Point(115, 329);
            this.dgvEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(839, 185);
            this.dgvEmployee.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // AlkatreszId
            // 
            this.AlkatreszId.DataPropertyName = "AlkatreszId";
            this.AlkatreszId.HeaderText = "AlkatreszId";
            this.AlkatreszId.Name = "AlkatreszId";
            this.AlkatreszId.ReadOnly = true;
            this.AlkatreszId.Visible = false;
            // 
            // Azonosito
            // 
            this.Azonosito.DataPropertyName = "Azonosito";
            this.Azonosito.HeaderText = "Azonosító";
            this.Azonosito.Name = "Azonosito";
            this.Azonosito.ReadOnly = true;
            // 
            // Nev
            // 
            this.Nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nev.DataPropertyName = "Nev";
            this.Nev.HeaderText = "Név";
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            // 
            // Darab
            // 
            this.Darab.DataPropertyName = "Darab";
            this.Darab.HeaderText = "Darab";
            this.Darab.Name = "Darab";
            this.Darab.ReadOnly = true;
            this.Darab.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Darab.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CBTermekek
            // 
            this.CBTermekek.FormattingEnabled = true;
            this.CBTermekek.Location = new System.Drawing.Point(265, 123);
            this.CBTermekek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBTermekek.Name = "CBTermekek";
            this.CBTermekek.Size = new System.Drawing.Size(160, 24);
            this.CBTermekek.TabIndex = 15;
            this.CBTermekek.SelectedIndexChanged += new System.EventHandler(this.CBTermekek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Válasz ki egy terméket";
            // 
            // TermekAlkatresz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBTermekek);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvEmployee);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TermekAlkatresz";
            this.Text = "p";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.ComboBox CBTermekek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlkatreszId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Azonosito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Darab;
        private System.Windows.Forms.Label label1;
    }
}