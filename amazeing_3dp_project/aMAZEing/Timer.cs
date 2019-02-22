using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public class Timer
    {
        private Game game;
        private int zeit;
        private SpriteFont font;

        public string ZeitString
        {
            get
            {
                int min = zeit / 60;
                int sec = zeit % 60;
                string minString = Convert.ToString(min);
                string secString = Convert.ToString(sec);
                if (min < 10)
                {
                    minString = "0" + Convert.ToString(min);
                }
                if (sec < 10)
                {
                    secString = "0" + Convert.ToString(sec);
                }
                return minString + " : " + secString;
            }
        }

        public Timer(Game game, SpriteFont font)
        {
            this.game = game;
            this.zeit = 0;
            this.font = font;
        }

        public void Update(GameTime gameTime)
        {
            zeit = Convert.ToInt32(gameTime.TotalGameTime.TotalSeconds);
        }
        public void Draw(GameTime gameTime)
        {
            Game1 g = game as Game1;

            //g.spriteBatch.Begin(0, BlendState.Opaque, null, null, null, desaturateEffect);
            //g.spriteBatch.Draw(font, ZeitString, new Vector2(100, 100), Color.Black);
            //g.spriteBatch.End();
           
        }
    }
}
