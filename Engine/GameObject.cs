using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace Engine
{
    public abstract class GameObject
    {
        public Vector2 position;
        public ObjectManager objectManager;
        public  Rectangle bounds;


        public GameObject()
        {
            position = new Vector2(0, 0);
        }

        public virtual void init() { }

        public virtual void update(GameTime gameTime) { }

        public virtual void draw(SpriteBatch _spriteBatch) { }
    }
}