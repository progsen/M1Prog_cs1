namespace RpgBattle
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
            attack = new Button();
            fireball = new Button();
            playerchar = new Panel();
            monster = new Panel();
            monsterhealth = new Label();
            monstername = new Label();
            SuspendLayout();
            // 
            // attack
            // 
            attack.Location = new Point(303, 272);
            attack.Name = "attack";
            attack.Size = new Size(75, 23);
            attack.TabIndex = 0;
            attack.Text = "attack";
            attack.UseVisualStyleBackColor = true;
            attack.Click += attack_Click;
            // 
            // fireball
            // 
            fireball.Location = new Point(303, 301);
            fireball.Name = "fireball";
            fireball.Size = new Size(75, 23);
            fireball.TabIndex = 1;
            fireball.Text = "fireball";
            fireball.UseVisualStyleBackColor = true;
            fireball.Click += fireball_Click;
            // 
            // playerchar
            // 
            playerchar.Location = new Point(28, 272);
            playerchar.Name = "playerchar";
            playerchar.Size = new Size(200, 100);
            playerchar.TabIndex = 2;
            // 
            // monster
            // 
            monster.Location = new Point(588, 36);
            monster.Name = "monster";
            monster.Size = new Size(200, 100);
            monster.TabIndex = 3;
            // 
            // monsterhealth
            // 
            monsterhealth.AutoSize = true;
            monsterhealth.Location = new Point(588, 141);
            monsterhealth.Name = "monsterhealth";
            monsterhealth.Size = new Size(18, 15);
            monsterhealth.TabIndex = 4;
            monsterhealth.Text = "-1";
            // 
            // monstername
            // 
            monstername.AutoSize = true;
            monstername.Location = new Point(588, 18);
            monstername.Name = "monstername";
            monstername.Size = new Size(42, 15);
            monstername.TabIndex = 5;
            monstername.Text = "Goblin";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monstername);
            Controls.Add(monsterhealth);
            Controls.Add(monster);
            Controls.Add(playerchar);
            Controls.Add(fireball);
            Controls.Add(attack);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button attack;
        private Button fireball;
        private Panel playerchar;
        private Panel monster;
        private Label monsterhealth;
        private Label monstername;
    }
}
