namespace erp
{
    partial class GyartasiTerv
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
            this.BtnModosit = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkafolyamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sorrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSorrend = new System.Windows.Forms.NumericUpDown();
            this.TBMunka = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSorrend)).BeginInit();
            this.SuspendLayout();
            // 
            // CBTermekek
            // 
            this.CBTermekek.FormattingEnabled = true;
            this.CBTermekek.Location = new System.Drawing.Point(72, 36);
            this.CBTermekek.Name = "CBTermekek";
            this.CBTermekek.Size = new System.Drawing.Size(121, 21);
            this.CBTermekek.TabIndex = 19;
            this.CBTermekek.SelectedIndexChanged += new System.EventHandler(this.CBTermekek_SelectedIndexChanged);
            // 
            // BtnModosit
            // 
            this.BtnModosit.Location = new System.Drawing.Point(72, 140);
            this.BtnModosit.Name = "BtnModosit";
            this.BtnModosit.Size = new System.Drawing.Size(75, 23);
            this.BtnModosit.TabIndex = 17;
            this.BtnModosit.Text = "Módosít";
            this.BtnModosit.UseVisualStyleBackColor = true;
            this.BtnModosit.Click += new System.EventHandler(this.BtnModosit_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Munkafolyamat,
            this.Sorrend});
            this.dgvEmployee.Location = new System.Drawing.Point(75, 264);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.Size = new System.Drawing.Size(629, 150);
            this.dgvEmployee.TabIndex = 16;
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
            // NSorrend
            // 
            this.NSorrend.Location = new System.Drawing.Point(584, 140);
            this.NSorrend.Name = "NSorrend";
            this.NSorrend.Size = new System.Drawing.Size(120, 20);
            this.NSorrend.TabIndex = 23;
            // 
            // TBMunka
            // 
            this.TBMunka.Location = new System.Drawing.Point(584, 100);
            this.TBMunka.Name = "TBMunka";
            this.TBMunka.Size = new System.Drawing.Size(154, 20);
            this.TBMunka.TabIndex = 24;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(584, 186);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // GyartasiTerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.TBMunka);
            this.Controls.Add(this.NSorrend);
            this.Controls.Add(this.CBTermekek);
            this.Controls.Add(this.BtnModosit);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "GyartasiTerv";
            this.Text = "GyartasiTerv";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSorrend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTermekek;
        private System.Windows.Forms.Button BtnModosit;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkafolyamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sorrend;
        private System.Windows.Forms.NumericUpDown NSorrend;
        private System.Windows.Forms.TextBox TBMunka;
        private System.Windows.Forms.Button btnOk;
    }
}