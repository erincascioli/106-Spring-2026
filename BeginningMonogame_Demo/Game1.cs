using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BeginningMonogame_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Fields for the class: Texture2D (images)
        private Texture2D splat;
        private Texture2D whiteBox;
        private Texture2D star;

        // Fields for the class: screen size
        private int screenWidth;
        private int screenHeight;

        // Fields for the class: movement
        private int xPosition;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void Initialize()
        {
            screenWidth = _graphics.PreferredBackBufferWidth;
            screenHeight = _graphics.PreferredBackBufferHeight;

            // Start my red splat at 0 on the X
            xPosition = 0;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            splat = Content.Load<Texture2D>("splat02");
            whiteBox = Content.Load<Texture2D>("whiteBox");
            star = Content.Load<Texture2D>("blue_star");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Increase X position once per frame
            xPosition += 3;

            if (xPosition > screenWidth)
                xPosition = -splat.Width;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // --------------------------------------------------------
            // ALWAYS DO THIS!
            _spriteBatch.Begin();

            // Draw calls
            _spriteBatch.Draw(
                splat,                              // Texture2D
                new Vector2(xPosition, 0),          // Location upper left corner
                Color.Red);                         // Color tint

            _spriteBatch.Draw(
                splat,                              // Texture2D
                new Vector2(screenWidth/2, 0),      // Location upper left corner
                Color.LawnGreen);                   // Color tint

            _spriteBatch.Draw(
                star, 
                new Rectangle(
                    screenWidth/2 - ((star.Width * 5) / 2), 
                    screenHeight/2 - ((star.Height * 5) / 2), 
                    star.Width*5, 
                    star.Height*5), 
                Color.White);   

            // ALWAYS DO THIS!
            _spriteBatch.End();
            // --------------------------------------------------------

            base.Draw(gameTime);
        }
    }
}

