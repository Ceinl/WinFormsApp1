namespace WinFormsApp1
{
    partial class CreateCharacterForm
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
            SubmitDataButton = new Button();
            CharacterName = new TextBox();
            SuspendLayout();
            // 
            // SubmitDataButton
            // 
            SubmitDataButton.Location = new Point(779, 875);
            SubmitDataButton.Name = "SubmitDataButton";
            SubmitDataButton.Size = new Size(178, 65);
            SubmitDataButton.TabIndex = 0;
            SubmitDataButton.Text = "submit";
            SubmitDataButton.UseVisualStyleBackColor = true;
            SubmitDataButton.Click += SubmitDataButton_Click;
            // 
            // CharacterName
            // 
            CharacterName.Location = new Point(12, 12);
            CharacterName.Name = "CharacterName";
            CharacterName.Size = new Size(100, 23);
            CharacterName.TabIndex = 1;
            // 
            // CreateCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1876, 952);
            Controls.Add(CharacterName);
            Controls.Add(SubmitDataButton);
            Name = "CreateCharacterForm";
            Text = "CreateCharacterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitDataButton;
        private TextBox CharacterName;
    }
}