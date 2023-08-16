namespace WinFormsApp1
{
    partial class CharacterSheet
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
            lbl_CharacterName = new Label();
            label2 = new Label();
            lbl_ClassAndLevel = new Label();
            lbl_Background = new Label();
            lbl_PlayerName = new Label();
            lbl_Race = new Label();
            lbl_Alignment = new Label();
            lbl_ExpiriencePoints = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // lbl_CharacterName
            // 
            lbl_CharacterName.BorderStyle = BorderStyle.FixedSingle;
            lbl_CharacterName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CharacterName.Location = new Point(12, 9);
            lbl_CharacterName.Name = "lbl_CharacterName";
            lbl_CharacterName.Size = new Size(251, 35);
            lbl_CharacterName.TabIndex = 0;
            lbl_CharacterName.Text = "-";
            lbl_CharacterName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Character name";
            // 
            // lbl_ClassAndLevel
            // 
            lbl_ClassAndLevel.BorderStyle = BorderStyle.FixedSingle;
            lbl_ClassAndLevel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ClassAndLevel.Location = new Point(298, 9);
            lbl_ClassAndLevel.Name = "lbl_ClassAndLevel";
            lbl_ClassAndLevel.Size = new Size(251, 35);
            lbl_ClassAndLevel.TabIndex = 2;
            lbl_ClassAndLevel.Text = "-";
            lbl_ClassAndLevel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_ClassAndLevel.Click += lbl_ClassAndLevel_Click;
            // 
            // lbl_Background
            // 
            lbl_Background.BorderStyle = BorderStyle.FixedSingle;
            lbl_Background.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Background.Location = new Point(555, 9);
            lbl_Background.Name = "lbl_Background";
            lbl_Background.Size = new Size(251, 35);
            lbl_Background.TabIndex = 3;
            lbl_Background.Text = "-";
            lbl_Background.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_PlayerName
            // 
            lbl_PlayerName.BorderStyle = BorderStyle.FixedSingle;
            lbl_PlayerName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_PlayerName.Location = new Point(812, 9);
            lbl_PlayerName.Name = "lbl_PlayerName";
            lbl_PlayerName.Size = new Size(251, 35);
            lbl_PlayerName.TabIndex = 4;
            lbl_PlayerName.Text = "-";
            lbl_PlayerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Race
            // 
            lbl_Race.BorderStyle = BorderStyle.FixedSingle;
            lbl_Race.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Race.Location = new Point(298, 73);
            lbl_Race.Name = "lbl_Race";
            lbl_Race.Size = new Size(251, 35);
            lbl_Race.TabIndex = 2;
            lbl_Race.Text = "-";
            lbl_Race.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Alignment
            // 
            lbl_Alignment.BorderStyle = BorderStyle.FixedSingle;
            lbl_Alignment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Alignment.Location = new Point(555, 73);
            lbl_Alignment.Name = "lbl_Alignment";
            lbl_Alignment.Size = new Size(251, 35);
            lbl_Alignment.TabIndex = 3;
            lbl_Alignment.Text = "-";
            lbl_Alignment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ExpiriencePoints
            // 
            lbl_ExpiriencePoints.BorderStyle = BorderStyle.FixedSingle;
            lbl_ExpiriencePoints.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ExpiriencePoints.Location = new Point(812, 73);
            lbl_ExpiriencePoints.Name = "lbl_ExpiriencePoints";
            lbl_ExpiriencePoints.Size = new Size(251, 35);
            lbl_ExpiriencePoints.TabIndex = 4;
            lbl_ExpiriencePoints.Text = "-";
            lbl_ExpiriencePoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(298, 44);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 5;
            label9.Text = "Class and level";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(555, 44);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 6;
            label10.Text = "Background";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(812, 44);
            label11.Name = "label11";
            label11.Size = new Size(72, 15);
            label11.TabIndex = 6;
            label11.Text = "Player name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(298, 108);
            label12.Name = "label12";
            label12.Size = new Size(32, 15);
            label12.TabIndex = 6;
            label12.Text = "Race";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(555, 108);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 7;
            label13.Text = "Alignment";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(812, 108);
            label14.Name = "label14";
            label14.Size = new Size(97, 15);
            label14.TabIndex = 7;
            label14.Text = "Expirience points";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 1211);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lbl_ExpiriencePoints);
            Controls.Add(lbl_PlayerName);
            Controls.Add(lbl_Alignment);
            Controls.Add(lbl_Background);
            Controls.Add(lbl_Race);
            Controls.Add(lbl_ClassAndLevel);
            Controls.Add(label2);
            Controls.Add(lbl_CharacterName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lbl_CharacterName;
        private Label label2;
        private Label lbl_ClassAndLevel;
        private Label lbl_Background;
        private Label lbl_PlayerName;
        private Label lbl_Race;
        private Label lbl_Alignment;
        private Label lbl_ExpiriencePoints;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
    }
}