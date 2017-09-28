using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MGCleverDemo.UWP
{
    public class LoadingScreen:MGClever.GameScreen
    {

        public LoadingScreen()
        {

        }
        public override void LoadContent()
        {
            base.LoadContent();
        }
        public override void Draw(GameTime gameTime)
        {
            
            base.ScreenManager.Game.GraphicsDevice.Clear(Color.Black);
            base.ScreenManager.SpriteBatch.Begin();
            base.ScreenManager.SpriteBatch.DrawString(base.ScreenManager.DefaultFont, "Loading...",new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width- base.ScreenManager.DefaultFont.MeasureString("Loading").X) / 2, (ScreenManager.Game.GraphicsDevice.Viewport.Height- base.ScreenManager.DefaultFont.MeasureString("Loading").Y) / 2), Color.White);
            base.ScreenManager.SpriteBatch.End();
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime)
        {
            if (gameTime.TotalGameTime.TotalSeconds > 5)
            {
                base.ScreenManager.RemoveScreen(this);
                base.ScreenManager.AddScreen(new MainMenuScreen());
                base.ScreenManager.Game.ResetElapsedTime();
            }
            base.Update(gameTime);
        }
    }
}
