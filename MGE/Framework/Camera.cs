using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;

namespace MGE.Framework
{
    class Camera
    {
        public Vector2 Position = Vector2.Zero;
        public Matrix View;
        public Matrix InverseView
        {
            get
            {
                return Matrix.Invert(View);
            }
        }

        public float Zoom = 1f;
        public float Rotation = 0f;

        public MGEWindow Game;

        public Camera (MGEWindow window)
        {
            Game = window;
        }

        public void Update ()
        {
            Rotation = ClampAngle(Rotation);
            View = Matrix.CreateRotationZ(Rotation) * 
                Matrix.CreateScale(new Vector3(Zoom, Zoom, 1)) * 
                Matrix.CreateTranslation(Position.X, Position.Y, 0);
        }

        float ClampAngle (float radians)
        {
            while (radians < -MathHelper.Pi)
            {
                radians += MathHelper.TwoPi;
            }
            while (radians > MathHelper.Pi)
            {
                radians -= MathHelper.TwoPi;
            }
            return radians;
        }
    }
}
