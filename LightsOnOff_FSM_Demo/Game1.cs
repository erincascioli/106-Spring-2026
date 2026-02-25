using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


// ----------------------------------------------------------------------------
// Lights on Lights off demo for IGME 106.
// In teams, students should answer the following questions:
//
// What is the outcome of the project/what do you see when it runs?
// What is the purpose of the enum LightState?
// What is the purpose of the enum-type field 'lights'?
// INITIALIZE: What does this method do with the lights field? Why?
// UPDATE: What does the switch statement do? Why?
// DRAW: What does the switch statement do? Why?
// What are the differences between the switches in Update and Draw?
// ----------------------------------------------------------------------------


namespace LightsOnOff_FSM
{
    public enum LightState
    {
        On,
        Off
    }

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private LightState lights;

        private Color backgroundColor;
        private Texture2D lightOn; 
        private Texture2D lightOff;

        private SpriteFont arial20;
        private string instructions;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            lights = LightState.Off;

            if(lights == LightState.Off)
            {
                backgroundColor = Color.Black;
            }
            else
            {
                backgroundColor = Color.Yellow;
            }

            instructions = "Press F to turn light off.\nPress N to turn light on.";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            lightOn = Content.Load<Texture2D>("lightOn");
            lightOff = Content.Load<Texture2D>("lightOff");
            arial20 = Content.Load<SpriteFont>("arial20");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState kbState = Keyboard.GetState();

            switch (lights)
            {
                case LightState.On:
                    backgroundColor = Color.Yellow;

                    if (kbState.IsKeyDown(Keys.F))
                    {
                        lights = LightState.Off;
                    }

                    break;

                case LightState.Off:
                    backgroundColor = new Color(30, 30, 30);

                    if (kbState.IsKeyDown(Keys.N))
                    {
                        lights = LightState.On;
                    }

                    break;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(backgroundColor);

            _spriteBatch.Begin();

            switch (lights)
            {
                case LightState.On:
                    _spriteBatch.Draw(
                        lightOn, 
                        new Vector2(50, 50), 
                        Color.White);
                    _spriteBatch.DrawString(
                        arial20,
                        instructions,
                        new Vector2(400, 20),
                        Color.Black);
                    break;

                case LightState.Off:
                    _spriteBatch.Draw(
                        lightOff, 
                        new Vector2(50, 50), 
                        Color.DarkGray);
                    _spriteBatch.DrawString(
                        arial20,
                        instructions,
                        new Vector2(400, 20),
                        Color.White);
                    break;
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}