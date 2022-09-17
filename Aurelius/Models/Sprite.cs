using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Aurelius.Models;

public abstract class Sprite
{
    public Texture2D Texture;
    public Vector2 Position;
    public abstract string TextureName();
}

