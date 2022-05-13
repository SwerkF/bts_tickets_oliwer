namespace prj_wfrm_centreCall_tickets
{
    partial class frmClientCentreAfficher
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
            this.cbCentreAppel = new System.Windows.Forms.ComboBox();
            this.lvCentreAppel = new System.Windows.Forms.ListView();
            this.numClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raisonSociale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCentreAppel
            // 
            this.cbCentreAppel.FormattingEnabled = true;
            this.cbCentreAppel.Location = new System.Drawing.Point(478, 13);
            this.cbCentreAppel.Name = "cbCentreAppel";
            this.cbCentreAppel.Size = new System.Drawing.Size(386, 24);
            this.cbCentreAppel.TabIndex = 1;
            this.cbCentreAppel.SelectedIndexChanged += new System.EventHandler(this.cbCentreAppel_SelectedIndexChanged);
            // 
            // lvCentreAppel
            // 
            this.lvCentreAppel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numClient,
            this.raisonSociale});
            this.lvCentreAppel.HideSelection = false;
            this.lvCentreAppel.Location = new System.Drawing.Point(12, 12);
            this.lvCentreAppel.Name = "lvCentreAppel";
            this.lvCentreAppel.Size = new System.Drawing.Size(312, 491);
            this.lvCentreAppel.TabIndex = 2;
            this.lvCentreAppel.UseCompatibleStateImageBehavior = false;
            this.lvCentreAppel.View = System.Windows.Forms.View.Details;
            // 
            // numClient
            // 
            this.numClient.Text = "N°Client";
            this.numClient.Width = 90;
            // 
            // raisonSociale
            // 
            this.raisonSociale.Text = "Raison Sociale";
            this.raisonSociale.Width = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centre d\'appel :";
            // 
            // frmClientCentreAfficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvCentreAppel);
            this.Controls.Add(this.cbCentreAppel);
            this.Name = "frmClientCentreAfficher";
            this.Text = "Client - Par Centre";
            this.Load += new System.EventHandler(this.frmClientCentreAfficher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCentreAppel;
        private System.Windows.Forms.ListView lvCentreAppel;
        private System.Windows.Forms.ColumnHeader numClient;
        private System.Windows.Forms.ColumnHeader raisonSociale;
        private System.Windows.Forms.Label label1;
    }
}