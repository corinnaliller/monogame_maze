using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    /**
     * Aus dem Unterricht
     */
    public interface IHierarchy
    {
        // The number of children
        int ChildCount { get; }

        // The parent of the GameObject (null if GameObject has no parent)
        IGameObject Parent { get; set; }

        // Set the parent of the transform.
        // This method is the same as the parent property except that it is 
        // possible to make the Transform keep its local orientation rather 
        // than its global orientation.This is managed by setting the 
        // worldPositionStays parameter to false. When SetParent is called with 
        // only the single Transform argument the worldPositionStays argument is 
        // set to true.
        void SetParent(IGameObject newParent, bool worldPositionStays);

        void AddChild(IGameObject newChild);

        void RemoveChild(IGameObject Child);

        List<IGameObject> GetChildren();

        // Returns the topmost transform in the hierarchy
        IGameObject Root { get; }

        // Unparents all children
        void DetachChildren();

        // Returns a Child-GameObject by index
        // If the GameObject has no child, or the index argument has a value 
        // greater than the number of children then an error will be generated.
        IGameObject GetChild(int index);

        // Finds a child by name and returns it
        // If no child with name can be found, null is returned
        IGameObject FindInChildren(String name);

        // Returns a boolean value that indicates whether the GameObject is a child 
        // of a given GameObject
        bool IsChildOf(IGameObject parent);

    }
}
