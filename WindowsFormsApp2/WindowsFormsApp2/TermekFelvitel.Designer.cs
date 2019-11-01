namespace erp
{
    partial class TermekFelvitel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBGyart = new System.Windows.Forms.CheckBox();
            this.TBNev = new System.Windows.Forms.TextBox();
            this.TBAzon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TBId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Név";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gyártandó";
            // 
            // CBGyart
            // 
            this.CBGyart.AutoSize = true;
            this.CBGyart.Location = new System.Drawing.Point(407, 243);
            this.CBGyart.Name = "CBGyart";
            this.CBGyart.Size = new System.Drawing.Size(15, 14);
            this.CBGyart.TabIndex = 12;
            this.CBGyart.UseVisualStyleBackColor = true;
            // 
            // TBNev
            // 
            this.TBNev.Location = new System.Drawing.Point(407, 217);
            this.TBNev.Name = "TBNev";
            this.TBNev.Size = new System.Drawing.Size(100, 20);
            this.TBNev.TabIndex = 11;
            // 
            // TBAzon
            // 
            this.TBAzon.Location = new System.Drawing.Point(407, 191);
            this.TBAzon.Name = "TBAzon";
            this.TBAzon.Size = new System.Drawing.Size(100, 20);
            this.TBAzon.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(341, 146);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(100, 20);
            this.TBId.TabIndex = 18;
            this.TBId.Visible = false;
            // 
            // TermekFelvitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBGyart);
            this.Controls.Add(this.TBNev);
            this.Controls.Add(this.TBAzon);
            this.Name = "TermekFelvitel";
            this.Text = "TermekFelvitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBGyart;
        private System.Windows.Forms.TextBox TBNev;
        private System.Windows.Forms.TextBox TBAzon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TBId;
    }
}