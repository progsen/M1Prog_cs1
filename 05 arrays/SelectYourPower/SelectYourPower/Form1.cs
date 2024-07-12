

using System.Diagnostics;

namespace SelectYourPower
{
    public partial class Form1 : Form
    {
        private readonly Image image;
        const int spriteSize = 16;

        //UITLEG: deze rectangle geeft aan welk stuk van het plaatje `sprites.png` getekend wordt, probeer het maar aan te passen!
        Rectangle frame = new Rectangle(5, 3, spriteSize * 2, spriteSize);
        Rectangle coin = new Rectangle(8, 26, spriteSize, spriteSize);

        //UITLEG: elk punt is 1 plek waar we mario willen tekenen
        Square player = new Square(50, 50, spriteSize * 2, spriteSize);

        List<Square> pickups = new List<Square>();
        string[] powerUps = new string[] { "speed", "missles", "ripple", "lazer", "option" };
        int powerCount = -1;

        private const int size = 16;
        float playerSpeed = 50;
        float nextPickup = 1;


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
            FormClosing += Form1_FormClosing;
            image = Bitmap.FromFile("sprites.png");
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                SelectPowerUp();
            }
        }

        private void SelectPowerUp()
        {
            //1) reset de powerCount variable naar -1
            powerCount = ???;
        }

        private void PowerAdded()
        {
            //2) tel 1 bij de powerCount op;
            powerCount ???;

            //3) check of de powerCount waarde groter is dan de powerups lengte min 1
            if (powerCount > ???)
            {
                powerCount = 0;
            }
        }
     
        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //opruimen
            image.Dispose();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            g.DrawImage(image, new Rectangle((int)player.x, (int)player.y, (int)player.w, (int)player.h), frame, GraphicsUnit.Pixel);

            for (int i = 0; i < pickups.Count; i++)
            {
                g.DrawImage(image, new Rectangle((int)pickups[i].x, (int)pickups[i].y, (int)pickups[i].w, (int)pickups[i].h), coin, GraphicsUnit.Pixel);
            }

            DrawPowerUpBar(g);
        }

        private void DrawPowerUpBar(Graphics g)
        {
            int x = 0;
            for (int i = 0; i < powerUps.Length; i++)
            {
                //4) maak dit af, zorg dat je de huidige powerUp string pakt uit powerUps, gebruik i
                string powerUp = powerUps???;

                SizeF sizeF = g.MeasureString(powerUp, Font);
                g.DrawString(powerUp, Font, Brushes.White, x, 100);


                if (powerCount == i)
                {
                    g.DrawRectangle(Pens.Yellow, x, 100, sizeF.Width, sizeF.Height);
                }
                else
                {
                    g.DrawRectangle(Pens.White, x, 100, sizeF.Width, sizeF.Height);
                }

                x += (int)sizeF.Width + 5;
            }
        }

        internal void DoLogic(float frametime)
        {
            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                //5) maak dit af, zorg dat je de huidige pickup Square pakt uit pickups, gebruik i
                Square pickup = ???;
                pickup.x += -playerSpeed * frametime;
                if (pickup.x < player.x + player.h)//picked up by player 
                {
                    PowerAdded();
                    pickups.RemoveAt(i);
                }
            }

            SpawnNewPowerUps(frametime);
        }

        private void SpawnNewPowerUps(float frametime)
        {
            nextPickup -= frametime;
            if (nextPickup <= 0)
            {
                pickups.Add(new Square(150, 50, spriteSize, spriteSize));
                nextPickup = 1;
            }
        }
    }
}
