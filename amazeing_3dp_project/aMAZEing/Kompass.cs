using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace aMAZEing
{
    public class Kompass : GameObject
    {
        private Model model;
        private Spieler spieler;
        public Kompass(Game game, Model model, Spieler spieler) : base(game)
        {
            this.model = model;
            this.spieler = spieler;
            Forward = Vector3.Forward;
        }
        public override void Update(GameTime gameTime)
        {
            Position = spieler.Position - new Vector3(0, 2, 0);
        }
        public void Draw(GameTime gameTime, ICamera camera)
        {
            model.Draw(LocalToWorld, camera.View, camera.Projection);
        }
    }
    
}
