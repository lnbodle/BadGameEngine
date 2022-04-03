using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;

namespace BadGameEngine
{
    public class Bullet : GameObject
    {
        public Collider collider;

        public Bullet() { 
            
        }

        public override void Init() { 
            base.Init();


            collider = AddComponent<Collider>();
            
        }

        public override void Update(GameTime gameTime) { 
            base.Update(gameTime);

            Collider c = collider.CheckCollision();

            position += new Vector2(0,-10);

            collider.position = position;

            if (position.Y < 0) Remove();
        }

        public override void Draw(SpriteBatch _spriteBatch) {
            base.Draw(_spriteBatch);
        }
    }
}




