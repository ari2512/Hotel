namespace Hotel
{
    partial class frm_photo
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pbx_picture = new System.Windows.Forms.PictureBox();
            this.lbl_presentazione = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("MS Mincho", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_titolo.Location = new System.Drawing.Point(71, 29);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(319, 35);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "HOTEL CONCHIGLIA";
            // 
            // pbx_picture
            // 
            this.pbx_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx_picture.Image = global::Hotel.Properties.Resources.hotel_presidente_4s;
            this.pbx_picture.Location = new System.Drawing.Point(425, 1);
            this.pbx_picture.Name = "pbx_picture";
            this.pbx_picture.Size = new System.Drawing.Size(356, 231);
            this.pbx_picture.TabIndex = 1;
            this.pbx_picture.TabStop = false;
            // 
            // lbl_presentazione
            // 
            this.lbl_presentazione.AutoSize = true;
            this.lbl_presentazione.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentazione.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_presentazione.Location = new System.Drawing.Point(91, 64);
            this.lbl_presentazione.Name = "lbl_presentazione";
            this.lbl_presentazione.Size = new System.Drawing.Size(252, 13);
            this.lbl_presentazione.TabIndex = 2;
            this.lbl_presentazione.Text = "Benvenuti nel sito del nostro hotel";
            // 
            // frm_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 467);
            this.Controls.Add(this.lbl_presentazione);
            this.Controls.Add(this.pbx_picture);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "frm_photo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pbx_picture;
        private System.Windows.Forms.Label lbl_presentazione;
    }
}

