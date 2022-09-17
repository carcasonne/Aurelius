using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurelius.GameStates;

public class GameStateManager : IGameStateManager
{
    // Instance of the game state manager     
    private static GameStateManager _instance;
    private ContentManager _content;

    // Stack for the screens     
    private Stack<GameState> _screens = new Stack<GameState>();

    //screen dimensions
    public GraphicsDeviceManager Graphics;

    public static GameStateManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameStateManager();
            }
            return _instance;
        }
    }

    // Sets the content manager
    public void SetContent(ContentManager content)
    {
        _content = content;
    }

    // Adds a new screen to the stack 
    public void AddScreen(GameState screen)
    {
        // Add the screen to the stack
        _screens.Push(screen);
        _screens.Peek().Initialize();

        // Call the LoadContent on the screen
        if (_content != null)
        {
            _screens.Peek().LoadContent(_content);
        }
    }

    // Removes the top screen from the stack
    public void RemoveScreen()
    {
        if (_screens.Count > 0)
        {
            _screens.Pop();
        }
    }

    // Clears all the screen from the list
    public void ClearScreens()
    {
        while (_screens.Count > 0)
        {
            _screens.Pop();
        }
    }

    // Removes all screens from the stack and adds a new one 
    public void ChangeToScreen(GameState screen)
    {
        ClearScreens();
        AddScreen(screen);
    }

    // Updates the top screen. 
    public void Update(GameTime gameTime)
    {
        if (_screens.Count > 0)
        {
            _screens.Peek().Update(gameTime);
        }
    }

    // Renders the top screen.
    public void Draw(SpriteBatch spriteBatch)
    {
        if (_screens.Count > 0)
        {
            _screens.Peek().Draw(spriteBatch);
        }
    }
}

