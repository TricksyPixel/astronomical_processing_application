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
            this.ModifyGroupBox = new System.Windows.Forms.GroupBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.NewValueTextBox = new System.Windows.Forms.TextBox();
            this.EnterValueLabel = new System.Windows.Forms.Label();
            this.SlectHourLabel = new System.Windows.Forms.Label();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SearchSortWarningLabel = new System.Windows.Forms.Label();
            this.SearchGroupBox.SuspendLayout();
            this.ModifyGroupBox.SuspendLayout();
            this.SortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataListBox
            // 
            this.DataListBox.FormattingEnabled = true;
            this.DataListBox.Location = new System.Drawing.Point(47, 64);
            this.DataListBox.Margin = new System.Windows.Forms.Padding(2);
            this.DataListBox.Name = "DataListBox";
            this.DataListBox.Size = new System.Drawing.Size(52, 316);
            this.DataListBox.TabIndex = 0;
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Location = new System.Drawing.Point(45, 49);
            this.DataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(33, 13);
            this.DataLabel.TabIndex = 1;
            this.DataLabel.Text = "Data:";
            // 
            // HourListLabel
            // 
            this.HourListLabel.AutoSize = true;
            this.HourListLabel.Location = new System.Drawing.Point(24, 66);
            this.HourListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HourListLabel.Name = "HourListLabel";
            this.HourListLabel.Size = new System.Drawing.Size(22, 312);
            this.HourListLabel.TabIndex = 3;
            this.HourListLabel.Text = "1.\r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10.\r\n11.\r\n12.\r\n13.\r\n14.\r\n15.\r\n16.\r\n17.\r\n18.\r\n" +
    "19.\r\n20.\r\n21.\r\n22.\r\n23.\r\n24.";
            this.HourListLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NeutrinoStreamInfoLabel
            // 
            this.NeutrinoStreamInfoLabel.AutoSize = true;
            this.NeutrinoStreamInfoLabel.Location = new System.Drawing.Point(163, 15);
            this.NeutrinoStreamInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NeutrinoStreamInfoLabel.Name = "NeutrinoStreamInfoLabel";
            this.NeutrinoStreamInfoLabel.Size = new System.Drawing.Size(206, 13);
            this.NeutrinoStreamInfoLabel.TabIndex = 4;
            this.NeutrinoStreamInfoLabel.Text = "Neutrino data streamed from last 24 hours.";
            // 
            // SearchDataLabel
            // 
            this.SearchDataLabel.AutoSize = true;
            this.SearchDataLabel.Location = new System.Drawing.Point(156, 74);
            this.SearchDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchDataLabel.Name = "SearchDataLabel";
            this.SearchDataLabel.Size = new System.Drawing.Size(120, 13);
            this.SearchDataLabel.TabIndex = 5;
            this.SearchDataLabel.Text = "Enter number to search:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(158, 89);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(138, 20);
            this.SearchTextBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(300, 88);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(56, 21);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(156, 138);
            this.ResultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(45, 13);
            this.ResultsLabel.TabIndex = 8;
            this.ResultsLabel.Text = "Results:";
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(158, 153);
            this.ResultsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ResultsListBox.Size = new System.Drawing.Size(199, 69);
            this.ResultsListBox.TabIndex = 9;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchSortWarningLabel);
            this.SearchGroupBox.Location = new System.Drawing.Point(125, 49);
            this.SearchGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SearchGroupBox.Size = new System.Drawing.Size(268, 199);
            this.SearchGroupBox.TabIndex = 10;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Data";
            // 
            // ModifyGroupBox
            // 
            this.ModifyGroupBox.Controls.Add(this.ModifyButton);
            this.ModifyGroupBox.Controls.Add(this.NewValueTextBox);
            this.ModifyGroupBox.Controls.Add(this.EnterValueLabel);
            this.ModifyGroupBox.Controls.Add(this.SlectHourLabel);
            this.ModifyGroupBox.Location = new System.Drawing.Point(125, 263);
            this.ModifyGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyGroupBox.Name = "ModifyGroupBox";
            this.ModifyGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ModifyGroupBox.Size = new System.Drawing.Size(268, 125);
            this.ModifyGroupBox.TabIndex = 11;
            this.ModifyGroupBox.TabStop = false;
            this.ModifyGroupBox.Text = "Modify Data";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(153, 79);
            this.ModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(56, 20);
            this.ModifyButton.TabIndex = 12;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // NewValueTextBox
            // 
            this.NewValueTextBox.Location = new System.Drawing.Point(11, 79);
            this.NewValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NewValueTextBox.Name = "NewValueTextBox";
            this.NewValueTextBox.Size = new System.Drawing.Size(138, 20);
            this.NewValueTextBox.TabIndex = 12;
            // 
            // EnterValueLabel
            // 
            this.EnterValueLabel.AutoSize = true;
            this.EnterValueLabel.Location = new System.Drawing.Point(9, 64);
            this.EnterValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterValueLabel.Name = "EnterValueLabel";
            this.EnterValueLabel.Size = new System.Drawing.Size(87, 13);
            this.EnterValueLabel.TabIndex = 12;
            this.EnterValueLabel.Text = "Enter new value:";
            // 
            // SlectHourLabel
            // 
            this.SlectHourLabel.AutoSize = true;
            this.SlectHourLabel.Location = new System.Drawing.Point(9, 22);
            this.SlectHourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SlectHourLabel.Name = "SlectHourLabel";
            this.SlectHourLabel.Size = new System.Drawing.Size(201, 26);
            this.SlectHourLabel.TabIndex = 12;
            this.SlectHourLabel.Text = "Select a data element you want to modify\r\nand enter a new value to replace it wit" +
    "h.\r\n";
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Controls.Add(this.SortButton);
            this.SortGroupBox.Controls.Add(this.SortLabel);
            this.SortGroupBox.Location = new System.Drawing.Point(125, 404);
            this.SortGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SortGroupBox.Size = new System.Drawing.Size(268, 72);
            this.SortGroupBox.TabIndex = 12;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Sort Data";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(147, 28);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(63, 20);
            this.SortButton.TabIndex = 13;
            this.SortButton.Text = "Sort Data";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(9, 32);
            this.SortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(139, 13);
            this.SortLabel.TabIndex = 13;
            this.SortLabel.Text = "Sort data in numerical order:";
            // 
            // SearchSortWarningLabel
            // 
            this.SearchSortWarningLabel.AutoSize = true;
            this.SearchSortWarningLabel.Location = new System.Drawing.Point(5, 62);
            this.SearchSortWarningLabel.Name = "SearchSortWarningLabel";
            this.SearchSortWarningLabel.Size = new System.Drawing.Size(257, 13);
            this.SearchSortWarningLabel.TabIndex = 13;
            this.SearchSortWarningLabel.Text = "(Searching will result in data being sorted numerically)";
            // 
            // astronomical_processing_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 486);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "astronomical_processing_application";
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

