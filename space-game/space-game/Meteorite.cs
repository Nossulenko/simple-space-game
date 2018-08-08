using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace space_game
{
    class Meteorite
    {
        public Vector2 position = new Vector2(600, 300);
        public int speed;
        public int radius = 59;

        public Meteorite(int newSpeed)
        {
            speed = newSpeed;
        }
        public void meteoriteUpdate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
