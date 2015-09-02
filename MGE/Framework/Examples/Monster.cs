using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace MGE.Framework.Examples
{
    class Monster : GameObject
    {
        Texture2D spr;
        public Vector2 Pos;
        public Vector2 Size;

        public override void LoadContent()
        {
            base.LoadContent();

            spr = level.Window.Content.Load<Texture2D>("Monster");
        }

        public override void Draw()
        {
            base.Draw();
            level.Window.spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend, null, null, null, null, level.cam.View);

            level.Window.spriteBatch.Draw(spr, new Rectangle((int)Pos.X, (int)Pos.Y, (int)Size.X, (int)Size.Y), Color.White);

            level.Window.spriteBatch.End();
        }
    }
}
