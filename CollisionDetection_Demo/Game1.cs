using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Erin Cascioli
// 2/25/26
// Demo: AABB collision detection with Intersects method

namespace CollisionDetection_Demo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Fields for the demo
        public Rectangle firstBox;
        public Rectangle secondBox;
        public Texture2D boxTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Rectangles are not dependent on loaded content, so they can be initialized
            //   in Initialize instead if LoadContent
            firstBox = new Rectangle(50, 50, 100, 100);
            secondBox = new Rectangle(75, 75, 100, 100);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load the box's texture as a white box so it can be tinted later
            boxTexture = Content.Load<Texture2D>("whiteBox");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Do the 2 Rectangles overlap?
            bool overlap = firstBox.Intersects(secondBox);

            // If so, draw the first one black
            if (overlap)
            {
                _spriteBatch.Draw(boxTexture, firstBox, Color.Black);
            }
            // Otherwise, draw it sea green
            else
            {
                _spriteBatch.Draw(boxTexture, firstBox, Color.DarkSeaGreen);
            }
                
            // Regardless of overlap, draw the second rectangle bright green
            _spriteBatch.Draw(boxTexture, secondBox, Color.LawnGreen);

            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}
