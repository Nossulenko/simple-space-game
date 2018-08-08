﻿using System;
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
        public double maxTime = 2D;
        public int nextSpeed = 240;
        public bool inGame = false;
        public void conUpdate(GameTime gameTime)
        {
            if (inGame)
            {
                timer -= gameTime.ElapsedGameTime.TotalSeconds;
            }
            if (timer <= 0)
            {
                meteorites.Add(new Meteorite(nextSpeed));
                timer = maxTime;
                if(maxTime > 0.5)
                {
                    maxTime -= 0.1D;
                }
                if (nextSpeed < 1200)
                {
                    nextSpeed += 4;
                }
                

            }
        }
    }
}
