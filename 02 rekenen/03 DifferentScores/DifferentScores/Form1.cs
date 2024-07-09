
namespace UpAndDown
{
    public partial class Form1 : Form
    {

        int score = 0;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //1) tel hieronder 1 bij de score op
            }
            if (e.KeyCode == Keys.E)
            {
                //2) tel hieronder 5 bij de score op
            }
            if (e.KeyCode == Keys.W)
            {
                //3) tel hier zelf iets bij de score op
            }
            if (e.KeyCode == Keys.Delete)
            {
                //4) haal hieronder iets van de score af
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            e.Graphics.DrawString("Score: " + score, Font, Brushes.White, 50, 50);

        }

        public void DoLogic(float frametime)
        {
        }
    }
}
