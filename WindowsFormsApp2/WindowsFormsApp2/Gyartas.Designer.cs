namespace erp
{
    partial class Gyartas
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkafolyamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kesz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mikor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(244, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lekérdezés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView1.Location = new System.Drawing.Point(9, 110);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(307, 439);
            this.treeView1.TabIndex = 2;
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_Click_1);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Munkafolyamat,
            this.Sorrend,
            this.Kesz,
            this.Nev,
            this.Mikor});
            this.dgvEmployee.Location = new System.Drawing.Point(322, 176);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(850, 373);
            this.dgvEmployee.TabIndex = 17;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Munkafolyamat
            // 
            this.Munkafolyamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Munkafolyamat.DataPropertyName = "Munkafolyamat";
            this.Munkafolyamat.HeaderText = "Munkafolyamat";
            this.Munkafolyamat.Name = "Munkafolyamat";
            this.Munkafolyamat.ReadOnly = true;
            // 
            // Sorrend
            // 
            this.Sorrend.DataPropertyName = "Sorrend";
            this.Sorrend.HeaderText = "Sorrend";
            this.Sorrend.Name = "Sorrend";
            this.Sorrend.ReadOnly = true;
            this.Sorrend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sorrend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Kesz
            // 
            this.Kesz.DataPropertyName = "Kesz";
            this.Kesz.HeaderText = "Kész";
            this.Kesz.Name = "Kesz";
            this.Kesz.ReadOnly = true;
            // 
            // Nev
            // 
            this.Nev.DataPropertyName = "Nev";
            this.Nev.HeaderText = "Nev";
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            // 
            // Mikor
            // 
            this.Mikor.DataPropertyName = "Mikor";
            this.Mikor.HeaderText = "Mikor";
            this.Mikor.Name = "Mikor";
            this.Mikor.ReadOnly = true;
            this.Mikor.Width = 150;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(668, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 68);
            this.button2.TabIndex = 18;
            this.button2.Text = "Részletek lekérdezése";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(956, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 68);
            this.button4.TabIndex = 19;
            this.button4.Text = "Mentés PDF-be";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(322, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(850, 60);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF|*.pdf";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(9, 66);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 28);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Kész";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(9, 26);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(177, 28);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Folyamatban lévő";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // Gyartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Gyartas";
            this.Text = "teszt";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkafolyamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorrend;
        private System.Windows.Forms.DataGridViewButtonColumn Kesz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mikor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}