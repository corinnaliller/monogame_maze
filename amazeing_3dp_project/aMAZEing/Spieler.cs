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
    class Spieler : GameObject
    {
        private Vector3 ziel;
        private Model model;
        private float speed = 5;
        public float Speed
        {
            get { return speed; }
            set
            {
                ;
            }
        }       
        

        public Spieler(Game game, Model model, Vector2 ziel) : base(game)
        {
            this.model = model;
            this.ziel = new Vector3(ziel.X * 5, 3, ziel.Y * 5);
            
        }
        public void LoadContent()
        {
            
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
            //Forward = Position - ziel;
        }
    }
}
