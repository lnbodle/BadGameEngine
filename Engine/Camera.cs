using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace BadGameEngine
{
    public class Camera
    {
        public Matrix transform;
        Viewport view;
        public Vector2 position;

        public Camera(Viewport viewport)
        {
            view = viewport;
        }

        public void Update(GameTime gameTime) {
            transform = Matrix.CreateScale(new Vector3(1,1,0)) * Matrix.CreateTranslation(new Vector3(-position.X, -position.Y,0));
        }
    }
}