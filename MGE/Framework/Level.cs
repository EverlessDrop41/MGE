using System;
using System.Collections.Generic;

namespace MGE.Framework
{
    class Level : IMGEObject
    {
        public MGEWindow Window;
        public List<GameObject> LevelObjects;

        public Level () { }

        public Level(MGEWindow window)
        {
            Window = window;
        }

        public virtual void Initialize ()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.Initialize();
            }
        }

        /// <summary>
        /// Create a new object in the level
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <returns>The object instantaited</returns>
        public T InstatiateGameObject<T>() where T : GameObject, new()
        {
            T obj = new T();
            obj.level = this;
            LevelObjects.Add(obj);
            return obj;
        } 

        public virtual void LoadContent()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.LoadContent();
            }
        }

        public virtual void UnloadContent ()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.UnloadContent();
            }
        }

        public virtual void Update ()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.Update();
            }
        }

        public virtual void Draw()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.Draw();
            }
        }
    }
}
