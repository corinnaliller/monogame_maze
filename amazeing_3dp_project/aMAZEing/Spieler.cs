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
        private Vector3 prevCameraPosition;
        private Model model;
        public BoundingBox TeekanneBox;
        public List<BoundingBox> BoundingBoxes;
        private float speed = 5;
        public bool HitWall { get; set; }
        public float Speed
        {
            get { return speed; }
        }       
        

        public Spieler(Game game, Model model) : base(game)
        {
            this.model = model;
            TeekanneBox = CreateBoundingBox();

        }
        

        public void Draw(GameTime gameTime, ICamera camera)
        {
            model.Draw(LocalToWorld, camera.View, camera.Projection);
        }


        public override void Update(GameTime gametime)
        {
            KeyboardState keys = Keyboard.GetState();
            TeekanneBox = CreateBoundingBox();
            Game1 g = Game as Game1;
            HitWall = false;
            
            foreach (BoundingBox box in g.maze.BoundingBoxes)
            {
                
                    if (TeekanneBox.Intersects(box))
                    {
                        Console.WriteLine("Collision");
                        HitWall = true;
                        Position = PrevPosition;
                        g.Camera.Position = prevCameraPosition;
                    }
                
                

            }
            
            if (!HitWall)
            {
                if((Convert.ToInt32(gametime.TotalGameTime.TotalMilliseconds) % 100) == 0)
                {
                    PrevPosition = Position;
                    prevCameraPosition = g.Camera.Position;
                }

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
            
            


        }

        public BoundingBox CreateBoundingBox()
        {
            BoundingBox box = new BoundingBox(Position - new Vector3(0.5f), Position + new Vector3(0.5f));
            return box;
        }
        


    }
}
