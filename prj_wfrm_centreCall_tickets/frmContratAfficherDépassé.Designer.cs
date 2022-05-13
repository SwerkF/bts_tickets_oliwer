namespace prj_wfrm_centreCall_tickets
{
    partial class frmContratAfficherDépassé
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
            this.lvDépassement = new System.Windows.Forms.ListView();
            this.numContrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montantContrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montantTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montantDépassement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvDépassement
            // 
            this.lvDépassement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numContrat,
            this.nomClient,
            this.montantContrat,
            this.montantTicket,
            this.montantDépassement});
            this.lvDépassement.HideSelection = false;
            this.lvDépassement.Location = new System.Drawing.Point(0, 0);
            this.lvDépassement.Name = "lvDépassement";
            this.lvDépassement.Size = new System.Drawing.Size(1108, 602);
            this.lvDépassement.TabIndex = 0;
            this.lvDépassement.UseCompatibleStateImageBehavior = false;
            this.lvDépassement.View = System.Windows.Forms.View.Details;
            // 
            // numContrat
            // 
            this.numContrat.Text = "N°Contrat";
            this.numContrat.Width = 106;
            // 
            // nomClient
            // 
            this.nomClient.Text = "Client";
            this.nomClient.Width = 180;
            // 
            // montantContrat
            // 
            this.montantContrat.Text = "Montant du contrat";
            this.montantContrat.Width = 165;
            // 
            // montantTicket
            // 
            this.montantTicket.Text = "Montant Ticket";
            this.montantTicket.Width = 158;
            // 
            // montantDépassement
            // 
            this.montantDépassement.Text = "Dépassement";
            this.montantDépassement.Width = 150;
            // 
            // frmContratAfficherDépassé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 751);
            this.Controls.Add(this.lvDépassement);
            this.Name = "frmContratAfficherDépassé";
            this.Text = "Contrat Dépassement";
            this.Load += new System.EventHandler(this.frmContratAfficherDépassé_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDépassement;
        private System.Windows.Forms.ColumnHeader numContrat;
        private System.Windows.Forms.ColumnHeader nomClient;
        private System.Windows.Forms.ColumnHeader montantContrat;
        private System.Windows.Forms.ColumnHeader montantTicket;
        private System.Windows.Forms.ColumnHeader montantDépassement;
    }
}