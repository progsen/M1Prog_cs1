
namespace MenuDraw
{
    class GameMenuItem
    {
        public Rectangle bounds;
        public string text;
        public Font font = new Font(FontFamily.GenericMonospace, 15);

        public GameMenuItem(string text)
        {
            this.text = text;
            bounds = new Rectangle(0, 0, 300, 60);
        }

        public void Draw(Graphics g)
        {

            g.FillRectangle(Brushes.White, bounds);
            g.DrawRectangle(Pens.Blue, bounds);

            g.DrawString(text, font, Brushes.Black, bounds.X +10,bounds.Y+ 10);
        }
    }
}
