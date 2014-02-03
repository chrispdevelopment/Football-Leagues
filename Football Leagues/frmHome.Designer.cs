namespace Football_Leagues
{
    partial class frmHome
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
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabLeagues = new System.Windows.Forms.TabPage();
            this.btnEditLeag = new System.Windows.Forms.Button();
            this.btnPrevLeag = new System.Windows.Forms.Button();
            this.lblLeagName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLeagPrize = new System.Windows.Forms.Label();
            this.btnNextLeag = new System.Windows.Forms.Button();
            this.lblLeagSponsor = new System.Windows.Forms.Label();
            this.lblLeageFixNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFixtures = new System.Windows.Forms.Panel();
            this.btnDelFix = new System.Windows.Forms.Button();
            this.btnEditFix = new System.Windows.Forms.Button();
            this.btnProcResults = new System.Windows.Forms.Button();
            this.btnAddFixture = new System.Windows.Forms.Button();
            this.btnPrevFix = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNextFix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFixLocation = new System.Windows.Forms.Label();
            this.picLogoHome = new System.Windows.Forms.PictureBox();
            this.lblFixTime = new System.Windows.Forms.Label();
            this.picLogoAway = new System.Windows.Forms.PictureBox();
            this.lblFixDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAwayName = new System.Windows.Forms.Label();
            this.lblHomeName = new System.Windows.Forms.Label();
            this.pnlNoFix = new System.Windows.Forms.Panel();
            this.btnAddFixture2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabTeams = new System.Windows.Forms.TabPage();
            this.lblTeamGoalDiff = new System.Windows.Forms.Label();
            this.lblTeamGamesPlayed = new System.Windows.Forms.Label();
            this.lblTeamPoints = new System.Windows.Forms.Label();
            this.lblTeamPostion = new System.Windows.Forms.Label();
            this.lblTeamLeague = new System.Windows.Forms.Label();
            this.lblTeamNoPlayers = new System.Windows.Forms.Label();
            this.lblTeamStadium = new System.Windows.Forms.Label();
            this.lblTeamManager = new System.Windows.Forms.Label();
            this.lblTeamNickname = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPrevTeam = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.btnNextTeam = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.picTeamLogo = new System.Windows.Forms.PictureBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabPages.SuspendLayout();
            this.tabLeagues.SuspendLayout();
            this.pnlFixtures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAway)).BeginInit();
            this.pnlNoFix.SuspendLayout();
            this.tabTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabLeagues);
            this.tabPages.Controls.Add(this.tabTeams);
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPages.Location = new System.Drawing.Point(15, 22);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Drawing.Point(10, 5);
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(609, 679);
            this.tabPages.TabIndex = 0;
            // 
            // tabLeagues
            // 
            this.tabLeagues.Controls.Add(this.btnEditLeag);
            this.tabLeagues.Controls.Add(this.btnPrevLeag);
            this.tabLeagues.Controls.Add(this.lblLeagName);
            this.tabLeagues.Controls.Add(this.label4);
            this.tabLeagues.Controls.Add(this.lblLeagPrize);
            this.tabLeagues.Controls.Add(this.btnNextLeag);
            this.tabLeagues.Controls.Add(this.lblLeagSponsor);
            this.tabLeagues.Controls.Add(this.lblLeageFixNo);
            this.tabLeagues.Controls.Add(this.label6);
            this.tabLeagues.Controls.Add(this.label2);
            this.tabLeagues.Controls.Add(this.pnlFixtures);
            this.tabLeagues.Controls.Add(this.pnlNoFix);
            this.tabLeagues.Location = new System.Drawing.Point(4, 33);
            this.tabLeagues.Name = "tabLeagues";
            this.tabLeagues.Padding = new System.Windows.Forms.Padding(3);
            this.tabLeagues.Size = new System.Drawing.Size(601, 642);
            this.tabLeagues.TabIndex = 1;
            this.tabLeagues.Text = "Leagues";
            this.tabLeagues.UseVisualStyleBackColor = true;
            this.tabLeagues.Enter += new System.EventHandler(this.tabLeagues_Selected);
            // 
            // btnEditLeag
            // 
            this.btnEditLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLeag.Location = new System.Drawing.Point(239, 10);
            this.btnEditLeag.Name = "btnEditLeag";
            this.btnEditLeag.Size = new System.Drawing.Size(117, 35);
            this.btnEditLeag.TabIndex = 11;
            this.btnEditLeag.Text = "Edit League";
            this.btnEditLeag.UseVisualStyleBackColor = true;
            this.btnEditLeag.Click += new System.EventHandler(this.btnEditLeag_Click);
            // 
            // btnPrevLeag
            // 
            this.btnPrevLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevLeag.Location = new System.Drawing.Point(51, 51);
            this.btnPrevLeag.Name = "btnPrevLeag";
            this.btnPrevLeag.Size = new System.Drawing.Size(117, 35);
            this.btnPrevLeag.TabIndex = 1;
            this.btnPrevLeag.Text = "Prev League";
            this.btnPrevLeag.UseVisualStyleBackColor = true;
            this.btnPrevLeag.Click += new System.EventHandler(this.btnPrevLeag_Click);
            // 
            // lblLeagName
            // 
            this.lblLeagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeagName.Location = new System.Drawing.Point(174, 54);
            this.lblLeagName.Name = "lblLeagName";
            this.lblLeagName.Size = new System.Drawing.Size(252, 32);
            this.lblLeagName.TabIndex = 0;
            this.lblLeagName.Text = "League Name";
            this.lblLeagName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "League Prize:";
            // 
            // lblLeagPrize
            // 
            this.lblLeagPrize.AutoSize = true;
            this.lblLeagPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeagPrize.Location = new System.Drawing.Point(319, 150);
            this.lblLeagPrize.Name = "lblLeagPrize";
            this.lblLeagPrize.Size = new System.Drawing.Size(119, 25);
            this.lblLeagPrize.TabIndex = 6;
            this.lblLeagPrize.Text = "Prize Text";
            // 
            // btnNextLeag
            // 
            this.btnNextLeag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLeag.Location = new System.Drawing.Point(432, 51);
            this.btnNextLeag.Name = "btnNextLeag";
            this.btnNextLeag.Size = new System.Drawing.Size(117, 35);
            this.btnNextLeag.TabIndex = 2;
            this.btnNextLeag.Text = "Next League";
            this.btnNextLeag.UseVisualStyleBackColor = true;
            this.btnNextLeag.Click += new System.EventHandler(this.btnNextLeag_Click);
            // 
            // lblLeagSponsor
            // 
            this.lblLeagSponsor.AutoSize = true;
            this.lblLeagSponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeagSponsor.Location = new System.Drawing.Point(319, 105);
            this.lblLeagSponsor.Name = "lblLeagSponsor";
            this.lblLeagSponsor.Size = new System.Drawing.Size(152, 25);
            this.lblLeagSponsor.TabIndex = 4;
            this.lblLeagSponsor.Text = "Sponsor Text";
            // 
            // lblLeageFixNo
            // 
            this.lblLeageFixNo.AutoSize = true;
            this.lblLeageFixNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeageFixNo.Location = new System.Drawing.Point(319, 192);
            this.lblLeageFixNo.Name = "lblLeageFixNo";
            this.lblLeageFixNo.Size = new System.Drawing.Size(160, 25);
            this.lblLeageFixNo.TabIndex = 8;
            this.lblLeageFixNo.Text = "No of Fix Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "No of Fixtures:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "League Sponsor:";
            // 
            // pnlFixtures
            // 
            this.pnlFixtures.Controls.Add(this.btnDelFix);
            this.pnlFixtures.Controls.Add(this.btnEditFix);
            this.pnlFixtures.Controls.Add(this.btnProcResults);
            this.pnlFixtures.Controls.Add(this.btnAddFixture);
            this.pnlFixtures.Controls.Add(this.btnPrevFix);
            this.pnlFixtures.Controls.Add(this.label8);
            this.pnlFixtures.Controls.Add(this.btnNextFix);
            this.pnlFixtures.Controls.Add(this.label1);
            this.pnlFixtures.Controls.Add(this.label3);
            this.pnlFixtures.Controls.Add(this.label5);
            this.pnlFixtures.Controls.Add(this.lblFixLocation);
            this.pnlFixtures.Controls.Add(this.picLogoHome);
            this.pnlFixtures.Controls.Add(this.lblFixTime);
            this.pnlFixtures.Controls.Add(this.picLogoAway);
            this.pnlFixtures.Controls.Add(this.lblFixDate);
            this.pnlFixtures.Controls.Add(this.label7);
            this.pnlFixtures.Controls.Add(this.lblAwayName);
            this.pnlFixtures.Controls.Add(this.lblHomeName);
            this.pnlFixtures.Location = new System.Drawing.Point(37, 220);
            this.pnlFixtures.Name = "pnlFixtures";
            this.pnlFixtures.Size = new System.Drawing.Size(526, 416);
            this.pnlFixtures.TabIndex = 28;
            // 
            // btnDelFix
            // 
            this.btnDelFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFix.Location = new System.Drawing.Point(328, 329);
            this.btnDelFix.Name = "btnDelFix";
            this.btnDelFix.Size = new System.Drawing.Size(117, 35);
            this.btnDelFix.TabIndex = 25;
            this.btnDelFix.Text = "Delete Fixture";
            this.btnDelFix.UseVisualStyleBackColor = true;
            this.btnDelFix.Click += new System.EventHandler(this.btnDelFix_Click);
            // 
            // btnEditFix
            // 
            this.btnEditFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFix.Location = new System.Drawing.Point(205, 329);
            this.btnEditFix.Name = "btnEditFix";
            this.btnEditFix.Size = new System.Drawing.Size(117, 35);
            this.btnEditFix.TabIndex = 24;
            this.btnEditFix.Text = "Edit Fixture";
            this.btnEditFix.UseVisualStyleBackColor = true;
            this.btnEditFix.Click += new System.EventHandler(this.btnEditFix_Click);
            // 
            // btnProcResults
            // 
            this.btnProcResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcResults.Location = new System.Drawing.Point(165, 375);
            this.btnProcResults.Name = "btnProcResults";
            this.btnProcResults.Size = new System.Drawing.Size(197, 35);
            this.btnProcResults.TabIndex = 29;
            this.btnProcResults.Text = "Process Fixture Results";
            this.btnProcResults.UseVisualStyleBackColor = true;
            this.btnProcResults.Click += new System.EventHandler(this.btnProcResults_Click);
            // 
            // btnAddFixture
            // 
            this.btnAddFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFixture.Location = new System.Drawing.Point(82, 329);
            this.btnAddFixture.Name = "btnAddFixture";
            this.btnAddFixture.Size = new System.Drawing.Size(117, 35);
            this.btnAddFixture.TabIndex = 28;
            this.btnAddFixture.Text = "Add Fixture";
            this.btnAddFixture.UseVisualStyleBackColor = true;
            this.btnAddFixture.Click += new System.EventHandler(this.btnAddFixture_Click);
            // 
            // btnPrevFix
            // 
            this.btnPrevFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevFix.Location = new System.Drawing.Point(14, 16);
            this.btnPrevFix.Name = "btnPrevFix";
            this.btnPrevFix.Size = new System.Drawing.Size(117, 35);
            this.btnPrevFix.TabIndex = 27;
            this.btnPrevFix.Text = "Prev Fixture";
            this.btnPrevFix.UseVisualStyleBackColor = true;
            this.btnPrevFix.Click += new System.EventHandler(this.btnPrevFix_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(172, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "League Fixtures";
            // 
            // btnNextFix
            // 
            this.btnNextFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFix.Location = new System.Drawing.Point(395, 16);
            this.btnNextFix.Name = "btnNextFix";
            this.btnNextFix.Size = new System.Drawing.Size(117, 35);
            this.btnNextFix.TabIndex = 26;
            this.btnNextFix.Text = "Next Fixture";
            this.btnNextFix.UseVisualStyleBackColor = true;
            this.btnNextFix.Click += new System.EventHandler(this.btnNextFix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location:";
            // 
            // lblFixLocation
            // 
            this.lblFixLocation.AutoSize = true;
            this.lblFixLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixLocation.Location = new System.Drawing.Point(270, 115);
            this.lblFixLocation.Name = "lblFixLocation";
            this.lblFixLocation.Size = new System.Drawing.Size(102, 25);
            this.lblFixLocation.TabIndex = 23;
            this.lblFixLocation.Text = "Location";
            // 
            // picLogoHome
            // 
            this.picLogoHome.Image = global::Football_Leagues.Properties.Resources.noLogo;
            this.picLogoHome.Location = new System.Drawing.Point(85, 192);
            this.picLogoHome.Name = "picLogoHome";
            this.picLogoHome.Size = new System.Drawing.Size(120, 120);
            this.picLogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoHome.TabIndex = 16;
            this.picLogoHome.TabStop = false;
            // 
            // lblFixTime
            // 
            this.lblFixTime.AutoSize = true;
            this.lblFixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixTime.Location = new System.Drawing.Point(371, 65);
            this.lblFixTime.Name = "lblFixTime";
            this.lblFixTime.Size = new System.Drawing.Size(63, 25);
            this.lblFixTime.TabIndex = 22;
            this.lblFixTime.Text = "Time";
            // 
            // picLogoAway
            // 
            this.picLogoAway.Image = global::Football_Leagues.Properties.Resources.noLogo;
            this.picLogoAway.Location = new System.Drawing.Point(322, 192);
            this.picLogoAway.Name = "picLogoAway";
            this.picLogoAway.Size = new System.Drawing.Size(120, 120);
            this.picLogoAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoAway.TabIndex = 17;
            this.picLogoAway.TabStop = false;
            // 
            // lblFixDate
            // 
            this.lblFixDate.AutoSize = true;
            this.lblFixDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixDate.Location = new System.Drawing.Point(161, 65);
            this.lblFixDate.Name = "lblFixDate";
            this.lblFixDate.Size = new System.Drawing.Size(61, 25);
            this.lblFixDate.TabIndex = 21;
            this.lblFixDate.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "VS";
            // 
            // lblAwayName
            // 
            this.lblAwayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayName.Location = new System.Drawing.Point(270, 164);
            this.lblAwayName.Name = "lblAwayName";
            this.lblAwayName.Size = new System.Drawing.Size(242, 25);
            this.lblAwayName.TabIndex = 20;
            this.lblAwayName.Text = "Away Name";
            this.lblAwayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHomeName
            // 
            this.lblHomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeName.Location = new System.Drawing.Point(14, 164);
            this.lblHomeName.Name = "lblHomeName";
            this.lblHomeName.Size = new System.Drawing.Size(250, 25);
            this.lblHomeName.TabIndex = 19;
            this.lblHomeName.Text = "Home Name";
            this.lblHomeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNoFix
            // 
            this.pnlNoFix.Controls.Add(this.btnAddFixture2);
            this.pnlNoFix.Controls.Add(this.label10);
            this.pnlNoFix.Controls.Add(this.label9);
            this.pnlNoFix.Location = new System.Drawing.Point(37, 220);
            this.pnlNoFix.Name = "pnlNoFix";
            this.pnlNoFix.Size = new System.Drawing.Size(526, 369);
            this.pnlNoFix.TabIndex = 29;
            // 
            // btnAddFixture2
            // 
            this.btnAddFixture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFixture2.Location = new System.Drawing.Point(202, 228);
            this.btnAddFixture2.Name = "btnAddFixture2";
            this.btnAddFixture2.Size = new System.Drawing.Size(117, 35);
            this.btnAddFixture2.TabIndex = 29;
            this.btnAddFixture2.Text = "Add Fixture";
            this.btnAddFixture2.UseVisualStyleBackColor = true;
            this.btnAddFixture2.Click += new System.EventHandler(this.btnAddFixture2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(318, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "This League Has No Fixtures";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(172, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "League Fixtures";
            // 
            // tabTeams
            // 
            this.tabTeams.Controls.Add(this.lblTeamGoalDiff);
            this.tabTeams.Controls.Add(this.lblTeamGamesPlayed);
            this.tabTeams.Controls.Add(this.lblTeamPoints);
            this.tabTeams.Controls.Add(this.lblTeamPostion);
            this.tabTeams.Controls.Add(this.lblTeamLeague);
            this.tabTeams.Controls.Add(this.lblTeamNoPlayers);
            this.tabTeams.Controls.Add(this.lblTeamStadium);
            this.tabTeams.Controls.Add(this.lblTeamManager);
            this.tabTeams.Controls.Add(this.lblTeamNickname);
            this.tabTeams.Controls.Add(this.label19);
            this.tabTeams.Controls.Add(this.label18);
            this.tabTeams.Controls.Add(this.btnEditTeam);
            this.tabTeams.Controls.Add(this.label17);
            this.tabTeams.Controls.Add(this.label16);
            this.tabTeams.Controls.Add(this.label15);
            this.tabTeams.Controls.Add(this.label14);
            this.tabTeams.Controls.Add(this.label13);
            this.tabTeams.Controls.Add(this.label12);
            this.tabTeams.Controls.Add(this.btnPrevTeam);
            this.tabTeams.Controls.Add(this.lblTeamName);
            this.tabTeams.Controls.Add(this.btnNextTeam);
            this.tabTeams.Controls.Add(this.label11);
            this.tabTeams.Controls.Add(this.picTeamLogo);
            this.tabTeams.Controls.Add(this.btnAddTeam);
            this.tabTeams.Location = new System.Drawing.Point(4, 33);
            this.tabTeams.Name = "tabTeams";
            this.tabTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeams.Size = new System.Drawing.Size(601, 642);
            this.tabTeams.TabIndex = 2;
            this.tabTeams.Text = "Teams";
            this.tabTeams.UseVisualStyleBackColor = true;
            this.tabTeams.Enter += new System.EventHandler(this.tabTeams_Selected);
            // 
            // lblTeamGoalDiff
            // 
            this.lblTeamGoalDiff.AutoSize = true;
            this.lblTeamGoalDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamGoalDiff.Location = new System.Drawing.Point(464, 357);
            this.lblTeamGoalDiff.Name = "lblTeamGoalDiff";
            this.lblTeamGoalDiff.Size = new System.Drawing.Size(93, 25);
            this.lblTeamGoalDiff.TabIndex = 39;
            this.lblTeamGoalDiff.Text = "Number";
            // 
            // lblTeamGamesPlayed
            // 
            this.lblTeamGamesPlayed.AutoSize = true;
            this.lblTeamGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamGamesPlayed.Location = new System.Drawing.Point(464, 314);
            this.lblTeamGamesPlayed.Name = "lblTeamGamesPlayed";
            this.lblTeamGamesPlayed.Size = new System.Drawing.Size(93, 25);
            this.lblTeamGamesPlayed.TabIndex = 38;
            this.lblTeamGamesPlayed.Text = "Number";
            // 
            // lblTeamPoints
            // 
            this.lblTeamPoints.AutoSize = true;
            this.lblTeamPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPoints.Location = new System.Drawing.Point(162, 357);
            this.lblTeamPoints.Name = "lblTeamPoints";
            this.lblTeamPoints.Size = new System.Drawing.Size(93, 25);
            this.lblTeamPoints.TabIndex = 37;
            this.lblTeamPoints.Text = "Number";
            // 
            // lblTeamPostion
            // 
            this.lblTeamPostion.AutoSize = true;
            this.lblTeamPostion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamPostion.Location = new System.Drawing.Point(162, 314);
            this.lblTeamPostion.Name = "lblTeamPostion";
            this.lblTeamPostion.Size = new System.Drawing.Size(93, 25);
            this.lblTeamPostion.TabIndex = 36;
            this.lblTeamPostion.Text = "Number";
            // 
            // lblTeamLeague
            // 
            this.lblTeamLeague.AutoSize = true;
            this.lblTeamLeague.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamLeague.Location = new System.Drawing.Point(188, 166);
            this.lblTeamLeague.Name = "lblTeamLeague";
            this.lblTeamLeague.Size = new System.Drawing.Size(143, 25);
            this.lblTeamLeague.TabIndex = 35;
            this.lblTeamLeague.Text = "League Text";
            // 
            // lblTeamNoPlayers
            // 
            this.lblTeamNoPlayers.AutoSize = true;
            this.lblTeamNoPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNoPlayers.Location = new System.Drawing.Point(188, 201);
            this.lblTeamNoPlayers.Name = "lblTeamNoPlayers";
            this.lblTeamNoPlayers.Size = new System.Drawing.Size(207, 25);
            this.lblTeamNoPlayers.TabIndex = 34;
            this.lblTeamNoPlayers.Text = "No of Players Text";
            // 
            // lblTeamStadium
            // 
            this.lblTeamStadium.AutoSize = true;
            this.lblTeamStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamStadium.Location = new System.Drawing.Point(188, 239);
            this.lblTeamStadium.Name = "lblTeamStadium";
            this.lblTeamStadium.Size = new System.Drawing.Size(150, 25);
            this.lblTeamStadium.TabIndex = 33;
            this.lblTeamStadium.Text = "Stadium Text";
            // 
            // lblTeamManager
            // 
            this.lblTeamManager.AutoSize = true;
            this.lblTeamManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamManager.Location = new System.Drawing.Point(188, 131);
            this.lblTeamManager.Name = "lblTeamManager";
            this.lblTeamManager.Size = new System.Drawing.Size(157, 25);
            this.lblTeamManager.TabIndex = 32;
            this.lblTeamManager.Text = "Manager Text";
            // 
            // lblTeamNickname
            // 
            this.lblTeamNickname.AutoSize = true;
            this.lblTeamNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamNickname.Location = new System.Drawing.Point(188, 95);
            this.lblTeamNickname.Name = "lblTeamNickname";
            this.lblTeamNickname.Size = new System.Drawing.Size(168, 25);
            this.lblTeamNickname.TabIndex = 31;
            this.lblTeamNickname.Text = "Nickname Text";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(85, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 25);
            this.label19.TabIndex = 30;
            this.label19.Text = "League:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(281, 357);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 25);
            this.label18.TabIndex = 29;
            this.label18.Text = "Goal Difference:";
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeam.Location = new System.Drawing.Point(317, 423);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(117, 35);
            this.btnEditTeam.TabIndex = 28;
            this.btnEditTeam.Text = "Edit Team";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(293, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "Games Played:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(71, 357);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 25);
            this.label16.TabIndex = 26;
            this.label16.Text = "Points:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(52, 314);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 25);
            this.label15.TabIndex = 25;
            this.label15.Text = "Position:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "No. of Players:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Stadium:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Manager:";
            // 
            // btnPrevTeam
            // 
            this.btnPrevTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevTeam.Location = new System.Drawing.Point(51, 30);
            this.btnPrevTeam.Name = "btnPrevTeam";
            this.btnPrevTeam.Size = new System.Drawing.Size(117, 35);
            this.btnPrevTeam.TabIndex = 20;
            this.btnPrevTeam.Text = "Prev Team";
            this.btnPrevTeam.UseVisualStyleBackColor = true;
            this.btnPrevTeam.Click += new System.EventHandler(this.btnPrevTeam_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(174, 33);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(252, 32);
            this.lblTeamName.TabIndex = 19;
            this.lblTeamName.Text = "Team Name";
            this.lblTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextTeam
            // 
            this.btnNextTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTeam.Location = new System.Drawing.Point(432, 30);
            this.btnNextTeam.Name = "btnNextTeam";
            this.btnNextTeam.Size = new System.Drawing.Size(117, 35);
            this.btnNextTeam.TabIndex = 21;
            this.btnNextTeam.Text = "Next Team";
            this.btnNextTeam.UseVisualStyleBackColor = true;
            this.btnNextTeam.Click += new System.EventHandler(this.btnNextTeam_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nickname:";
            // 
            // picTeamLogo
            // 
            this.picTeamLogo.Image = global::Football_Leagues.Properties.Resources.noLogo;
            this.picTeamLogo.Location = new System.Drawing.Point(432, 95);
            this.picTeamLogo.Name = "picTeamLogo";
            this.picTeamLogo.Size = new System.Drawing.Size(120, 120);
            this.picTeamLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTeamLogo.TabIndex = 17;
            this.picTeamLogo.TabStop = false;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(167, 423);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(117, 35);
            this.btnAddTeam.TabIndex = 2;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(451, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 35);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 713);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tabPages);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football Resultio";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabPages.ResumeLayout(false);
            this.tabLeagues.ResumeLayout(false);
            this.tabLeagues.PerformLayout();
            this.pnlFixtures.ResumeLayout(false);
            this.pnlFixtures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoAway)).EndInit();
            this.pnlNoFix.ResumeLayout(false);
            this.pnlNoFix.PerformLayout();
            this.tabTeams.ResumeLayout(false);
            this.tabTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTeamLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeageFixNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLeagPrize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLeagSponsor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextLeag;
        private System.Windows.Forms.Button btnPrevLeag;
        private System.Windows.Forms.Label lblLeagName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEditLeag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAwayName;
        private System.Windows.Forms.Label lblHomeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picLogoAway;
        private System.Windows.Forms.PictureBox picLogoHome;
        private System.Windows.Forms.Label lblFixLocation;
        private System.Windows.Forms.Label lblFixTime;
        private System.Windows.Forms.Label lblFixDate;
        private System.Windows.Forms.Button btnDelFix;
        private System.Windows.Forms.Button btnEditFix;
        private System.Windows.Forms.Button btnPrevFix;
        private System.Windows.Forms.Button btnNextFix;
        private System.Windows.Forms.Panel pnlFixtures;
        private System.Windows.Forms.Panel pnlNoFix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddFixture;
        private System.Windows.Forms.Button btnAddFixture2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProcResults;
        private System.Windows.Forms.PictureBox picTeamLogo;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnPrevTeam;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnNextTeam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTeamGoalDiff;
        private System.Windows.Forms.Label lblTeamGamesPlayed;
        private System.Windows.Forms.Label lblTeamPoints;
        private System.Windows.Forms.Label lblTeamPostion;
        private System.Windows.Forms.Label lblTeamLeague;
        private System.Windows.Forms.Label lblTeamNoPlayers;
        private System.Windows.Forms.Label lblTeamStadium;
        private System.Windows.Forms.Label lblTeamManager;
        private System.Windows.Forms.Label lblTeamNickname;
        public System.Windows.Forms.TabControl tabPages;
        public System.Windows.Forms.TabPage tabLeagues;
        public System.Windows.Forms.TabPage tabTeams;
    }
}