
namespace SquareCommand
{
    internal class Level
    {
        internal Tile[][] tiles;
        internal Point goal, playerStart;

        internal Level(string[] level)
        {
            tiles = new Tile[level.Length][];
            for (int y = 0; y < level.Length; y++)
            {
                tiles[y] = new Tile[level[y].Length];
                for (int x = 0; x < level[y].Length; x++)
                {
                    CreateTile(level, y, x);

                    if (level[y][x] == 'P')
                    {
                        playerStart.X = x;
                        playerStart.Y = y;

                    }
                    if (level[y][x] == 'E')
                    {
                        goal.X = x;
                        goal.Y = y;

                    }
                }
            }
        }

        internal Tile GetTile(int x, int y)
        {
            return tiles[y][x];
        }

        private void CreateTile(string[] level, int y, int x)
        {
            tiles[y][x] = new Tile();
            tiles[y][x].x = x;
            tiles[y][x].y = y;

            if (level[y][x] == '#')
            {
                tiles[y][x].blocking = true;
                tiles[y][x].color = Brushes.Gray;
            }
        }
    }
}