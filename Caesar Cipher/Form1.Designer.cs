namespace Caesar_Cipher
{
    partial class homePage
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
            inputTextBox = new TextBox();
            clearButton = new Button();
            encryptButton = new Button();
            title = new Label();
            shiftComboBox = new ComboBox();
            shifterLabel = new Label();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 96);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(787, 23);
            inputTextBox.TabIndex = 0;
            inputTextBox.TextChanged += inputTextBox_TextChanged;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 492);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(72, 58);
            clearButton.TabIndex = 1;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // encryptButton
            // 
            encryptButton.Location = new Point(90, 492);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(72, 58);
            encryptButton.TabIndex = 2;
            encryptButton.Text = "ENCRYPT";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(12, 64);
            title.Name = "title";
            title.Size = new Size(216, 17);
            title.TabIndex = 3;
            title.Text = "Enter what you want to be encrypted:";
            // 
            // shiftComboBox
            // 
            shiftComboBox.FormattingEnabled = true;
            shiftComboBox.Location = new Point(12, 159);
            shiftComboBox.Name = "shiftComboBox";
            shiftComboBox.Size = new Size(171, 23);
            shiftComboBox.TabIndex = 4;
            // 
            // shifterLabel
            // 
            shifterLabel.AutoSize = true;
            shifterLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shifterLabel.ForeColor = SystemColors.ButtonHighlight;
            shifterLabel.Location = new Point(12, 128);
            shifterLabel.Name = "shifterLabel";
            shifterLabel.Size = new Size(82, 17);
            shifterLabel.TabIndex = 5;
            shifterLabel.Text = "And the shift";
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(813, 562);
            Controls.Add(shifterLabel);
            Controls.Add(shiftComboBox);
            Controls.Add(title);
            Controls.Add(encryptButton);
            Controls.Add(clearButton);
            Controls.Add(inputTextBox);
            Name = "homePage";
            Text = "Caesar Cipher";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button clearButton;
        private Button encryptButton;
        private Label title;
        private ComboBox shiftComboBox;
        private Label shifterLabel;
    }
}
