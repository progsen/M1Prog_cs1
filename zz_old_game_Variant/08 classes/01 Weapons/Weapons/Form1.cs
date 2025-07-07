

using System.Diagnostics;

namespace SelectYourPower
{
    public partial class Form1 : Form
    {
        private readonly Image image;
        private const int size = 16;

        //UITLEG: deze rectangle geeft aan welk stuk van het plaatje `sprites.png` getekend wordt, probeer het maar aan te passen!

        //UITLEG: elk punt is 1 plek waar we mario willen tekenen
        GameObject player = new GameObject()
        {
            position = new GameRect(50, 50, size * 2, size),
            sprite = new Rectangle(5, 3, size * 2, size)
        };

        List<Bullet> bullets = new List<Bullet>();
        int currentWeapon = 0;
        Weapon[] weapons = new Weapon[4];



        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Rectangle[] weaponSprites = CreateWeaponSprites();


            //1) zorg ervoor dat alle 4 de wapens verschillende plaatjes uit weaponSprites gebruiken
            weapons = new Weapon[4] {
                new Weapon( "red bolt",weaponSprites[0]),
                new Weapon( "lazer",weaponSprites[0]),
                new Weapon( "piercing rect",weaponSprites[0]),
                new Weapon( "green bolt",weaponSprites[0])
            };

            KeyDown += Form1_KeyDown;
            FormClosing += Form1_FormClosing;
            image = Bitmap.FromFile("sprites.png");
        }

        private Rectangle[] CreateWeaponSprites()
        {
            Rectangle[] weaponSprites = new Rectangle[weapons.Length];
            for (int i = 0; i < weaponSprites.Length; i++)
            {
                weaponSprites[i] = new Rectangle(1 + (12 * i), 51, 10, 10);
            }

            return weaponSprites;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K)
            {
                currentWeapon++;
                if (currentWeapon >= weapons.Length)
                {
                    currentWeapon = 0;
                }
            }
            if (e.KeyCode == Keys.L)
            {
                ShootBullet();
            }
        }

        private void ShootBullet()
        {
            Bullet bullet = new Bullet()
            {
                gameObject = new GameObject()
                {
                    sprite = weapons[currentWeapon].sprite,
                    position = new GameRect(player.position.x, player.position.y, 10, 10)
                }
            };
            bullets.Add(bullet);
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

            g.DrawImage(image, player.GetRect(), player.sprite, GraphicsUnit.Pixel);

            for (int i = 0; i < bullets.Count; i++)
            {
                GameObject gameObject = bullets[i].gameObject;
                g.DrawImage(image, gameObject.GetRect(), gameObject.sprite, GraphicsUnit.Pixel);
            }

            g.DrawString(weapons[currentWeapon].name, Font, Brushes.White, 0, 20);

        }


        internal void DoLogic(float frametime)
        {
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = bullets[i];
                bullet.gameObject.position.x += bullet.speed * frametime;
                if (ClientRectangle.Contains((int)bullet.gameObject.position.x, (int)bullet.gameObject.position.y) == false)//picked up by player 
                {
                    bullets.RemoveAt(i);
                }
            }
        }


    }
}
