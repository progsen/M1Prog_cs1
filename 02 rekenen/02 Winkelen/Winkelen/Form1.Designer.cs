namespace Winkelen
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
            calculateTotal = new Button();
            label1 = new Label();
            totalPrice = new TextBox();
            koopPs5 = new Button();
            koopElden = new Button();
            koopSponge = new Button();
            koopSpiderman = new Button();
            koopController = new Button();
            labelPs5Amount = new Label();
            labelCtrlAmount = new Label();
            labelSpongeAmount = new Label();
            labelSpiderAmount = new Label();
            labelEldenAmount = new Label();
            SuspendLayout();
            // 
            // calculateTotal
            // 
            calculateTotal.Location = new Point(236, 55);
            calculateTotal.Name = "calculateTotal";
            calculateTotal.Size = new Size(144, 23);
            calculateTotal.TabIndex = 0;
            calculateTotal.Text = "bereken totaal";
            calculateTotal.UseVisualStyleBackColor = true;
            calculateTotal.Click += calculateTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 58);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "totaal:";
            // 
            // totalPrice
            // 
            totalPrice.Enabled = false;
            totalPrice.Location = new Point(112, 55);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(100, 23);
            totalPrice.TabIndex = 2;
            totalPrice.Text = "0";
            // 
            // koopPs5
            // 
            koopPs5.Location = new Point(70, 234);
            koopPs5.Name = "koopPs5";
            koopPs5.Size = new Size(82, 76);
            koopPs5.TabIndex = 3;
            koopPs5.Text = "Ps5";
            koopPs5.UseVisualStyleBackColor = true;
            koopPs5.Click += koopPs5_Click;
            // 
            // koopElden
            // 
            koopElden.Location = new Point(477, 234);
            koopElden.Name = "koopElden";
            koopElden.Size = new Size(82, 76);
            koopElden.TabIndex = 4;
            koopElden.Text = "Elden ring";
            koopElden.UseVisualStyleBackColor = true;
            koopElden.Click += koopElden_Click;
            // 
            // koopSponge
            // 
            koopSponge.Location = new Point(298, 234);
            koopSponge.Name = "koopSponge";
            koopSponge.Size = new Size(82, 76);
            koopSponge.TabIndex = 5;
            koopSponge.Text = "Sponge bob";
            koopSponge.UseVisualStyleBackColor = true;
            koopSponge.Click += koopSponge_Click;
            // 
            // koopSpiderman
            // 
            koopSpiderman.Location = new Point(389, 234);
            koopSpiderman.Name = "koopSpiderman";
            koopSpiderman.Size = new Size(82, 76);
            koopSpiderman.TabIndex = 6;
            koopSpiderman.Text = "Spiderman";
            koopSpiderman.UseVisualStyleBackColor = true;
            koopSpiderman.Click += koopSpiderman_Click;
            // 
            // koopController
            // 
            koopController.Location = new Point(158, 234);
            koopController.Name = "koopController";
            koopController.Size = new Size(82, 76);
            koopController.TabIndex = 7;
            koopController.Text = "Dualshock 5";
            koopController.UseVisualStyleBackColor = true;
            koopController.Click += koopController_Click;
            // 
            // label2
            // 
            labelPs5Amount.AutoSize = true;
            labelPs5Amount.Location = new Point(70, 325);
            labelPs5Amount.Name = "label2";
            labelPs5Amount.Size = new Size(38, 15);
            labelPs5Amount.TabIndex = 8;
            labelPs5Amount.Text = "0";
            // 
            // label3
            // 
            labelCtrlAmount.AutoSize = true;
            labelCtrlAmount.Location = new Point(158, 325);
            labelCtrlAmount.Name = "label3";
            labelCtrlAmount.Size = new Size(38, 15);
            labelCtrlAmount.TabIndex = 9;
            labelCtrlAmount.Text = "0";
            // 
            // label4
            // 
            labelSpongeAmount.AutoSize = true;
            labelSpongeAmount.Location = new Point(298, 325);
            labelSpongeAmount.Name = "label4";
            labelSpongeAmount.Size = new Size(38, 15);
            labelSpongeAmount.TabIndex = 10;
            labelSpongeAmount.Text = "0";
            // 
            // label5
            // 
            labelSpiderAmount.AutoSize = true;
            labelSpiderAmount.Location = new Point(389, 325);
            labelSpiderAmount.Name = "label5";
            labelSpiderAmount.Size = new Size(38, 15);
            labelSpiderAmount.TabIndex = 11;
            labelSpiderAmount.Text = "0";
            // 
            // label6
            // 
            labelEldenAmount.AutoSize = true;
            labelEldenAmount.Location = new Point(477, 325);
            labelEldenAmount.Name = "label6";
            labelEldenAmount.Size = new Size(38, 15);
            labelEldenAmount.TabIndex = 12;
            labelEldenAmount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEldenAmount);
            Controls.Add(labelSpiderAmount);
            Controls.Add(labelSpongeAmount);
            Controls.Add(labelCtrlAmount);
            Controls.Add(labelPs5Amount);
            Controls.Add(koopController);
            Controls.Add(koopSpiderman);
            Controls.Add(koopSponge);
            Controls.Add(koopElden);
            Controls.Add(koopPs5);
            Controls.Add(totalPrice);
            Controls.Add(label1);
            Controls.Add(calculateTotal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateTotal;
        private Label label1;
        private TextBox totalPrice;
        private Button koopPs5;
        private Button koopElden;
        private Button koopSponge;
        private Button koopSpiderman;
        private Button koopController;
        private Label labelPs5Amount;
        private Label labelCtrlAmount;
        private Label labelSpongeAmount;
        private Label labelSpiderAmount;
        private Label labelEldenAmount;
    }
}
