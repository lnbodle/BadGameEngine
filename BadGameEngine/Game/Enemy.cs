using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace BadGameEngine
{
    public class Enemy : GameObject
    {
        public Collider collider;

        public override void Init() { 
            base.Init();

            collider = AddComponent<Collider>();
            collider.bounds = new Rectangle(0,0,30,30);
        }

        public override void Update(GameTime gameTime) { 
            base.Update(gameTime);

            Collider c = collider.CheckCollision();
            collider.position = position;
            if (c != null) {
                if (c.parent is Bullet) {
                    c.parent.Remove();
                    Remove();
                }
            }
        }

        public override void Draw(SpriteBatch _spriteBatch) {
            base.Draw(_spriteBatch);
        }
    }
}




