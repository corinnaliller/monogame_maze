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
        public SpriteBatch spriteBatch;
        private Model spieler, arrow,hintArrow;
        private Vector3 pos;
        private Plane p;
        private ICamera camera;
        private Grid g;
        private Spieler teekanne;

        private float modelRotation = 0.0f;
        private double modelRotationdeg;
        private Matrix projectionMatrix;
        private float aspectRatio;
        public MazeConstructor maze;
        private MazeFloor floor;
        private Mazemap map;
        private Kompass kompass;
        private Hint hint;
        private SpriteFont font;
        private Timer timer;

        public ICamera Camera
        {
            get { return camera; }
        }
        public Spieler Player
        {
            get { return teekanne; }
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 800;
            Content.RootDirectory = "Content";

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
            //g = new Grid(this, 5, 10, Color.Gray, Color.Red, Color.Blue);
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
            font = Content.Load<SpriteFont>("Time");
            Texture2D gras = Content.Load<Texture2D>("Gras");
            Texture2D hecke = Content.Load<Texture2D>("Hecke2");
            spieler = Content.Load<Model>("Teapot_red");
            arrow = Content.Load<Model>("Arrow");
            hintArrow = Content.Load<Model>("HintArrow");
            map = new Mazemap(1);
            maze = new MazeConstructor(this,hecke,map, 7, 5);
            floor = new MazeFloor(this, gras, 5, map.MazeSize, map.MazeSize);
            p = new Plane(this, gras, 100, 1);


            teekanne = new Spieler(this, spieler) { Position = new Vector3(map.AnfangsFeld.X + 2.5f, 4, map.AnfangsFeld.Y + 2.5f) };
            teekanne.Scale = new Vector3(0.015f);
            kompass = new Kompass(this, arrow, teekanne) { Scale = new Vector3(0.15f) };
            hint = new Hint(this, hintArrow, teekanne, map.ZielFeld) { Scale = new Vector3(0.2f) };
            
            camera = new ArcBallCamera(this,teekanne);
            timer = new Timer(this, font);
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
            teekanne.Update(gameTime);
            kompass.Update(gameTime);
            hint.Update(gameTime);
            //timer.Update(gameTime);
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
            
            //g.Draw(camera);
            
            //p.Draw(camera);
            maze.Draw(camera);
            floor.Draw(camera);
            teekanne.Draw(gameTime, camera);
            kompass.Draw(gameTime, camera);
            hint.Draw(gameTime, camera);
            //timer.Draw(gameTime);
            base.Draw(gameTime);
        }
    }
}
