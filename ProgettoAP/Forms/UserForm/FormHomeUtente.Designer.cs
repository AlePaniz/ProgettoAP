﻿namespace ProgettoAP.Forms.UserForm
{
    partial class FormHomeUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeUtente));
            this.lblDescrizioneDesktop = new System.Windows.Forms.Label();
            this.lblTitoloDesktop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescrizioneDesktop
            // 
            this.lblDescrizioneDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescrizioneDesktop.AutoSize = true;
            this.lblDescrizioneDesktop.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizioneDesktop.Location = new System.Drawing.Point(236, 308);
            this.lblDescrizioneDesktop.Name = "lblDescrizioneDesktop";
            this.lblDescrizioneDesktop.Size = new System.Drawing.Size(765, 140);
            this.lblDescrizioneDesktop.TabIndex = 6;
            this.lblDescrizioneDesktop.Text = resources.GetString("lblDescrizioneDesktop.Text");
            this.lblDescrizioneDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitoloDesktop
            // 
            this.lblTitoloDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitoloDesktop.AutoSize = true;
            this.lblTitoloDesktop.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloDesktop.Location = new System.Drawing.Point(506, 161);
            this.lblTitoloDesktop.Name = "lblTitoloDesktop";
            this.lblTitoloDesktop.Size = new System.Drawing.Size(203, 49);
            this.lblTitoloDesktop.TabIndex = 5;
            this.lblTitoloDesktop.Text = "Chi siamo?";
            // 
            // FormHomeUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.lblDescrizioneDesktop);
            this.Controls.Add(this.lblTitoloDesktop);
            this.Name = "FormHomeUtente";
            this.Text = "FormHomeUtente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescrizioneDesktop;
        private System.Windows.Forms.Label lblTitoloDesktop;
    }
}