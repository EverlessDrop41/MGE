using System;
using System.Collections.Generic;

namespace MGE.Framework
{
    class GameObject : IMGEObject
    {
        public Level level;

        public GameObject () { }

        public GameObject (Level l)
        {
            level = l;
        }

        public virtual void Initialize() { }

        public virtual void LoadContent() { }

        public virtual void UnloadContent() { }

        public virtual void Update() { }

        public virtual void Draw() { }
    }
}
