using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace Engine
{
    public abstract class Sprite : GameObject
    {
        public string textureName;
        public float depth;
        public float textureRotation;
        public Vector2 textureOrigin;
        public Vector2 textureScale;
        public Texture2D texture;
        public bool useDepthYAxis = true;

        public Sprite()
        {
            position = new Vector2(0, 0);
            depth = 0;
            textureOrigin = new Vector2(0, 0);
            textureScale = new Vector2(1, 1);
            textureRotation = 0;
        }

        public void LoadTexture(string _textureName)
        {
            var t = objectManager.textures.FirstOrDefault(o => o.Name == _textureName);
            if (t != null)
            {
                texture = t;
            }
        }

        public override void init()
        {
            base.init();
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);
            if (useDepthYAxis) depth = Helper.Remap(-position.Y, -9999999, 9999999, 0, -1);
        }

        public override void draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(
                texture,
                position,
                null,
                Color.White,
                textureRotation,
                textureOrigin,
                textureScale,
                SpriteEffects.None,
                depth
            );
        }
    }
}