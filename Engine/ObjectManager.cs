using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace BadGameEngine
{
    public class ObjectManager
    {
        public List<GameObject> gameObjects;
        public List<Texture2D> textures;
        public SpriteFont font;
        public Scene scene;

        public ObjectManager()
        {
            gameObjects = new List<GameObject>();
            textures = new List<Texture2D>();
           
        }

        public void Update(GameTime gameTime)
        {
            foreach (GameObject gameObject in gameObjects.ToList())
            {
                gameObject.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch _spriteBatch)
        {   
            foreach (GameObject gameObject in gameObjects.ToList())
            {
                gameObject.Draw(_spriteBatch);
            }
        }

        public T Instanciate<T>() where T : GameObject, new() {
            T gameObject = new T();
            gameObjects.Add(gameObject);
            gameObject.objectManager = this;
            gameObject.Init(); 
            return gameObject;
        }

        public void Remove(GameObject _gameObject)
        {
            foreach(GameObject gameObject in _gameObject.components.ToList()) {
                gameObjects.Remove(gameObject);
            }
            gameObjects.Remove(_gameObject);
        }

        public List<T> GetListOf<T>()
        {
            if (gameObjects.OfType<T>().Any()) {
                return gameObjects.OfType<T>().ToList();
            }
            return new List<T>();
        } 
    }
}