using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    class Plane
    {
        private Game game;
        private int anzahl;
        private int abstand;
        private Texture2D texture;
        private IndexBuffer indexBuffer;
        private VertexBuffer vertexBuffer;
        private BasicEffect effect;

        public VertexPositionTexture[] Vertices;
        public short[] Indices;

        public Plane(Game game, Texture2D texture, int anzahl, int abstand)
        {
            this.game = game;
            this.texture = texture;
            this.anzahl = anzahl;
            this.abstand = abstand;
            effect = new BasicEffect(game.GraphicsDevice);
            MakePlane();
        }

        private void MakePlane()
        {
            //Vertices = new VertexPositionTexture[anzahl * anzahl];
            List<VertexPositionTexture> liste = new List<VertexPositionTexture>();
            List<short> indexListe = new List<short>();
            for (int i = 0; i < anzahl * abstand; i += abstand)
            {
                for (int j = 0; j < anzahl * abstand; j += abstand)
                {
                    VertexPositionTexture neu = new VertexPositionTexture(new Vector3(j, 0, -i), new Vector2(i / (anzahl), j / (anzahl)));
                    liste.Add(neu);

                }
            }
            Vertices = liste.ToArray();

            for (int i = 0; i < Vertices.Length; i++)
            {
                if (((i + 1) % anzahl) != 0)
                {
                    indexListe.Add(Convert.ToInt16(i));
                    indexListe.Add(Convert.ToInt16(i + anzahl));
                    indexListe.Add(Convert.ToInt16(i + anzahl + 1));
                    indexListe.Add(Convert.ToInt16(i));
                    indexListe.Add(Convert.ToInt16(i + anzahl + 1));
                    indexListe.Add(Convert.ToInt16(i + 1));
                }
            }
            Indices = indexListe.ToArray();
            vertexBuffer = new VertexBuffer(game.GraphicsDevice, typeof(VertexPositionTexture), Vertices.Length, BufferUsage.WriteOnly);
            vertexBuffer.SetData<VertexPositionTexture>(Vertices);
            indexBuffer = new IndexBuffer(game.GraphicsDevice, typeof(short), Indices.Length, BufferUsage.WriteOnly);
            indexBuffer.SetData<short>(Indices);
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
