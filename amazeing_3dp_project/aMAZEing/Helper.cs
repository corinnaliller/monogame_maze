using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace aMAZEing
{
    public class Helper
    {
        public static Vector3 QuaternionToEuler(Quaternion rotation)
        {
            Vector3 eulerAngles = new Vector3();
            eulerAngles.Y = MathHelper.ToDegrees((float)Math.Atan2(2 * (rotation.W * rotation.Y + rotation.X * rotation.Z), 1 - 2 * (Math.Pow(rotation.Y, 2) + Math.Pow(rotation.X, 2))));
            eulerAngles.X = MathHelper.ToDegrees((float)Math.Asin(2 * (rotation.W * rotation.X - rotation.Z * rotation.Y)));
            eulerAngles.Z = MathHelper.ToDegrees((float)Math.Atan2(2 * (rotation.W * rotation.Z + rotation.Y * rotation.X), 1 - 2 * (Math.Pow(rotation.X, 2) + Math.Pow(rotation.Z, 2))));
            return eulerAngles;
        }

    }
}