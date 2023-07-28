using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace firstProject
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;


        private Texture2D charSprite;
        private Texture2D backgroundSprite;
        private Texture2D objectSprite;

        private Vector2 playerPosition;

        const int charHitbox = 45;

        Character player;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;



        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            charSprite = Content.Load<Texture2D>("ladie");
            backgroundSprite = Content.Load<Texture2D>("sky");
            objectSprite = Content.Load<Texture2D>("tree");


            // Set the resolution to match the background image dimensions
            //_graphics.PreferredBackBufferWidth = backgroundSprite.Width;
            //_graphics.PreferredBackBufferHeight = backgroundSprite.Height;
            //_graphics.ApplyChanges();

            // TODO: use this.Content to load your game content here
            player = new Character(new Vector2(50, 50), charSprite);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

      
            
            player.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);


            // Calculate the position to center the background image
            int screenWidth = GraphicsDevice.Viewport.Width;
            int screenHeight = GraphicsDevice.Viewport.Height;
            int backgroundX = (screenWidth - backgroundSprite.Width) / 2;
            int backgroundY = (screenHeight - backgroundSprite.Height) / 2;



            // TODO: Add your drawing code here
            // start the draw
            _spriteBatch.Begin();
           // _spriteBatch.Draw(backgroundSprite, new Vector2(backgroundX, backgroundY), Color.White);
            //_spriteBatch.Draw(objectSprite, new Vector2(0,0), Color.White);
            //_spriteBatch.Draw(charSprite, playerPosition, Color.White);
            player.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}