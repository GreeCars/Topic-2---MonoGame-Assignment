using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2___MonoGame_Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Texture2D rectangleTexture;

        Rectangle head, leftEyeRect, rightEyeRect, mouthRect;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 600;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            head = new Rectangle(150, 50, 500, 400);
            leftEyeRect = new Rectangle(250, 100, 100, 75);
            rightEyeRect = new Rectangle(450, 100, 100, 75);
            mouthRect = new Rectangle(300, 350, 200, 50);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangleTexture, head, Color.Red);
            _spriteBatch.Draw(rectangleTexture, leftEyeRect, Color.Black);
            _spriteBatch.Draw(rectangleTexture, rightEyeRect, Color.Black);
            _spriteBatch.Draw(circleTexture, mouthRect, Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
