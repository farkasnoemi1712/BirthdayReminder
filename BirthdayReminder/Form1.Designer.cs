
namespace BirthdayReminder
{
    partial class OverviewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewForm));
            this.todayLabel = new System.Windows.Forms.Label();
            this.nearestLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.birthdayMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Location = new System.Drawing.Point(511, 25);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(59, 25);
            this.todayLabel.TabIndex = 0;
            this.todayLabel.Text = "label1";
            // 
            // nearestLabel
            // 
            this.nearestLabel.AutoSize = true;
            this.nearestLabel.Location = new System.Drawing.Point(511, 74);
            this.nearestLabel.Name = "nearestLabel";
            this.nearestLabel.Size = new System.Drawing.Size(59, 25);
            this.nearestLabel.TabIndex = 1;
            this.nearestLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nearest birthday:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(662, 121);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(59, 25);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "label5";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Age";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(662, 167);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(59, 25);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "label8";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.AutoSize = true;
            this.addButton.Image = global::BirthdayReminder.Properties.Resources.iconfinder_299068_add_sign_icon_32px;
            this.addButton.Location = new System.Drawing.Point(230, 528);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 50);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.removeButton.AutoSize = true;
            this.removeButton.Image = global::BirthdayReminder.Properties.Resources.iconfinder_1646012_cancel_delete_error_exit_remove_icon_32px;
            this.removeButton.Location = new System.Drawing.Point(543, 528);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(119, 50);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove";
            this.removeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // peopleListBox
            // 
            this.peopleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 25;
            this.peopleListBox.Location = new System.Drawing.Point(138, 130);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(306, 354);
            this.peopleListBox.Sorted = true;
            this.peopleListBox.TabIndex = 10;
            this.peopleListBox.SelectedIndexChanged += new System.EventHandler(this.peopleListBox_SelectedIndexChanged);
            // 
            // birthdayMonthCalendar
            // 
            this.birthdayMonthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayMonthCalendar.Enabled = false;
            this.birthdayMonthCalendar.Location = new System.Drawing.Point(511, 221);
            this.birthdayMonthCalendar.MaxSelectionCount = 1;
            this.birthdayMonthCalendar.Name = "birthdayMonthCalendar";
            this.birthdayMonthCalendar.ShowToday = false;
            this.birthdayMonthCalendar.TabIndex = 11;
            // 
            // OverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 626);
            this.Controls.Add(this.birthdayMonthCalendar);
            this.Controls.Add(this.peopleListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nearestLabel);
            this.Controls.Add(this.todayLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anniversary";
            this.Load += new System.EventHandler(this.OverviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.MonthCalendar birthdayMonthCalendar;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label nearestLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}

