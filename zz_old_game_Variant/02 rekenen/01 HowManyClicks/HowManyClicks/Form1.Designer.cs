namespace HowManyClicks
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
            plusButton = new Button();
            clicksAmountText = new Label();
            clicksText = new Label();
            SuspendLayout();
            // 
            // plusButton
            // 
            plusButton.Location = new Point(42, 82);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(325, 283);
            plusButton.TabIndex = 0;
            plusButton.Text = "click me";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // label1
            // 
            clicksAmountText.AutoSize = true;
            clicksAmountText.Location = new Point(59, 23);
            clicksAmountText.Name = "label1";
            clicksAmountText.Size = new Size(13, 15);
            clicksAmountText.TabIndex = 1;
            clicksAmountText.Text = "0";
            // 
            // label2
            // 
            clicksText.AutoSize = true;
            clicksText.Location = new Point(12, 23);
            clicksText.Name = "label2";
            clicksText.Size = new Size(41, 15);
            clicksText.TabIndex = 2;
            clicksText.Text = "Clicks:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clicksText);
            Controls.Add(clicksAmountText);
            Controls.Add(plusButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plusButton;
        private Label clicksAmountText;
        private Label clicksText;
    }
}
