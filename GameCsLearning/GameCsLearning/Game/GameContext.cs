using System.Collections.Generic;

namespace GameJam.Game
{
    public class GameContext
    {
        internal int scaleunit = 4;
        internal int tileSize = 16;
        internal RenderObject player = new RenderObject();
        internal SpriteMap spriteMap = new SpriteMap();
    }
}