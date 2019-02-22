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
     * Corinna Liller
     * Eine Enum, die bei der Konstruktion eines Labyrinths hilft.
     */
    public enum MazePart
    {
        GangObenUnten, GangRechtsLinks,TKreuzungRechts,TKreuzungLinks, TKreuzungOben, TKreuzungUnten, SackgasseOben, SackgasseUnten, SackgasseRechts, SackgasseLinks, KurveUntenRechts, KurveUntenLinks, KurveObenRechts, KurveObenLinks, Kreuzung, Wand
    }

    /**
     * Corinna Liller
     * Diese Klasse legt mithilfe der obigen Enum und einer Mazemap ein Labyrinth an.
     */
    public class MazeConstructor
    {
        private List<VertexPositionTexture> vertexListWaende;
        private List<short> indexListWaende;
        private int height;
        private int step;
        private BasicEffect wandEffect;
        private Texture2D hecke;
        private IndexBuffer indexBufferWaende;
        private VertexBuffer vertexBufferWaende;
        private Game game;
        private Mazemap map;

        public List<BoundingBox> BoundingBoxes
        {
            get;
        }

        public VertexPositionTexture[] VerticesWaende
        {
            get
            {
                return vertexListWaende.ToArray();
            }
        }
        
        public short[] IndicesWaende
        {
            get
            {
                return indexListWaende.ToArray();
            }
        }
        

        public MazeConstructor(Game game,Texture2D textureWand,Mazemap map, int height, int step)
        {
            vertexListWaende = new List<VertexPositionTexture>();
            indexListWaende = new List<short>();
            BoundingBoxes = new List<BoundingBox>();
            this.game = game;
            this.height = height;
            this.step = step;
            this.hecke = textureWand;
            wandEffect = new BasicEffect(game.GraphicsDevice);
            this.map = map;
            CreateMaze(map);
        }
        /**
         * Diese Methode erzeugt das Labyrinth
         */
        private void CreateMaze(Mazemap map)
        {
            for (int i = 0; i < map.Part.Length; i++)
            {
                WandLinks(-1, i);
                WandOben(i, -1);
                WandRechts(map.Part.Length, i);
                if(i != map.ZielFeld.X)
                {
                    WandUnten(i, map.Part.Length);
                }
                
            }
            for (int i = 0; i < map.Part.Length; i++)
            {
                for(int j = 0; j < map.Part.Length-1; j++)
                {
                    switch(map.Part[i][j])
                    {
                        case MazePart.GangObenUnten: GangObenUnten(i, j);break;
                        case MazePart.GangRechtsLinks: GangRechtsLinks(i, j);break;
                        case MazePart.Kreuzung:break;
                        case MazePart.KurveObenLinks: KurveObenLinks(i, j);break;
                        case MazePart.KurveObenRechts: KurveObenRechts(i, j);break;
                        case MazePart.KurveUntenLinks: KurveUntenLinks(i, j);break;
                        case MazePart.KurveUntenRechts: KurveUntenRechts(i, j);break;
                        case MazePart.SackgasseLinks: SackgasseLinks(i, j);break;
                        case MazePart.SackgasseOben: SackgasseOben(i, j);break;
                        case MazePart.SackgasseRechts: SackgasseRechts(i, j);break;
                        case MazePart.SackgasseUnten: SackgasseUnten(i, j);break;
                        case MazePart.TKreuzungLinks: TKreuzungLinks(i, j);break;
                        case MazePart.TKreuzungOben: TKreuzungOben(i, j);break;
                        case MazePart.TKreuzungRechts: TKreuzungRechts(i, j);break;
                        case MazePart.TKreuzungUnten: TKreuzungUnten(i, j);break;
                        case MazePart.Wand: Wand(i, j);break;
                    }
                }
            }
            vertexBufferWaende = new VertexBuffer(game.GraphicsDevice, typeof(VertexPositionTexture), VerticesWaende.Length, BufferUsage.WriteOnly);
            vertexBufferWaende.SetData<VertexPositionTexture>(VerticesWaende);

            indexBufferWaende = new IndexBuffer(game.GraphicsDevice, typeof(short), IndicesWaende.Length, BufferUsage.WriteOnly);
            indexBufferWaende.SetData<short>(IndicesWaende);   
        }
        /**
         * Diese Methoden werden aufgerufen, um die verschiedenen Segmente des Labyrinths zu erzeugen
         */
        private void Wand(int x, int z)
        {
            Decke(x, z);
        }
        private void GangObenUnten(int x, int z)
        {
            WandLinks(x, z);
            WandRechts(x, z);
        }
        private void GangRechtsLinks(int x, int z)
        {
            WandOben(x, z);
            WandUnten(x, z);
        }
        private void SackgasseOben(int x, int z)
        {
            WandOben(x, z);
            WandRechts(x, z);
            WandLinks(x, z);
        }
        private void SackgasseUnten(int x, int z)
        {
            WandUnten(x, z);
            WandRechts(x, z);
            WandLinks(x, z);
        }

        private void SackgasseLinks(int x, int z)
        {
            WandOben(x, z);
            WandUnten(x, z);
            WandRechts(x, z);
        }

        private void SackgasseRechts(int x, int z)
        {
            WandOben(x, z);
            WandUnten(x, z);
            WandLinks(x, z);
        }
        private void TKreuzungLinks(int x, int z)
        {
            WandLinks(x, z);
        }
        private void TKreuzungRechts(int x, int z)
        {
            WandRechts(x, z);
        }
        private void TKreuzungOben(int x, int z)
        {
            WandUnten(x, z);
        }
        private void TKreuzungUnten(int x, int z)
        {
            WandOben(x, z);
        }

        private void KurveUntenLinks(int x, int z)
        {
            WandLinks(x, z);
            WandOben(x, z);
        }

        private void KurveUntenRechts(int x, int z)
        {
            WandRechts(x, z);
            WandOben(x, z);
        }

        private void KurveObenLinks(int x, int z)
        {
            WandLinks(x, z);
            WandUnten(x, z);
        }
        private void KurveObenRechts(int x, int z)
        {
            WandRechts(x, z);
            WandUnten(x, z);
        }

        /**
         * Diese Methoden erzeugen die eigentlichen Wände in der angegebenen Position und bestimmen und speichern ihre BoundingBoxes
         */
        private void Decke(int x, int z)
        {
            int oldIndex = vertexListWaende.Count;
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step, height, z * step), new Vector2(0, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step+step, height, z * step), new Vector2(0, 1)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step+step, height, z * step + step), new Vector2(1, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step, height, z * step + step), new Vector2(1, 1)));

            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 1));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 2));
            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 2));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
        }
        private void WandRechts(int x, int z)
        {
            int oldIndex = vertexListWaende.Count;
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x*step, 0, z * step), new Vector2(0,0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x*step, height, z * step), new Vector2(0,1)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x*step, 0, z * step + step), new Vector2(1,0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x*step, height, z * step + step), new Vector2(1,1)));

            List<Vector3> templist = new List<Vector3>();
            for (int i = oldIndex; i < vertexListWaende.Count; i++)
            {
                templist.Add(vertexListWaende[i].Position);
            }
            BoundingBoxes.Add(BoundingBox.CreateFromPoints(templist));

            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 1));
            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 2));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
        }
        private void WandLinks(int x, int z)
        {
            int oldIndex = vertexListWaende.Count;
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, 0, z * step), new Vector2(0, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, height, z * step), new Vector2(0, 1)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, 0, z * step + step), new Vector2(1, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, height, z * step + step), new Vector2(1, 1)));

            List<Vector3> templist = new List<Vector3>();
            for (int i = oldIndex; i < vertexListWaende.Count; i++)
            {
                templist.Add(vertexListWaende[i].Position);
            }
            BoundingBoxes.Add(BoundingBox.CreateFromPoints(templist));

            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 1));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 2));
        }
        private void WandOben(int x, int z)
        {
            int oldIndex = vertexListWaende.Count;
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step, 0, z * step + step), new Vector2(0, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step, height, z * step + step), new Vector2(0, 1)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, 0, z * step + step), new Vector2(1, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, height, z * step + step), new Vector2(1, 1)));

            List<Vector3> templist = new List<Vector3>();
            for (int i = oldIndex; i < vertexListWaende.Count; i++)
            {
                templist.Add(vertexListWaende[i].Position);
            }
            BoundingBoxes.Add(BoundingBox.CreateFromPoints(templist));
           //Console.WriteLine(BoundingBox.CreateFromPoints(templist).Min + " - " + BoundingBox.CreateFromPoints(templist).Max);

            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 1));
            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 2));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
        }
        private void WandUnten(int x, int z)
        {
            int oldIndex = vertexListWaende.Count;
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step, 0, z * step), new Vector2(0, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step, height, z * step), new Vector2(0, 1)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, 0, z * step), new Vector2(1, 0)));
            vertexListWaende.Add(new VertexPositionTexture(new Vector3(x * step + step, height, z * step), new Vector2(1, 1)));

            List<Vector3> templist = new List<Vector3>();
            for (int i = oldIndex; i < vertexListWaende.Count; i++)
            {
                templist.Add(vertexListWaende[i].Position);
            }
            BoundingBoxes.Add(BoundingBox.CreateFromPoints(templist));

            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 1));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
            indexListWaende.Add(Convert.ToInt16(oldIndex));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 3));
            indexListWaende.Add(Convert.ToInt16(oldIndex + 2));
        }

        public void Draw(ICamera camera)
        {
            wandEffect.Projection = camera.Projection;
            wandEffect.View = camera.View;
            wandEffect.World = Matrix.Identity;
            wandEffect.TextureEnabled = true;
            wandEffect.Texture = hecke;
            wandEffect.CurrentTechnique.Passes[0].Apply();
            game.GraphicsDevice.SetVertexBuffer(vertexBufferWaende);
            game.GraphicsDevice.Indices = indexBufferWaende;

            game.GraphicsDevice.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, IndicesWaende.Length / 3);
        }
    }
}
