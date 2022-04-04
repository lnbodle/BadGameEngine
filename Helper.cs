using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;

namespace BadGameEngine
{
    public static class Helper
    {
        //Return the direction beetwin two vector 
        public static float Direction(Vector2 v1, Vector2 v2)
        {
            float _x = v1.X - v2.X;
            float _y = v1.Y - v2.Y;
            float result = (float)-Math.Atan2(_x, _y);
            return result;
        }
        //Return the difference beetwin two angles
        public static float AngleDifference(float a1, float a2)
        {
            float result = (float)Math.Atan2(Math.Sin(a1-a2), Math.Cos(a1-a2)); 
            return result;
        }
        //Remap a vlaue to an other range 
        public static float Remap(float value, float from1, float to1, float from2, float to2)
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }

    }
}