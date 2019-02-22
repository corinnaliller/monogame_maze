using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public class Spieler : GameObject
    {
        Vector3 pos;
        private Model model;
        private BoundingBox teekanneBox;
        private float speed = 5;
        public float Speed
        {
            get { return speed; }
        }       
        

        public Spieler(Game game, Model model, BoundingBox teeKanneBox) : base(game)
        {
            this.model = model;
            teekanneBox = new BoundingBox();

        }
        

        public void Draw(GameTime gameTime, ICamera camera)
        {
            model.Draw(LocalToWorld, camera.View, camera.Projection);
        }


        public override void Update(GameTime gametime)
        {
            KeyboardState keys = Keyboard.GetState();


            if (keys.IsKeyDown(Keys.Down))
            {
                Position = Position + (Forward * (float)gametime.ElapsedGameTime.TotalSeconds * Speed);
                
            }
            if (keys.IsKeyDown(Keys.Up))
            {
                Position = Position + (Backward * (float)gametime.ElapsedGameTime.TotalSeconds * Speed);
            }
            if (keys.IsKeyDown(Keys.Left))
            {
                Position = Position + (Right * (float)gametime.ElapsedGameTime.TotalSeconds * Speed);
            }
            if (keys.IsKeyDown(Keys.Right))
            {
                Position = Position + (Left * (float)gametime.ElapsedGameTime.TotalSeconds * Speed);
            }
        }

        public void CreateBoundingBox()
        {
            teekanneBox = new BoundingBox()
        }
    }
}
