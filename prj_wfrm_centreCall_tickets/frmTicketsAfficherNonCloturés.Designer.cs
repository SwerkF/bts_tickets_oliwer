namespace prj_wfrm_centreCall_tickets
{
    partial class frmTicketsAfficherNonCloturés
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
            this.lvNonCloturé = new System.Windows.Forms.ListView();
            this.numInterv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objetTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statutTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvNonCloturé
            // 
            this.lvNonCloturé.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numInterv,
            this.dateTicket,
            this.numClient,
            this.objetTicket,
            this.statutTicket});
            this.lvNonCloturé.HideSelection = false;
            this.lvNonCloturé.Location = new System.Drawing.Point(-2, -2);
            this.lvNonCloturé.Name = "lvNonCloturé";
            this.lvNonCloturé.Size = new System.Drawing.Size(1288, 607);
            this.lvNonCloturé.TabIndex = 0;
            this.lvNonCloturé.UseCompatibleStateImageBehavior = false;
            this.lvNonCloturé.View = System.Windows.Forms.View.Details;
            // 
            // numInterv
            // 
            this.numInterv.Text = "Numéro d\'intervention";
            this.numInterv.Width = 144;
            // 
            // dateTicket
            // 
            this.dateTicket.Text = "Date ticket";
            this.dateTicket.Width = 92;
            // 
            // numClient
            // 
            this.numClient.Text = "Numéro Client";
            this.numClient.Width = 110;
            // 
            // objetTicket
            // 
            this.objetTicket.Text = "Objet ";
            this.objetTicket.Width = 539;
            // 
            // statutTicket
            // 
            this.statutTicket.Text = "Clôturé ?";
            this.statutTicket.Width = 222;
            // 
            // frmTicketsAfficherNonCloturés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 688);
            this.Controls.Add(this.lvNonCloturé);
            this.Name = "frmTicketsAfficherNonCloturés";
            this.Text = "Ticket Non Cloturés";
            this.Load += new System.EventHandler(this.frmTicketsAfficherNonCloturés_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvNonCloturé;
        private System.Windows.Forms.ColumnHeader numInterv;
        private System.Windows.Forms.ColumnHeader dateTicket;
        private System.Windows.Forms.ColumnHeader numClient;
        private System.Windows.Forms.ColumnHeader objetTicket;
        private System.Windows.Forms.ColumnHeader statutTicket;
    }
}