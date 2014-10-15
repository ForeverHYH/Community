namespace Client
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.communityLabel = new System.Windows.Forms.Label();
            this.communityComboBox = new System.Windows.Forms.ComboBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameLabel.Location = new System.Drawing.Point(114, 115);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 46);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "姓名";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nameTextBox.Location = new System.Drawing.Point(304, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(261, 53);
            this.nameTextBox.TabIndex = 1;
            // 
            // communityLabel
            // 
            this.communityLabel.AutoSize = true;
            this.communityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.communityLabel.Location = new System.Drawing.Point(114, 275);
            this.communityLabel.Name = "communityLabel";
            this.communityLabel.Size = new System.Drawing.Size(100, 46);
            this.communityLabel.TabIndex = 2;
            this.communityLabel.Text = "小区";
            // 
            // communityComboBox
            // 
            this.communityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.communityComboBox.FormattingEnabled = true;
            this.communityComboBox.Items.AddRange(new object[] {
            "小区A",
            "小区B",
            "小区C",
            "小区D",
            "小区E"});
            this.communityComboBox.Location = new System.Drawing.Point(304, 275);
            this.communityComboBox.Name = "communityComboBox";
            this.communityComboBox.Size = new System.Drawing.Size(261, 54);
            this.communityComboBox.TabIndex = 3;
            this.communityComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.commentLabel.Location = new System.Drawing.Point(77, 420);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(180, 46);
            this.commentLabel.TabIndex = 4;
            this.commentLabel.Text = "想说的话";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(304, 387);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(441, 148);
            this.commentTextBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(304, 578);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(234, 72);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "提交";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 695);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.communityComboBox);
            this.Controls.Add(this.communityLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label communityLabel;
        private System.Windows.Forms.ComboBox communityComboBox;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}

