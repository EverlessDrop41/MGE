using System;
using System.Collections.Generic;

namespace MGE.Framework
{
    class Level
    {
        public MGEWindow Window;
        public List<GameObject> LevelObjects;

        public void Initialize () { }

        public void Instatiate(GameObject obj)
        {
            LevelObjects.Add(obj);
        } 

        public void LoadContent() { }

        public void UnloadContent () { }

        public void Update () { }

        public void Draw() { }
    }
}
