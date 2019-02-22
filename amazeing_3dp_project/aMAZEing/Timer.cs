using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    /**
     * Corinna Liller
     * Diese Klasse sollte der Zeiterfassung während des Spiels dienen.
     * Leider zerschließt die Draw-Methode die Darstellung aller anderen Objekte.
     * Deshalb auskommentiert in der Game-Klasse
     */
    public class Timer
    {
        private Game game;
        private int zeit;
        private SpriteFont font;
        private BasicEffect basicEffect;

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
            basicEffect = new BasicEffect(game.GraphicsDevice)
            {
                TextureEnabled = true,
                VertexColorEnabled = true,
            };
        }

        public void Update(GameTime gameTime)
        {
            zeit = Convert.ToInt32(gameTime.TotalGameTime.TotalSeconds);
        }
        public void Draw(GameTime gameTime)
        {
            Game1 g = game as Game1;


            //Vector3 textPosition = new Vector3(0, 45, 0);

            //basicEffect.World = Matrix.CreateConstrainedBillboard(textPosition, textPosition - g.Camera.Forward, Vector3.Down, null, null);
            //basicEffect.View = g.Camera.View;
            //basicEffect.Projection = g.Camera.Projection;

            //const string message = "hello, world!";
            //Vector2 textOrigin = font.MeasureString(message) / 2;
            //const float textSize = 0.25f;

            //g.spriteBatch.Begin(0, null, null, DepthStencilState.DepthRead, RasterizerState.CullNone, basicEffect);
            //g.spriteBatch.DrawString(font, message, Vector2.Zero, Color.White, 0, textOrigin, textSize, 0, 0);
            //g.spriteBatch.End();
        }
    }
}
