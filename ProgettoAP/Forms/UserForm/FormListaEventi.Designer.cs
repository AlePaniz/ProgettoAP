
namespace ProgettoAP.Forms.UserForm
{
    partial class FormListaEventi
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
            this.dtRisultati = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRisultati
            // 
            this.dtRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRisultati.Location = new System.Drawing.Point(197, 155);
            this.dtRisultati.Name = "dtRisultati";
            this.dtRisultati.RowHeadersWidth = 62;
            this.dtRisultati.RowTemplate.Height = 28;
            this.dtRisultati.Size = new System.Drawing.Size(574, 320);
            this.dtRisultati.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Eventi Disponibili:";
            // 
            // FormListaEventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtRisultati);
            this.Name = "FormListaEventi";
            this.Text = "FormListaEventi";
            this.Load += new System.EventHandler(this.FormListaEventi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRisultati;
        private System.Windows.Forms.Label label1;
    }
}