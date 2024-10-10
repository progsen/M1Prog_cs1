namespace SquareCommand
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Square player = new Square();
        Square endGoal = new Square();

        Action[] steps;
        int step = 0;

        Level level = new Level(
            [
                "##########",
                "#P...#...#",
                "#.####...#",
                "#........#",
                "#...######",
                "###.#....#",
                "#.#....#.#",
                "#.#####..#",
                "#......E##",
                "##########",
            ]

            );
        private bool done;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            player.ix = level.playerStart.X;
            player.iy = level.playerStart.Y;

            endGoal.color = Brushes.Yellow;
            endGoal.ix = level.goal.X;
            endGoal.iy = level.goal.Y;

            // 1) vervang de ???? met 1 van de 4 Move functions van player
            // voorbeeld: player.MoveRight(level)

            //2) zorg dat je de speler bij het einde komt! ( waar de E staat!)
            steps = [

                ()=>????,
                ()=>????,
                // je kan de regel hierboven kopieeren en plakken als je meer stappen nodig hebt
            ];

        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (done)
            {
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (step < steps.Length)
                {
                    steps[step]();
                    step++;
                    if (player.ix == endGoal.ix && player.iy == endGoal.iy)
                    {
                        done = true;
                    }

                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            foreach (Tile[] row in level.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.ix * size, tile.iy * size, size, size);
                }

                e.Graphics.FillRectangle(player.color, player.ix*size , player.iy * size, size, size);
                e.Graphics.FillRectangle(endGoal.color, endGoal.ix * size, endGoal.iy * size, size, size);

            }
            if (done)
            {
                e.Graphics.DrawString("Winner!", Font, Brushes.Orange, 16 * 5, 16 * 5);
            }
        }
    }
}
