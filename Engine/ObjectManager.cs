using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Engine
{
    public class ObjectManager
    {
        //List that contain GameObjects
        public List<GameObject> gameObjects;

        public List<Texture2D> textures;

        public ObjectManager()
        {
            gameObjects = new List<GameObject>();
        }

        public void update(GameTime gameTime)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.update(gameTime);
            }
        }

        public void draw(SpriteBatch _spriteBatch)
        {
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.draw(_spriteBatch);
            }
        }

        public void Add(GameObject gameObject)
        {
            gameObject.objectManager = this;
            gameObjects.Add(gameObject);
            gameObject.init();
        }
    }
}