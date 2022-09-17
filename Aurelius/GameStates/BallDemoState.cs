using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Aurelius.Models;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Aurelius.GameStates;

public class BallDemoState : GameState
{
    private GraphicsDeviceManager graphics => GameStateManager.Instance.Graphics;

    private Ball _ball;

    public BallDemoState(GraphicsDevice graphicsDevice) : base(graphicsDevice)
    {
        _ball = new Ball();
        _ball.Position = new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2);
        _ball.Speed = 500f;
    }

    public override void Initialize()
    {
    }

    public override void LoadContent(ContentManager content)
    {
        // TODO: use this.Content to load your game content here
        _ball.Texture = content.Load<Texture2D>(_ball.TextureName());
    }

    public override void UnloadContent()
    {
    }

    public override void Update(GameTime gameTime)
    {
        var kstate = Keyboard.GetState();

        _ball.Move(kstate, gameTime);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        _graphicsDevice.Clear(Color.CornflowerBlue);

        spriteBatch.Begin();

        spriteBatch.Draw(_ball.Texture,
            _ball.Position,
            null,
            Color.White,
            0f,
            new Vector2(_ball.Texture.Width / 2, _ball.Texture.Height / 2),
            Vector2.One,
            SpriteEffects.None,
            0f);

        spriteBatch.End();
    }
}
