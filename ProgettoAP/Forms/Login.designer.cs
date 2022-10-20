
namespace ProgettoAP.Forms
{
    partial class Login
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
            this.bLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.cbCeo = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbRegistrazione = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(321, 247);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(119, 62);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(372, 94);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 26);
            this.tbEmail.TabIndex = 3;
            // 
            // tbPsw
            // 
            this.tbPsw.Location = new System.Drawing.Point(372, 152);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.Size = new System.Drawing.Size(100, 26);
            this.tbPsw.TabIndex = 4;
            // 
            // cbCeo
            // 
            this.cbCeo.AutoSize = true;
            this.cbCeo.Location = new System.Drawing.Point(546, 198);
            this.cbCeo.Name = "cbCeo";
            this.cbCeo.Size = new System.Drawing.Size(107, 24);
            this.cbCeo.TabIndex = 5;
            this.cbCeo.Text = "Login Ceo";
            this.cbCeo.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // lbRegistrazione
            // 
            this.lbRegistrazione.AutoSize = true;
            this.lbRegistrazione.LinkColor = System.Drawing.Color.Black;
            this.lbRegistrazione.Location = new System.Drawing.Point(576, 289);
            this.lbRegistrazione.Name = "lbRegistrazione";
            this.lbRegistrazione.Size = new System.Drawing.Size(77, 20);
            this.lbRegistrazione.TabIndex = 7;
            this.lbRegistrazione.TabStop = true;
            this.lbRegistrazione.Text = "Registrati";
            this.lbRegistrazione.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbRegistrazione_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 648);
            this.Controls.Add(this.lbRegistrazione);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbCeo);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.CheckBox cbCeo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lbRegistrazione;
    }
}