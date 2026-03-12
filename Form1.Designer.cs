namespace CatchButton
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
            GameButton = new Button();
            SuspendLayout();
            // 
            // GameButton
            // 
            GameButton.BackColor = SystemColors.Info;
            GameButton.Font = new Font("한컴 말랑말랑 Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            GameButton.ForeColor = SystemColors.HotTrack;
            GameButton.Location = new Point(80, 72);
            GameButton.Name = "GameButton";
            GameButton.Size = new Size(244, 99);
            GameButton.TabIndex = 0;
            GameButton.Text = "나를 잡아봐";
            GameButton.UseVisualStyleBackColor = false;
            GameButton.Click += GameButton_Click_1;
            GameButton.MouseEnter += GameButton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 306);
            Controls.Add(GameButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button GameButton;
    }
}
