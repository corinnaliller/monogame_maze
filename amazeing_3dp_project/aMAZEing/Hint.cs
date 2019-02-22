using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace aMAZEing
{
    public class Hint : GameObject
    {
        private Model model;
        private Spieler spieler;
        private Vector3 ziel;
        public Hint(Game game, Model model, Spieler spieler, Vector2 ziel) : base(game)
        {
            this.model = model;
            this.spieler = spieler;
            this.ziel = new Vector3(ziel.X*5, 1, (ziel.Y+1)*5+2.5f);
            Position = new Vector3(spieler.Position.X,1,spieler.Position.Z);
            Forward = this.ziel - Position;
        }
        public override void Update(GameTime gameTime)
        {
            Position = spieler.Position - new Vector3(0, 1, 0);
            Forward = this.ziel - Position;
        }
        public void Draw(GameTime gameTime, ICamera camera)
        {
            model.Draw(LocalToWorld, camera.View, camera.Projection);
        }
    }
}
