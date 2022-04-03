using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace BadGameEngine
{
    public abstract class GameObject
    {
        public ObjectManager objectManager;
        public List<GameObject> components;
        public Vector2 position;

        public GameObject() {
            components = new List<GameObject>();
         }

        public virtual void Init() { 
            
        }

        public virtual void Update(GameTime gameTime) { }

        public virtual void Draw(SpriteBatch _spriteBatch) { }

        public Scene GetScene() {
            return this.objectManager.scene;
        }

        public GraphicsDevice GetGraphicsDevice() {
            return GetScene().graphicsDevice;
        }

        public void Remove() {
            objectManager.Remove(this);
        }

        public T AddComponent<T>() where T : Component, new() {
            T component = objectManager.Instanciate<T>();
            component.parent = this;
            components.Add(component);
            return component;
        }
    }
}