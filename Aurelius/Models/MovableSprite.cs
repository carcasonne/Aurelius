using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurelius.GameStates;

namespace Aurelius.Models;

public abstract class MovableSprite : Sprite
{
    public float Speed;

    public void Move(KeyboardState kstate, GameTime gameTime)
    {
        //TODO: switch statement
        if (kstate.IsKeyDown(Keys.Up))
        {
            Position.Y -= Speed * (float) gameTime.ElapsedGameTime.TotalSeconds;
        }

        if (kstate.IsKeyDown(Keys.Down))
        {
            Position.Y += Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        if (kstate.IsKeyDown(Keys.Left))
        {
            Position.X -= Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        if (kstate.IsKeyDown(Keys.Right))
        {
            Position.X += Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        var graphics = GameStateManager.Instance.Graphics;

        if (Position.X > graphics.PreferredBackBufferWidth - Texture.Width / 2)
        {
            Position.X = graphics.PreferredBackBufferWidth - Texture.Width / 2;
        }
        else if (Position.X < Texture.Width / 2)
        {
            Position.X = Texture.Width / 2;
        }

        if (Position.Y > graphics.PreferredBackBufferHeight - Texture.Height / 2)
        {
            Position.Y = graphics.PreferredBackBufferHeight - Texture.Height / 2;
        }
        else if (Position.Y < Texture.Height / 2)
        {
            Position.Y = Texture.Height / 2;
        }
    }
}

