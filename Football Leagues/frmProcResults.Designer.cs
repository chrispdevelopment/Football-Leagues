namespace Football_Leagues
{
    partial class frmProcResults
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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblTeamNames = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnProcResults = new System.Windows.Forms.Button();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.txtAway = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(11, 71);
            this.lblHome.Name = "lblHome";
            this.lblHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHome.Size = new System.Drawing.Size(276, 24);
            this.lblHome.TabIndex = 6;
            this.lblHome.Text = "Home Goals:";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTeamNames
            // 
            this.lblTeamNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNames.Location = new System.Drawing.Point(91, 17);
            this.lblTeamNames.Name = "lblTeamNames";
            this.lblTeamNames.Size = new System.Drawing.Size(402, 32);
            this.lblTeamNames.TabIndex = 7;
            this.lblTeamNames.Text = "Team V Team";
            this.lblTeamNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAway
            // 
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.Location = new System.Drawing.Point(293, 71);
            this.lblAway.Name = "lblAway";
            this.lblAway.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAway.Size = new System.Drawing.Size(276, 24);
            this.lblAway.TabIndex = 8;
            this.lblAway.Text = "Away Goals:";
            this.lblAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(373, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 35);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(243, 148);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnProcResults
            // 
            this.btnProcResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcResults.Location = new System.Drawing.Point(97, 148);
            this.btnProcResults.Name = "btnProcResults";
            this.btnProcResults.Size = new System.Drawing.Size(134, 35);
            this.btnProcResults.TabIndex = 25;
            this.btnProcResults.Text = "Process Results";
            this.btnProcResults.UseVisualStyleBackColor = true;
            this.btnProcResults.Click += new System.EventHandler(this.btnProcResults_Click);
            // 
            // txtHome
            // 
            this.txtHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHome.Location = new System.Drawing.Point(86, 98);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(118, 26);
            this.txtHome.TabIndex = 28;
            // 
            // txtAway
            // 
            this.txtAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAway.Location = new System.Drawing.Point(370, 98);
            this.txtAway.Name = "txtAway";
            this.txtAway.Size = new System.Drawing.Size(118, 26);
            this.txtAway.TabIndex = 29;
            // 
            // frmProcResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 200);
            this.Controls.Add(this.txtAway);
            this.Controls.Add(this.txtHome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProcResults);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.lblTeamNames);
            this.Controls.Add(this.lblHome);
            this.MaximizeBox = false;
            this.Name = "frmProcResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProcResults_FormClosing);
            this.Load += new System.EventHandler(this.frmProcResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblTeamNames;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnProcResults;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtAway;
    }
}