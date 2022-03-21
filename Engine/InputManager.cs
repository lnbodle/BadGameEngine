using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;

namespace Engine
{
    public static class InputManager    
    {
        static KeyboardState kstate;
        static KeyboardState previousKstate;
        
        static GamePadState gstate;
        static GamePadState previousGstate;

        public static KeyboardState GetKeyboardState()
        {
            previousKstate = kstate;
            kstate = Microsoft.Xna.Framework.Input.Keyboard.GetState();

            return kstate;
        }

        public static GamePadState GetGamePadState(int _playerIndex)
        {
            previousGstate = gstate;
            gstate = Microsoft.Xna.Framework.Input.GamePad.GetState(_playerIndex);

            return gstate;
        }

        public static void UpdateInputManager() {
            GetGamePadState(0);
            GetKeyboardState();
        }

        public static bool Input(int _playerIndex, string _index, bool onTime)
        {
            switch (_index)
            {
                case "UP":
                    if (kstate.IsKeyDown(Keys.Up) || gstate.IsButtonDown(Buttons.DPadUp)) return true;
                    break;

                case "DOWN":
                    if (kstate.IsKeyDown(Keys.Down) || gstate.IsButtonDown(Buttons.DPadDown)) return true;
                    break;

                case "LEFT":
                    if (kstate.IsKeyDown(Keys.Left) || gstate.IsButtonDown(Buttons.DPadLeft)) return true;
                    break;

                case "RIGHT":
                    if (kstate.IsKeyDown(Keys.Right) || gstate.IsButtonDown(Buttons.DPadRight)) return true;
                    break;

                case "ACTION":
                    if (!onTime) {
                        if (kstate.IsKeyDown(Keys.Space) || gstate.IsButtonDown(Buttons.A)) return true;
                    } else {
                        return (kstate.IsKeyDown(Keys.Space) && !previousKstate.IsKeyDown(Keys.Space)) || (gstate.IsButtonDown(Buttons.A) && !previousGstate.IsButtonDown(Buttons.A));
                    }
                    break;

                default:
                    return false;
            }
            return false;
        }

    }
}