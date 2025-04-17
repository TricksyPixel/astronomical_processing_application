namespace astronomical_processing_application
{
    partial class astronomical_processing_application
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
            this.DataListBox = new System.Windows.Forms.ListBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.HourListLabel = new System.Windows.Forms.Label();
            this.NeutrinoStreamInfoLabel = new System.Windows.Forms.Label();
            this.SearchDataLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchSortWarningLabel = new System.Windows.Forms.Label();
            this.ModifyGroupBox = new System.Windows.Forms.GroupBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.NewValueTextBox = new System.Windows.Forms.TextBox();
            this.EnterValueLabel = new System.Windows.Forms.Label();
            this.SlectHourLabel = new System.Windows.Forms.Label();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox.SuspendLayout();
            this.ModifyGroupBox.SuspendLayout();
            this.SortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataListBox
            // 
            this.DataListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.DataListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.ItemHeight = 16;
            this.DataListBox.Location = new System.Drawing.Point(63, 79);
            this.DataListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(68, 386);
            this.DataListBox.TabIndex = 0;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.ForeColor = System.Drawing.Color.White;
            this.DataLabel.Location = new System.Drawing.Point(60, 60);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(39, 16);
            this.DataLabel.TabIndex = 1;
            this.DataLabel.Text = "Data:";
            // 
            // HourListLabel
            // 
            this.HourListLabel.AutoSize = true;
            this.HourListLabel.ForeColor = System.Drawing.Color.White;
            this.HourListLabel.Location = new System.Drawing.Point(32, 81);
            this.HourListLabel.Name = "HourListLabel";
            this.HourListLabel.Size = new System.Drawing.Size(24, 384);
            this.HourListLabel.TabIndex = 3;
            this.HourListLabel.Text = "1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n11.\r\n12.\r\n13.\r\n14.\r\n15.\r\n16.\r\n17.\r\n18.\r\n" +
    "19.\r\n20.\r\n21.\r\n22.\r\n23.\r\n24.";
            this.HourListLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NeutrinoStreamInfoLabel
            // 
            this.NeutrinoStreamInfoLabel.AutoSize = true;
            this.NeutrinoStreamInfoLabel.ForeColor = System.Drawing.Color.White;
            this.NeutrinoStreamInfoLabel.Location = new System.Drawing.Point(217, 18);
            this.NeutrinoStreamInfoLabel.Name = "NeutrinoStreamInfoLabel";
            this.NeutrinoStreamInfoLabel.Size = new System.Drawing.Size(256, 16);
            this.NeutrinoStreamInfoLabel.TabIndex = 4;
            this.NeutrinoStreamInfoLabel.Text = "Neutrino data streamed from last 24 hours.";
            // 
            // SearchDataLabel
            // 
            this.SearchDataLabel.AutoSize = true;
            this.SearchDataLabel.ForeColor = System.Drawing.Color.White;
            this.SearchDataLabel.Location = new System.Drawing.Point(208, 91);
            this.SearchDataLabel.Name = "SearchDataLabel";
            this.SearchDataLabel.Size = new System.Drawing.Size(147, 16);
            this.SearchDataLabel.TabIndex = 5;
            this.SearchDataLabel.Text = "Enter number to search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchTextBox.Location = new System.Drawing.Point(211, 110);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(183, 22);
            this.SearchTextBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchButton.Location = new System.Drawing.Point(400, 108);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 26);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.ForeColor = System.Drawing.Color.White;
            this.ResultsLabel.Location = new System.Drawing.Point(208, 170);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(55, 16);
            this.ResultsLabel.TabIndex = 8;
            this.ResultsLabel.Text = "Results:";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.ResultsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 16;
            this.ResultsListBox.Location = new System.Drawing.Point(211, 188);
            this.ResultsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ResultsListBox.Size = new System.Drawing.Size(264, 82);
            this.ResultsListBox.TabIndex = 9;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchSortWarningLabel);
            this.SearchGroupBox.ForeColor = System.Drawing.Color.White;
            this.SearchGroupBox.Location = new System.Drawing.Point(167, 60);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchGroupBox.Size = new System.Drawing.Size(363, 245);
            this.SearchGroupBox.TabIndex = 10;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Data";
            // 
            // SearchSortWarningLabel
            // 
            this.SearchSortWarningLabel.AutoSize = true;
            this.SearchSortWarningLabel.ForeColor = System.Drawing.Color.White;
            this.SearchSortWarningLabel.Location = new System.Drawing.Point(10, 77);
            this.SearchSortWarningLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchSortWarningLabel.Name = "SearchSortWarningLabel";
            this.SearchSortWarningLabel.Size = new System.Drawing.Size(324, 16);
            this.SearchSortWarningLabel.TabIndex = 13;
            this.SearchSortWarningLabel.Text = "(Searching will result in data being sorted numerically)";
            // 
            // ModifyGroupBox
            // 
            this.ModifyGroupBox.Controls.Add(this.ModifyButton);
            this.ModifyGroupBox.Controls.Add(this.NewValueTextBox);
            this.ModifyGroupBox.Controls.Add(this.EnterValueLabel);
            this.ModifyGroupBox.Controls.Add(this.SlectHourLabel);
            this.ModifyGroupBox.ForeColor = System.Drawing.Color.White;
            this.ModifyGroupBox.Location = new System.Drawing.Point(167, 324);
            this.ModifyGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyGroupBox.Name = "ModifyGroupBox";
            this.ModifyGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyGroupBox.Size = new System.Drawing.Size(363, 154);
            this.ModifyGroupBox.TabIndex = 11;
            this.ModifyGroupBox.TabStop = false;
            this.ModifyGroupBox.Text = "Modify Data";
            // 
            // ModifyButton
            // 
            this.ModifyButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ModifyButton.Location = new System.Drawing.Point(233, 105);
            this.ModifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 25);
            this.ModifyButton.TabIndex = 12;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // NewValueTextBox
            // 
            this.NewValueTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.NewValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewValueTextBox.Location = new System.Drawing.Point(44, 107);
            this.NewValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewValueTextBox.Name = "NewValueTextBox";
            this.NewValueTextBox.Size = new System.Drawing.Size(183, 22);
            this.NewValueTextBox.TabIndex = 12;
            // 
            // EnterValueLabel
            // 
            this.EnterValueLabel.AutoSize = true;
            this.EnterValueLabel.ForeColor = System.Drawing.Color.White;
            this.EnterValueLabel.Location = new System.Drawing.Point(41, 89);
            this.EnterValueLabel.Name = "EnterValueLabel";
            this.EnterValueLabel.Size = new System.Drawing.Size(104, 16);
            this.EnterValueLabel.TabIndex = 12;
            this.EnterValueLabel.Text = "Enter new value:";
            // 
            // SlectHourLabel
            // 
            this.SlectHourLabel.AutoSize = true;
            this.SlectHourLabel.ForeColor = System.Drawing.Color.White;
            this.SlectHourLabel.Location = new System.Drawing.Point(41, 37);
            this.SlectHourLabel.Name = "SlectHourLabel";
            this.SlectHourLabel.Size = new System.Drawing.Size(249, 32);
            this.SlectHourLabel.TabIndex = 12;
            this.SlectHourLabel.Text = "Select a data element you want to modify\r\nand enter a new value to replace it wit" +
    "h.\r\n";
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.SortButton);
            this.SortGroupBox.Controls.Add(this.SortLabel);
            this.SortGroupBox.ForeColor = System.Drawing.Color.White;
            this.SortGroupBox.Location = new System.Drawing.Point(167, 497);
            this.SortGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortGroupBox.Size = new System.Drawing.Size(363, 89);
            this.SortGroupBox.TabIndex = 12;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Sort Data";
            // 
            // SortButton
            // 
            this.SortButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SortButton.Location = new System.Drawing.Point(224, 36);
            this.SortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(84, 25);
            this.SortButton.TabIndex = 13;
            this.SortButton.Text = "Sort Data";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.ForeColor = System.Drawing.Color.White;
            this.SortLabel.Location = new System.Drawing.Point(41, 40);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(173, 16);
            this.SortLabel.TabIndex = 13;
            this.SortLabel.Text = "Sort data in numerical order:";
            // 
            // astronomical_processing_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.BackgroundImage = global::astronomical_processing_application.Properties.Resources.space_4984262_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(569, 612);
            this.Controls.Add(this.SortGroupBox);
            this.Controls.Add(this.ModifyGroupBox);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchDataLabel);
            this.Controls.Add(this.NeutrinoStreamInfoLabel);
            this.Controls.Add(this.HourListLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataListBox);
            this.Controls.Add(this.SearchGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "astronomical_processing_application";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astronomical Processing";
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ModifyGroupBox.ResumeLayout(false);
            this.ModifyGroupBox.PerformLayout();
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DataListBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label HourListLabel;
        private System.Windows.Forms.Label NeutrinoStreamInfoLabel;
        private System.Windows.Forms.Label SearchDataLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.GroupBox ModifyGroupBox;
        private System.Windows.Forms.Label SlectHourLabel;
        private System.Windows.Forms.Label EnterValueLabel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.TextBox NewValueTextBox;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label SearchSortWarningLabel;
    }
}

