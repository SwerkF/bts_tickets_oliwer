namespace prj_wfrm_centreCall_tickets
{
    partial class frmStatTicketClient
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
            this.lvStatTicketClient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvStatTicketClient
            // 
            this.lvStatTicketClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvStatTicketClient.FullRowSelect = true;
            this.lvStatTicketClient.HideSelection = false;
            this.lvStatTicketClient.Location = new System.Drawing.Point(11, 11);
            this.lvStatTicketClient.Margin = new System.Windows.Forms.Padding(2);
            this.lvStatTicketClient.Name = "lvStatTicketClient";
            this.lvStatTicketClient.Size = new System.Drawing.Size(463, 681);
            this.lvStatTicketClient.TabIndex = 2;
            this.lvStatTicketClient.UseCompatibleStateImageBehavior = false;
            this.lvStatTicketClient.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Raison sociale";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre de tickets";
            this.columnHeader2.Width = 132;
            // 
            // frmStatTicketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 723);
            this.Controls.Add(this.lvStatTicketClient);
            this.Name = "frmStatTicketClient";
            this.Text = "Ticket par client";
            this.Load += new System.EventHandler(this.frmStatTicketClient_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvStatTicketClient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}