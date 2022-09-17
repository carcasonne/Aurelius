using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurelius.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Aurelius.GameStates;

public abstract class GameState
{
    protected GraphicsDevice _graphicsDevice;

    public IDictionary<string, Sprite> Sprites;

    public GameState(GraphicsDevice graphicsDevice)
    {
        _graphicsDevice = graphicsDevice;
    }

    public abstract void Initialize();
    public abstract void LoadContent(ContentManager content);
    public abstract void UnloadContent();
    public abstract void Update(GameTime gameTime);
    public abstract void Draw(SpriteBatch spriteBatch);
}

