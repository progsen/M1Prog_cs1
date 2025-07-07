

namespace SquareCommand
{
    internal class Square
    {
        public int ix, iy;
        internal Brush color = Brushes.Red;

        internal void MoveUp(Level level)
        {
            Tile next = level.GetTile(ix, iy - 1);
            if (next.blocking == false)
            {
                iy--;

            }
        }
        internal void MoveDown(Level level)
        {
            Tile next = level.GetTile(ix, iy + 1);
            if (next.blocking == false)
            {
                iy++;

            }
        }
        internal void MoveLeft(Level level)
        {
            Tile next = level.GetTile(ix - 1, iy);
            if (next.blocking == false)
            {
                ix--;

            }
        }
        internal void MoveRight(Level level)
        {
            Tile next = level.GetTile(ix+1, iy );
            if (next.blocking == false)
            {
                ix++;

            }
        }
    }
}