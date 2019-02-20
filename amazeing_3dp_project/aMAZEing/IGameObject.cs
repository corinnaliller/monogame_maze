using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public interface IGameObject : IHierarchy, ITransform
    {
        // The name of the object
        String Name { get; set; }

        // The tag of this game object
        String Tag { get; set; }

        // The layer the game object is in
        int Layer { get; set; }

        // legt fest ob die Update-Methode ausgeführt wird
        bool Enabled { get; set; }

        void Update(GameTime gameTime);
    }
}
