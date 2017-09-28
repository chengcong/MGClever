using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MGClever
{
    public class ScreenManager : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private List<GameScreen> screens = new List<GameScreen>();
        private List<GameScreen> screensToUpdate = new List<GameScreen>();
        /// <summary>
        /// 是否初始化
        /// </summary>
        private bool isInitialized;

        SpriteBatch spriteBatch;
        public SpriteBatch SpriteBatch
        {
            get { return spriteBatch; }
        }
       
        public ScreenManager(Game game) : base(game)
        {
        }
        public override void Initialize()
        {
            base.Initialize();
            isInitialized = true;
        }
        /// <summary>
        /// 添加游戏场景
        /// </summary>
        /// <param name="screen">场景</param>
        public void AddScreen(GameScreen screen)
        {
            screen.ScreenManager = this;
            screen.IsExiting = false;
            if(isInitialized)
            {
                //加载场景资源文件
                screen.LoadContent();
            }
            this.screens.Add(screen);
        }
        /// <summary>
        /// 删除游戏场景
        /// </summary>
        /// <param name="screen">场景</param>
        public void RemoveScreen(GameScreen screen)
        {
            if (isInitialized)
            {
                //卸载场景资源文件
                screen.UnLoadContent();
            }
            this.screens.Remove(screen);
        }
        /// <summary>
        /// 初始化精灵画刷并加载场景资源
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(base.GraphicsDevice);
           

            foreach (GameScreen screen in screens)
            {
                screen.LoadContent();
            }
            base.LoadContent();
        }
        public override void Draw(GameTime gameTime)
        {
            foreach(GameScreen screen in this.screens)
            {
                if(screen.ScreenState==ScreenState.Hidden)
                {
                    continue;
                }
                screen.Draw(gameTime);
            }
        }
        public override void Update(GameTime gameTime)
        {
            this.screensToUpdate.Clear();
            foreach (GameScreen screen in this.screens)
            {
                screensToUpdate.Add(screen);
            }
            if (this.screensToUpdate.Count > 0)
            {
                //最后加入的游戏场景生效Update
                GameScreen lastInputScreen=this.screensToUpdate[this.screensToUpdate.Count - 1];
                lastInputScreen.Update(gameTime);
            }
        }
        /// <summary>
        /// 卸载所有游戏场景资源
        /// </summary>
        protected override void UnloadContent()
        {
            foreach(GameScreen screen in screens)
            {
                screen.UnLoadContent();
            }
        }
    }
}
