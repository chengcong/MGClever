using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGCleverDemo
{
    public class MainMenuScreen:MGClever.GameScreen
    {

        SpriteFont defaultFont;
        public MainMenuScreen()
        {

        }
        public override void LoadContent()
        {
            defaultFont = base.ScreenManager.Game.Content.Load<SpriteFont>("DefaultFont");
            base.LoadContent();
        }
        public override void Draw(GameTime gameTime)
        {
            base.ScreenManager.Game.GraphicsDevice.Clear(Color.Black);
            base.ScreenManager.SpriteBatch.Begin();
            base.ScreenManager.SpriteBatch.DrawString(defaultFont, "Play", new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width - defaultFont.MeasureString("Play").X) / 2, ((ScreenManager.Game.GraphicsDevice.Viewport.Height - defaultFont.MeasureString("Play").Y) / 2)-100), Color.White);
            base.ScreenManager.SpriteBatch.DrawString(defaultFont, "About", new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width - defaultFont.MeasureString("About").X) / 2, ((ScreenManager.Game.GraphicsDevice.Viewport.Height - defaultFont.MeasureString("About").Y) / 2)-50), Color.White);
            base.ScreenManager.SpriteBatch.DrawString(defaultFont, "Exit", new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width - defaultFont.MeasureString("Exit").X) / 2, ((ScreenManager.Game.GraphicsDevice.Viewport.Height - defaultFont.MeasureString("Exit").Y) / 2) + 0), Color.White);
            base.ScreenManager.SpriteBatch.End();
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }
    }
}
