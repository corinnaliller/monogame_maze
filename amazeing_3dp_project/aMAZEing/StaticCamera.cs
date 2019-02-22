using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public class StaticCamera : GameObject, ICamera
    {
        #region Private Members
        private Matrix view, projection;
        private float nearPlane = 0;
        private float farPlane = 100;
        private float aspectRatio = 1.6f;
        private float fieldOfView = MathHelper.PiOver4;
        private GameObject targetObject;
        private Vector3 offset = new Vector3(1, -1, 1);
        #endregion

        #region Public Properties

        public Matrix View
        {
            get { return view; }
        }

        public Matrix Projection
        {
            get { return projection; }
        }

        public float FieldOfView
        {
            get { return MathHelper.ToDegrees(fieldOfView); }
            set
            {
                if (value <= 0 || value >= 180)
                    throw new InvalidOperationException("Fehler! Ungültiger Wert.");

                fieldOfView = MathHelper.ToRadians(value);
                MakeProjectionMatrix();
            }
        }

        public float AspectRatio
        {
            get { return aspectRatio; }
            set
            {
                if (value <= 0 || value >= 4)
                    throw new InvalidOperationException("Fehler! Ungültiger Wert.");

                aspectRatio = value;
                MakeProjectionMatrix();
            }
        }

        public float NearPlane
        {
            get { return nearPlane; }
            set
            {
                if (value <= 0 || value >= farPlane)
                    throw new InvalidOperationException("Fehler! Ungültiger Wert.");

                nearPlane = value;
                MakeProjectionMatrix();
            }
        }

        public float FarPlane
        {
            get { return farPlane; }
            set
            {
                if (value <= nearPlane)
                    throw new InvalidOperationException("Fehler! Ungültiger Wert.");

                farPlane = value;
                MakeProjectionMatrix();
            }
        }
        public Vector3 Target
        {
            get { return targetObject.Position; }
            set
            {
                LookAt(value);
            }
        }
        #endregion

        #region Public Constructors
        public StaticCamera(Game game) : this(game, Vector3.Zero) { }

        public StaticCamera(Game game, GameObject target) : this(game, target.Position - new Vector3(1, -1, 1))
        {
            targetObject = target;
        }

        public StaticCamera(Game game, Vector3 position) : this(game, position, Vector3.Forward) { }

        public StaticCamera(Game game, Vector3 position, Vector3 forward, float aspectRatio = 1.6f,
                 float fieldOfView = MathHelper.PiOver4, float nearPlane = 1, float farPlane = 100) : base(game)
        {
            Position = position;
            Forward = forward;
            this.fieldOfView = fieldOfView;
            this.aspectRatio = aspectRatio;
            this.nearPlane = nearPlane;
            this.farPlane = farPlane;

            MakeProjectionMatrix();
            MakeViewMatrix();
        }


        #endregion

        #region Private Methods
        private void MakeViewMatrix()
        {
            view = Matrix.CreateLookAt(Position, Position + Forward, Up);
        }

        private void MakeProjectionMatrix()
        {
            projection = Matrix.CreatePerspectiveFieldOfView(fieldOfView, aspectRatio,
                nearPlane, farPlane);
        }
        #endregion

        #region Public Methods


        public override void CreateLocalToWorldMatrix()
        {
            base.CreateLocalToWorldMatrix();
            MakeViewMatrix();
        }
        public override void LookAt(Vector3 target)
        {
            //Distance = (target - Position).Length();
            base.LookAt(target);
        }
        #endregion

    }
}
