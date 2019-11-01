using System.Windows.Forms;

namespace erp
{
    partial class Reg
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
            this.tboxPass = new System.Windows.Forms.TextBox();
            this.tboxUser = new System.Windows.Forms.TextBox();
            this.tboxPass2 = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxPass
            // 
            this.tboxPass.Location = new System.Drawing.Point(531, 274);
            this.tboxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPass.Name = "tboxPass";
            this.tboxPass.Size = new System.Drawing.Size(132, 22);
            this.tboxPass.TabIndex = 5;
            // 
            // tboxUser
            // 
            this.tboxUser.Location = new System.Drawing.Point(531, 121);
            this.tboxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxUser.Name = "tboxUser";
            this.tboxUser.Size = new System.Drawing.Size(132, 22);
            this.tboxUser.TabIndex = 4;
            // 
            // tboxPass2
            // 
            this.tboxPass2.Location = new System.Drawing.Point(531, 315);
            this.tboxPass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxPass2.Name = "tboxPass2";
            this.tboxPass2.Size = new System.Drawing.Size(132, 22);
            this.tboxPass2.TabIndex = 6;
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(531, 196);
            this.tboxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(132, 22);
            this.tboxName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Felhasználó név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Teljes név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jelszó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 315);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jelszó újra";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(599, 386);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 28);
            this.btnReg.TabIndex = 12;
            this.btnReg.Text = "Regisztráció";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(373, 386);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Login";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxPass2);
            this.Controls.Add(this.tboxPass);
            this.Controls.Add(this.tboxUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reg";
            this.Text = "Reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxPass;
        private System.Windows.Forms.TextBox tboxUser;
        private System.Windows.Forms.TextBox tboxPass2;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Button btnReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
    }
}