namespace FormUI
{
    partial class Dashboard
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GetAll = new System.Windows.Forms.Button();
            this.FNameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LNameEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailEntry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneEntry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 25;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(40, 103);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(795, 304);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(175, 58);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(267, 32);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(35, 61);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(124, 26);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(465, 57);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 32);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GetAll
            // 
            this.GetAll.Location = new System.Drawing.Point(571, 57);
            this.GetAll.Name = "GetAll";
            this.GetAll.Size = new System.Drawing.Size(112, 32);
            this.GetAll.TabIndex = 4;
            this.GetAll.Text = "All";
            this.GetAll.UseVisualStyleBackColor = true;
            this.GetAll.Click += new System.EventHandler(this.GetAll_Click);
            // 
            // FNameEntry
            // 
            this.FNameEntry.Location = new System.Drawing.Point(187, 428);
            this.FNameEntry.Name = "FNameEntry";
            this.FNameEntry.Size = new System.Drawing.Size(267, 32);
            this.FNameEntry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNameEntry
            // 
            this.LNameEntry.Location = new System.Drawing.Point(187, 466);
            this.LNameEntry.Name = "LNameEntry";
            this.LNameEntry.Size = new System.Drawing.Size(267, 32);
            this.LNameEntry.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // EmailEntry
            // 
            this.EmailEntry.Location = new System.Drawing.Point(187, 504);
            this.EmailEntry.Name = "EmailEntry";
            this.EmailEntry.Size = new System.Drawing.Size(267, 32);
            this.EmailEntry.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // PhoneEntry
            // 
            this.PhoneEntry.Location = new System.Drawing.Point(187, 542);
            this.PhoneEntry.Name = "PhoneEntry";
            this.PhoneEntry.Size = new System.Drawing.Size(267, 32);
            this.PhoneEntry.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone:";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(491, 542);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(108, 32);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Submit";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(857, 103);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(183, 37);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 647);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.GetAll);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.PhoneEntry);
            this.Controls.Add(this.EmailEntry);
            this.Controls.Add(this.LNameEntry);
            this.Controls.Add(this.FNameEntry);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button GetAll;
        private System.Windows.Forms.TextBox FNameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LNameEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

