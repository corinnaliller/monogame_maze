using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;


namespace aMAZEing
{
    public class GameObject : GameComponent, IGameObject
    {
        # region Private Members
        private String name;
        private String tag;
        private int layer;
        private IGameObject parent;
        private List<IGameObject> children = new List<IGameObject>();
        private Vector3 localPosition = Vector3.Zero;
        private Matrix localRotation = Matrix.Identity;
        private Vector3 localScale = Vector3.One;
        private Matrix localToWorld = Matrix.Identity;
        #endregion

        #region Public Properties

        public String Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new InvalidProgramException("Fehler: null oder Leerstring nicht erlaubt");
                }
                name = value;
            }
        }

        public String Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        public int Layer
        {
            get { return layer; }
            set { layer = value; }
        }

        public IGameObject Parent
        {
            get { return parent; }
            set { SetParent(value); }
        }

        public int ChildCount
        {
            get { return children.Count; }
        }

        public IGameObject Root
        {
            get
            {
                if (parent == null)
                {
                    return this;
                }
                else
                {
                    return parent.Root;
                }
            }
        }

        public virtual Matrix LocalToWorld
        {
            get { return localToWorld; }
        }

        public virtual Vector3 LocalPosition
        {
            get { return localPosition; }
            set
            {
                localPosition = value;
                CreateLocalToWorldMatrix();
            }
        }

        public virtual Vector3 Position
        {
            get { return localToWorld.Translation; }
            set
            {
                //if (parent != null)
                //    LocalPosition = value - parent.Position;
                //else
                //    LocalPosition = value;

                LocalPosition = (parent != null) ? (value - parent.Position) : value;
            }
        }


        public Vector3 LocalScale
        {
            get { return localScale; }
            set
            {
                localScale = value;
                CreateLocalToWorldMatrix();
            }
        }

        public Vector3 Scale
        {
            get
            {
                if (parent == null)
                    return LocalScale;
                else
                    return LocalScale * parent.Scale;
            }
            set
            {
                if (parent == null)
                    LocalScale = value;
                else
                    LocalScale = value / parent.Scale;
            }
        }

        public virtual Quaternion LocalRotation
        {
            get { return Quaternion.CreateFromRotationMatrix(localRotation); }
            set
            {
                localRotation = Matrix.CreateFromQuaternion(value);
                CreateLocalToWorldMatrix();
            }
        }

        public Quaternion Rotation
        {
            get
            {
                if (parent == null)
                    return LocalRotation;
                else
                    return LocalRotation * parent.Rotation;
            }
            set
            {
                value = Quaternion.Normalize(value);

                if (parent == null)
                    LocalRotation = value;
                else
                    LocalRotation = value * Quaternion.Inverse(parent.Rotation);
            }
        }


        public virtual Matrix LocalRotationMatrix
        {
            get { return localRotation; }
            set
            {
                Vector3 scale, translation;
                Quaternion rotation;
                value.Decompose(out scale, out rotation, out translation);
                LocalRotation = rotation;
            }
        }

        public Matrix RotationMatrix
        {
            get
            {
                if (parent == null)
                    return LocalRotationMatrix;
                else
                    return LocalRotationMatrix * Matrix.Invert(parent.RotationMatrix);
            }
            set
            {
                if (parent == null)
                    LocalRotationMatrix = value;
                else
                {
                    Vector3 scale, translation;
                    Quaternion rotation;
                    value.Decompose(out scale, out rotation, out translation);
                    Rotation = rotation;
                }
            }
        }

        public virtual Vector3 LocalEulerAngles
        {
            get { return Helper.QuaternionToEuler(LocalRotation); }
            set
            {
                LocalRotation = Quaternion.CreateFromYawPitchRoll(MathHelper.ToRadians(value.Y),
                    MathHelper.ToRadians(value.X), MathHelper.ToRadians(value.Z));
            }
        }

        public Vector3 EulerAngles
        {
            get
            {
                return Helper.QuaternionToEuler(Rotation);
            }
            set
            {
                Rotation = Quaternion.CreateFromYawPitchRoll(MathHelper.ToRadians(value.Y),
                MathHelper.ToRadians(value.X), MathHelper.ToRadians(value.Z));
            }
        }



        public virtual Vector3 Forward
        {
            get { return RotationMatrix.Forward; }
            set
            {
                value = Vector3.Normalize(value);

                if (value == Vector3.Up)
                {
                    localRotation.Forward = Vector3.Up;
                    localRotation.Up = Vector3.Backward;
                    localRotation.Right = Vector3.Right;
                }
                else if (value == Vector3.Down)
                {
                    localRotation.Forward = Vector3.Down;
                    localRotation.Up = Vector3.Forward;
                    localRotation.Right = Vector3.Right;
                }
                else
                {
                    localRotation.Forward = value;
                    localRotation.Right = Vector3.Normalize(Vector3.Cross(value, Vector3.Up));
                    localRotation.Up = Vector3.Normalize(Vector3.Cross(localRotation.Right, localRotation.Forward));
                }

                if (parent != null)
                {
                    localRotation = localRotation * Matrix.Invert(parent.LocalRotationMatrix);
                }

                CreateLocalToWorldMatrix();
            }
        }

        public virtual Vector3 Backward
        {
            get { return Vector3.Negate(Forward); }
            set { Forward = Vector3.Negate(value); }
        }


        public virtual Vector3 Up
        {
            get { return RotationMatrix.Up; }
            set
            {
                value = Vector3.Normalize(value);

                if (value == Vector3.Forward)
                {
                    localRotation.Up = value;
                    localRotation.Right = Vector3.Right;
                    localRotation.Forward = Vector3.Down;
                }
                else if (value == Vector3.Negate(Vector3.Forward))
                {
                    localRotation.Up = value;
                    localRotation.Right = Vector3.Right;
                    localRotation.Forward = Vector3.Up;
                }
                else
                {
                    localRotation.Up = value;
                    localRotation.Right = Vector3.Normalize(Vector3.Cross(Vector3.Forward, value));
                    localRotation.Forward = Vector3.Normalize(Vector3.Cross(localRotation.Up, localRotation.Right));
                }

                if (parent != null)
                {
                    localRotation = localRotation * Matrix.Invert(parent.LocalRotationMatrix);
                }

                CreateLocalToWorldMatrix();
            }
        }

        public Vector3 Down
        {
            get { return Vector3.Negate(Up); }
            set { Up = Vector3.Negate(value); }
        }


        public virtual Vector3 Right
        {
            get { return RotationMatrix.Right; }
            set
            {
                value = Vector3.Normalize(value);

                if (value == Vector3.Forward)
                {
                    localRotation.Right = value;
                    localRotation.Forward = Vector3.Left;
                    localRotation.Up = Vector3.Up;
                }
                else if (value == Vector3.Backward)
                {
                    localRotation.Right = value;
                    localRotation.Forward = Vector3.Right;
                    localRotation.Up = Vector3.Up;
                }
                else
                {
                    localRotation.Right = value;
                    localRotation.Up = Vector3.Normalize(Vector3.Cross(value, Vector3.Forward));
                    localRotation.Forward = Vector3.Normalize(Vector3.Cross(localRotation.Up, localRotation.Right));
                }

                if (parent != null)
                {
                    localRotation = localRotation * Matrix.Invert(parent.LocalRotationMatrix);
                }

                CreateLocalToWorldMatrix();
            }
        }

        public Vector3 Left
        {
            get { return Vector3.Negate(Right); }
            set { Right = Vector3.Negate(value); }
        }

        #endregion

        public GameObject(Game game) : base(game)
        {
        }

        public virtual void Update(GameTime gameTime)
        {
            if (!Enabled)
                return;

            base.Update(gameTime);
        }

        #region Public Methods

        public virtual void CreateLocalToWorldMatrix()
        {   // Identity * Scale * Rotation Orbit * Translation
            localToWorld = Matrix.CreateScale(localScale) * localRotation * Matrix.CreateTranslation(localPosition);

            if (parent != null)
            {
                localToWorld *= parent.LocalToWorld;
            }

            foreach (var child in children)
            {
                child.CreateLocalToWorldMatrix();
            }
        }

        public List<IGameObject> GetChildren()
        {
            return children;
        }


        public void AddChild(IGameObject newChild)
        {
            if (!children.Contains(newChild))
                children.Add(newChild);

            if (newChild.Parent != this)
                newChild.Parent = this;
        }

        public void RemoveChild(IGameObject child)
        {
            if (children.Contains(child))
                children.Remove(child);

            if (child.Parent == this)
                child.Parent = null;
        }

        public void SetParent(IGameObject newParent, bool worldPositionStays = true)
        {
            if (newParent == this.parent)
                return;

            Vector3 position = this.Position;
            Vector3 scale = this.Scale;
            Quaternion rotation = this.Rotation;

            if (this.parent != null)
            {
                this.parent = null;
                this.parent.RemoveChild(this);
            }

            this.parent = newParent;

            if (newParent != null)
            {
                newParent.AddChild(this);
            }

            if (worldPositionStays)
            {
                // localPosition, localScale, localRotation berechnen!
                this.Position = position;
                this.Scale = scale;
                this.Rotation = rotation;
            }
            else
            {
                CreateLocalToWorldMatrix();
            }

        }


        public void Translate(float x, float y, float z, Space relativeTo = Space.Self)
        {
            Translate(new Vector3(x, y, z), relativeTo);
        }

        public void Translate(Vector3 translation, Space relativeTo = Space.Self)
        {
            if (relativeTo == Space.World)
            {
                Position += translation;
            }
            else if (relativeTo == Space.Self)
            {
                Position += Right * translation.X + Up * translation.Y +
                    Forward * translation.Z;
            }
        }

        public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
        {
            Position = position;
            Rotation = rotation;
        }

        public virtual void LookAt(IGameObject target)
        {
            LookAt(target.Position);
        }

        public virtual void LookAt(Vector3 target)
        {
            Forward = target - Position;
        }

        public void Rotate(Vector3 eulers, Space relativeTo = Space.Self)
        {
            Rotate(new Vector3(eulers.X, eulers.Y, eulers.Z), relativeTo);
        }

        public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo = Space.Self)
        {
            if (relativeTo == Space.World)
            {
                Rotation *= Quaternion.CreateFromYawPitchRoll(MathHelper.ToRadians(yAngle),
                    MathHelper.ToRadians(xAngle), MathHelper.ToRadians(zAngle));
            }
            else if (relativeTo == Space.Self)
            {
                Rotation *= Quaternion.CreateFromAxisAngle(Up, yAngle) *
                    Quaternion.CreateFromAxisAngle(Right, xAngle) *
                    Quaternion.CreateFromAxisAngle(Forward, zAngle);
            }
        }

        public void Rotate(Vector3 axis, float angle, Space relativeTo = Space.Self)
        {
            if (relativeTo == Space.Self)
            {
                axis = TransformDirection(axis);
            }

            Rotation *= Quaternion.CreateFromAxisAngle(axis, angle);
        }


        public Vector3 TransformDirection(float x, float y, float z)
        {
            return TransformDirection(new Vector3(x, y, z));
        }

        public Vector3 TransformDirection(Vector3 direction)
        {
            return Vector3.Transform(direction, Matrix.Invert(RotationMatrix));
        }

        public Vector3 InverseTransformDirection(float x, float y, float z)
        {
            return InverseTransformDirection(new Vector3(x, y, z));
        }

        public Vector3 InverseTransformDirection(Vector3 direction)
        {
            return Vector3.Transform(direction, RotationMatrix);
        }

        public Vector3 TransformPoint(float x, float y, float z)
        {
            return TransformPoint(new Vector3(x, y, z));
        }

        public Vector3 TransformPoint(Vector3 position)
        {
            return Vector3.Transform(position, Matrix.Invert(localToWorld));
        }

        public Vector3 InverseTransformPoint(float x, float y, float z)
        {
            return TransformPoint(new Vector3(x, y, z));
        }
        public Vector3 InverseTransformPoint(Vector3 position)
        {
            return Vector3.Transform(position, localToWorld);
        }

        public Vector3 TransformVector(float x, float y, float z)
        {
            return TransformVector(new Vector3(x, y, z));
        }
        public Vector3 TransformVector(Vector3 vector)
        {
            return Vector3.Transform(vector, Matrix.Invert(Matrix.CreateScale(Scale) *
                RotationMatrix));
        }

        public Vector3 InverseTransformVector(float x, float y, float z)
        {
            return InverseTransformVector(new Vector3(x, y, z));
        }

        public Vector3 InverseTransformVector(Vector3 vector)
        {
            return Vector3.Transform(vector, Matrix.CreateScale(Scale) * RotationMatrix);
        }

        public void RotateAround(Vector3 point, Vector3 axis, float angle)
        {
            axis = Vector3.Normalize(axis);
            Position = Vector3.Transform(Position - point,
                Matrix.CreateFromAxisAngle(axis, MathHelper.ToRadians(angle))) + point;
            Rotation = Quaternion.CreateFromAxisAngle(axis, MathHelper.ToRadians(angle)) * Rotation;
        }

        public void DetachChildren()
        {
            foreach (var child in children)
            {
                child.Parent = null;
            }

            children.Clear();
        }

        public IGameObject GetChild(int index)
        {
            if (index < 0 || index > children.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            return children[index];
        }

        public IGameObject FindInChildren(String name)
        {
            return children.Find(x => x.Name == name);
        }

        public bool IsChildOf(IGameObject parent)
        {
            if (this.parent == parent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
