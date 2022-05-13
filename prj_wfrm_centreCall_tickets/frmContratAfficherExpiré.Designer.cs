namespace prj_wfrm_centreCall_tickets
{
    partial class frmContratAfficherExpiré
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
            this.lvContratExpire = new System.Windows.Forms.ListView();
            this.numClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raisonSociale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.centreAppel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codeNAF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateContrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dureeContrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montantContrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valTickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvContratExpire
            // 
            this.lvContratExpire.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numClient,
            this.raisonSociale,
            this.centreAppel,
            this.codeNAF,
            this.dateContrat,
            this.dureeContrat,
            this.montantContrat,
            this.valTickets});
            this.lvContratExpire.HideSelection = false;
            this.lvContratExpire.Location = new System.Drawing.Point(0, 0);
            this.lvContratExpire.Name = "lvContratExpire";
            this.lvContratExpire.Size = new System.Drawing.Size(1328, 737);
            this.lvContratExpire.TabIndex = 0;
            this.lvContratExpire.UseCompatibleStateImageBehavior = false;
            this.lvContratExpire.View = System.Windows.Forms.View.Details;
            // 
            // numClient
            // 
            this.numClient.Text = "N°Client";
            this.numClient.Width = 77;
            // 
            // raisonSociale
            // 
            this.raisonSociale.Text = "Raison Sociale";
            this.raisonSociale.Width = 110;
            // 
            // centreAppel
            // 
            this.centreAppel.Text = "Centre d\'appel";
            this.centreAppel.Width = 102;
            // 
            // codeNAF
            // 
            this.codeNAF.Text = "NAF";
            // 
            // dateContrat
            // 
            this.dateContrat.Text = "Date Contrat";
            this.dateContrat.Width = 123;
            // 
            // dureeContrat
            // 
            this.dureeContrat.Text = "Durée";
            // 
            // montantContrat
            // 
            this.montantContrat.Text = "Montant";
            this.montantContrat.Width = 95;
            // 
            // valTickets
            // 
            this.valTickets.Text = "Valeur Tickets";
            this.valTickets.Width = 163;
            // 
            // frmContratAfficherExpiré
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 886);
            this.Controls.Add(this.lvContratExpire);
            this.Name = "frmContratAfficherExpiré";
            this.Text = "Contrat Expiré";
            this.Load += new System.EventHandler(this.frmContratAfficherExpiré_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvContratExpire;
        private System.Windows.Forms.ColumnHeader numClient;
        private System.Windows.Forms.ColumnHeader raisonSociale;
        private System.Windows.Forms.ColumnHeader centreAppel;
        private System.Windows.Forms.ColumnHeader codeNAF;
        private System.Windows.Forms.ColumnHeader dateContrat;
        private System.Windows.Forms.ColumnHeader dureeContrat;
        private System.Windows.Forms.ColumnHeader montantContrat;
        private System.Windows.Forms.ColumnHeader valTickets;
    }
}