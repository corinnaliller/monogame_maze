using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace aMAZEing
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Model spieler;
        private Vector3 pos;
        double speedx, speedz;
        private Plane p;
        private ICamera camera;
        private Grid g;
        private Spieler teekanne;
<<<<<<< HEAD
        string text, modelRotationstr;
        private float modelRotation = 0.0f;
        private double modelRotationdeg;
        private Matrix projectionMatrix;
        private float aspectRatio;
        private MazeConstructor maze;
        private MazeFloor floor;
        private Mazemap map;
=======
        private MazeConstructor maze;
        private Mazemap map;
        private MazeFloor floor;
>>>>>>> phil_arbeit

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            camera = new ArcBallCamera(this, new Vector3(20, 15, 30));
            ((ArcBallCamera)camera).SetView(ViewMode.Front);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            g = new Grid(this, 5, 10, Color.Gray, Color.Red, Color.Blue);
            pos = Vector3.Zero;
            base.Initialize();
           
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D gras = Content.Load<Texture2D>("Gras");
            Texture2D hecke = Content.Load<Texture2D>("Hecke");
            spieler = Content.Load<Model>("Teapot_red");
            map = new Mazemap();
<<<<<<< HEAD
            maze = new MazeConstructor(this,hecke,map, 7, 5);
            floor = new MazeFloor(this, gras, 5, map.MazeSize, map.MazeSize);
            p = new Plane(this, gras, 100, 1);
=======
            maze = new MazeConstructor(this, hecke, map, 7, 5);
            floor = new MazeFloor(this, gras, 5, map.Part.Length, map.Part.Length);
            //p = new Plane(this, gras, 100, 1);
>>>>>>> phil_arbeit
            teekanne = new Spieler(this, spieler);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            ((ArcBallCamera)camera).Update(gameTime);
            // TODO: Add your update logic here
<<<<<<< HEAD
            modelRotationstr = Convert.ToString(modelRotation);
            speedx = (Math.Sin(modelRotation)) * 30;
            speedz = (Math.Cos(modelRotation)) * 30;
            float speedxdouble, speedzdouble;
            speedxdouble = (float)speedx;
            speedzdouble = (float)speedz;

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                pos += Vector3.Forward * speedzdouble;
                pos += Vector3.Left * speedxdouble;
            }
            if (keyboardState.IsKeyDown(Keys.Down))
            {
                pos += Vector3.Backward * speedzdouble;
                pos += Vector3.Right * speedxdouble;
            }

=======
            teekanne.Update(gameTime);
>>>>>>> phil_arbeit
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Matrix[] transforms = new Matrix[spieler.Bones.Count];
            spieler.CopyAbsoluteBoneTransformsTo(transforms);

            foreach(ModelMesh mesh in spieler.Meshes)
            {
                foreach(BasicEffect effect in mesh.Effects)
                {
                    effect.EnableDefaultLighting();
                    effect.World = transforms[mesh.ParentBone.Index] * Matrix.CreateRotationY(modelRotation) * Matrix.CreateTranslation(pos);
                    effect.Projection = projectionMatrix;
                }
                mesh.Draw();
            }

            // TODO: Add your drawing code here
            g.Draw(camera);
            teekanne.Draw(gameTime, camera);
            //p.Draw(camera);
            maze.Draw(camera);
            floor.Draw(camera);
            base.Draw(gameTime);
        }
    }
}
