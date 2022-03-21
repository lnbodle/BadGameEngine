using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;

namespace Engine
{
    public class Rigidbody : Collider
    {
        public float direction = 0;
        public float speed = 0;
        public float friction = 0.5f;

        public Rigidbody() : base()
        {

        }
        public override void init()
        {
            base.init();
            //speed = 0;
        }
        public override void update(GameTime gameTime)
        {
            base.update(gameTime);

            float updated_speed = speed; //* gameTime.ElapsedGameTime.Seconds; 



            position.X += (float)Math.Sin(direction) * updated_speed;
            position.Y -= (float)Math.Cos(direction) * updated_speed;


            //speed = MathHelper.Lerp(speed, 0, 0.1f);
            //if (speed >= 0) speed -= friction;

            speed = MathHelper.SmoothStep(speed,0,friction);
            //if (speed < 0.05) speed += friction;

        }
    }
}