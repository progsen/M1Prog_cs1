
namespace MenuDraw
{
    class Card
    {
        public Rectangle placement;
        public string sprite;
        public readonly Rectangle frame;
        public bool turned = false;

        public Card(string sprite,Rectangle placement, Dictionary<string, Rectangle> sprites)
        {
            this.placement = placement;
            this.sprite = sprite;
            this.frame = sprites[sprite];
        }

    }
}
