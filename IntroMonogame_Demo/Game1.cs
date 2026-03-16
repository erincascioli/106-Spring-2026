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
        private float radians;

        // SpriteFont data
        private SpriteFont arial20;

        // Input fields
        private KeyboardState kbState;
        private MouseState mState;


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
            radians = 0f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            planet = Content.Load<Texture2D>("planet01");
            splat = Content.Load<Texture2D>("splat02");

            arial20 = Content.Load<SpriteFont>("arial-20");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // KeyboardState opbject instantiation is done with GetState
            kbState = Keyboard.GetState();
            mState = Mouse.GetState();

            // ALWAYS want the object to move/wrap
            xPosition += 2;

            if(xPosition >= screenWidth)
            {
                xPosition = -splat.Width;
            }

            if (kbState.IsKeyDown(Keys.R) && kbState.IsKeyDown(Keys.LeftShift))
            {
                // ONLY rotate while R is pressed
                radians += 0.05f;
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


            // TODO: Draw one of your sprites somewhere in the bottom right of the game window:
            _spriteBatch.Draw(
                planet,
                new Rectangle(500, 180, planet.Width/4, planet.Height/4),
                Color.Red);

            // Draw it rotated!
            _spriteBatch.Draw(
                planet,
                new Rectangle(
                    500 + (planet.Width/8), 
                    180 + (planet.Height/8), 
                    planet.Width/4, 
                    planet.Height/4),
                null,
                Color.White,
                radians,
                new Vector2(planet.Width/2, planet.Height/2),
                SpriteEffects.None,
                1f);

            _spriteBatch.DrawString(
                arial20,                                            // SpriteFont
                "This text will appear in the foreground",          // Text
                new Vector2(0, 0),                                  // Position upper-left
                Color.Lime);                                        // Color of text

            _spriteBatch.DrawString(
                arial20,                                            // SpriteFont
                mState.X.ToString(),                                 // Text
                new Vector2(0, 80),                                 // Position upper-left
                Color.Maroon);                                      // Color of text

            // ALWAYS DO THIS
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
