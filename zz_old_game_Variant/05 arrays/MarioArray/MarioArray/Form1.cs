namespace MarioArray
{
    public partial class Form1 : Form
    {
        private readonly Image image;
        const int spriteSize = 16;
		
		//UITLEG: deze rectangle geeft aan welk stuk van het plaatje `sprites.png` getekend wordt, probeer het maar aan te passen!
        Rectangle frame = new Rectangle(1, 9, spriteSize, spriteSize);
		
		//UITLEG: elk punt is 1 plek waar we mario willen tekenen
        Point mario1 = new Point(50, 50);
		
		
		//1) vervang de ??? door het type wat daar nodig is
        // > hint: kijk wat er in hoort te zitten, dat kan je zien!
        ??? otherMarios = new ???[] {
            new Point(100,100)
			//2) zet hier nog 4 andere marios neer
			
        };
        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            image = Bitmap.FromFile("sprites.png");


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

            g.DrawImage(image,  new Rectangle(mario1.X, mario1.Y, spriteSize, spriteSize), frame, GraphicsUnit.Pixel);
            for (int i = 0; i < otherMarios.Length; i++)
            {
                g.DrawImage(image, new Rectangle(otherMarios[i].X, otherMarios[i].Y, spriteSize, spriteSize),frame, GraphicsUnit.Pixel);

            }
        }
    }
}
