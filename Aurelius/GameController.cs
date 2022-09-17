using System;
using Aurelius.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Aurelius;
public class GameController : Game
{
    private GraphicsDeviceManager graphics => GameStateManager.Instance.Graphics;
    private SpriteBatch spriteBatch;

    private static int _screenWidth = 1344;
    private static int _screenHeight = 700;

    public GameController()
    {
        GameStateManager.Instance.Graphics = new GraphicsDeviceManager(this);
        graphics.PreferredBackBufferWidth = _screenWidth;
        graphics.PreferredBackBufferHeight = _screenHeight;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        

        GameStateManager.Instance.SetContent(Content);

        GameStateManager.Instance.AddScreen(new BallDemoState(GraphicsDevice));
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        GameStateManager.Instance.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        //not sure if keep this logic here
        //GraphicsDevice.Clear(Color.CornflowerBlue);

        GameStateManager.Instance.Draw(spriteBatch);

        base.Draw(gameTime);
    }
}
