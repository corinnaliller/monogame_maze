using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public enum MazePart
    {
        GangObenUnten, GangRechtsLinks,TKreuzungRechts,TKreuzungLinks, TKreuzungOben, TKreuzungUnten, SackgasseOben, SackgasseUnten, SackgasseRechts, SackgasseLinks, KurveUntenRechts, KurveUntenLinks, KurveObenRechts, KurveObenLinks
    }
    public class MazeConstructor
    {
        private List<VertexPositionTexture> vertexList;
        private List<short> indexList;
        private int height;
        private int step;
        private BasicEffect effect;
        private Texture2D texture;
        private IndexBuffer indexBuffer;
        private VertexBuffer vertexBuffer;
        private Game game;

        public VertexPositionTexture[] Vertices
        {
            get
            {
                return vertexList.ToArray();
            }
        }
        public short[] Indices
        {
            get
            {
                return indexList.ToArray();
            }
        }

        public MazeConstructor(Game game,Texture2D texture,int height, int step)
        {
            vertexList = new List<VertexPositionTexture>();
            indexList = new List<short>();
            this.game = game;
            this.height = height;
            this.step = step;
            this.texture = texture;
            effect = new BasicEffect(game.GraphicsDevice);
            CreateMaze();
        }
        private void CreateMaze()
        {
            GangObenUnten(0, 0);
            //WandLinks(0, 0);
            //WandRechts(0, 0);
            //WandOben(0, 0);
            //WandUnten(0, 0);
            vertexBuffer = new VertexBuffer(game.GraphicsDevice, typeof(VertexPositionTexture), Vertices.Length, BufferUsage.WriteOnly);
            vertexBuffer.SetData<VertexPositionTexture>(Vertices);
            indexBuffer = new IndexBuffer(game.GraphicsDevice, typeof(short), Indices.Length, BufferUsage.WriteOnly);
            indexBuffer.SetData<short>(Indices);
        }
        
        private void GangObenUnten(int x, int z)
        {
            WandLinks(x, z);
            WandRechts(x, z);
        }

        private void WandLinks(int x, int z)
        {
            int oldIndex = vertexList.Count;
            vertexList.Add(new VertexPositionTexture(new Vector3(x, 0, z), new Vector2(0,0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x, height, z), new Vector2(0,1)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x, 0, z + step), new Vector2(1,0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x, height, z + step), new Vector2(1,1)));

            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
            indexList.Add(Convert.ToInt16(oldIndex + 1));
            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 2));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
        }
        private void WandRechts(int x, int z)
        {
            int oldIndex = vertexList.Count;
            vertexList.Add(new VertexPositionTexture(new Vector3(x+step, 0, z), new Vector2(0, 0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x+step, height, z), new Vector2(0, 1)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x+step, 0, z + step), new Vector2(1, 0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x+step, height, z + step), new Vector2(1, 1)));

            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 1));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
            indexList.Add(Convert.ToInt16(oldIndex + 2));
        }
        private void WandOben(int x, int z)
        {
            int oldIndex = vertexList.Count;
            vertexList.Add(new VertexPositionTexture(new Vector3(x, 0, z+step), new Vector2(0, 0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x, height, z+step), new Vector2(0, 1)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x + step, 0, z + step), new Vector2(1, 0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x + step, height, z + step), new Vector2(1, 1)));

            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
            indexList.Add(Convert.ToInt16(oldIndex + 1));
            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 2));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
        }
        private void WandUnten(int x, int z)
        {
            int oldIndex = vertexList.Count;
            vertexList.Add(new VertexPositionTexture(new Vector3(x, 0, z), new Vector2(0, 0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x, height, z), new Vector2(0, 1)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x + step, 0, z), new Vector2(1, 0)));
            vertexList.Add(new VertexPositionTexture(new Vector3(x + step, height, z), new Vector2(1, 1)));

            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 1));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
            indexList.Add(Convert.ToInt16(oldIndex));
            indexList.Add(Convert.ToInt16(oldIndex + 3));
            indexList.Add(Convert.ToInt16(oldIndex + 2));
        }
        public void Draw(ICamera camera)
        {
            effect.Projection = camera.Projection;
            effect.View = camera.View;
            effect.World = Matrix.Identity;
            effect.TextureEnabled = true;
            effect.Texture = texture;
            //effect.EnableDefaultLighting();

            effect.CurrentTechnique.Passes[0].Apply();
            game.GraphicsDevice.SetVertexBuffer(vertexBuffer);
            game.GraphicsDevice.Indices = indexBuffer;

            //game.GraphicsDevice.DrawUserIndexedPrimitives(PrimitiveType.TriangleList, vertices, 0, vertices.Length, indices, 0, indices.Length / 3);
            game.GraphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, Indices.Length / 3);
        }
    }
}
