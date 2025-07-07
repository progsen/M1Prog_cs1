namespace SquareCommand
{
    public partial class Form1 : Form
    {
        private const int size = 16;
        Level current = null;
        Level[] levels ={
           new Level( [
                "#####",
                "#...#",
                "#...#",
                "#...#",
                "#####",
            ]),

           new Level( [
                "#####",
                "#...#",
                "#.###",
                "#...#",
                "#####",
            ])
                ,
           new Level( [
                "#####",
                "#..##",
                "#...#",
                "##..#",
                "#####",
            ])
                ,
           new Level( [
                "#####",
                "#...#",
                "#.#.#",
                "#...#",
                "#####",
            ])
                ,
           new Level( [
                "#####",
                "#.###",
                "#...#",
                "#...#",
                "#####",
            ])

        };

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;

            current = levels[0];
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Random r = new Random();
                //1) pak een getal van 0 tot de lengte van de array, gebruik de random hierboven
                int nextLevel = ???;

                //2) gebruik het random getal om een level uit de levels te pakken
                Level next = ???;
                //3) zet current op het level wat op de index zit van het getal uit 2)

                current = ???;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            foreach (Tile[] row in current.tiles)
            {
                foreach (Tile tile in row)
                {
                    e.Graphics.FillRectangle(tile.color, tile.x * size, tile.y * size, size, size);
                }


            }
        }
    }
}
