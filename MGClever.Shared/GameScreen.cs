using Microsoft.Xna.Framework;
using System;


namespace MGClever
{
    public abstract class GameScreen
    {
       
        bool isExiting;
        public bool IsExiting
        {
            get
            {
                return isExiting;
            }
            protected internal set
            {
                isExiting = value;
            }
        }
        ScreenState screenState;
        /// <summary>
        /// 游戏场景状态 显示或隐藏
        /// </summary>
        public ScreenState ScreenState
        {
            get { return screenState; }
            protected set { screenState = value; }
        }
        ScreenManager screenManager;
        private bool isActive;

        public ScreenManager ScreenManager
        {
            get { return screenManager; }
            internal set { screenManager = value; }
        }

        public virtual void LoadContent()
        {

        }
        public virtual void Draw(GameTime gameTime)
        {

        }
        public virtual void Update(GameTime gameTime)
        {
            if(!isExiting)
            {
                //没有退出，设置游戏场景状态为Active
                screenState = ScreenState.Active;
            }
            else
            {
                //否则设置游戏场景为Hidden，并从场景管理器中删除
                screenState = ScreenState.Hidden;
                ScreenManager.RemoveScreen(this);
            }
        }
        public virtual void UnLoadContent()
        {

        }

        
        /// <summary>
        /// 退出游戏场景
        /// </summary>
        public void ExitScreen()
        {

            isExiting = true;
            //删除当前场景
            ScreenManager.RemoveScreen(this);
        }
    }
}
