using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;

namespace BadGameEngine
{
    public static class BasicDraw
    {
        private static Texture2D rect;

        public static void DrawRectangle(Rectangle coords, Color color, GraphicsDevice graphicsDevice, SpriteBatch spriteBatch)
        {
            if (rect == null)
            {
                rect = new Texture2D(graphicsDevice, 1, 1);
                rect.SetData(new[] { Color.White });
            }

            spriteBatch.Draw(
                     rect,
                     new Vector2(coords.X, coords.Y),
                     coords,
                     color * 0.5f,
                     0,
                     new Vector2(0, 0),
                     new Vector2(1, 1),
                     SpriteEffects.None,
                     1
            );
        }
    }
}