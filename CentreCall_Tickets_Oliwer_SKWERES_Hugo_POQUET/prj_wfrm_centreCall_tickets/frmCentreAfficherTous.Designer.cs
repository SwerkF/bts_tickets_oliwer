namespace prj_wfrm_centreCall_tickets
{
    partial class frmCentreAfficherTous
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
            this.lvCentre = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvCentre
            // 
            this.lvCentre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCentre.FullRowSelect = true;
            this.lvCentre.HideSelection = false;
            this.lvCentre.Location = new System.Drawing.Point(33, 12);
            this.lvCentre.Name = "lvCentre";
            this.lvCentre.Size = new System.Drawing.Size(693, 765);
            this.lvCentre.TabIndex = 0;
            this.lvCentre.UseCompatibleStateImageBehavior = false;
            this.lvCentre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N°";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ville";
            // 
            // frmCentreAfficherTous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 818);
            this.Controls.Add(this.lvCentre);
            this.Name = "frmCentreAfficherTous";
            this.Text = "Centres d\'appel - Tous";
            this.Load += new System.EventHandler(this.frmCentreAfficherTous_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCentre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}