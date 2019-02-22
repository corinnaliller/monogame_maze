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
        private float speed;
        private Keys leftKey = Keys.A;
        private Keys rightKey = Keys.D;
        private Keys upKey = Keys.W;
        private Keys downKey = Keys.S;
        private GameObject target;
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

        public ArcBallCamera(Game game, GameObject target) : this(game,target.Position - new Vector3(0,-2,3),target)
        {
        }
        public ArcBallCamera(Game game, Vector3 position) : base(game,position)
        {
            Target = Vector3.Zero;
        }

        public ArcBallCamera(Game game, Vector3 position, GameObject target) :
            base(game, position)
        {
            this.target = target;
            this.speed = ((Spieler)target).Speed;
            this.distance = (target.Position - position).Length();
        }

        public override void Update(GameTime gameTime)
        {
            Target = target.Position;
            //Position = target.Position - new Vector3(2, -2, 2);

            KeyboardState currentKeyBoardState = Keyboard.GetState();


            if (currentKeyBoardState.IsKeyDown(leftKey))
            {
                RotateAround(Position + (Forward * distance), Vector3.Up, rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
                target.Rotate(0, (float)gameTime.ElapsedGameTime.TotalSeconds,0);
            }

            if (currentKeyBoardState.IsKeyDown(rightKey))
            {
                RotateAround(Position + (Forward * distance), Vector3.Up, -rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
                target.Rotate(0, -(float)gameTime.ElapsedGameTime.TotalSeconds, 0);
            }

            if (currentKeyBoardState.IsKeyDown(upKey))
            {
                RotateAround(Position + (Forward * distance), Right, -rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }

            if (currentKeyBoardState.IsKeyDown(downKey))
            {
                RotateAround(Position + (Forward * distance), Right, rotationSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds);
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Down))
            {
                Position = Position + (target.Forward * (float)gameTime.ElapsedGameTime.TotalSeconds * speed);
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Up))
            {
                Position = Position + (target.Backward * (float)gameTime.ElapsedGameTime.TotalSeconds * speed);
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Left))
            {
                Position = Position + (target.Right * (float)gameTime.ElapsedGameTime.TotalSeconds * speed);
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Right))
            {
                Position = Position + (target.Left * (float)gameTime.ElapsedGameTime.TotalSeconds * speed);
            }

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