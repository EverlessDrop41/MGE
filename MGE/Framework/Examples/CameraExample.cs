using System;

namespace MGE.Framework.Examples
{
    class CameraExample : Level
    {
        public Camera cam;

        public CameraExample (MGEWindow win) : base (win)
        {
            cam = new Camera(win);
        }
    }
}
