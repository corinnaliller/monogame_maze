using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public class Timer
    {
        private double zeit;
        public string ZeitString
        {
            get
            {
                int min = Convert.ToInt32(zeit) / 60;
                int sec = Convert.ToInt32(zeit) % 60;
                string minString = Convert.ToString(min);
                string secString = Convert.ToString(sec);
                if (min < 10)
                {
                    minString = "0"+Convert.ToString(min);
                }
                if (sec < 10)
                {
                    secString = "0"+Convert.ToString(sec);
                }
                return minString + " : " + secString;
            }
        }
        
        public Timer()
        {
            this.zeit = 0;
        }

        public void Update(GameTime gameTime)
        {
            zeit = gameTime.TotalGameTime.TotalSeconds;
        }
    }
}
