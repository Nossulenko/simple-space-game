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
    class Spaceship
    {
        public Vector2 position = new Vector2(100, 100);
        public int speed = 5;

        public void shipUpdate()
        {
            KeyboardState kState = Keyboard.GetState();
            //MouseState mState = Mouse.GetState();

            if (kState.IsKeyDown(Keys.Right))
            {
                position.X+= speed;
            }else if (kState.IsKeyDown(Keys.Down))
            {
                position.Y+= speed;
            }else if (kState.IsKeyDown(Keys.Left))
            {
                position.X-= speed;
            }else if (kState.IsKeyDown(Keys.Up))
            {
                position.Y-= speed;
            }
            
        }
    }
}
