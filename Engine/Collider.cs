using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace Engine
{
    public abstract class Collider : Sprite
    {
        GameObject collided;
        bool debugDraw = false;

        public Collider()
        {

        }

        public override void init()
        {
            base.init();
            bounds = new Rectangle(0, 0, 0, 100);
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);
            bounds = new Rectangle((int)position.X - (int)textureOrigin.X, (int)position.Y - (int)textureOrigin.Y, texture.Width, texture.Height);

        }

        public override void draw(SpriteBatch _spriteBatch)
        {
            base.draw(_spriteBatch);

            if (debugDraw)
            {
                Color c;
                if (collided != null)
                {
                    c = Color.Red;
                }
                else
                {
                    c = Color.Green;
                }
                BasicDraw.DrawRectangle(bounds, c, texture.GraphicsDevice, _spriteBatch);
            }
        }

        public GameObject CheckCollision()
        {
            foreach (GameObject o in objectManager.gameObjects)
            {
                if (o != this)
                {
                    if (RectangleCollision(bounds, o.bounds))
                    {
                        collided = o;
                        return o;
                    }
                    else
                    {
                        collided = null;
                    }
                }
            }
            return null;
        }

        public bool RectangleCollision(Rectangle r1, Rectangle r2)
        {
            if (r1.X < r2.X + r2.Width &&
                r1.X + r1.Width > r2.X &&
                r1.Y < r2.Y + r2.Height &&
                r1.Height + r1.Y > r2.Y)
            {
                return true;
            }
            return false;
        }
    }
}