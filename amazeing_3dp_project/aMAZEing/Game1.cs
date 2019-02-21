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
        private Plane p;
        private ICamera camera;
        private Grid g;
        private Spieler teekanne;
        private MazeConstructor maze;
        private Mazemap map;
        private MazeFloor floor;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            camera = new ArcBallCamera(this, new Vector3(0, 0, 10));
            ((ArcBallCamera)camera).SetView(ViewMode.Back);
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
            maze = new MazeConstructor(this, hecke, map, 7, 5);
            floor = new MazeFloor(this, gras, 5, map.Part.Length, map.Part.Length);
            //p = new Plane(this, gras, 100, 1);
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
            teekanne.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

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
