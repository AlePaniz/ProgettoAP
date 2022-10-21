
namespace ProgettoAP.Forms
{
    partial class Registrazione
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tUser = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.cbOrg = new System.Windows.Forms.ComboBox();
            this.tOrg = new System.Windows.Forms.Label();
            this.checkBoxOrg = new System.Windows.Forms.CheckBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(466, 175);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(162, 26);
            this.tbNome.TabIndex = 0;
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(466, 225);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(162, 26);
            this.tbCognome.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(466, 336);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 26);
            this.tbPassword.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(466, 280);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 26);
            this.tbEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cognome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // tUser
            // 
            this.tUser.AutoSize = true;
            this.tUser.Location = new System.Drawing.Point(307, 133);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(87, 20);
            this.tUser.TabIndex = 9;
            this.tUser.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "REGISTRAZIONE";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(466, 130);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 26);
            this.tbUser.TabIndex = 10;
            // 
            // cbOrg
            // 
            this.cbOrg.FormattingEnabled = true;
            this.cbOrg.Location = new System.Drawing.Point(466, 130);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Size = new System.Drawing.Size(162, 28);
            this.cbOrg.TabIndex = 11;
            // 
            // tOrg
            // 
            this.tOrg.AutoSize = true;
            this.tOrg.Location = new System.Drawing.Point(307, 133);
            this.tOrg.Name = "tOrg";
            this.tOrg.Size = new System.Drawing.Size(118, 20);
            this.tOrg.TabIndex = 12;
            this.tOrg.Text = "Oganizzazione:";
            // 
            // checkBoxOrg
            // 
            this.checkBoxOrg.AutoSize = true;
            this.checkBoxOrg.Location = new System.Drawing.Point(311, 425);
            this.checkBoxOrg.Name = "checkBoxOrg";
            this.checkBoxOrg.Size = new System.Drawing.Size(135, 24);
            this.checkBoxOrg.TabIndex = 13;
            this.checkBoxOrg.Text = "Organizzatore";
            this.checkBoxOrg.UseVisualStyleBackColor = true;
            this.checkBoxOrg.CheckedChanged += new System.EventHandler(this.checkBoxOrg_CheckedChanged);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(519, 410);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(109, 39);
            this.btnReg.TabIndex = 14;
            this.btnReg.Text = "Registrati";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 572);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.checkBoxOrg);
            this.Controls.Add(this.tOrg);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.tbNome);
            this.Name = "Registrazione";
            this.Text = "Registrazione";
            this.Load += new System.EventHandler(this.Registrazione_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.ComboBox cbOrg;
        private System.Windows.Forms.Label tOrg;
        private System.Windows.Forms.CheckBox checkBoxOrg;
        private System.Windows.Forms.Button btnReg;
    }
}