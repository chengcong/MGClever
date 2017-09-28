using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MGCleverDemo
{
    public class LoadingScreen:MGClever.GameScreen
    {
        SpriteFont defaultFont;
        public LoadingScreen()
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
            base.ScreenManager.SpriteBatch.DrawString(defaultFont, "Loading...",new Vector2((ScreenManager.Game.GraphicsDevice.Viewport.Width- defaultFont.MeasureString("Loading").X) / 2, (ScreenManager.Game.GraphicsDevice.Viewport.Height- defaultFont.MeasureString("Loading").Y) / 2), Color.White);
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
