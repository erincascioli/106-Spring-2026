using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

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
        private float radians;

        // SpriteFonts
        private SpriteFont arial20;

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
            radians = 0f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Textures
            splat = Content.Load<Texture2D>("splat02");
            whiteBox = Content.Load<Texture2D>("whiteBox");
            star = Content.Load<Texture2D>("blue_star");

            // SpriteFonts
            arial20 = Content.Load<SpriteFont>("arial-20");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Get KeyboardState (what's happening THIS FRAME only)
            KeyboardState kbState = Keyboard.GetState();

            // Increase X position once per frame
            xPosition += 3;

            if (xPosition > screenWidth)
                xPosition = -splat.Width;

            // ----------------------------------------------------------
            // WHEN I PRESS R KEY
            // Increase radians for constant rotation
            if (kbState.IsKeyDown(Keys.R))
            {
                radians += 0.05f;
            }

            // Once it exceeds 2 pi, reset back to 0.
            if(radians > 6.28f)
            {
                radians = 0;
            }
            // -----------------------------------------------------------

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // --------------------------------------------------------
            // ALWAYS DO THIS!
            _spriteBatch.Begin();

            // 1) Splat at full size, xPosition changes each frame
            _spriteBatch.Draw(
                splat,                              // Texture2D
                new Vector2(xPosition, 100),        // Location upper left corner
                Color.Red);                         // Color tint

            // 2) Splat at full size, X is in center of window
            _spriteBatch.Draw(
                splat,
                new Vector2(screenWidth/2, 200),
                Color.LawnGreen);

            // 3) Splat at full size, in upper-left corner of the game window
            _spriteBatch.Draw(
                splat,
                new Vector2(0, 0),
                Color.White);

            // 4) Splat at full size, xPosition changes each frame
            _spriteBatch.Draw(
                splat,                                          // Texture2D
                new Rectangle(
                    splat.Width/2,                              // Rect: X
                    splat.Height/2,                             // Rect: Y
                    splat.Width,                                // Rect: Width
                    splat.Height),                              // Rect: Height
                null,                                           // Source rectangle (Draw just a portion)
                Color.Yellow,                                   // Color tint
                radians,                                        // Rotation in radians
                new Vector2(splat.Width/2, splat.Height/2),     // Origin point of rotation
                SpriteEffects.None,                             // Flip the image?
                1f);                                            // Layer depth (keep at 1)

            // Start centered around the center of the game window
            _spriteBatch.Draw(
                star, 
                new Rectangle(
                    screenWidth/2 - ((star.Width * 5) / 2), 
                    screenHeight/2 - ((star.Height * 5) / 2), 
                    star.Width*5, 
                    star.Height*5), 
                Color.White);

            // Tet in the top-left corner
            _spriteBatch.DrawString(
                arial20,                                    // SpriteFont
                Math.Round(radians, 1).ToString(),          // Radians text to window
                new Vector2(0, 0),                          // Upper-left corner of text
                Color.Aquamarine);                          // Text color

            // ALWAYS DO THIS!
            _spriteBatch.End();
            // --------------------------------------------------------

            base.Draw(gameTime);
        }
    }
}

