using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace BadGameEngine
{
    public class Test : GameObject
    {
        public Collider collider;

        public Sprite sprite;

        public float speed;

        public Test() { 
            
        }

        public override void Init() { 
            base.Init();

            collider = AddComponent<Collider>();
            speed = 1;

            sprite = AddComponent<Sprite>();
            sprite.LoadTexture("test");

        }

        public override void Update(GameTime gameTime) { 
            base.Update(gameTime);

        

            Collider c = collider.CheckCollision();

            sprite.textureRotation += 0.1f;
            sprite.textureOrigin = new Vector2(sprite.texture.Bounds.Width / 2, sprite.texture.Bounds.Height / 2 );
            sprite.position = position + sprite.textureOrigin;
            collider.position = position;

            KeyboardState state = Keyboard.GetState();

            position.X += (Convert.ToInt32(state.IsKeyDown(Keys.Right)) - Convert.ToInt32(state.IsKeyDown(Keys.Left))) * speed * gameTime.ElapsedGameTime.Milliseconds;

            if (state.IsKeyDown(Keys.Space)) {

                Bullet b = objectManager.Instanciate<Bullet>();
                //objectManager.Add(b);
                
                b.position = position + new Vector2(0,-32);

                b.collider.bounds.Width = 4;
                b.collider.bounds.Height= 12;
                //b.bounds = new Rectangle(0,0,5,16);
                
            }

            collider.bounds = new Rectangle(0,0,30,30);
        }

        public override void Draw(SpriteBatch _spriteBatch) {
            base.Draw(_spriteBatch);

            _spriteBatch.DrawString(objectManager.font, Convert.ToString(position.X), position + new Vector2(0,-32), Color.Black);
         }
    }
}




