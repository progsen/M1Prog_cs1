
namespace MovePlayerLoop
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        float playerSpeed = 10;
       
        bool left, right, down, up;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            player.x = 10;
            player.y = 10;
            player.color = Brushes.Red;

        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                right = true;
            }

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;


            g.Clear(Color.Black);
            g.FillRectangle(player.color, player.x * size, player.y * size, size, size);
        }

        internal void DoLogic(float frametime)
        {
            //player.x += playerSpeed * frametime;
            //player.y += playerSpeed * frametime;

        }
    }
}
