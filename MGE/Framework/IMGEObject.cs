namespace MGE.Framework
{
    public interface IMGEObject
    {
        void Initialize();

        void LoadContent();

        void UnloadContent();

        void Update();

        void Draw();
    }
}
