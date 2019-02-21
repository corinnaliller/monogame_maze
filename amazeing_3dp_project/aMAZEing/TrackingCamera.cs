using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    /**
     * Kameraklasse - gefunden und abgewandelt von StackExchange
     * https://gamedev.stackexchange.com/questions/25005/3d-xna-tracking-camera
     */
    public class TrackingCamera : StaticCamera
    {
        private const float DEFAULT_DISTANCE_FROM_TARGET = 2.0f;
        private const float DEFAULT_NEAR_PLANE_DISTANCE = 0.1f;
        private const float DEFAULT_FAR_PLANE_DISTANCE = 300.0f;

        private GameObject mTarget;

        private Matrix mWorldMatrix;
        private Matrix mViewMatrix;
        private Matrix mProjectionMatrix;

        private Vector3 mPosition = Vector3.Zero;
        private Vector3 mLookAt = Vector3.Zero;

        private float mDistanceBehindTarget = DEFAULT_DISTANCE_FROM_TARGET;
        private float mDistanceAboveTarget = DEFAULT_DISTANCE_FROM_TARGET;
        private float mNearClippingPlaneDistance = DEFAULT_NEAR_PLANE_DISTANCE;
        private float mFarClippingPlaneDistance = DEFAULT_FAR_PLANE_DISTANCE;

        public TrackingCamera(Game game)
            : base(game)
        {
            // Perform initial matrix calculations
            CalculateMatrices();
        }

        #region Properties

        /// <summary>
        /// Gets or sets the distance the camera should be positioned behind the target.
        /// </summary>
        public float DistanceBehindTarget
        {
            get { return mDistanceBehindTarget; }
            set { mDistanceBehindTarget = value; }
        }

        /// <summary>
        /// Gets or sets the distance the camera should be positioned above the target.
        /// </summary>
        public float DistanceAboveTarget
        {
            get { return mDistanceAboveTarget; }
            set { mDistanceAboveTarget = value; }
        }

        #endregion

        #region ICamera Implementation

        /// <inherit />
        public Matrix World
        {
            get { return mWorldMatrix; }
        }


        /// <inherit />
        public float NearClippingPlaneDistance
        {
            get { return mNearClippingPlaneDistance; }
            set
            {
                // Make sure the value has changed
                if (mNearClippingPlaneDistance != value)
                {
                    mNearClippingPlaneDistance = value;

                    // Re-calculate the projection matrix
                    CalculateProjectionMatrix();
                }
            }
        }

        /// <inherit />
        public float FarClippingPlaneDistance
        {
            get { return mFarClippingPlaneDistance; }
            set
            {
                // Make sure the value has changed
                if (mFarClippingPlaneDistance != value)
                {
                    mFarClippingPlaneDistance = value;

                    // Re-calculate the projection matrix
                    CalculateProjectionMatrix();
                }
            }
        }

        #endregion

        #region GameComponent Overrides

        public override void Update(GameTime gameTime)
        {
            if (mTarget != null)
            {
                UpdateTrackingInformation();
                CalculateViewMatrix();
            }

            base.Update(gameTime);
        }

        #endregion

        #region Tracking

        public void Track(GameObject target)
        {
            mTarget = target;
        }

        #endregion

        #region Calculations

        private void CalculateMatrices()
        {
            CalculateWorldMatrix();
            CalculateViewMatrix();
            CalculateProjectionMatrix();
        }

        private void CalculateWorldMatrix()
        {
            mWorldMatrix = Matrix.Identity;
        }

        private void CalculateViewMatrix()
        {
            mViewMatrix = Matrix.CreateLookAt(mPosition, mLookAt, Vector3.Up);
        }

        private void CalculateProjectionMatrix()
        {
            Viewport viewport = this.Game.GraphicsDevice.Viewport;

            // Calculate the projection matrix parameters
            float fieldOfView = MathHelper.PiOver4; // 45 degrees in radians
            float aspectRatio = viewport.Width / viewport.Height;
            float nearClippingPlaneDistance = this.NearClippingPlaneDistance;
            float farClippingPlaneDistance = this.FarClippingPlaneDistance;

            // The projection matrix represents the focal projection from a camera lense
            mProjectionMatrix = Matrix.CreatePerspectiveFieldOfView(fieldOfView, aspectRatio, nearClippingPlaneDistance, farClippingPlaneDistance);
        }

        private void UpdateTrackingInformation()
        {
            // Calculate the offset vector
            Vector3 offset = new Vector3(0.0f, this.DistanceAboveTarget, -this.DistanceBehindTarget);

            // Transform the offset by the target's rotation
            float targetRotation = mTarget.Rotation.Y;
            Matrix rotationMatrix = Matrix.CreateRotationY(targetRotation);

            Vector3 transformedOffset = Vector3.Transform(offset, rotationMatrix);

            // Calculate the new position and look at vectors
            Vector3 targetPosition = mTarget.Position;
            mLookAt = targetPosition;

            mPosition = targetPosition + transformedOffset;
        }

        #endregion
    }
}
