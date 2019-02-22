using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    public class Mazemap
    {
        public MazePart[][] part;

        public int MazeNumber
        {
            get;set;
        }
        
        public int MazeSize
        {
            get { return part.Length; }
        }
        public MazePart[][] Part
        {
            get { return part; }
        }
        public Vector2 AnfangsFeld
        {
            get
            {
                switch(MazeNumber)
                {
                    case 1: return new Vector2(0, 0);
                    default: return Vector2.Zero;
                }
            }
        }
        public Vector2 ZielFeld
        {
            get
            {
                switch(MazeNumber)
                {
                    case 1: return new Vector2(11, 22);
                    default:return Vector2.One;
                }
            }
        }


        public Mazemap(int mazenumber)
        {
            MazeNumber = mazenumber;
            switch(MazeNumber)
            {
                case 1: Map1();break;
                case 2: break;
            }
            
        }
        private void Map1()
        {
            part = new MazePart[23][];
            part[0] = new MazePart[] { MazePart.GangObenUnten, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.SackgasseOben, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts };
            part[1] = new MazePart[] { MazePart.SackgasseLinks, MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks };
            part[2] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.KurveUntenRechts, MazePart.SackgasseUnten, MazePart.KurveUntenRechts, MazePart.SackgasseLinks, MazePart.SackgasseLinks, MazePart.GangRechtsLinks, MazePart.SackgasseRechts };
            part[3] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.SackgasseOben, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.KurveUntenLinks, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.TKreuzungLinks, MazePart.TKreuzungRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.KurveUntenRechts };
            part[4] = new MazePart[] { MazePart.TKreuzungOben, MazePart.TKreuzungUnten, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.SackgasseRechts, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.TKreuzungUnten, MazePart.KurveObenLinks, MazePart.SackgasseOben, MazePart.KurveObenLinks, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks };
            part[5] = new MazePart[] { MazePart.SackgasseRechts, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.SackgasseUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks };
            part[6] = new MazePart[] { MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks };
            part[7] = new MazePart[] { MazePart.TKreuzungOben, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseLinks, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.KurveUntenLinks };
            part[8] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.TKreuzungUnten, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.SackgasseOben };
            part[9] = new MazePart[] { MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.SackgasseUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.Kreuzung, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.SackgasseOben };
            part[10] = new MazePart[] { MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenLinks, MazePart.TKreuzungLinks, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.SackgasseOben, MazePart.GangRechtsLinks, MazePart.SackgasseLinks, MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.KurveObenLinks, MazePart.TKreuzungLinks, MazePart.SackgasseOben };
            part[11] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.SackgasseLinks, MazePart.GangRechtsLinks, MazePart.SackgasseUnten, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.SackgasseOben, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.TKreuzungRechts, MazePart.TKreuzungRechts };
            part[12] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.TKreuzungLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenLinks, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.SackgasseUnten, MazePart.KurveObenLinks, MazePart.GangRechtsLinks };
            part[13] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.TKreuzungUnten, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.TKreuzungUnten, MazePart.SackgasseLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.KurveUntenLinks };
            part[14] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseLinks, MazePart.SackgasseLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.SackgasseRechts, MazePart.KurveObenRechts, MazePart.TKreuzungLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.KurveUntenRechts };
            part[15] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.KurveObenRechts, MazePart.TKreuzungUnten, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseUnten, MazePart.KurveUntenLinks };
            part[16] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.TKreuzungLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.KurveUntenRechts };
            part[17] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.KurveUntenLinks, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.TKreuzungRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks };
            part[18] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.SackgasseUnten, MazePart.KurveUntenLinks, MazePart.SackgasseUnten, MazePart.TKreuzungLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks };
            part[19] = new MazePart[] { MazePart.TKreuzungOben, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.SackgasseOben, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.TKreuzungUnten, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.TKreuzungUnten };
            part[20] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.SackgasseLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.SackgasseUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.SackgasseRechts, MazePart.GangRechtsLinks };
            part[21] = new MazePart[] { MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.GangRechtsLinks, MazePart.KurveObenRechts, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenRechts, MazePart.KurveObenRechts, MazePart.KurveUntenRechts, MazePart.GangRechtsLinks, MazePart.GangRechtsLinks, MazePart.KurveObenLinks, MazePart.SackgasseOben, MazePart.GangRechtsLinks };
            part[22] = new MazePart[] { MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.KurveObenLinks, MazePart.TKreuzungLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.TKreuzungLinks, MazePart.GangObenUnten, MazePart.SackgasseOben, MazePart.KurveObenLinks, MazePart.TKreuzungLinks, MazePart.GangObenUnten, MazePart.SackgasseOben, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.KurveObenLinks, MazePart.KurveUntenLinks, MazePart.KurveObenLinks, MazePart.GangObenUnten, MazePart.GangObenUnten, MazePart.KurveUntenLinks };
        }
    }
}
