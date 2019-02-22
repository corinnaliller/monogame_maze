using Microsoft.Xna.Framework;
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
    public interface ICamera : ITransform
    {
        Matrix View { get; }
        Matrix Projection { get; }

        float FieldOfView { get; set; }

        float AspectRatio { get; set; }

        float NearPlane { get; set; }

        float FarPlane { get; set; }

    }
}
