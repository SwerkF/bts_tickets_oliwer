namespace prj_wfrm_centreCall_tickets
{
    partial class frmClientNafAfficher
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
            this.lvNafClient = new System.Windows.Forms.ListView();
            this.numClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.raisonSociale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbCodeNaf = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvNafClient
            // 
            this.lvNafClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numClient,
            this.raisonSociale});
            this.lvNafClient.HideSelection = false;
            this.lvNafClient.Location = new System.Drawing.Point(16, 15);
            this.lvNafClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvNafClient.Name = "lvNafClient";
            this.lvNafClient.Size = new System.Drawing.Size(333, 517);
            this.lvNafClient.TabIndex = 0;
            this.lvNafClient.UseCompatibleStateImageBehavior = false;
            this.lvNafClient.View = System.Windows.Forms.View.Details;
            // 
            // numClient
            // 
            this.numClient.Text = "N°Client";
            this.numClient.Width = 79;
            // 
            // raisonSociale
            // 
            this.raisonSociale.Text = "Raison Sociale";
            this.raisonSociale.Width = 106;
            // 
            // cbCodeNaf
            // 
            this.cbCodeNaf.FormattingEnabled = true;
            this.cbCodeNaf.Location = new System.Drawing.Point(449, 26);
            this.cbCodeNaf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCodeNaf.Name = "cbCodeNaf";
            this.cbCodeNaf.Size = new System.Drawing.Size(461, 24);
            this.cbCodeNaf.TabIndex = 1;
            this.cbCodeNaf.SelectedIndexChanged += new System.EventHandler(this.cbCodeNaf_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code NAF :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmClientNafAfficher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCodeNaf);
            this.Controls.Add(this.lvNafClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientNafAfficher";
            this.Text = "Client - Par NAF";
            this.Load += new System.EventHandler(this.frmClientNafAfficher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNafClient;
        private System.Windows.Forms.ComboBox cbCodeNaf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader numClient;
        private System.Windows.Forms.ColumnHeader raisonSociale;
    }
}