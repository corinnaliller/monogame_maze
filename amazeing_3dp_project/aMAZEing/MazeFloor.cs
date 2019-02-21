using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    class MazeFloor
    {
        private List<VertexPositionTexture> vertexListBoden;
        private List<short> indexListBoden;
        private int step, width, length;
        private BasicEffect  bodenEffect;
        private Texture2D gras;
        private IndexBuffer indexBufferBoden;
        private VertexBuffer vertexBufferBoden;
        private Game game;

        public VertexPositionTexture[] VerticesBoden
        {
            get
            {
                return vertexListBoden.ToArray();
            }
        }

        public short[] IndicesBoden
        {
            get
            {
                return indexListBoden.ToArray();
            }
        }
        public MazeFloor(Game game, Texture2D texture, int step, int width, int length)
        {
            vertexListBoden = new List<VertexPositionTexture>();
            indexListBoden = new List<short>();
            this.game = game;
            this.step = step;
            this.width = width;
            this.length = length;
            this.gras = texture;
            bodenEffect = new BasicEffect(game.GraphicsDevice);
            CreateFloor();
        }

        private void CreateFloor()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Boden(i, j);
                }
            }

            vertexBufferBoden = new VertexBuffer(game.GraphicsDevice, typeof(VertexPositionTexture), VerticesBoden.Length, BufferUsage.WriteOnly);
            vertexBufferBoden.SetData<VertexPositionTexture>(VerticesBoden);
            indexBufferBoden = new IndexBuffer(game.GraphicsDevice, typeof(short), IndicesBoden.Length, BufferUsage.WriteOnly);
            indexBufferBoden.SetData<short>(IndicesBoden);
        }
        private void Boden(int x, int z)
        {
            int oldIndex = vertexListBoden.Count;
            vertexListBoden.Add(new VertexPositionTexture(new Vector3(x * step, 0, z * step), new Vector2(0, 0)));
            vertexListBoden.Add(new VertexPositionTexture(new Vector3(x * step, 0, z * step+step), new Vector2(0, 1)));
            vertexListBoden.Add(new VertexPositionTexture(new Vector3(x * step + step, 0, z * step + step), new Vector2(1, 0)));
            vertexListBoden.Add(new VertexPositionTexture(new Vector3(x * step + step, 0, z * step), new Vector2(1, 1)));

            indexListBoden.Add(Convert.ToInt16(oldIndex));
            indexListBoden.Add(Convert.ToInt16(oldIndex + 2));
            indexListBoden.Add(Convert.ToInt16(oldIndex + 1));
            indexListBoden.Add(Convert.ToInt16(oldIndex));
            indexListBoden.Add(Convert.ToInt16(oldIndex + 3));
            indexListBoden.Add(Convert.ToInt16(oldIndex + 2));
        }
        public void Draw(ICamera camera)
        {
            bodenEffect.Projection = camera.Projection;
            bodenEffect.View = camera.View;
            bodenEffect.World = Matrix.Identity;
            bodenEffect.TextureEnabled = true;
            bodenEffect.Texture = gras;
            bodenEffect.CurrentTechnique.Passes[0].Apply();
            game.GraphicsDevice.SetVertexBuffer(vertexBufferBoden);
            game.GraphicsDevice.Indices = indexBufferBoden;

            game.GraphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, IndicesBoden.Length / 3);
        }
    }
}
