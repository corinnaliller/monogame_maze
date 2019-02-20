using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace aMAZEing
{
    public enum Space
    {
        Self,
        World
    }
    public enum ViewMode
    {
        Front,
        Back,
        Left,
        Right,
        Top,
        Bottom
    }
    public class ArcBallCamera : StaticCamera
    {
        private float distance;
        private float rotationSpeed = 60;
        private Keys fastKey = Keys.LeftShift;
        private Keys leftKey = Keys.A;
        private Keys rightKey = Keys.D;
        private Keys upKey = Keys.W;
        private Keys downKey = Keys.S;
        private Keys zoomInKey = Keys.Add;
        private Keys zoomOutKey = Keys.Subtract;
        private Keys liftUpKey = Keys.Up;
        private Keys liftDownKey = Keys.Down;
        private Keys shiftLeftKey = Keys.Left;
        private Keys shiftRightKey = Keys.Right;
        private float scrollSpeed = 0.5f;
        private float fastScrollSpeed = 4;

        #region Public Properties

        public float Distance
        {
            get { return distance; }
            set
            {
                if (value < NearPlane || value > FarPlane)
                    throw new InvalidOperationException("Fehler: die Distance muss zwischen NearPlane und FarPlane liegen");

                Translate(Forward * (distance - value), Space.World);
                distance = value;
            }
        }

        public Vector3 Target
        {
            get { return Position + (Forward * distance); }
            set
            {
                LookAt(value);
            }
        }

        #endregion

        public ArcBallCamera(Game game, Vector3 position) :
            this(game, position, Vector3.Zero)
        { }

        public ArcBallCamera(Game game, Vector3 position, Vector3 target) :
            base(game, position)
        {
            this.distance = (target - position).Length();
        }

        public override void Update(GameTime gameTime)
        {


            KeyboardState currentKeyBoardState = Keyboard.GetState();

            // Zoom in/out
            float distanceDelta = 0;

            if (currentKeyBoardState.IsKeyDown(zoomInKey))
                distanceDelta += (float)(-40 * scrollSpeed * gameTime.ElapsedGameTime.TotalSeconds);

            if (currentKeyBoardState.IsKeyDown(zoomOutKey))
                distanceDelta += (float)(40 * scrollSpeed * gameTime.ElapsedGameTime.TotalSeconds);

            if (distanceDelta != 0)
            {
                if (currentKeyBoardState.IsKeyDown(fastKey))
                    distanceDelta *= fastScrollSpeed / scrollSpeed;

                float newDistance = Distance + distanceDelta;

                if (newDistance < NearPlane)
                {
                    Distance = NearPlane;
                }
                else
                {
                    if (newDistance > FarPlane)
                    {
                        Distance = FarPlane;
                    }
                    else
                    {
                        Distance = newDistance;
                    }
                }
            }


            if (currentKeyBoardState.IsKeyDown(leftKey))
            {
                RotateAround(Position + (Forward * distance), Vector3.Up, rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }

            if (currentKeyBoardState.IsKeyDown(rightKey))
            {
                RotateAround(Position + (Forward * distance), Vector3.Up, -rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }

            if (currentKeyBoardState.IsKeyDown(upKey))
            {
                RotateAround(Position + (Forward * distance), Right, -rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }

            if (currentKeyBoardState.IsKeyDown(downKey))
            {
                RotateAround(Position + (Forward * distance), Right, rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }


            if (currentKeyBoardState.IsKeyDown(liftUpKey))
                Target = Target + Down * rotationSpeed / 10f * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (currentKeyBoardState.IsKeyDown(liftDownKey))
                Target = Target + Up * rotationSpeed / 10f * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (currentKeyBoardState.IsKeyDown(shiftLeftKey))
                Target = Target + Left * rotationSpeed / 10f * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (currentKeyBoardState.IsKeyDown(shiftRightKey))
                Target = Target + Right * rotationSpeed / 10f * (float)gameTime.ElapsedGameTime.TotalSeconds;


            base.Update(gameTime);
        }

        #region Public Methods

        public override void LookAt(Vector3 target)
        {
            Distance = (target - Position).Length();
            base.LookAt(target);
        }

        public void SetView(ViewMode viewMode)
        {
            SetView(viewMode, Distance);
        }

        public void SetView(ViewMode viewMode, float distance)
        {
            if (distance < NearPlane || distance > FarPlane)
                throw new InvalidOperationException("Fehler: die Distance muss zwischen NearPlane und FarPlane liegen");

            Vector3 target = Target;

            switch (viewMode)
            {
                case ViewMode.Front:
                    Position = Target + Vector3.Forward * distance;
                    break;
                case ViewMode.Back:
                    Position = Target + Vector3.Backward * distance;
                    break;

                case ViewMode.Left:
                    Position = Target + Vector3.Left * distance;
                    break;

                case ViewMode.Right:
                    Position = Target + Vector3.Right * distance;
                    break;

                case ViewMode.Top:
                    Position = Target + Vector3.Up * distance;
                    break;

                case ViewMode.Bottom:
                    Position = Target + Vector3.Down * distance;
                    break;
            }

            LookAt(target);

        }

        #endregion
    }
}