namespace prj_wfrm_centreCall_tickets
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCentreAppel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCentreAppelAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCentreAppelAfficherTous = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechnicien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechnicienAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTechnicienAfficherTous = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientAfficherTous = new System.Windows.Forms.ToolStripMenuItem();
            this.clientParNafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientParCentreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratExpiréToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratDépasséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicketAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTicketAfficherTous = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketNonClôturéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCodeNaf = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCodeNafAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCodeNafAfficherTous = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketParClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsParCentreDappelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuCentreAppel,
            this.mnuTechnicien,
            this.mnuClient,
            this.contratToolStripMenuItem,
            this.mnuTicket,
            this.mnuCodeNaf,
            this.mnuStat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1043, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierOuvrir,
            this.mnuFichierEnregistrer,
            this.mnuFichierQuitter});
            this.mnuFichier.Image = ((System.Drawing.Image)(resources.GetObject("mnuFichier.Image")));
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(104, 36);
            this.mnuFichier.Text = "&Fichiers";
            // 
            // mnuFichierOuvrir
            // 
            this.mnuFichierOuvrir.Name = "mnuFichierOuvrir";
            this.mnuFichierOuvrir.Size = new System.Drawing.Size(163, 26);
            this.mnuFichierOuvrir.Text = "&Ouvrir";
            this.mnuFichierOuvrir.Click += new System.EventHandler(this.mnuFichierOuvrir_Click);
            // 
            // mnuFichierEnregistrer
            // 
            this.mnuFichierEnregistrer.Name = "mnuFichierEnregistrer";
            this.mnuFichierEnregistrer.Size = new System.Drawing.Size(163, 26);
            this.mnuFichierEnregistrer.Text = "&Enregistrer";
            this.mnuFichierEnregistrer.Click += new System.EventHandler(this.mnuFichierEnregistrer_Click);
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.Size = new System.Drawing.Size(163, 26);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuCentreAppel
            // 
            this.mnuCentreAppel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCentreAppelAfficher});
            this.mnuCentreAppel.Image = ((System.Drawing.Image)(resources.GetObject("mnuCentreAppel.Image")));
            this.mnuCentreAppel.Name = "mnuCentreAppel";
            this.mnuCentreAppel.Size = new System.Drawing.Size(146, 36);
            this.mnuCentreAppel.Text = "Centres &appel";
            // 
            // mnuCentreAppelAfficher
            // 
            this.mnuCentreAppelAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCentreAppelAfficherTous});
            this.mnuCentreAppelAfficher.Name = "mnuCentreAppelAfficher";
            this.mnuCentreAppelAfficher.Size = new System.Drawing.Size(144, 26);
            this.mnuCentreAppelAfficher.Text = "Afficher";
            // 
            // mnuCentreAppelAfficherTous
            // 
            this.mnuCentreAppelAfficherTous.Name = "mnuCentreAppelAfficherTous";
            this.mnuCentreAppelAfficherTous.Size = new System.Drawing.Size(122, 26);
            this.mnuCentreAppelAfficherTous.Text = "Tous";
            this.mnuCentreAppelAfficherTous.Click += new System.EventHandler(this.mnuCentreAppelAfficherTous_Click);
            // 
            // mnuTechnicien
            // 
            this.mnuTechnicien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTechnicienAfficher});
            this.mnuTechnicien.Image = ((System.Drawing.Image)(resources.GetObject("mnuTechnicien.Image")));
            this.mnuTechnicien.Name = "mnuTechnicien";
            this.mnuTechnicien.Size = new System.Drawing.Size(130, 36);
            this.mnuTechnicien.Text = "Tec&hniciens";
            // 
            // mnuTechnicienAfficher
            // 
            this.mnuTechnicienAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTechnicienAfficherTous});
            this.mnuTechnicienAfficher.Name = "mnuTechnicienAfficher";
            this.mnuTechnicienAfficher.Size = new System.Drawing.Size(144, 26);
            this.mnuTechnicienAfficher.Text = "Afficher";
            // 
            // mnuTechnicienAfficherTous
            // 
            this.mnuTechnicienAfficherTous.Name = "mnuTechnicienAfficherTous";
            this.mnuTechnicienAfficherTous.Size = new System.Drawing.Size(122, 26);
            this.mnuTechnicienAfficherTous.Text = "Tous";
            this.mnuTechnicienAfficherTous.Click += new System.EventHandler(this.mnuTechnicienAfficherTous_Click);
            // 
            // mnuClient
            // 
            this.mnuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem2});
            this.mnuClient.Image = ((System.Drawing.Image)(resources.GetObject("mnuClient.Image")));
            this.mnuClient.Name = "mnuClient";
            this.mnuClient.Size = new System.Drawing.Size(99, 36);
            this.mnuClient.Text = "&Clients";
            // 
            // afficherToolStripMenuItem2
            // 
            this.afficherToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientAfficherTous,
            this.clientParNafToolStripMenuItem,
            this.clientParCentreToolStripMenuItem});
            this.afficherToolStripMenuItem2.Name = "afficherToolStripMenuItem2";
            this.afficherToolStripMenuItem2.Size = new System.Drawing.Size(144, 26);
            this.afficherToolStripMenuItem2.Text = "Afficher";
            // 
            // mnuClientAfficherTous
            // 
            this.mnuClientAfficherTous.Name = "mnuClientAfficherTous";
            this.mnuClientAfficherTous.Size = new System.Drawing.Size(203, 26);
            this.mnuClientAfficherTous.Text = "Tous";
            this.mnuClientAfficherTous.Click += new System.EventHandler(this.mnuClientAfficherTous_Click);
            // 
            // clientParNafToolStripMenuItem
            // 
            this.clientParNafToolStripMenuItem.Name = "clientParNafToolStripMenuItem";
            this.clientParNafToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.clientParNafToolStripMenuItem.Text = "Client par Naf";
            this.clientParNafToolStripMenuItem.Click += new System.EventHandler(this.clientParNafToolStripMenuItem_Click);
            // 
            // clientParCentreToolStripMenuItem
            // 
            this.clientParCentreToolStripMenuItem.Name = "clientParCentreToolStripMenuItem";
            this.clientParCentreToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.clientParCentreToolStripMenuItem.Text = "Client par Centre";
            this.clientParCentreToolStripMenuItem.Click += new System.EventHandler(this.clientParCentreToolStripMenuItem_Click);
            // 
            // contratToolStripMenuItem
            // 
            this.contratToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem});
            this.contratToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contratToolStripMenuItem.Image")));
            this.contratToolStripMenuItem.Name = "contratToolStripMenuItem";
            this.contratToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.contratToolStripMenuItem.Text = "Contrat";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratExpiréToolStripMenuItem,
            this.contratDépasséToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // contratExpiréToolStripMenuItem
            // 
            this.contratExpiréToolStripMenuItem.Name = "contratExpiréToolStripMenuItem";
            this.contratExpiréToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.contratExpiréToolStripMenuItem.Text = "Contrat expiré";
            this.contratExpiréToolStripMenuItem.Click += new System.EventHandler(this.contratExpiréToolStripMenuItem_Click);
            // 
            // contratDépasséToolStripMenuItem
            // 
            this.contratDépasséToolStripMenuItem.Name = "contratDépasséToolStripMenuItem";
            this.contratDépasséToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.contratDépasséToolStripMenuItem.Text = "Contrat dépassé";
            this.contratDépasséToolStripMenuItem.Click += new System.EventHandler(this.contratDépasséToolStripMenuItem_Click);
            // 
            // mnuTicket
            // 
            this.mnuTicket.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTicketAfficher,
            this.nouveauToolStripMenuItem});
            this.mnuTicket.Image = ((System.Drawing.Image)(resources.GetObject("mnuTicket.Image")));
            this.mnuTicket.Name = "mnuTicket";
            this.mnuTicket.Size = new System.Drawing.Size(100, 36);
            this.mnuTicket.Text = "&Tickets";
            // 
            // mnuTicketAfficher
            // 
            this.mnuTicketAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTicketAfficherTous,
            this.ticketNonClôturéToolStripMenuItem,
            this.ticketClientToolStripMenuItem});
            this.mnuTicketAfficher.Name = "mnuTicketAfficher";
            this.mnuTicketAfficher.Size = new System.Drawing.Size(224, 26);
            this.mnuTicketAfficher.Text = "Afficher";
            // 
            // mnuTicketAfficherTous
            // 
            this.mnuTicketAfficherTous.Name = "mnuTicketAfficherTous";
            this.mnuTicketAfficherTous.Size = new System.Drawing.Size(210, 26);
            this.mnuTicketAfficherTous.Text = "Tous";
            this.mnuTicketAfficherTous.Click += new System.EventHandler(this.mnuTicketAfficherTous_Click);
            // 
            // ticketNonClôturéToolStripMenuItem
            // 
            this.ticketNonClôturéToolStripMenuItem.Name = "ticketNonClôturéToolStripMenuItem";
            this.ticketNonClôturéToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ticketNonClôturéToolStripMenuItem.Text = "Ticket non clôturé";
            this.ticketNonClôturéToolStripMenuItem.Click += new System.EventHandler(this.ticketNonClôturéToolStripMenuItem_Click);
            // 
            // mnuCodeNaf
            // 
            this.mnuCodeNaf.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCodeNafAfficher});
            this.mnuCodeNaf.Image = ((System.Drawing.Image)(resources.GetObject("mnuCodeNaf.Image")));
            this.mnuCodeNaf.Name = "mnuCodeNaf";
            this.mnuCodeNaf.Size = new System.Drawing.Size(128, 36);
            this.mnuCodeNaf.Text = "Codes NAF";
            // 
            // mnuCodeNafAfficher
            // 
            this.mnuCodeNafAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCodeNafAfficherTous});
            this.mnuCodeNafAfficher.Name = "mnuCodeNafAfficher";
            this.mnuCodeNafAfficher.Size = new System.Drawing.Size(144, 26);
            this.mnuCodeNafAfficher.Text = "Afficher";
            // 
            // mnuCodeNafAfficherTous
            // 
            this.mnuCodeNafAfficherTous.Name = "mnuCodeNafAfficherTous";
            this.mnuCodeNafAfficherTous.Size = new System.Drawing.Size(122, 26);
            this.mnuCodeNafAfficherTous.Text = "Tous";
            this.mnuCodeNafAfficherTous.Click += new System.EventHandler(this.mnuCodeNafAfficherTous_Click);
            // 
            // mnuStat
            // 
            this.mnuStat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuStat.Image = ((System.Drawing.Image)(resources.GetObject("mnuStat.Image")));
            this.mnuStat.Name = "mnuStat";
            this.mnuStat.Size = new System.Drawing.Size(131, 36);
            this.mnuStat.Text = "Statistiques";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketParClientToolStripMenuItem,
            this.ticketsParCentreDappelToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem1.Text = "Afficher";
            // 
            // ticketParClientToolStripMenuItem
            // 
            this.ticketParClientToolStripMenuItem.Name = "ticketParClientToolStripMenuItem";
            this.ticketParClientToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.ticketParClientToolStripMenuItem.Text = "Tickets par client";
            this.ticketParClientToolStripMenuItem.Click += new System.EventHandler(this.ticketParClientToolStripMenuItem_Click);
            // 
            // ticketsParCentreDappelToolStripMenuItem
            // 
            this.ticketsParCentreDappelToolStripMenuItem.Name = "ticketsParCentreDappelToolStripMenuItem";
            this.ticketsParCentreDappelToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.ticketsParCentreDappelToolStripMenuItem.Text = "Tickets par centre d\'appel";
            this.ticketsParCentreDappelToolStripMenuItem.Click += new System.EventHandler(this.ticketsParCentreDappelToolStripMenuItem_Click_1);
            // 
            // ticketClientToolStripMenuItem
            // 
            this.ticketClientToolStripMenuItem.Name = "ticketClientToolStripMenuItem";
            this.ticketClientToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ticketClientToolStripMenuItem.Text = "Ticket Client";
            this.ticketClientToolStripMenuItem.Click += new System.EventHandler(this.ticketClientToolStripMenuItem_Click);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 564);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Gestion des tickets chez CentreCall";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuCentreAppel;
        private System.Windows.Forms.ToolStripMenuItem mnuCentreAppelAfficher;
        private System.Windows.Forms.ToolStripMenuItem mnuCentreAppelAfficherTous;
        private System.Windows.Forms.ToolStripMenuItem mnuTechnicien;
        private System.Windows.Forms.ToolStripMenuItem mnuTechnicienAfficher;
        private System.Windows.Forms.ToolStripMenuItem mnuTechnicienAfficherTous;
        private System.Windows.Forms.ToolStripMenuItem mnuClient;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuClientAfficherTous;
        private System.Windows.Forms.ToolStripMenuItem mnuTicket;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketAfficher;
        private System.Windows.Forms.ToolStripMenuItem mnuTicketAfficherTous;
        private System.Windows.Forms.ToolStripMenuItem mnuCodeNaf;
        private System.Windows.Forms.ToolStripMenuItem mnuCodeNafAfficher;
        private System.Windows.Forms.ToolStripMenuItem mnuCodeNafAfficherTous;
        private System.Windows.Forms.ToolStripMenuItem clientParNafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientParCentreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratExpiréToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratDépasséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketNonClôturéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ticketParClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsParCentreDappelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    }
}

