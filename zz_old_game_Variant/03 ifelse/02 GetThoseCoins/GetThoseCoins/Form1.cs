
using System.Diagnostics;

namespace GetThoseCoins
{
    public partial class Form1 : Form
    {

        private const int size = 16;
        Random r = new Random();

        Square player = new Square();
        List<Square> coins = new List<Square>();

        int score = 0;
        bool lDown, rDown;
        DateTime nextCoin = DateTime.Now;


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
            ]
        , size
            );

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            player.x = level.playerStart.X;
            player.y = level.playerStart.Y;

        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            HandleKey(e, false);
        }
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            HandleKey(e, true);
        }


        private void HandleKey(KeyEventArgs e, bool up)
        {
            if (e.KeyCode == Keys.A)
            {
                lDown = up;
            }
            if (e.KeyCode == Keys.D)
            {
                rDown = up;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawLevel(e);

            //speler tekenen
            e.Graphics.FillRectangle(player.color, player.x, player.y, size, size);
            DrawCoins(e);
            e.Graphics.DrawString("Score: " + score, Font, Brushes.White, 10, 10);
        }

        private void DrawLevel(PaintEventArgs e)
        {
            foreach (Tile[] row in level.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.x, tile.y, size, size);
                }
            }
        }

        private void DrawCoins(PaintEventArgs e)
        {
            foreach (Square row in coins)
            {
                e.Graphics.FillRectangle(row.color, row.x, row.y, size, size);
            }
        }

        public void DoLogic(float frametime)
        {

            //1) als lDown true is dan voer je de code hieronder uit (in de  {} van de if)
            //player.x -= 112.5f * frametime;
          

            //2) als rDown true is dan voer je de code hieronder uit (in de  {} van de if)
            //player.x += 112.5f * frametime;
            

            //4) de speler kan nog buiten het scherm komen!!! los dat met een if op.
            // zet bijvoorbeeld de speler x weer terug op size of op het eind van het scherm (size*8)
            SpawnCoins();
            HandleCoinLogic(frametime);
        }

        private void HandleCoinLogic(float frametime)
        {
            foreach (Square tile in coins)
            {
                tile.y -= 100.5f * frametime;
            }
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                Square coin = coins[i];
                float distToPlayer = GetDistanceToPlayer(coin);
                //3) als de coin dicht bij de speler is dan:
                // - gebruik je de code hieronder in de {} van de if
                //          coins.Remove(coin);
                // - tel je 1 bij de score op
               
            }
            coins.RemoveAll(coin => coin.y < -10);
        }

        private float GetDistanceToPlayer(Square coin)
        {
            float dx = coin.x - player.x;
            float dy = coin.y - player.y;
            float distToPlayer = (float)Math.Sqrt((dx * dx) + (dy * dy));
            return distToPlayer;
        }

        private void SpawnCoins()
        {
            if (nextCoin <= DateTime.Now)
            {
                nextCoin = DateTime.Now.AddMilliseconds(250 + r.Next(100));
                coins.Add(new Square() { x = size + r.Next(size * 7), y = size * 10, color = Brushes.Yellow });
            }
        }
    }
}
