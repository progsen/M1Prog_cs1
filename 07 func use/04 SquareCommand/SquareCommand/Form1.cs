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
            player.x = level.playerStart.X;
            player.y = level.playerStart.Y;

            endGoal.color = Brushes.Yellow;
            endGoal.x = level.goal.X;
            endGoal.y = level.goal.Y;

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
                    if (player.x == endGoal.x && player.y == endGoal.y)
                    {
                        done= true;
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
                    e.Graphics.FillRectangle(tile.color, tile.x * size, tile.y * size, size, size);
                }

                e.Graphics.FillRectangle(player.color, player.x * size, player.y * size, size, size);
                e.Graphics.FillRectangle(endGoal.color, endGoal.x * size, endGoal.y * size, size, size);

            }
            if (done)
            {
                e.Graphics.DrawString("Winner!", Font, Brushes.Orange, 16 * 5, 16 * 5);
            }
        }
    }
}
