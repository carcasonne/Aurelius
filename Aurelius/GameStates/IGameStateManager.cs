using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelius.GameStates;

public interface IGameStateManager
{
    public void SetContent(ContentManager content);
    public void AddScreen(GameState screen);
    public void RemoveScreen();
    public void ClearScreens();
    public void ChangeToScreen(GameState screen);
    public void Update(GameTime gameTime);
    public void Draw(SpriteBatch spriteBatch);
}

