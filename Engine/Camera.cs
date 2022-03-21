using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace Engine
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
            //center = new Vector2(position.X, position.Y);
            transform = Matrix.CreateScale(new Vector3(1,1,0)) * Matrix.CreateTranslation(new Vector3(-position.X, -position.Y,0));
        }
    }
}