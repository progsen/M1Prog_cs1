

namespace MenuDraw
{
    public partial class Form1 : Form
    {
        string[] names = ["1up", "star", "flower", "mushroom", "10coin", "20coin", "10coin", "20coin", "mushroom"];
        const int w = 22;
        const int h = 32;
        const int rows = 3;
        const int cols = 6;
        private readonly Rectangle cardback;
        Bitmap cardImg = new Bitmap("memory.png");
        Card[] cards;
        Dictionary<string, Rectangle> sprites = new Dictionary<string, Rectangle>()
        {
            {"1up",new Rectangle(172,95,w,h) },
            { "star",new Rectangle(140,95,w,h) },
            { "flower",new Rectangle(108,95,w,h) },
            { "mushroom",new Rectangle(76,95, w, h) },
            { "10coin",new Rectangle(44,95, w, h) },
            { "20coin" ,new Rectangle(12,95, w, h) },
            { "cardback" ,new Rectangle(12,55, w, h) }
        };

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MakeCards();
            cardback = sprites["cardback"];
            MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            //1) maak hier een for loop, die over cards loopt
            for (int i = 0; i < cards.Length; i++)
            {
                //2) pak hier 1 card uit cards, die van [i]
                ????

                //3) maak een if die kijkt of de muis X en Y in card.placement zit
                // HINTS: 
                // https://learn.microsoft.com/en-us/dotnet/api/system.drawing.rectangle.contains?view=net-8.0
                // https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.mouseeventargs?view=windowsdesktop-8.0
                
                //HIER KOMT JE IF
                {
                    //hier zeggen we dat de card omgedraait is
                    card.turned = true;
                }
            }
        }

        private void MakeCards()
        {
            int x = 0;
            int y = 0;
            cards = new Card[rows * cols];
            List<string> options = CreateOptions();

            Random random = new Random();
            for (int i = 0; i < cards.Length; i++)
            {
                int v = random.Next(options.Count);
                string type = options[v];
                options.RemoveAt(v);
                cards[i] = new Card(type, new Rectangle(x * w, y * h, w, h), sprites);
                x++;
                if (x == cols)
                {
                    y++;
                    x = 0;
                }
            }
        }

        private List<string> CreateOptions()
        {
            List<string> options = new List<string>();
            options.AddRange(names);
            options.AddRange(names);
            return options;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Black);

            //4) maak hier een for loop, die over cards loopt
            for (int i = 0; i < cards.Length; i++)
            {
                //5) geef hier de card die in [i] zit door op de ????
                DrawCard(graphics, ???);
            }
        }

        private void DrawCard(Graphics graphics, Card card)
        {
            Rectangle frame = cardback;
            if (card.turned)
            {
                frame = card.frame;
            }

            graphics.DrawImage(cardImg, card.placement, frame, GraphicsUnit.Pixel);
        }

        internal void DoLogic(float frametime)
        {
            //gebruiken we nu even niet
        }
    }
}
