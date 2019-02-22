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
        public Vector3 PrevPosition { get; set; }
        private Model model;
        public BoundingBox teekanneBox;
        private float speed = 5;
        public float Speed
        {
            get { return speed; }
        }       
        

        public Spieler(Game game, Model model) : base(game)
        {
            this.model = model;
            teekanneBox = CreateBoundingBox();

        }
        

        public void Draw(GameTime gameTime, ICamera camera)
        {
            //Debug.GraphicsManager.DrawLine(teekanneBox, Color.Purple);
            model.Draw(LocalToWorld, camera.View, camera.Projection);
        }


        public override void Update(GameTime gametime)
        {
            KeyboardState keys = Keyboard.GetState();
            teekanneBox = CreateBoundingBox();
            Game1 g = Game as Game1;
            bool collision = false;
            
            foreach (BoundingBox box in g.maze.BoundingBoxes)
            {
                
                if (teekanneBox.Intersects(box))
                {
                    //Console.WriteLine("Collision");
                    collision = true;
                    Position = PrevPosition;
                }

            }
           // if (!collision)
            //{
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
            //}
            PrevPosition = Position;


        }

        public BoundingBox CreateBoundingBox()
        {
            teekanneBox = new BoundingBox(new Vector3(Position.X - 1, Position.Y, Position.Z - 1), new Vector3(Position.X + 1, Position.Y + 2, Position.Z + 1));
            return teekanneBox;
        }

        
    }
}
