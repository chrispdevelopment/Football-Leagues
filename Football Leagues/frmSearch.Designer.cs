namespace Football_Leagues
{
    partial class frmSearch
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
            this.pnlLeagues = new System.Windows.Forms.Panel();
            this.lstResultsLeag = new System.Windows.Forms.ListBox();
            this.comboPropLeag = new System.Windows.Forms.ComboBox();
            this.txtStringLeag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFixtures = new System.Windows.Forms.Panel();
            this.lstResultsFix = new System.Windows.Forms.ListBox();
            this.comboPropFix = new System.Windows.Forms.ComboBox();
            this.txtStringFix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlTeams = new System.Windows.Forms.Panel();
            this.lstResultsTeam = new System.Windows.Forms.ListBox();
            this.comboPropTeam = new System.Windows.Forms.ComboBox();
            this.txtStringTeam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSearchType = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateFixDate = new System.Windows.Forms.DateTimePicker();
            this.pnlLeagues.SuspendLayout();
            this.pnlFixtures.SuspendLayout();
            this.pnlTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeagues
            // 
            this.pnlLeagues.Controls.Add(this.lstResultsLeag);
            this.pnlLeagues.Controls.Add(this.comboPropLeag);
            this.pnlLeagues.Controls.Add(this.txtStringLeag);
            this.pnlLeagues.Controls.Add(this.label2);
            this.pnlLeagues.Controls.Add(this.label1);
            this.pnlLeagues.Location = new System.Drawing.Point(30, 74);
            this.pnlLeagues.Name = "pnlLeagues";
            this.pnlLeagues.Size = new System.Drawing.Size(493, 297);
            this.pnlLeagues.TabIndex = 0;
            // 
            // lstResultsLeag
            // 
            this.lstResultsLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultsLeag.FormattingEnabled = true;
            this.lstResultsLeag.ItemHeight = 20;
            this.lstResultsLeag.Location = new System.Drawing.Point(114, 110);
            this.lstResultsLeag.Name = "lstResultsLeag";
            this.lstResultsLeag.Size = new System.Drawing.Size(315, 164);
            this.lstResultsLeag.TabIndex = 68;
            // 
            // comboPropLeag
            // 
            this.comboPropLeag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPropLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPropLeag.FormattingEnabled = true;
            this.comboPropLeag.Items.AddRange(new object[] {
            "Name",
            "Sponsor",
            "Prize",
            "No of Fixtures"});
            this.comboPropLeag.Location = new System.Drawing.Point(258, 58);
            this.comboPropLeag.Name = "comboPropLeag";
            this.comboPropLeag.Size = new System.Drawing.Size(171, 28);
            this.comboPropLeag.TabIndex = 67;
            // 
            // txtStringLeag
            // 
            this.txtStringLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringLeag.Location = new System.Drawing.Point(258, 22);
            this.txtStringLeag.Name = "txtStringLeag";
            this.txtStringLeag.Size = new System.Drawing.Size(171, 26);
            this.txtStringLeag.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Property to Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Search String:";
            // 
            // pnlFixtures
            // 
            this.pnlFixtures.Controls.Add(this.dateFixDate);
            this.pnlFixtures.Controls.Add(this.lstResultsFix);
            this.pnlFixtures.Controls.Add(this.comboPropFix);
            this.pnlFixtures.Controls.Add(this.txtStringFix);
            this.pnlFixtures.Controls.Add(this.label4);
            this.pnlFixtures.Controls.Add(this.label5);
            this.pnlFixtures.Location = new System.Drawing.Point(30, 74);
            this.pnlFixtures.Name = "pnlFixtures";
            this.pnlFixtures.Size = new System.Drawing.Size(493, 297);
            this.pnlFixtures.TabIndex = 1;
            // 
            // lstResultsFix
            // 
            this.lstResultsFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultsFix.FormattingEnabled = true;
            this.lstResultsFix.ItemHeight = 20;
            this.lstResultsFix.Location = new System.Drawing.Point(114, 110);
            this.lstResultsFix.Name = "lstResultsFix";
            this.lstResultsFix.Size = new System.Drawing.Size(315, 164);
            this.lstResultsFix.TabIndex = 73;
            // 
            // comboPropFix
            // 
            this.comboPropFix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPropFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPropFix.FormattingEnabled = true;
            this.comboPropFix.Items.AddRange(new object[] {
            "Date",
            "Time",
            "Location",
            "Home Team",
            "Away Team"});
            this.comboPropFix.Location = new System.Drawing.Point(258, 58);
            this.comboPropFix.Name = "comboPropFix";
            this.comboPropFix.Size = new System.Drawing.Size(171, 28);
            this.comboPropFix.TabIndex = 72;
            this.comboPropFix.SelectedIndexChanged += new System.EventHandler(this.comboPropFix_SelectedIndexChanged);
            // 
            // txtStringFix
            // 
            this.txtStringFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringFix.Location = new System.Drawing.Point(258, 22);
            this.txtStringFix.Name = "txtStringFix";
            this.txtStringFix.Size = new System.Drawing.Size(171, 26);
            this.txtStringFix.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Property to Search:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 69;
            this.label5.Text = "Search String:";
            // 
            // pnlTeams
            // 
            this.pnlTeams.Controls.Add(this.lstResultsTeam);
            this.pnlTeams.Controls.Add(this.comboPropTeam);
            this.pnlTeams.Controls.Add(this.txtStringTeam);
            this.pnlTeams.Controls.Add(this.label6);
            this.pnlTeams.Controls.Add(this.label7);
            this.pnlTeams.Location = new System.Drawing.Point(30, 74);
            this.pnlTeams.Name = "pnlTeams";
            this.pnlTeams.Size = new System.Drawing.Size(493, 297);
            this.pnlTeams.TabIndex = 2;
            // 
            // lstResultsTeam
            // 
            this.lstResultsTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultsTeam.FormattingEnabled = true;
            this.lstResultsTeam.ItemHeight = 20;
            this.lstResultsTeam.Location = new System.Drawing.Point(114, 110);
            this.lstResultsTeam.Name = "lstResultsTeam";
            this.lstResultsTeam.Size = new System.Drawing.Size(315, 164);
            this.lstResultsTeam.TabIndex = 73;
            // 
            // comboPropTeam
            // 
            this.comboPropTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPropTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPropTeam.FormattingEnabled = true;
            this.comboPropTeam.Items.AddRange(new object[] {
            "Name",
            "League",
            "Manager",
            "Nickname",
            "Stadium",
            "Position",
            "Points",
            "Games Played",
            "Goal Difference",
            "Team Size"});
            this.comboPropTeam.Location = new System.Drawing.Point(258, 58);
            this.comboPropTeam.Name = "comboPropTeam";
            this.comboPropTeam.Size = new System.Drawing.Size(171, 28);
            this.comboPropTeam.TabIndex = 72;
            // 
            // txtStringTeam
            // 
            this.txtStringTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringTeam.Location = new System.Drawing.Point(258, 22);
            this.txtStringTeam.Name = "txtStringTeam";
            this.txtStringTeam.Size = new System.Drawing.Size(171, 26);
            this.txtStringTeam.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "Property to Search:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 69;
            this.label7.Text = "Search String:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Select Search Type:";
            // 
            // comboSearchType
            // 
            this.comboSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchType.FormattingEnabled = true;
            this.comboSearchType.Items.AddRange(new object[] {
            "League",
            "Fixture",
            "Team"});
            this.comboSearchType.Location = new System.Drawing.Point(231, 25);
            this.comboSearchType.Name = "comboSearchType";
            this.comboSearchType.Size = new System.Drawing.Size(171, 28);
            this.comboSearchType.TabIndex = 66;
            this.comboSearchType.SelectedIndexChanged += new System.EventHandler(this.comboLocation_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(408, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 35);
            this.btnClose.TabIndex = 71;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(340, 393);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 70;
            this.btnReset.Text = "Reset Search";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(220, 393);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(114, 35);
            this.btnShowDetails.TabIndex = 69;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(98, 393);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 35);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateFixDate
            // 
            this.dateFixDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFixDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFixDate.Location = new System.Drawing.Point(258, 22);
            this.dateFixDate.Name = "dateFixDate";
            this.dateFixDate.Size = new System.Drawing.Size(118, 26);
            this.dateFixDate.TabIndex = 74;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 442);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboSearchType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlFixtures);
            this.Controls.Add(this.pnlLeagues);
            this.Controls.Add(this.pnlTeams);
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddFixture_FormClosing);
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.pnlLeagues.ResumeLayout(false);
            this.pnlLeagues.PerformLayout();
            this.pnlFixtures.ResumeLayout(false);
            this.pnlFixtures.PerformLayout();
            this.pnlTeams.ResumeLayout(false);
            this.pnlTeams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeagues;
        private System.Windows.Forms.Panel pnlFixtures;
        private System.Windows.Forms.Panel pnlTeams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSearchType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPropLeag;
        private System.Windows.Forms.TextBox txtStringLeag;
        private System.Windows.Forms.ListBox lstResultsLeag;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstResultsFix;
        private System.Windows.Forms.ComboBox comboPropFix;
        private System.Windows.Forms.TextBox txtStringFix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstResultsTeam;
        private System.Windows.Forms.ComboBox comboPropTeam;
        private System.Windows.Forms.TextBox txtStringTeam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateFixDate;
    }
}