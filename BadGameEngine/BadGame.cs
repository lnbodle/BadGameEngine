using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;

namespace BadGameEngine
{
    public class BadGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Bad Game Engine
        private Scene scene;

        public BadGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

          
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            scene = new Scene(_graphics.GraphicsDevice);

            Texture2D testTexture = Content.Load<Texture2D>("test");
            scene.objectManager.textures.Add(testTexture);

            SpriteFont arialFont = Content.Load<SpriteFont>("arial");
            scene.objectManager.font = arialFont;

            Test test = scene.objectManager.Instanciate<Test>();
            test.position = new Vector2(32,400);

            for (int i = 0 ; i<10 ; i++) {
                Enemy enemy = scene.objectManager.Instanciate<Enemy>();
                enemy.position = new Vector2(32 + i * 32, 32);
            }

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            scene.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            
            scene.Draw(_spriteBatch);

            base.Draw(gameTime);
            
        }
    }
}
