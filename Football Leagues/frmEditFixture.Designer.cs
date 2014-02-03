namespace Football_Leagues
{
    partial class frmEditFixture
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dateFixDate = new System.Windows.Forms.DateTimePicker();
            this.txtFixTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditFix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAway = new System.Windows.Forms.ComboBox();
            this.comboHome = new System.Windows.Forms.ComboBox();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(316, 197);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 35);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(179, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dateFixDate
            // 
            this.dateFixDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFixDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFixDate.Location = new System.Drawing.Point(214, 15);
            this.dateFixDate.Name = "dateFixDate";
            this.dateFixDate.Size = new System.Drawing.Size(118, 26);
            this.dateFixDate.TabIndex = 35;
            // 
            // txtFixTime
            // 
            this.txtFixTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFixTime.Location = new System.Drawing.Point(214, 48);
            this.txtFixTime.Name = "txtFixTime";
            this.txtFixTime.Size = new System.Drawing.Size(118, 26);
            this.txtFixTime.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fixture Away Team:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fixture Home Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fixture Location:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fixture Time:";
            // 
            // btnEditFix
            // 
            this.btnEditFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFix.Location = new System.Drawing.Point(46, 197);
            this.btnEditFix.Name = "btnEditFix";
            this.btnEditFix.Size = new System.Drawing.Size(114, 35);
            this.btnEditFix.TabIndex = 26;
            this.btnEditFix.Text = "Edit Fixture";
            this.btnEditFix.UseVisualStyleBackColor = true;
            this.btnEditFix.Click += new System.EventHandler(this.btnEditFix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fixture Date:";
            // 
            // comboAway
            // 
            this.comboAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAway.FormattingEnabled = true;
            this.comboAway.Location = new System.Drawing.Point(205, 148);
            this.comboAway.Name = "comboAway";
            this.comboAway.Size = new System.Drawing.Size(255, 28);
            this.comboAway.Sorted = true;
            this.comboAway.TabIndex = 67;
            // 
            // comboHome
            // 
            this.comboHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboHome.FormattingEnabled = true;
            this.comboHome.Location = new System.Drawing.Point(205, 114);
            this.comboHome.Name = "comboHome";
            this.comboHome.Size = new System.Drawing.Size(255, 28);
            this.comboHome.Sorted = true;
            this.comboHome.TabIndex = 66;
            // 
            // comboLocation
            // 
            this.comboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Location = new System.Drawing.Point(205, 81);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(255, 28);
            this.comboLocation.Sorted = true;
            this.comboLocation.TabIndex = 65;
            // 
            // frmEditFixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 249);
            this.Controls.Add(this.comboAway);
            this.Controls.Add(this.comboHome);
            this.Controls.Add(this.comboLocation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dateFixDate);
            this.Controls.Add(this.txtFixTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditFix);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "frmEditFixture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Fixture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditFixture_FormClosing);
            this.Load += new System.EventHandler(this.frmEditFixture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dateFixDate;
        private System.Windows.Forms.TextBox txtFixTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditFix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAway;
        private System.Windows.Forms.ComboBox comboHome;
        private System.Windows.Forms.ComboBox comboLocation;
    }
}