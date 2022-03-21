using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace Engine
{
    public class Scene
    {
        public ObjectManager objectManager;
        public Camera camera {get; set;}

        public Scene()
        {
            objectManager = new ObjectManager();
            camera = new Camera(new Viewport(0, 0, 320,240));
        }

        public void update(GameTime gameTime) {
            camera.Update(gameTime);
            objectManager.update(gameTime);
        }

        public void draw(SpriteBatch _spriteBatch) { 
            objectManager.draw(_spriteBatch);
        }

        public void Instantiate(GameObject gameObject) {
            objectManager.Add(gameObject);
        }
    }
}