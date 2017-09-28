using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGCleverDemo.UWP
{
    public class MainMenuScreen:MGClever.GameScreen
    {
  
        public MainMenuScreen()
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
            base.ScreenManager.SpriteBatch.DrawString(base.ScreenManager.DefaultFont, "Play", new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width - base.ScreenManager.DefaultFont.MeasureString("Play").X) / 2, ((ScreenManager.Game.GraphicsDevice.Viewport.Height - base.ScreenManager.DefaultFont.MeasureString("Play").Y) / 2)-100), Color.White);
            base.ScreenManager.SpriteBatch.DrawString(base.ScreenManager.DefaultFont, "About", new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width - base.ScreenManager.DefaultFont.MeasureString("About").X) / 2, ((ScreenManager.Game.GraphicsDevice.Viewport.Height - base.ScreenManager.DefaultFont.MeasureString("About").Y) / 2)-50), Color.White);
            base.ScreenManager.SpriteBatch.DrawString(base.ScreenManager.DefaultFont, "Exit", new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width - base.ScreenManager.DefaultFont.MeasureString("Exit").X) / 2, ((ScreenManager.Game.GraphicsDevice.Viewport.Height - base.ScreenManager.DefaultFont.MeasureString("Exit").Y) / 2) + 0), Color.White);
            base.ScreenManager.SpriteBatch.End();
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }
    }
}
