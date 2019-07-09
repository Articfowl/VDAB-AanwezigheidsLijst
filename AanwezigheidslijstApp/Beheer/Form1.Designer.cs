namespace Beheer
{
    partial class frmBeheer
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnTijdsregistraties = new System.Windows.Forms.Button();
            this.btnDocenten = new System.Windows.Forms.Button();
            this.btnFeestdagen = new System.Windows.Forms.Button();
            this.btnOpleiding = new System.Windows.Forms.Button();
            this.btnDeelnemers = new System.Windows.Forms.Button();
            this.pnlInformatie = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpleidngsInstelling = new System.Windows.Forms.Label();
            this.lblOpleiding = new System.Windows.Forms.Label();
            this.lblContactPersoon = new System.Windows.Forms.Label();
            this.lblOpleidingsplaats = new System.Windows.Forms.Label();
            this.lblReferentieOpleiding = new System.Windows.Forms.Label();
            this.lblOENummer = new System.Windows.Forms.Label();
            this.lblOpleidingcode = new System.Windows.Forms.Label();
            this.btnInfoBeheer = new System.Windows.Forms.Button();
            this.pnlDeelnemers = new System.Windows.Forms.Panel();
            this.lstbDeelnemers = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStartEindDatum = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.pnlInformatie.SuspendLayout();
            this.pnlDeelnemers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnTijdsregistraties);
            this.pnlButtons.Controls.Add(this.btnDocenten);
            this.pnlButtons.Controls.Add(this.btnFeestdagen);
            this.pnlButtons.Controls.Add(this.btnOpleiding);
            this.pnlButtons.Controls.Add(this.btnDeelnemers);
            this.pnlButtons.Location = new System.Drawing.Point(12, 12);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(292, 234);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnTijdsregistraties
            // 
            this.btnTijdsregistraties.Location = new System.Drawing.Point(81, 156);
            this.btnTijdsregistraties.Name = "btnTijdsregistraties";
            this.btnTijdsregistraties.Size = new System.Drawing.Size(127, 65);
            this.btnTijdsregistraties.TabIndex = 9;
            this.btnTijdsregistraties.Text = "Tijdsregistraties";
            this.btnTijdsregistraties.UseVisualStyleBackColor = true;
            // 
            // btnDocenten
            // 
            this.btnDocenten.Location = new System.Drawing.Point(149, 85);
            this.btnDocenten.Name = "btnDocenten";
            this.btnDocenten.Size = new System.Drawing.Size(127, 65);
            this.btnDocenten.TabIndex = 8;
            this.btnDocenten.Text = "Docenten";
            this.btnDocenten.UseVisualStyleBackColor = true;
            // 
            // btnFeestdagen
            // 
            this.btnFeestdagen.Location = new System.Drawing.Point(16, 85);
            this.btnFeestdagen.Name = "btnFeestdagen";
            this.btnFeestdagen.Size = new System.Drawing.Size(127, 65);
            this.btnFeestdagen.TabIndex = 7;
            this.btnFeestdagen.Text = "Feestdagen / Vakentiedagen";
            this.btnFeestdagen.UseVisualStyleBackColor = true;
            // 
            // btnOpleiding
            // 
            this.btnOpleiding.Location = new System.Drawing.Point(16, 13);
            this.btnOpleiding.Name = "btnOpleiding";
            this.btnOpleiding.Size = new System.Drawing.Size(127, 65);
            this.btnOpleiding.TabIndex = 6;
            this.btnOpleiding.Text = "Opleiding Informatie";
            this.btnOpleiding.UseVisualStyleBackColor = true;
            this.btnOpleiding.Click += new System.EventHandler(this.BtnOpleiding_Click);
            // 
            // btnDeelnemers
            // 
            this.btnDeelnemers.Location = new System.Drawing.Point(149, 13);
            this.btnDeelnemers.Name = "btnDeelnemers";
            this.btnDeelnemers.Size = new System.Drawing.Size(127, 65);
            this.btnDeelnemers.TabIndex = 5;
            this.btnDeelnemers.Text = "Deelnemers";
            this.btnDeelnemers.UseVisualStyleBackColor = true;
            this.btnDeelnemers.Click += new System.EventHandler(this.BtnDeelnemers_Click);
            // 
            // pnlInformatie
            // 
            this.pnlInformatie.Controls.Add(this.lblStartEindDatum);
            this.pnlInformatie.Controls.Add(this.btnInfoBeheer);
            this.pnlInformatie.Controls.Add(this.lblOpleidingcode);
            this.pnlInformatie.Controls.Add(this.lblOENummer);
            this.pnlInformatie.Controls.Add(this.lblReferentieOpleiding);
            this.pnlInformatie.Controls.Add(this.lblOpleidingsplaats);
            this.pnlInformatie.Controls.Add(this.lblContactPersoon);
            this.pnlInformatie.Controls.Add(this.lblOpleiding);
            this.pnlInformatie.Controls.Add(this.lblOpleidngsInstelling);
            this.pnlInformatie.Controls.Add(this.label1);
            this.pnlInformatie.Location = new System.Drawing.Point(352, 12);
            this.pnlInformatie.Name = "pnlInformatie";
            this.pnlInformatie.Size = new System.Drawing.Size(400, 234);
            this.pnlInformatie.TabIndex = 1;
            this.pnlInformatie.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 195);
            this.label1.TabIndex = 0;
            this.label1.Text = "OpleidingsInstelling: \r\n\r\nOpleiding:\r\n\r\nContactPersoon:\r\n\r\nOpleidingsplaats: \r\n\r\n" +
    "Referentie opleidingsplaats:\r\n\r\nOE-Nummer: \r\n\r\nOpleidingscode: \r\n\r\nStart en eind" +
    " datum: ";
            // 
            // lblOpleidngsInstelling
            // 
            this.lblOpleidngsInstelling.AutoSize = true;
            this.lblOpleidngsInstelling.Location = new System.Drawing.Point(133, 13);
            this.lblOpleidngsInstelling.Name = "lblOpleidngsInstelling";
            this.lblOpleidngsInstelling.Size = new System.Drawing.Size(0, 13);
            this.lblOpleidngsInstelling.TabIndex = 1;
            // 
            // lblOpleiding
            // 
            this.lblOpleiding.AutoSize = true;
            this.lblOpleiding.Location = new System.Drawing.Point(78, 39);
            this.lblOpleiding.Name = "lblOpleiding";
            this.lblOpleiding.Size = new System.Drawing.Size(0, 13);
            this.lblOpleiding.TabIndex = 2;
            // 
            // lblContactPersoon
            // 
            this.lblContactPersoon.AutoSize = true;
            this.lblContactPersoon.Location = new System.Drawing.Point(112, 65);
            this.lblContactPersoon.Name = "lblContactPersoon";
            this.lblContactPersoon.Size = new System.Drawing.Size(0, 13);
            this.lblContactPersoon.TabIndex = 2;
            // 
            // lblOpleidingsplaats
            // 
            this.lblOpleidingsplaats.AutoSize = true;
            this.lblOpleidingsplaats.Location = new System.Drawing.Point(112, 91);
            this.lblOpleidingsplaats.Name = "lblOpleidingsplaats";
            this.lblOpleidingsplaats.Size = new System.Drawing.Size(0, 13);
            this.lblOpleidingsplaats.TabIndex = 3;
            this.lblOpleidingsplaats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReferentieOpleiding
            // 
            this.lblReferentieOpleiding.AutoSize = true;
            this.lblReferentieOpleiding.Location = new System.Drawing.Point(175, 117);
            this.lblReferentieOpleiding.Name = "lblReferentieOpleiding";
            this.lblReferentieOpleiding.Size = new System.Drawing.Size(0, 13);
            this.lblReferentieOpleiding.TabIndex = 4;
            // 
            // lblOENummer
            // 
            this.lblOENummer.AutoSize = true;
            this.lblOENummer.Location = new System.Drawing.Point(90, 143);
            this.lblOENummer.Name = "lblOENummer";
            this.lblOENummer.Size = new System.Drawing.Size(0, 13);
            this.lblOENummer.TabIndex = 5;
            // 
            // lblOpleidingcode
            // 
            this.lblOpleidingcode.AutoSize = true;
            this.lblOpleidingcode.Location = new System.Drawing.Point(112, 169);
            this.lblOpleidingcode.Name = "lblOpleidingcode";
            this.lblOpleidingcode.Size = new System.Drawing.Size(0, 13);
            this.lblOpleidingcode.TabIndex = 6;
            // 
            // btnInfoBeheer
            // 
            this.btnInfoBeheer.Location = new System.Drawing.Point(300, 169);
            this.btnInfoBeheer.Name = "btnInfoBeheer";
            this.btnInfoBeheer.Size = new System.Drawing.Size(89, 54);
            this.btnInfoBeheer.TabIndex = 7;
            this.btnInfoBeheer.Text = "Terugkeren naar beheer";
            this.btnInfoBeheer.UseVisualStyleBackColor = true;
            this.btnInfoBeheer.Click += new System.EventHandler(this.BtnInfoBeheer_Click);
            // 
            // pnlDeelnemers
            // 
            this.pnlDeelnemers.Controls.Add(this.button1);
            this.pnlDeelnemers.Controls.Add(this.lstbDeelnemers);
            this.pnlDeelnemers.Location = new System.Drawing.Point(775, 12);
            this.pnlDeelnemers.Name = "pnlDeelnemers";
            this.pnlDeelnemers.Size = new System.Drawing.Size(292, 467);
            this.pnlDeelnemers.TabIndex = 10;
            this.pnlDeelnemers.Visible = false;
            // 
            // lstbDeelnemers
            // 
            this.lstbDeelnemers.FormattingEnabled = true;
            this.lstbDeelnemers.Location = new System.Drawing.Point(3, 9);
            this.lstbDeelnemers.Name = "lstbDeelnemers";
            this.lstbDeelnemers.Size = new System.Drawing.Size(286, 407);
            this.lstbDeelnemers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Terugkeren naar beheer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblStartEindDatum
            // 
            this.lblStartEindDatum.AutoSize = true;
            this.lblStartEindDatum.Location = new System.Drawing.Point(136, 195);
            this.lblStartEindDatum.Name = "lblStartEindDatum";
            this.lblStartEindDatum.Size = new System.Drawing.Size(0, 13);
            this.lblStartEindDatum.TabIndex = 8;
            // 
            // frmBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 622);
            this.Controls.Add(this.pnlDeelnemers);
            this.Controls.Add(this.pnlInformatie);
            this.Controls.Add(this.pnlButtons);
            this.Name = "frmBeheer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanwezigheidslijst Beheer";
            this.Load += new System.EventHandler(this.FrmBeheer_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlInformatie.ResumeLayout(false);
            this.pnlInformatie.PerformLayout();
            this.pnlDeelnemers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnTijdsregistraties;
        private System.Windows.Forms.Button btnDocenten;
        private System.Windows.Forms.Button btnFeestdagen;
        private System.Windows.Forms.Button btnOpleiding;
        private System.Windows.Forms.Button btnDeelnemers;
        private System.Windows.Forms.Panel pnlInformatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpleidingcode;
        private System.Windows.Forms.Label lblOENummer;
        private System.Windows.Forms.Label lblReferentieOpleiding;
        private System.Windows.Forms.Label lblOpleidingsplaats;
        private System.Windows.Forms.Label lblContactPersoon;
        private System.Windows.Forms.Label lblOpleiding;
        private System.Windows.Forms.Label lblOpleidngsInstelling;
        private System.Windows.Forms.Button btnInfoBeheer;
        private System.Windows.Forms.Panel pnlDeelnemers;
        private System.Windows.Forms.ListBox lstbDeelnemers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStartEindDatum;
    }
}

