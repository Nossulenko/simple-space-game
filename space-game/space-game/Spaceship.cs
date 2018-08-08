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
        public int speed = 180;

        public void shipUpdate(GameTime gameTime)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            //MouseState mState = Mouse.GetState();

            if (kState.IsKeyDown(Keys.Right))
            {
                position.X+= speed * (float)dt;

            }else if (kState.IsKeyDown(Keys.Down)) 
            {
                position.Y+= speed * (float)dt;

            }else if (kState.IsKeyDown(Keys.Left))
            {
                position.X-= speed * (float)dt;

            }else if (kState.IsKeyDown(Keys.Up))
            {
                position.Y-= speed * (float)dt;
            }
            
        }
    }
}
