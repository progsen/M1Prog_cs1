

namespace SquareCommand
{
    internal class Square
    {
        public int x, y;
        internal Brush color = Brushes.Red;

        internal void MoveUp(Level level)
        {
            Tile next = level.GetTile(x, y - 1);
            if (next.blocking == false)
            {
                y--;

            }
        }
        internal void MoveDown(Level level)
        {
            Tile next = level.GetTile(x, y + 1);
            if (next.blocking == false)
            {
                y++;

            }
        }
        internal void MoveLeft(Level level)
        {
            Tile next = level.GetTile(x - 1, y);
            if (next.blocking == false)
            {
                x--;

            }
        }
        internal void MoveRight(Level level)
        {
            Tile next = level.GetTile(x+1, y );
            if (next.blocking == false)
            {
                x++;

            }
        }
    }
}