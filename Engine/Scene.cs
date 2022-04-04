using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace BadGameEngine
{
    public class Scene
    {
        public ObjectManager objectManager;
        public GraphicsDevice graphicsDevice;
        
        
        public Camera camera {get; set;}

        public Scene(GraphicsDevice _graphicsDevice)
        {
            objectManager = new ObjectManager();
            objectManager.scene = this;

            graphicsDevice = _graphicsDevice;
            camera = new Camera(new Viewport(0, 0, 320,240));
        }

        public void Update(GameTime gameTime) {
            camera.Update(gameTime);
            objectManager.Update(gameTime);
        }

        public void Draw(SpriteBatch _spriteBatch) { 
            _spriteBatch.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, camera.transform);
            objectManager.Draw(_spriteBatch);
            _spriteBatch.End();
        }

        /*public void Instantiate(GameObject gameObject) {
            objectManager.Add(gameObject);
        }*/
    }
}