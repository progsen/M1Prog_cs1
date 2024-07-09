
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

            player.x = size*3;
            player.y = size;
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
			//2) Zoek uit waarom de speler weer naar boven gaat, zet de reden hieronder achter de  //> neer
			//>
            player.y += 5;
        }
    }
}
