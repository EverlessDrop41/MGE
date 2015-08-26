using System;
using System.Collections.Generic;

namespace MGE.Framework
{
    class Level
    {
        public MGEWindow Window;
        public List<GameObject> LevelObjects;

        public void Initialize () { }

        public T InstatiateGameObject<T>() where T : GameObject, new()
        {
            T obj = new T();
            obj.level = this;
            LevelObjects.Add(obj);
            return obj;
        } 

        public void LoadContent() { }

        public void UnloadContent () { }

        public void Update () { }

        public void Draw() { }
    }
}
