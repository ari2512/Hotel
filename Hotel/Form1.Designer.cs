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
            this.lbl_scelte = new System.Windows.Forms.Label();
            this.lbl_sottotitolo = new System.Windows.Forms.Label();
            this.lbl_tipostanza = new System.Windows.Forms.Label();
            this.cmb_tipostanza = new System.Windows.Forms.ComboBox();
            this.lbl_stagione = new System.Windows.Forms.Label();
            this.lbl_giorni = new System.Windows.Forms.Label();
            this.txt_ngiorni = new System.Windows.Forms.TextBox();
            this.lbl_servizio = new System.Windows.Forms.Label();
            this.chk_si = new System.Windows.Forms.CheckBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_prenota = new System.Windows.Forms.Button();
            this.cmb_stagione = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("MS Mincho", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_titolo.Location = new System.Drawing.Point(184, 16);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(420, 48);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "HOTEL CONCHIGLIA";
            // 
            // pbx_picture
            // 
            this.pbx_picture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbx_picture.Image = global::Hotel.Properties.Resources.hotel_presidente_4s;
            this.pbx_picture.Location = new System.Drawing.Point(621, 1);
            this.pbx_picture.Name = "pbx_picture";
            this.pbx_picture.Size = new System.Drawing.Size(337, 211);
            this.pbx_picture.TabIndex = 1;
            this.pbx_picture.TabStop = false;
            // 
            // lbl_presentazione
            // 
            this.lbl_presentazione.AutoSize = true;
            this.lbl_presentazione.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentazione.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_presentazione.Location = new System.Drawing.Point(225, 64);
            this.lbl_presentazione.Name = "lbl_presentazione";
            this.lbl_presentazione.Size = new System.Drawing.Size(287, 15);
            this.lbl_presentazione.TabIndex = 2;
            this.lbl_presentazione.Text = "Benvenuti nel sito del nostro hotel";
            // 
            // lbl_scelte
            // 
            this.lbl_scelte.AutoSize = true;
            this.lbl_scelte.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scelte.Location = new System.Drawing.Point(0, 88);
            this.lbl_scelte.Name = "lbl_scelte";
            this.lbl_scelte.Size = new System.Drawing.Size(583, 13);
            this.lbl_scelte.TabIndex = 3;
            this.lbl_scelte.Text = "Immergiti in un\'atmosfera di pura eleganza, relax e comfort senza tempo.";
            // 
            // lbl_sottotitolo
            // 
            this.lbl_sottotitolo.AutoSize = true;
            this.lbl_sottotitolo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sottotitolo.Location = new System.Drawing.Point(0, 104);
            this.lbl_sottotitolo.Name = "lbl_sottotitolo";
            this.lbl_sottotitolo.Size = new System.Drawing.Size(455, 13);
            this.lbl_sottotitolo.TabIndex = 4;
            this.lbl_sottotitolo.Text = " Lasciati coccolare da un\'esperienza di soggiorno unica.";
            // 
            // lbl_tipostanza
            // 
            this.lbl_tipostanza.AutoSize = true;
            this.lbl_tipostanza.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipostanza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tipostanza.Location = new System.Drawing.Point(0, 152);
            this.lbl_tipostanza.Name = "lbl_tipostanza";
            this.lbl_tipostanza.Size = new System.Drawing.Size(392, 13);
            this.lbl_tipostanza.TabIndex = 5;
            this.lbl_tipostanza.Text = "Selezionare il tipo di stanza che si desidera prenotare";
            // 
            // cmb_tipostanza
            // 
            this.cmb_tipostanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipostanza.FormattingEnabled = true;
            this.cmb_tipostanza.Items.AddRange(new object[] {
            "BASE (B)",
            "MEDIUM (M)",
            "ALTA (A)"});
            this.cmb_tipostanza.Location = new System.Drawing.Point(398, 148);
            this.cmb_tipostanza.Name = "cmb_tipostanza";
            this.cmb_tipostanza.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipostanza.TabIndex = 6;
            this.cmb_tipostanza.Text = "Seleziona";
            // 
            // lbl_stagione
            // 
            this.lbl_stagione.AutoSize = true;
            this.lbl_stagione.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stagione.Location = new System.Drawing.Point(0, 192);
            this.lbl_stagione.Name = "lbl_stagione";
            this.lbl_stagione.Size = new System.Drawing.Size(224, 13);
            this.lbl_stagione.TabIndex = 9;
            this.lbl_stagione.Text = "Selezionare il tipo di stagione";
            // 
            // lbl_giorni
            // 
            this.lbl_giorni.AutoSize = true;
            this.lbl_giorni.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giorni.Location = new System.Drawing.Point(0, 229);
            this.lbl_giorni.Name = "lbl_giorni";
            this.lbl_giorni.Size = new System.Drawing.Size(273, 13);
            this.lbl_giorni.TabIndex = 11;
            this.lbl_giorni.Text = "Immettere il numero di giorni previsti";
            // 
            // txt_ngiorni
            // 
            this.txt_ngiorni.Location = new System.Drawing.Point(273, 225);
            this.txt_ngiorni.Name = "txt_ngiorni";
            this.txt_ngiorni.Size = new System.Drawing.Size(100, 20);
            this.txt_ngiorni.TabIndex = 12;
            // 
            // lbl_servizio
            // 
            this.lbl_servizio.AutoSize = true;
            this.lbl_servizio.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servizio.Location = new System.Drawing.Point(0, 270);
            this.lbl_servizio.Name = "lbl_servizio";
            this.lbl_servizio.Size = new System.Drawing.Size(273, 13);
            this.lbl_servizio.TabIndex = 13;
            this.lbl_servizio.Text = "Usufruire del servizio del parcheggio?";
            // 
            // chk_si
            // 
            this.chk_si.AutoSize = true;
            this.chk_si.Location = new System.Drawing.Point(273, 271);
            this.chk_si.Name = "chk_si";
            this.chk_si.Size = new System.Drawing.Size(36, 17);
            this.chk_si.TabIndex = 14;
            this.chk_si.Text = "SI";
            this.chk_si.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("MingLiU_MSCS-ExtB", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(12, 301);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(103, 11);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "SPESA TOTALE: ";
            // 
            // btn_prenota
            // 
            this.btn_prenota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prenota.Location = new System.Drawing.Point(12, 317);
            this.btn_prenota.Name = "btn_prenota";
            this.btn_prenota.Size = new System.Drawing.Size(131, 39);
            this.btn_prenota.TabIndex = 17;
            this.btn_prenota.Text = "PRENOTA";
            this.btn_prenota.UseVisualStyleBackColor = true;
            this.btn_prenota.Click += new System.EventHandler(this.btn_prenota_Click);
            // 
            // cmb_stagione
            // 
            this.cmb_stagione.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stagione.FormattingEnabled = true;
            this.cmb_stagione.Items.AddRange(new object[] {
            "ALTA STAGIONE (AS)",
            "MEDIA STAGIONE (MS)",
            "BASSA STAGIONE (BS)"});
            this.cmb_stagione.Location = new System.Drawing.Point(230, 192);
            this.cmb_stagione.Name = "cmb_stagione";
            this.cmb_stagione.Size = new System.Drawing.Size(121, 21);
            this.cmb_stagione.TabIndex = 18;
            this.cmb_stagione.Text = "Seleziona";
            // 
            // frm_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(961, 565);
            this.Controls.Add(this.cmb_stagione);
            this.Controls.Add(this.btn_prenota);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.chk_si);
            this.Controls.Add(this.lbl_servizio);
            this.Controls.Add(this.txt_ngiorni);
            this.Controls.Add(this.lbl_giorni);
            this.Controls.Add(this.lbl_stagione);
            this.Controls.Add(this.cmb_tipostanza);
            this.Controls.Add(this.lbl_tipostanza);
            this.Controls.Add(this.lbl_sottotitolo);
            this.Controls.Add(this.lbl_scelte);
            this.Controls.Add(this.lbl_presentazione);
            this.Controls.Add(this.pbx_picture);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "frm_photo";
            this.Text = "WWW.HOTELCONCHIGLIA";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pbx_picture;
        private System.Windows.Forms.Label lbl_presentazione;
        private System.Windows.Forms.Label lbl_scelte;
        private System.Windows.Forms.Label lbl_sottotitolo;
        private System.Windows.Forms.Label lbl_tipostanza;
        private System.Windows.Forms.ComboBox cmb_tipostanza;
        private System.Windows.Forms.Label lbl_stagione;
        private System.Windows.Forms.Label lbl_giorni;
        private System.Windows.Forms.TextBox txt_ngiorni;
        private System.Windows.Forms.Label lbl_servizio;
        private System.Windows.Forms.CheckBox chk_si;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_prenota;
        private System.Windows.Forms.ComboBox cmb_stagione;
    }
}

