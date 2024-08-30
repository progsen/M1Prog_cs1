
namespace Endless
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        private const int speed = 5;

        bool up, down, left, right;
        Square player = new Square();
        Level level = new Level(
            [
                "################",
                "#..............#",
                "#...P..........#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "#..............#",
                "################",
            ]
        , size
            );

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            player.x = size*3;
            player.y = size;

            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
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
            e.Graphics.Clear(Color.Black);

            foreach (Tile[] row in level.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.x, tile.y, size, size);
                }
            }
            e.Graphics.FillRectangle(player.color, player.x, player.y, size, size);
        }

        public void DoLogic(float frametime)
        {
            //2) zorg hier nu dat zowel de x als de y bestuurd kunnen worden

            if (up)
            {
                player.y -= speed;
            }
            if (down)
            {
            }
            if (left)
            {
            }
            if (right)
            {
            }
        }
    }
}
