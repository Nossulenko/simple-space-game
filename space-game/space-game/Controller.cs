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
    class Controller
    {
        public List<Meteorite> meteorites = new List<Meteorite>();
        public double timer = 2D;
        public void conUpdate(GameTime gameTime)
        {
            timer -= gameTime.ElapsedGameTime.TotalSeconds;

            if (timer <= 0)
            {
                meteorites.Add(new Meteorite(250));
                timer = 2D;  
            }
        }
    }
}
