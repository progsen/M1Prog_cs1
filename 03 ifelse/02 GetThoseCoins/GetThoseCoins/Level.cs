
using System.Drawing;
using System.Security.Policy;

namespace GetThoseCoins
{
    internal class Level
    {
        internal Tile[][] tiles;
        internal Point goal, playerStart;

        internal Level(string[] level,int size)
        {
            tiles = new Tile[level.Length][];
            for (int y = 0; y < level.Length; y++)
            {
                tiles[y] = new Tile[level[y].Length];
                for (int x = 0; x < level[y].Length; x++)
                {
                    CreateTile(level, y, x, size);

                    if (level[y][x] == 'P')
                    {
                        playerStart.X = x* size;
                        playerStart.Y = y * size;

                    }
                }
            }
        }

        internal Tile GetTile(int x, int y)
        {
            return tiles[y][x];
        }

        private void CreateTile(string[] level, int y, int x,int size)
        {
            tiles[y][x] = new Tile();
            tiles[y][x].x = x * size;
            tiles[y][x].y = y * size;

            if (level[y][x] == '#')
            {
                tiles[y][x].blocking = true;
                tiles[y][x].color = Brushes.Gray;
            }
        }
    }
}