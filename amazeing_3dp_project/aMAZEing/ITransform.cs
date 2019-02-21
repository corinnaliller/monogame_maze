using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public interface ITransform
    {
        Matrix LocalToWorld { get; }

        Vector3 LocalScale { get; set; }
        Vector3 Scale { get; set; }

        Vector3 LocalPosition { get; set; }
        Vector3 Position { get; set; }

        Vector3 Forward { get; set; }

        Vector3 Backward { get; set; }

        Vector3 Up { get; set; }

        Vector3 Down { get; set; }

        Vector3 Right { get; set; }

        Vector3 Left { get; set; }

        Quaternion LocalRotation { get; set; }
        Quaternion Rotation { get; set; }

        Matrix LocalRotationMatrix { get; set; }
        Matrix RotationMatrix { get; set; }

        Vector3 LocalEulerAngles { get; set; }

        Vector3 EulerAngles { get; set; }

        void CreateLocalToWorldMatrix();

        // Transforms direction from local space to world space.
        // This operation is not affected by scale or position of the transform.
        // The returned vector has the same length as direction.
        Vector3 TransformDirection(Vector3 direction);
        Vector3 TransformDirection(float x, float y, float z);

        // Transforms a direction from world space to local space. 
        // The opposite of Transform.TransformDirection.
        // This operation is unaffected by scale.
        Vector3 InverseTransformDirection(Vector3 direction);
        Vector3 InverseTransformDirection(float x, float y, float z);

        // Transforms position from local space to world space.
        // Note that the returned position is affected by scale.
        Vector3 TransformPoint(Vector3 position);
        Vector3 TransformPoint(float x, float y, float z);

        // Transforms position from world space to local space.
        // This function is essentially the opposite of Transform.TransformPoint, 
        // which is used to convert from local to world space.
        // Note that the returned position is affected by scale.
        Vector3 InverseTransformPoint(Vector3 position);
        Vector3 InverseTransformPoint(float x, float y, float z);

        // Transforms vector from local space to world space.
        // This operation is not affected by position of the transform, 
        // but it is affected by scale.The returned vector may have a different 
        // length than vector.
        Vector3 TransformVector(Vector3 vector);
        Vector3 TransformVector(float x, float y, float z);

        // Transforms a vector from world space to local space.
        // The opposite of Transform.TransformVector.
        // This operation is affected by scale.
        Vector3 InverseTransformVector(Vector3 vector);
        Vector3 InverseTransformVector(float x, float y, float z);

        // Rotates the GameObject so the forward vector points 
        // at target's current position.
        void LookAt(IGameObject target);
        void LookAt(Vector3 target);

        // Rotates the GameObject around it's Pivot Point
        // If relativeTo is not specified or set to Space.Self the rotation is applied 
        // around the GameObject's local axes. If relativeTo is set to Space.World 
        // the rotation is applied around the world x, y, z axes.
        void Rotate(Vector3 eulers, Space relativeTo = Space.Self);
        void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo = Space.Self);
        void Rotate(Vector3 axis, float angle, Space relativeTo = Space.Self);

        // Rotates the transform about axis passing through point in world 
        // coordinates by angle degrees. This modifies both the position and 
        // the rotation of the transform.
        void RotateAround(Vector3 point, Vector3 axis, float angle);

        // Sets the world space position and rotation of the Transform component.
        void SetPositionAndRotation(Vector3 position, Quaternion rotation);

        // Moves the transform in the direction and distance of translation.
        // If relativeTo is left out or set to Space.Self the movement is applied 
        // relative to the transform's local axes. (the x, y and z axes shown when 
        // selecting the object inside the Scene View.) If relativeTo is Space.World 
        // the movement is applied relative to the world coordinate system.
        void Translate(float x, float y, float z, Space relativeTo = Space.Self);
        void Translate(Vector3 translation, Space relativeTo = Space.Self);
    }
}
