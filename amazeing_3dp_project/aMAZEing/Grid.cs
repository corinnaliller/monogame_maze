using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public class Grid
    {
        private int abstand, linien;
        public List<VertexPositionColor> Vertices { get; private set; }
        BasicEffect basicEffect;
        Game game;
        VertexBuffer vertexBuffer;
        public int Abstand
        {
            get
            {
                return abstand;
            }
            set
            {
                if (value > 0)
                {
                    abstand = value;
                }
                else
                {
                    throw new InvalidOperationException("Abstand muss positiv sein!");
                }
                SetGrid();
            }
        }
        public int Linien
        {
            get
            {
                return linien;
            }
            set
            {
                if (value > 0)
                {
                    linien = value;
                }
                else
                {
                    throw new InvalidOperationException("Anzahl der Linien muss positiv sein!");
                }
                SetGrid();
            }
        }
        public Color DefaultColor { get; set; }
        public Color XColor { get; set; }
        public Color YColor { get; set; }
        public bool Visible { get; set; }
        public Grid(Game game, int abstand, int linien, Color defaultColor, Color xColor, Color yColor)
        {
            this.game = game;
            basicEffect = new BasicEffect(game.GraphicsDevice);
            basicEffect.VertexColorEnabled = true;
            basicEffect.World = Matrix.Identity;
            this.abstand = abstand;
            this.linien = linien;
            DefaultColor = defaultColor;
            XColor = xColor;
            YColor = yColor;
            Visible = true;
            Vertices = new List<VertexPositionColor>();
            SetGrid();
        }
        public VertexPositionColor[] VerticesToArray()
        {
            return Vertices.ToArray();
        }
        public int LineNumber()
        {
            return Vertices.Count / 2;
        }
        public void Update()
        {

        }
        public void Draw(ICamera camera)
        {
            if (Visible)
            {
                basicEffect.Projection = camera.Projection;
                basicEffect.View = camera.View;
                basicEffect.CurrentTechnique.Passes[0].Apply();
                game.GraphicsDevice.SetVertexBuffer(vertexBuffer);
                game.GraphicsDevice.DrawUserPrimitives(PrimitiveType.LineList, VerticesToArray(), 0, LineNumber());
            }

        }
        private void SetGrid()
        {
            Vertices.Clear();
            int gridSize = linien * abstand;
            for (int i = abstand; i <= gridSize; i += abstand)
            {
                Vertices.Add(new VertexPositionColor(new Vector3(-gridSize, 0, i), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(gridSize, 0, i), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(i, 0, -gridSize), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(i, 0, gridSize), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(-gridSize, 0, -i), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(gridSize, 0, -i), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(-i, 0, -gridSize), DefaultColor));
                Vertices.Add(new VertexPositionColor(new Vector3(-i, 0, gridSize), DefaultColor));
            }
            Vertices.Add(new VertexPositionColor(new Vector3(-gridSize, 0, 0), XColor));
            Vertices.Add(new VertexPositionColor(new Vector3(gridSize, 0, 0), XColor));
            Vertices.Add(new VertexPositionColor(new Vector3(0, 0, -gridSize), YColor));
            Vertices.Add(new VertexPositionColor(new Vector3(0, 0, gridSize), YColor));

            vertexBuffer = new VertexBuffer(game.GraphicsDevice, typeof(VertexPositionColor), Vertices.Count, BufferUsage.None);
            vertexBuffer.SetData<VertexPositionColor>(VerticesToArray());
        }
    }
}
