using System;
using System.Collections.Generic;

namespace MGE.Framework
{
    class GameObject
    {
        public Level level;

        public GameObject () { }

        public GameObject (Level l)
        {
            level = l;
        }

        public void Initialize() { }

        public void LoadContent() { }

        public void UnloadContent() { }

        public void Update() { }

        public void Draw() { }
    }
}
