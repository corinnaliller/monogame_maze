using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace aMAZEing
{
    /**
     * Corinna Liller
     * Diese Klasse hat einen Pfeil, der immer in Richtung Vector3.Forward ("Norden") zeigt.
     * Er dient der Orientierung im Labyrinth.
     */
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
            Position = new Vector3(spieler.Position.X, 1, spieler.Position.Z);
        }
        public void Draw(GameTime gameTime, ICamera camera)
        {
            model.Draw(LocalToWorld, camera.View, camera.Projection);
        }
    }
    
}
