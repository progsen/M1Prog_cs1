


using System.Numerics;

namespace SelectYourPower
{
    internal class GameObject
    {
        public GameRect position;
        public Rectangle sprite;

        internal RectangleF GetRect()
        {
            return new Rectangle((int)position.x, (int)position.y, (int)position.w, (int)position.h);
        }
    }
}