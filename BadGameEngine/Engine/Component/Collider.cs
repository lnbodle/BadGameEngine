using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace BadGameEngine
{
    public class Collider : Component
    {
        public Collider collided;
        public Rectangle bounds;

        bool debugDraw = true;

        public Collider() : base()
        {

        }

        public override void Init()
        {
            base.Init();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            bounds.X = (int)position.X;
            bounds.Y = (int)position.Y;
        }

        public override void Draw(SpriteBatch _spriteBatch)
        {
            base.Draw(_spriteBatch);
            
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
                BasicDraw.DrawRectangle(bounds, c, GetGraphicsDevice(), _spriteBatch);
            }
        }

        public Collider CheckCollision()
        {    
            foreach (Collider o in objectManager.GetListOf<Collider>())
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