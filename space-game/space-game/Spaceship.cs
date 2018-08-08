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
        public int speed = 180;
        static public Vector2 defaultPosition = new Vector2(900, 600);
        public Vector2 position = defaultPosition;


        public void shipUpdate(GameTime gameTime, Controller gameController)
        {
            KeyboardState kState = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            //MouseState mState = Mouse.GetState();

            if (gameController.inGame == false)
            {
                if (kState.IsKeyDown(Keys.Right))
                {
                    position.X += speed * dt;

                }
                else if (kState.IsKeyDown(Keys.Down))
                {
                    position.Y += speed * dt;

                }
                else if (kState.IsKeyDown(Keys.Left))
                {
                    position.X -= speed * dt;

                }
                else if (kState.IsKeyDown(Keys.Up))
                {
                    position.Y -= speed * dt;
                }
            }            
        }
    }
}
