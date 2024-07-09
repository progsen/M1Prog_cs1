
namespace UpAndDown
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        Level level = new Level(
            [
                "#........#",
                "#........#",
                "#...P....#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
                "#........#",
            ]
        , size
            );

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            player.x = (byte)level.playerStart.X;
            player.y = (byte)level.playerStart.X;
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
            player.y += 5;
        }
    }
}
