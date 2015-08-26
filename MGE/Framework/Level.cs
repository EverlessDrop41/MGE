using System;
using System.Collections.Generic;

namespace MGE.Framework
{
    class Level
    {
        public MGEWindow Window;
        public List<GameObject> LevelObjects;

        public Level () { }

        public Level(MGEWindow window)
        {
            Window = window;
        }

        public void Initialize ()
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

        public void LoadContent()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.LoadContent();
            }
        }

        public void UnloadContent ()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.UnloadContent();
            }
        }

        public void Update ()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.Update();
            }
        }

        public void Draw()
        {
            foreach (GameObject go in LevelObjects)
            {
                go.Draw();
            }
        }
    }
}
