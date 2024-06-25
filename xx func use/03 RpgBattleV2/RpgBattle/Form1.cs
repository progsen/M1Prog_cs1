namespace RpgBattle
{
    public partial class Form1 : Form
    {
        int monsterHealth = 100;
        int playerAttack = 20;
        int playerMagicAttack = 50;
        public Form1()
        {
            InitializeComponent();

            ???
            //2) vervang de code hieronder door de updateMonsterHealth();
            monsterhealth.Text=monsterHealth.ToString();
        }

        ???
        //1) maak hier een nieuwe function:
        // UpdateMonsterHealth
        // gebruik private en void
        // zet de code die onder 2) staat tussen de {} (de body)

        private void DoDamage(int damage)
        {

            monsterHealth -= damage;
            ???
            //3) deze code was ook dubbel, gebruik hier ook de function zodat die code wegkan
            monsterhealth.Text = monsterHealth.ToString();
        }
        private void attack_Click(object sender, EventArgs e)
        {
            DoDamage(playerAttack);

        }

        private void fireball_Click(object sender, EventArgs e)
        {
            DoDamage(playerMagicAttack);
        }
    }
}
