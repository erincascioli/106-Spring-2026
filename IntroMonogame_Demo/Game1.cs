using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace IntroMonogame_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Texture2D fields for use in this project
        private Texture2D planet;
        private Texture2D splat;

        // Screen sizing data
        private int screenWidth;
        private int screenHeight;

        // Movement fields
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
            xPosition = 0;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            planet = Content.Load<Texture2D>("planet01");
            splat = Content.Load<Texture2D>("splat02");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            xPosition += 2;

            if(xPosition >= screenWidth)
            {
                xPosition = -splat.Width;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // ALWAYS DO THIS
            _spriteBatch.Begin();

            // Draw the splat to the screen
            _spriteBatch.Draw(
                splat,                          // Texture2D object
                new Vector2(xPosition, 0),      // Upper left position
                Color.Purple);                  // Color tint

            // Draw the planet to the screen
            _spriteBatch.Draw(
                splat,                          // Texture2D object
                new Rectangle(
                    screenWidth/2, 
                    screenHeight/2, 
                    splat.Width/2, 
                    splat.Height/2),            // Rectangle
                Color.SkyBlue);                 // Color tint

            // ALWAYS DO THIS
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
