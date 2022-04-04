using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

using System;
using System.Collections.Generic;

namespace BadGameEngine
{
    public class Component : GameObject
    {
        public GameObject parent;

        public Component() : base()
        {

        }

        public override void Init()
        {
            base.Init();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //position = parent.position;
        }

        public override void Draw(SpriteBatch _spriteBatch)
        {
           
        }

    }
}