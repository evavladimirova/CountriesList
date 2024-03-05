namespace CountriesList
{
    partial class Form1
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
            morningRadioButton = new RadioButton();
            afternoonRadioButton = new RadioButton();
            eveningRadioButton = new RadioButton();
            countryComboBox = new ComboBox();
            cityComboBox = new ComboBox();
            moveToRightButton = new Button();
            moveToLeftButton = new Button();
            rigthListBox = new ListBox();
            leftListBox = new ListBox();
            timeGroupBox = new GroupBox();
            hobbiesGroupBox = new GroupBox();
            hobbie4CheckBox = new CheckBox();
            hobbie3CheckBox = new CheckBox();
            hobbie2checkBox = new CheckBox();
            hobbie1CheckBox = new CheckBox();
            questionareLabel = new Label();
            submitButton = new Button();
            timeGroupBox.SuspendLayout();
            hobbiesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // morningRadioButton
            // 
            morningRadioButton.AutoSize = true;
            morningRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            morningRadioButton.Location = new Point(15, 38);
            morningRadioButton.Name = "morningRadioButton";
            morningRadioButton.Size = new Size(132, 36);
            morningRadioButton.TabIndex = 1;
            morningRadioButton.TabStop = true;
            morningRadioButton.Text = "Morning";
            morningRadioButton.UseVisualStyleBackColor = true;
            // 
            // afternoonRadioButton
            // 
            afternoonRadioButton.AutoSize = true;
            afternoonRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            afternoonRadioButton.Location = new Point(15, 89);
            afternoonRadioButton.Name = "afternoonRadioButton";
            afternoonRadioButton.Size = new Size(150, 36);
            afternoonRadioButton.TabIndex = 2;
            afternoonRadioButton.TabStop = true;
            afternoonRadioButton.Text = "Afternoon";
            afternoonRadioButton.UseVisualStyleBackColor = true;
            // 
            // eveningRadioButton
            // 
            eveningRadioButton.AutoSize = true;
            eveningRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eveningRadioButton.Location = new Point(15, 143);
            eveningRadioButton.Name = "eveningRadioButton";
            eveningRadioButton.Size = new Size(124, 36);
            eveningRadioButton.TabIndex = 3;
            eveningRadioButton.TabStop = true;
            eveningRadioButton.Text = "Evening";
            eveningRadioButton.UseVisualStyleBackColor = true;
            // 
            // countryComboBox
            // 
            countryComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Bulgaria", "Italy", "Spain" });
            countryComboBox.Location = new Point(66, 139);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(182, 40);
            countryComboBox.TabIndex = 6;
            countryComboBox.Text = "Country";
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            // 
            // cityComboBox
            // 
            cityComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(66, 411);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(182, 40);
            cityComboBox.TabIndex = 7;
            cityComboBox.Text = "City";
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // moveToRightButton
            // 
            moveToRightButton.Location = new Point(600, 411);
            moveToRightButton.Name = "moveToRightButton";
            moveToRightButton.Size = new Size(57, 50);
            moveToRightButton.TabIndex = 8;
            moveToRightButton.Text = ">>";
            moveToRightButton.UseVisualStyleBackColor = true;
            moveToRightButton.Click += moveToRightButton_Click;
            // 
            // moveToLeftButton
            // 
            moveToLeftButton.Location = new Point(600, 490);
            moveToLeftButton.Name = "moveToLeftButton";
            moveToLeftButton.Size = new Size(57, 50);
            moveToLeftButton.TabIndex = 9;
            moveToLeftButton.Text = "<<";
            moveToLeftButton.UseVisualStyleBackColor = true;
            moveToLeftButton.Click += moveToLeftButton_Click;
            // 
            // rigthListBox
            // 
            rigthListBox.FormattingEnabled = true;
            rigthListBox.ItemHeight = 25;
            rigthListBox.Location = new Point(722, 411);
            rigthListBox.Name = "rigthListBox";
            rigthListBox.Size = new Size(180, 129);
            rigthListBox.TabIndex = 10;
            rigthListBox.SelectedIndexChanged += rigthListBox_SelectedIndexChanged;
            // 
            // leftListBox
            // 
            leftListBox.FormattingEnabled = true;
            leftListBox.ItemHeight = 25;
            leftListBox.Location = new Point(357, 411);
            leftListBox.Name = "leftListBox";
            leftListBox.Size = new Size(180, 129);
            leftListBox.TabIndex = 11;
            leftListBox.SelectedIndexChanged += leftListBox_SelectedIndexChanged;
            // 
            // timeGroupBox
            // 
            timeGroupBox.Controls.Add(morningRadioButton);
            timeGroupBox.Controls.Add(afternoonRadioButton);
            timeGroupBox.Controls.Add(eveningRadioButton);
            timeGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeGroupBox.Location = new Point(715, 125);
            timeGroupBox.Name = "timeGroupBox";
            timeGroupBox.Size = new Size(187, 191);
            timeGroupBox.TabIndex = 12;
            timeGroupBox.TabStop = false;
            timeGroupBox.Text = "Time";
            timeGroupBox.Enter += timeGroupBox_Enter;
            // 
            // hobbiesGroupBox
            // 
            hobbiesGroupBox.Controls.Add(hobbie4CheckBox);
            hobbiesGroupBox.Controls.Add(hobbie3CheckBox);
            hobbiesGroupBox.Controls.Add(hobbie2checkBox);
            hobbiesGroupBox.Controls.Add(hobbie1CheckBox);
            hobbiesGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hobbiesGroupBox.Location = new Point(357, 125);
            hobbiesGroupBox.Name = "hobbiesGroupBox";
            hobbiesGroupBox.Size = new Size(300, 253);
            hobbiesGroupBox.TabIndex = 13;
            hobbiesGroupBox.TabStop = false;
            hobbiesGroupBox.Text = "Hobbies";
            hobbiesGroupBox.Enter += hobbiesGroupBox_Enter;
            // 
            // hobbie4CheckBox
            // 
            hobbie4CheckBox.AutoSize = true;
            hobbie4CheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hobbie4CheckBox.Location = new Point(19, 200);
            hobbie4CheckBox.Name = "hobbie4CheckBox";
            hobbie4CheckBox.Size = new Size(213, 36);
            hobbie4CheckBox.TabIndex = 3;
            hobbie4CheckBox.Text = "Mountainbiking";
            hobbie4CheckBox.UseVisualStyleBackColor = true;
            hobbie4CheckBox.CheckedChanged += hobbie4CheckBox_CheckedChanged;
            // 
            // hobbie3CheckBox
            // 
            hobbie3CheckBox.AutoSize = true;
            hobbie3CheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hobbie3CheckBox.Location = new Point(19, 144);
            hobbie3CheckBox.Name = "hobbie3CheckBox";
            hobbie3CheckBox.Size = new Size(85, 36);
            hobbie3CheckBox.TabIndex = 2;
            hobbie3CheckBox.Text = "Golf";
            hobbie3CheckBox.UseVisualStyleBackColor = true;
            hobbie3CheckBox.CheckedChanged += hobbie3CheckBox_CheckedChanged;
            // 
            // hobbie2checkBox
            // 
            hobbie2checkBox.AutoSize = true;
            hobbie2checkBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hobbie2checkBox.Location = new Point(19, 89);
            hobbie2checkBox.Name = "hobbie2checkBox";
            hobbie2checkBox.Size = new Size(180, 36);
            hobbie2checkBox.TabIndex = 1;
            hobbie2checkBox.Text = "Horse Riding";
            hobbie2checkBox.UseVisualStyleBackColor = true;
            hobbie2checkBox.CheckedChanged += hobbie2checkBox_CheckedChanged;
            // 
            // hobbie1CheckBox
            // 
            hobbie1CheckBox.AutoSize = true;
            hobbie1CheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hobbie1CheckBox.Location = new Point(19, 39);
            hobbie1CheckBox.Name = "hobbie1CheckBox";
            hobbie1CheckBox.Size = new Size(131, 36);
            hobbie1CheckBox.TabIndex = 0;
            hobbie1CheckBox.Text = "Drawing";
            hobbie1CheckBox.UseVisualStyleBackColor = true;
            hobbie1CheckBox.CheckedChanged += hobbie1CheckBox_CheckedChanged;
            // 
            // questionareLabel
            // 
            questionareLabel.AutoSize = true;
            questionareLabel.Font = new Font("Zing Rust Demo Base", 27.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionareLabel.Location = new Point(345, 26);
            questionareLabel.Name = "questionareLabel";
            questionareLabel.Size = new Size(312, 68);
            questionareLabel.TabIndex = 14;
            questionareLabel.Text = "Questionare";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.DarkSlateBlue;
            submitButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.ForeColor = SystemColors.ButtonHighlight;
            submitButton.Location = new Point(345, 584);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(566, 59);
            submitButton.TabIndex = 15;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1020, 665);
            Controls.Add(submitButton);
            Controls.Add(questionareLabel);
            Controls.Add(hobbiesGroupBox);
            Controls.Add(timeGroupBox);
            Controls.Add(leftListBox);
            Controls.Add(rigthListBox);
            Controls.Add(moveToLeftButton);
            Controls.Add(moveToRightButton);
            Controls.Add(cityComboBox);
            Controls.Add(countryComboBox);
            Name = "Form1";
            Text = "Form1";
            timeGroupBox.ResumeLayout(false);
            timeGroupBox.PerformLayout();
            hobbiesGroupBox.ResumeLayout(false);
            hobbiesGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton morningRadioButton;
        private RadioButton afternoonRadioButton;
        private RadioButton eveningRadioButton;
        private ComboBox countryComboBox;
        private ComboBox cityComboBox;
        private Button moveToRightButton;
        private Button moveToLeftButton;
        private ListBox rigthListBox;
        private ListBox leftListBox;
        private GroupBox timeGroupBox;
        private GroupBox hobbiesGroupBox;
        private Label questionareLabel;
        private CheckBox hobbie4CheckBox;
        private CheckBox hobbie3CheckBox;
        private CheckBox hobbie2checkBox;
        private CheckBox hobbie1CheckBox;
        private Button submitButton;
    }
}
