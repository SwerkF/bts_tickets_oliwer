namespace prj_wfrm_centreCall_tickets
{
    partial class frmNafAfficherTous
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
            this.lvCode = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvCode
            // 
            this.lvCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCode.FullRowSelect = true;
            this.lvCode.HideSelection = false;
            this.lvCode.Location = new System.Drawing.Point(12, 28);
            this.lvCode.Name = "lvCode";
            this.lvCode.Size = new System.Drawing.Size(1700, 1300);
            this.lvCode.TabIndex = 1;
            this.lvCode.UseCompatibleStateImageBehavior = false;
            this.lvCode.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Intitulé";
            this.columnHeader2.Width = 700;
            // 
            // frmNafAfficherTous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 1254);
            this.Controls.Add(this.lvCode);
            this.Name = "frmNafAfficherTous";
            this.Text = "Code NAF - Tous";
            this.Load += new System.EventHandler(this.frmNafAfficherTous_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCode;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}