
namespace SquareCommand
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        bool run = false;
        Level level = new Level(
            [
                "#.........",
                "#.........",
                "#...P.....",
                "#.........",
                "#.........",
                "#.........",
                "#.........",
                "########..",
                "#.........",
                "#.........",
            ]
        , size
            );
        private bool done;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            player.x = level.playerStart.X;
            player.y = level.playerStart.Y;

        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (done)
            {
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                run = true;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DoLogic();
            foreach (Tile[] row in level.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.x, tile.y, size, size);
                }

                e.Graphics.FillRectangle(player.color, player.x, player.y, size, size);

            }

            Invalidate();
        }

        private void DoLogic()
        {
            if (run == false)
            {
                return;
            }
            //1) maak hieronder een variable:
            //- type: int
            //- naam: ground
            //- met de waarde van 7 keer size

            //2) maak hieronder een variable:
            //- type: float
            //- naam: playerBottom
            //- met de waarde van player.y plus size
            

            //3) gebruik een If om te kijken of de playerBottom < ground
            // dan mag je de player bewegen, anders niet!

                player.y += 0.5f;
        }
    }
}
