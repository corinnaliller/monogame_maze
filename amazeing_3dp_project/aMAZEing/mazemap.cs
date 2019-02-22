using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aMAZEing
{
    /**
     * Jacqueline Klein
     * 
     */
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
                    case 2: return new Vector2(0,3);
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
                    case 2: return new Vector2(50, 1);
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
                case 2: Map2(); break;
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
        private void Map2()
        {
            part = new MazePart[51][];

            // X1
            part[0] = new MazePart[50];
            for (int i = 0; i < 3; i++)
            {
                part[0][i] = MazePart.Wand;
            }
            part[0][3] = MazePart.GangRechtsLinks;
            for (int i = 4; i < 5; i++)
            {
                part[0][i] = MazePart.Wand;
            }

            // X2
            part[1] = new MazePart[51];
            part[1][0] = MazePart.Wand;
            part[1][1] = MazePart.SackgasseLinks;
            part[1][2] = MazePart.Wand;
            part[1][3] = MazePart.TKreuzungOben;
            part[1][4] = MazePart.GangObenUnten;
            part[1][5] = MazePart.KurveUntenRechts;
            part[1][6] = MazePart.Wand;
            part[1][7] = MazePart.KurveObenRechts;
            part[1][8] = MazePart.GangObenUnten;
            part[1][9] = MazePart.TKreuzungRechts;
            part[1][10] = MazePart.GangObenUnten;
            part[1][11] = MazePart.GangObenUnten;
            part[1][12] = MazePart.GangObenUnten;
            part[1][13] = MazePart.TKreuzungRechts;
            part[1][14] = MazePart.GangObenUnten;
            part[1][15] = MazePart.SackgasseOben;
            part[1][16] = MazePart.Wand;
            part[1][17] = MazePart.KurveObenRechts;
            part[1][18] = MazePart.GangObenUnten;
            part[1][19] = MazePart.KurveUntenRechts;
            part[1][20] = MazePart.Wand;
            part[1][21] = MazePart.KurveObenRechts;
            part[1][22] = MazePart.GangObenUnten;
            part[1][23] = MazePart.TKreuzungRechts;
            part[1][24] = MazePart.GangObenUnten;
            part[1][25] = MazePart.KurveUntenRechts;
            part[1][26] = MazePart.Wand;
            part[1][27] = MazePart.SackgasseLinks;
            part[1][28] = MazePart.Wand;
            part[1][29] = MazePart.SackgasseUnten;
            part[1][30] = MazePart.GangObenUnten;
            part[1][31] = MazePart.TKreuzungRechts;
            part[1][32] = MazePart.GangObenUnten;
            part[1][33] = MazePart.GangObenUnten;
            part[1][34] = MazePart.GangObenUnten;
            part[1][35] = MazePart.KurveUntenRechts;
            part[1][36] = MazePart.Wand;
            part[1][37] = MazePart.KurveObenRechts;
            part[1][38] = MazePart.GangObenUnten;
            part[1][39] = MazePart.KurveUntenRechts;
            part[1][40] = MazePart.Wand;
            part[1][41] = MazePart.SackgasseLinks;
            part[1][42] = MazePart.Wand;
            part[1][43] = MazePart.KurveObenRechts;
            part[1][44] = MazePart.GangObenUnten;
            part[1][45] = MazePart.GangObenUnten;
            part[1][46] = MazePart.GangObenUnten;
            part[1][47] = MazePart.GangObenUnten;
            part[1][48] = MazePart.GangObenUnten;
            part[1][49] = MazePart.SackgasseOben;
            part[1][50] = MazePart.Wand;

            //X3
            part[2] = new MazePart[51];
            part[2][0] = MazePart.Wand;
            part[2][1] = MazePart.GangRechtsLinks;
            part[2][2] = MazePart.Wand;
            part[2][3] = MazePart.GangRechtsLinks;
            part[2][4] = MazePart.Wand;
            part[2][5] = MazePart.GangRechtsLinks;
            part[2][6] = MazePart.Wand;
            part[2][7] = MazePart.GangRechtsLinks;
            part[2][8] = MazePart.Wand;
            part[2][9] = MazePart.GangRechtsLinks;
            part[2][10] = MazePart.Wand;
            part[2][11] = MazePart.Wand;
            part[2][12] = MazePart.Wand;
            part[2][13] = MazePart.GangRechtsLinks;
            part[2][14] = MazePart.Wand;
            part[2][15] = MazePart.Wand;
            part[2][16] = MazePart.Wand;
            part[2][17] = MazePart.GangRechtsLinks;
            part[2][18] = MazePart.Wand;
            part[2][19] = MazePart.GangRechtsLinks;
            part[2][20] = MazePart.Wand;
            part[2][21] = MazePart.GangRechtsLinks;
            part[2][22] = MazePart.Wand;
            part[2][23] = MazePart.GangRechtsLinks;
            part[2][24] = MazePart.Wand;
            part[2][25] = MazePart.GangRechtsLinks;
            part[2][26] = MazePart.Wand;
            part[2][27] = MazePart.GangRechtsLinks;
            part[2][28] = MazePart.Wand;
            part[2][29] = MazePart.Wand;
            part[2][30] = MazePart.Wand;
            part[2][31] = MazePart.GangRechtsLinks;
            part[2][32] = MazePart.Wand;
            part[2][33] = MazePart.Wand;
            part[2][34] = MazePart.Wand;
            part[2][35] = MazePart.GangRechtsLinks;
            part[2][36] = MazePart.Wand;
            part[2][37] = MazePart.GangRechtsLinks;
            part[2][38] = MazePart.Wand;
            part[2][39] = MazePart.GangRechtsLinks;
            part[2][40] = MazePart.Wand;
            part[2][41] = MazePart.GangRechtsLinks;
            part[2][42] = MazePart.Wand;
            part[2][43] = MazePart.GangRechtsLinks;
            part[2][44] = MazePart.Wand;
            part[2][45] = MazePart.Wand;
            part[2][46] = MazePart.Wand;
            part[2][47] = MazePart.Wand;
            part[2][48] = MazePart.Wand;
            part[2][49] = MazePart.Wand;
            part[2][50] = MazePart.Wand;

            //X4
            part[3] = new MazePart[51];
            part[3][0] = MazePart.Wand;
            part[3][1] = MazePart.TKreuzungOben;
            part[3][2] = MazePart.GangObenUnten;
            part[3][3] = MazePart.KurveUntenLinks;
            part[3][4] = MazePart.Wand;
            part[3][5] = MazePart.GangRechtsLinks;
            part[3][6] = MazePart.Wand;
            part[3][7] = MazePart.SackgasseRechts;
            part[3][8] = MazePart.Wand;
            part[3][9] = MazePart.KurveObenLinks;
            part[3][10] = MazePart.GangObenUnten;
            part[3][11] = MazePart.KurveUntenRechts;
            part[3][12] = MazePart.Wand;
            part[3][13] = MazePart.GangRechtsLinks;
            part[3][14] = MazePart.Wand;
            part[3][15] = MazePart.KurveObenRechts;
            part[3][16] = MazePart.GangObenUnten;
            part[3][17] = MazePart.KurveUntenLinks;
            part[3][18] = MazePart.Wand;
            part[3][19] = MazePart.GangRechtsLinks;
            part[3][20] = MazePart.Wand;
            part[3][21] = MazePart.GangRechtsLinks;
            part[3][22] = MazePart.Wand;
            part[3][23] = MazePart.GangRechtsLinks;
            part[3][24] = MazePart.Wand;
            part[3][25] = MazePart.KurveObenLinks;
            part[3][26] = MazePart.GangObenUnten;
            part[3][27] = MazePart.TKreuzungUnten;
            part[3][28] = MazePart.Wand;
            part[3][29] = MazePart.KurveObenRechts;
            part[3][30] = MazePart.GangObenUnten;
            part[3][31] = MazePart.KurveUntenLinks;
            part[3][32] = MazePart.Wand;
            part[3][33] = MazePart.SackgasseLinks;
            part[3][34] = MazePart.Wand;
            part[3][35] = MazePart.TKreuzungOben;
            part[3][36] = MazePart.GangObenUnten;
            part[3][37] = MazePart.KurveUntenLinks;
            part[3][38] = MazePart.Wand;
            part[3][39] = MazePart.KurveObenLinks;
            part[3][40] = MazePart.GangObenUnten;
            part[3][41] = MazePart.TKreuzungUnten;
            part[3][42] = MazePart.Wand;
            part[3][43] = MazePart.GangRechtsLinks;
            part[3][44] = MazePart.Wand;
            part[3][45] = MazePart.KurveObenRechts;
            part[3][46] = MazePart.GangObenUnten;
            part[3][47] = MazePart.TKreuzungRechts;
            part[3][48] = MazePart.GangObenUnten;
            part[3][49] = MazePart.KurveUntenRechts;
            part[3][50] = MazePart.Wand;

            //X5
            part[4] = new MazePart[51];
            part[4][0] = MazePart.Wand;
            part[4][1] = MazePart.GangRechtsLinks;
            part[4][2] = MazePart.Wand;
            part[4][3] = MazePart.Wand;
            part[4][4] = MazePart.Wand;
            part[4][5] = MazePart.GangRechtsLinks;
            part[4][6] = MazePart.Wand;
            part[4][7] = MazePart.Wand;
            part[4][8] = MazePart.Wand;
            part[4][9] = MazePart.Wand;
            part[4][10] = MazePart.Wand;
            part[4][11] = MazePart.GangRechtsLinks;
            part[4][12] = MazePart.Wand;
            part[4][13] = MazePart.GangRechtsLinks;
            part[4][14] = MazePart.Wand;
            part[4][15] = MazePart.GangRechtsLinks;
            part[4][16] = MazePart.Wand;
            part[4][17] = MazePart.Wand;
            part[4][18] = MazePart.Wand;
            part[4][19] = MazePart.GangRechtsLinks;
            part[4][20] = MazePart.Wand;
            part[4][21] = MazePart.GangRechtsLinks;
            part[4][22] = MazePart.Wand;
            part[4][23] = MazePart.GangRechtsLinks;
            part[4][24] = MazePart.Wand;
            part[4][25] = MazePart.Wand;
            part[4][26] = MazePart.Wand;
            part[4][27] = MazePart.GangRechtsLinks;
            part[4][28] = MazePart.Wand;
            part[4][29] = MazePart.GangRechtsLinks;
            part[4][30] = MazePart.Wand;
            part[4][31] = MazePart.Wand;
            part[4][32] = MazePart.Wand;
            part[4][33] = MazePart.GangRechtsLinks;
            part[4][34] = MazePart.Wand;
            part[4][35] = MazePart.GangRechtsLinks;
            part[4][36] = MazePart.Wand;
            part[4][37] = MazePart.Wand;
            part[4][38] = MazePart.Wand;
            part[4][39] = MazePart.Wand;
            part[4][40] = MazePart.Wand;
            part[4][41] = MazePart.GangRechtsLinks;
            part[4][42] = MazePart.Wand;
            part[4][43] = MazePart.GangRechtsLinks;
            part[4][44] = MazePart.Wand;
            part[4][45] = MazePart.GangRechtsLinks;
            part[4][46] = MazePart.Wand;
            part[4][47] = MazePart.GangRechtsLinks;
            part[4][48] = MazePart.Wand;
            part[4][49] = MazePart.GangRechtsLinks;
            part[4][50] = MazePart.Wand;

            //X6
            part[5] = new MazePart[51];
            part[5][0] = MazePart.Wand;
            part[5][1] = MazePart.GangRechtsLinks;
            part[5][2] = MazePart.Wand;
            part[5][3] = MazePart.KurveObenRechts;
            part[5][4] = MazePart.GangObenUnten;
            part[5][5] = MazePart.KurveUntenLinks;
            part[5][6] = MazePart.Wand;
            part[5][7] = MazePart.SackgasseUnten;
            part[5][8] = MazePart.GangObenUnten;
            part[5][9] = MazePart.KurveUntenRechts;
            part[5][10] = MazePart.Wand;
            part[5][11] = MazePart.GangObenUnten;
            part[5][12] = MazePart.Wand;
            part[5][13] = MazePart.GangObenUnten;
            part[5][14] = MazePart.Wand;
            part[5][15] = MazePart.GangObenUnten;
            part[5][16] = MazePart.Wand;
            part[5][17] = MazePart.SackgasseLinks;
            part[5][18] = MazePart.Wand;
            part[5][19] = MazePart.KurveObenLinks;
            part[5][20] = MazePart.GangObenUnten;
            part[5][21] = MazePart.KurveUntenLinks;
            part[5][22] = MazePart.Wand;
            part[5][23] = MazePart.KurveObenLinks;
            part[5][24] = MazePart.GangObenUnten;
            part[5][25] = MazePart.KurveUntenRechts;
            part[5][26] = MazePart.Wand;
            part[5][27] = MazePart.SackgasseRechts;
            part[5][28] = MazePart.Wand;
            part[5][29] = MazePart.KurveObenLinks;
            part[5][30] = MazePart.GangObenUnten;
            part[5][31] = MazePart.KurveUntenRechts;
            part[5][32] = MazePart.Wand;
            part[5][33] = MazePart.GangRechtsLinks;
            part[5][34] = MazePart.Wand;
            part[5][35] = MazePart.GangRechtsLinks;
            part[5][36] = MazePart.Wand;
            part[5][37] = MazePart.KurveObenRechts;
            part[5][38] = MazePart.GangObenUnten;
            part[5][39] = MazePart.KurveUntenRechts;
            part[5][40] = MazePart.Wand;
            part[5][41] = MazePart.SackgasseRechts;
            part[5][42] = MazePart.Wand;
            part[5][43] = MazePart.GangRechtsLinks;
            part[5][44] = MazePart.Wand;
            part[5][45] = MazePart.GangRechtsLinks;
            part[5][46] = MazePart.Wand;
            part[5][47] = MazePart.GangRechtsLinks;
            part[5][48] = MazePart.Wand;
            part[5][49] = MazePart.GangRechtsLinks;
            part[5][50] = MazePart.Wand;

            //X7
            part[6] = new MazePart[51];
            part[6][0] = MazePart.Wand;
            part[6][1] = MazePart.GangRechtsLinks;
            part[6][2] = MazePart.Wand;
            part[6][3] = MazePart.GangRechtsLinks;
            part[6][4] = MazePart.Wand;
            part[6][5] = MazePart.Wand;
            part[6][6] = MazePart.Wand;
            part[6][7] = MazePart.Wand;
            part[6][8] = MazePart.Wand;
            part[6][9] = MazePart.GangRechtsLinks;
            part[6][10] = MazePart.Wand;
            part[6][11] = MazePart.GangRechtsLinks;
            part[6][12] = MazePart.Wand;
            part[6][13] = MazePart.GangRechtsLinks;
            part[6][14] = MazePart.Wand;
            part[6][15] = MazePart.GangRechtsLinks;
            part[6][16] = MazePart.Wand;
            part[6][17] = MazePart.GangRechtsLinks;
            part[6][18] = MazePart.Wand;
            part[6][19] = MazePart.Wand;
            part[6][20] = MazePart.Wand;
            part[6][21] = MazePart.Wand;
            part[6][22] = MazePart.Wand;
            part[6][23] = MazePart.Wand;
            part[6][24] = MazePart.Wand;
            part[6][25] = MazePart.GangRechtsLinks;
            part[6][26] = MazePart.Wand;
            part[6][27] = MazePart.Wand;
            part[6][28] = MazePart.Wand;
            part[6][29] = MazePart.Wand;
            part[6][30] = MazePart.Wand;
            part[6][31] = MazePart.GangRechtsLinks;
            part[6][32] = MazePart.Wand;
            part[6][33] = MazePart.GangRechtsLinks;
            part[6][34] = MazePart.Wand;
            part[6][35] = MazePart.GangRechtsLinks;
            part[6][36] = MazePart.Wand;
            part[6][37] = MazePart.GangRechtsLinks;
            part[6][38] = MazePart.Wand;
            part[6][39] = MazePart.GangRechtsLinks;
            part[6][40] = MazePart.Wand;
            part[6][41] = MazePart.Wand;
            part[6][42] = MazePart.Wand;
            part[6][43] = MazePart.GangRechtsLinks;
            part[6][44] = MazePart.Wand;
            part[6][45] = MazePart.GangRechtsLinks;
            part[6][46] = MazePart.Wand;
            part[6][47] = MazePart.GangRechtsLinks;
            part[6][48] = MazePart.Wand;
            part[6][49] = MazePart.GangRechtsLinks;
            part[6][50] = MazePart.Wand;

            //X8
            part[7] = new MazePart[51];
            part[7][0] = MazePart.Wand;
            part[7][1] = MazePart.GangRechtsLinks;
            part[7][2] = MazePart.Wand;
            part[7][3] = MazePart.KurveObenLinks;
            part[7][4] = MazePart.GangObenUnten;
            part[7][5] = MazePart.GangObenUnten;
            part[7][6] = MazePart.GangObenUnten;
            part[7][7] = MazePart.TKreuzungRechts;
            part[7][8] = MazePart.GangObenUnten;
            part[7][9] = MazePart.KurveUntenLinks;
            part[7][10] = MazePart.Wand;
            part[7][11] = MazePart.GangRechtsLinks;
            part[7][12] = MazePart.Wand;
            part[7][13] = MazePart.GangRechtsLinks;
            part[7][14] = MazePart.Wand;
            part[7][15] = MazePart.KurveObenLinks;
            part[7][16] = MazePart.GangObenUnten;
            part[7][17] = MazePart.TKreuzungLinks;
            part[7][18] = MazePart.GangObenUnten;
            part[7][19] = MazePart.GangObenUnten;
            part[7][20] = MazePart.GangObenUnten;
            part[7][21] = MazePart.KurveUntenRechts;
            part[7][22] = MazePart.Wand;
            part[7][23] = MazePart.SackgasseLinks;
            part[7][24] = MazePart.Wand;
            part[7][25] = MazePart.KurveObenLinks;
            part[7][26] = MazePart.GangObenUnten;
            part[7][27] = MazePart.KurveUntenRechts;
            part[7][28] = MazePart.Wand;
            part[7][29] = MazePart.KurveObenRechts;
            part[7][30] = MazePart.GangObenUnten;
            part[7][31] = MazePart.KurveUntenLinks;
            part[7][32] = MazePart.Wand;
            part[7][33] = MazePart.GangRechtsLinks;
            part[7][34] = MazePart.Wand;
            part[7][35] = MazePart.KurveObenLinks;
            part[7][36] = MazePart.GangObenUnten;
            part[7][37] = MazePart.KurveUntenLinks;
            part[7][38] = MazePart.Wand;
            part[7][39] = MazePart.KurveObenLinks;
            part[7][40] = MazePart.GangObenUnten;
            part[7][41] = MazePart.GangObenUnten;
            part[7][42] = MazePart.GangObenUnten;
            part[7][43] = MazePart.KurveUntenLinks;
            part[7][44] = MazePart.Wand;
            part[7][45] = MazePart.GangRechtsLinks;
            part[7][46] = MazePart.Wand;
            part[7][47] = MazePart.SackgasseRechts;
            part[7][48] = MazePart.Wand;
            part[7][49] = MazePart.GangRechtsLinks;
            part[7][50] = MazePart.Wand;

            //X9
            part[8] = new MazePart[51];
            part[8][0] = MazePart.Wand;
            part[8][1] = MazePart.GangRechtsLinks;
            part[8][2] = MazePart.Wand;
            part[8][3] = MazePart.Wand;
            part[8][4] = MazePart.Wand;
            part[8][5] = MazePart.Wand;
            part[8][6] = MazePart.Wand;
            part[8][7] = MazePart.GangRechtsLinks;
            part[8][8] = MazePart.Wand;
            part[8][9] = MazePart.Wand;
            part[8][10] = MazePart.Wand;
            part[8][11] = MazePart.GangRechtsLinks;
            part[8][12] = MazePart.Wand;
            part[8][13] = MazePart.GangRechtsLinks;
            part[8][14] = MazePart.Wand;
            part[8][15] = MazePart.Wand;
            part[8][16] = MazePart.Wand;
            part[8][17] = MazePart.Wand;
            part[8][18] = MazePart.Wand;
            part[8][19] = MazePart.Wand;
            part[8][20] = MazePart.Wand;
            part[8][21] = MazePart.GangRechtsLinks;
            part[8][22] = MazePart.Wand;
            part[8][23] = MazePart.GangRechtsLinks;
            part[8][24] = MazePart.Wand;
            part[8][25] = MazePart.Wand;
            part[8][26] = MazePart.Wand;
            part[8][27] = MazePart.GangRechtsLinks;
            part[8][28] = MazePart.Wand;
            part[8][29] = MazePart.GangRechtsLinks;
            part[8][30] = MazePart.Wand;
            part[8][31] = MazePart.Wand;
            part[8][32] = MazePart.Wand;
            part[8][33] = MazePart.GangRechtsLinks;
            part[8][34] = MazePart.Wand;
            part[8][35] = MazePart.Wand;
            part[8][36] = MazePart.Wand;
            part[8][37] = MazePart.Wand;
            part[8][38] = MazePart.Wand;
            part[8][39] = MazePart.Wand;
            part[8][40] = MazePart.Wand;
            part[8][41] = MazePart.Wand;
            part[8][42] = MazePart.Wand;
            part[8][43] = MazePart.Wand;
            part[8][44] = MazePart.Wand;
            part[8][45] = MazePart.GangRechtsLinks;
            part[8][46] = MazePart.Wand;
            part[8][47] = MazePart.Wand;
            part[8][48] = MazePart.Wand;
            part[8][49] = MazePart.GangRechtsLinks;
            part[8][50] = MazePart.Wand;

            //X10
            part[9] = new MazePart[51];
            part[9][0] = MazePart.Wand;
            part[9][1] = MazePart.GangRechtsLinks;
            part[9][2] = MazePart.Wand;
            part[9][3] = MazePart.KurveObenRechts;
            part[9][4] = MazePart.GangObenUnten;
            part[9][5] = MazePart.TKreuzungRechts;
            part[9][6] = MazePart.GangObenUnten;
            part[9][7] = MazePart.TKreuzungLinks;
            part[9][8] = MazePart.GangObenUnten;
            part[9][9] = MazePart.SackgasseOben;
            part[9][10] = MazePart.Wand;
            part[9][11] = MazePart.GangRechtsLinks;
            part[9][12] = MazePart.Wand;
            part[9][13] = MazePart.TKreuzungOben;
            part[9][14] = MazePart.GangObenUnten;
            part[9][15] = MazePart.SackgasseOben;
            part[9][16] = MazePart.Wand;
            part[9][17] = MazePart.KurveObenRechts;
            part[9][18] = MazePart.GangObenUnten;
            part[9][19] = MazePart.SackgasseOben;
            part[9][20] = MazePart.Wand;
            part[9][21] = MazePart.GangRechtsLinks;
            part[9][22] = MazePart.Wand;
            part[9][23] = MazePart.TKreuzungOben;
            part[9][24] = MazePart.GangObenUnten;
            part[9][25] = MazePart.KurveUntenRechts;
            part[9][26] = MazePart.Wand;
            part[9][27] = MazePart.GangRechtsLinks;
            part[9][28] = MazePart.Wand;
            part[9][29] = MazePart.KurveObenLinks;
            part[9][30] = MazePart.GangObenUnten;
            part[9][31] = MazePart.GangObenUnten;
            part[9][32] = MazePart.GangObenUnten;
            part[9][33] = MazePart.Kreuzung;
            part[9][34] = MazePart.GangObenUnten;
            part[9][35] = MazePart.SackgasseOben;
            part[9][36] = MazePart.Wand;
            part[9][37] = MazePart.SackgasseLinks;
            part[9][38] = MazePart.Wand;
            part[9][39] = MazePart.SackgasseLinks;
            part[9][40] = MazePart.Wand;
            part[9][41] = MazePart.SackgasseLinks;
            part[9][42] = MazePart.Wand;
            part[9][43] = MazePart.SackgasseUnten;
            part[9][44] = MazePart.GangObenUnten;
            part[9][45] = MazePart.TKreuzungLinks;
            part[9][46] = MazePart.GangObenUnten;
            part[9][47] = MazePart.KurveUntenRechts;
            part[9][48] = MazePart.Wand;
            part[9][49] = MazePart.GangRechtsLinks;
            part[9][50] = MazePart.Wand;

            //X11
            part[10] = new MazePart[51];
            part[10][0] = MazePart.Wand;
            part[10][1] = MazePart.GangRechtsLinks;
            part[10][2] = MazePart.Wand;
            part[10][3] = MazePart.GangRechtsLinks;
            part[10][4] = MazePart.Wand;
            part[10][5] = MazePart.GangRechtsLinks;
            part[10][6] = MazePart.Wand;
            part[10][7] = MazePart.Wand;
            part[10][8] = MazePart.Wand;
            part[10][9] = MazePart.Wand;
            part[10][10] = MazePart.Wand;
            part[10][11] = MazePart.GangRechtsLinks;
            part[10][12] = MazePart.Wand;
            part[10][13] = MazePart.GangRechtsLinks;
            part[10][14] = MazePart.Wand;
            part[10][15] = MazePart.Wand;
            part[10][16] = MazePart.Wand;
            part[10][17] = MazePart.GangRechtsLinks;
            part[10][18] = MazePart.Wand;
            part[10][19] = MazePart.Wand;
            part[10][20] = MazePart.Wand;
            part[10][21] = MazePart.GangRechtsLinks;
            part[10][22] = MazePart.Wand;
            part[10][23] = MazePart.GangRechtsLinks;
            part[10][24] = MazePart.Wand;
            part[10][25] = MazePart.GangRechtsLinks;
            part[10][26] = MazePart.Wand;
            part[10][27] = MazePart.GangRechtsLinks;
            part[10][28] = MazePart.Wand;
            part[10][29] = MazePart.Wand;
            part[10][30] = MazePart.Wand;
            part[10][31] = MazePart.Wand;
            part[10][32] = MazePart.Wand;
            part[10][33] = MazePart.GangRechtsLinks;
            part[10][34] = MazePart.Wand;
            part[10][35] = MazePart.Wand;
            part[10][36] = MazePart.Wand;
            part[10][37] = MazePart.GangRechtsLinks;
            part[10][38] = MazePart.Wand;
            part[10][39] = MazePart.GangRechtsLinks;
            part[10][40] = MazePart.Wand;
            part[10][41] = MazePart.Wand;
            part[10][42] = MazePart.Wand;
            part[10][43] = MazePart.Wand;
            part[10][44] = MazePart.Wand;
            part[10][45] = MazePart.Wand;
            part[10][46] = MazePart.Wand;
            part[10][47] = MazePart.GangRechtsLinks;
            part[10][48] = MazePart.Wand;
            part[10][49] = MazePart.GangRechtsLinks;
            part[10][50] = MazePart.Wand;

            //X12
            part[11] = new MazePart[51];
            part[11][0] = MazePart.Wand;
            part[11][1] = MazePart.GangRechtsLinks;
            part[11][2] = MazePart.Wand;
            part[11][3] = MazePart.SackgasseRechts;
            part[11][4] = MazePart.Wand;
            part[11][5] = MazePart.KurveObenLinks;
            part[11][6] = MazePart.GangObenUnten;
            part[11][7] = MazePart.GangObenUnten;
            part[11][8] = MazePart.GangObenUnten;
            part[11][9] = MazePart.SackgasseOben;
            part[11][10] = MazePart.Wand;
            part[11][11] = MazePart.GangRechtsLinks;
            part[11][12] = MazePart.Wand;
            part[11][13] = MazePart.KurveObenLinks;
            part[11][14] = MazePart.GangObenUnten;
            part[11][15] = MazePart.GangObenUnten;
            part[11][16] = MazePart.GangObenUnten;
            part[11][17] = MazePart.TKreuzungLinks;
            part[11][18] = MazePart.GangObenUnten;
            part[11][19] = MazePart.KurveUntenRechts;
            part[11][20] = MazePart.Wand;
            part[11][21] = MazePart.KurveObenLinks;
            part[11][22] = MazePart.GangObenUnten;
            part[11][23] = MazePart.TKreuzungUnten;
            part[11][24] = MazePart.Wand;
            part[11][25] = MazePart.SackgasseRechts;
            part[11][26] = MazePart.Wand;
            part[11][27] = MazePart.GangRechtsLinks;
            part[11][28] = MazePart.Wand;
            part[11][29] = MazePart.SackgasseLinks;
            part[11][30] = MazePart.Wand;
            part[11][31] = MazePart.SackgasseLinks;
            part[11][32] = MazePart.Wand;
            part[11][33] = MazePart.KurveObenLinks;
            part[11][34] = MazePart.GangObenUnten;
            part[11][35] = MazePart.GangObenUnten;
            part[11][36] = MazePart.GangObenUnten;
            part[11][37] = MazePart.TKreuzungLinks;
            part[11][38] = MazePart.GangObenUnten;
            part[11][39] = MazePart.TKreuzungUnten;
            part[11][40] = MazePart.Wand;
            part[11][41] = MazePart.KurveObenLinks;
            part[11][42] = MazePart.GangObenUnten;
            part[11][43] = MazePart.GangObenUnten;
            part[11][44] = MazePart.GangObenUnten;
            part[11][45] = MazePart.TKreuzungRechts;
            part[11][46] = MazePart.GangObenUnten;
            part[11][47] = MazePart.KurveUntenLinks;
            part[11][48] = MazePart.Wand;
            part[11][49] = MazePart.GangRechtsLinks;
            part[11][50] = MazePart.Wand;

            //X13
            part[12] = new MazePart[51];
            part[12][0] = MazePart.Wand;
            part[12][1] = MazePart.GangRechtsLinks;
            part[12][2] = MazePart.Wand;
            part[12][3] = MazePart.Wand;
            part[12][4] = MazePart.Wand;
            part[12][5] = MazePart.Wand;
            part[12][6] = MazePart.Wand;
            part[12][7] = MazePart.Wand;
            part[12][8] = MazePart.Wand;
            part[12][9] = MazePart.Wand;
            part[12][10] = MazePart.Wand;
            part[12][11] = MazePart.GangRechtsLinks;
            part[12][12] = MazePart.Wand;
            part[12][13] = MazePart.Wand;
            part[12][14] = MazePart.Wand;
            part[12][15] = MazePart.Wand;
            part[12][16] = MazePart.Wand;
            part[12][17] = MazePart.Wand;
            part[12][18] = MazePart.Wand;
            part[12][19] = MazePart.GangRechtsLinks;
            part[12][20] = MazePart.Wand;
            part[12][21] = MazePart.Wand;
            part[12][22] = MazePart.Wand;
            part[12][23] = MazePart.GangRechtsLinks;
            part[12][24] = MazePart.Wand;
            part[12][25] = MazePart.Wand;
            part[12][26] = MazePart.Wand;
            part[12][27] = MazePart.GangRechtsLinks;
            part[12][28] = MazePart.Wand;
            part[12][29] = MazePart.GangRechtsLinks;
            part[12][30] = MazePart.Wand;
            part[12][31] = MazePart.Wand;
            part[12][32] = MazePart.Wand;
            part[12][33] = MazePart.Wand;
            part[12][34] = MazePart.Wand;
            part[12][35] = MazePart.Wand;
            part[12][36] = MazePart.Wand;
            part[12][37] = MazePart.Wand;
            part[12][38] = MazePart.Wand;
            part[12][39] = MazePart.GangRechtsLinks;
            part[12][40] = MazePart.Wand;
            part[12][41] = MazePart.Wand;
            part[12][42] = MazePart.Wand;
            part[12][43] = MazePart.Wand;
            part[12][44] = MazePart.Wand;
            part[12][45] = MazePart.GangRechtsLinks;
            part[12][46] = MazePart.Wand;
            part[12][47] = MazePart.Wand;
            part[12][48] = MazePart.Wand;
            part[12][49] = MazePart.GangRechtsLinks;
            part[12][50] = MazePart.Wand;

            //X14
            part[13] = new MazePart[51];
            part[13][0] = MazePart.Wand;
            part[13][1] = MazePart.GangRechtsLinks;
            part[13][2] = MazePart.Wand;
            part[13][3] = MazePart.KurveObenRechts;
            part[13][4] = MazePart.GangObenUnten;
            part[13][5] = MazePart.KurveUntenRechts;
            part[13][6] = MazePart.Wand;
            part[13][7] = MazePart.KurveObenRechts;
            part[13][8] = MazePart.GangObenUnten;
            part[13][9] = MazePart.GangObenUnten;
            part[13][10] = MazePart.GangObenUnten;
            part[13][11] = MazePart.KurveUntenLinks;
            part[13][12] = MazePart.Wand;
            part[13][13] = MazePart.KurveObenRechts;
            part[13][14] = MazePart.GangObenUnten;
            part[13][15] = MazePart.KurveUntenRechts;
            part[13][16] = MazePart.Wand;
            part[13][17] = MazePart.SackgasseLinks;
            part[13][18] = MazePart.Wand;
            part[13][19] = MazePart.TKreuzungOben;
            part[13][20] = MazePart.GangObenUnten;
            part[13][21] = MazePart.SackgasseOben;
            part[13][22] = MazePart.Wand;
            part[13][23] = MazePart.GangRechtsLinks;
            part[13][24] = MazePart.Wand;
            part[13][25] = MazePart.KurveObenRechts;
            part[13][26] = MazePart.GangObenUnten;
            part[13][27] = MazePart.TKreuzungUnten;
            part[13][28] = MazePart.Wand;
            part[13][29] = MazePart.KurveObenLinks;
            part[13][30] = MazePart.GangObenUnten;
            part[13][31] = MazePart.Kreuzung;
            part[13][32] = MazePart.GangObenUnten;
            part[13][33] = MazePart.GangObenUnten;
            part[13][34] = MazePart.GangObenUnten;
            part[13][35] = MazePart.KurveUntenRechts;
            part[13][36] = MazePart.Wand;
            part[13][37] = MazePart.SackgasseLinks;
            part[13][38] = MazePart.Wand;
            part[13][39] = MazePart.KurveObenLinks;
            part[13][40] = MazePart.GangObenUnten;
            part[13][41] = MazePart.KurveUntenRechts;
            part[13][42] = MazePart.Wand;
            part[13][43] = MazePart.KurveObenRechts;
            part[13][44] = MazePart.GangObenUnten;
            part[13][45] = MazePart.KurveUntenLinks;
            part[13][46] = MazePart.Wand;
            part[13][47] = MazePart.SackgasseLinks;
            part[13][48] = MazePart.Wand;
            part[13][49] = MazePart.GangRechtsLinks;
            part[13][50] = MazePart.Wand;

            //X15
            part[14] = new MazePart[51];
            part[14][0] = MazePart.Wand;
            part[14][1] = MazePart.GangRechtsLinks;
            part[14][2] = MazePart.Wand;
            part[14][3] = MazePart.GangRechtsLinks;
            part[14][4] = MazePart.Wand;
            part[14][5] = MazePart.GangRechtsLinks;
            part[14][6] = MazePart.Wand;
            part[14][7] = MazePart.GangRechtsLinks;
            part[14][8] = MazePart.Wand;
            part[14][9] = MazePart.Wand;
            part[14][10] = MazePart.Wand;
            part[14][11] = MazePart.Wand;
            part[14][12] = MazePart.Wand;
            part[14][13] = MazePart.GangRechtsLinks;
            part[14][14] = MazePart.Wand;
            part[14][15] = MazePart.GangRechtsLinks;
            part[14][16] = MazePart.Wand;
            part[14][17] = MazePart.GangRechtsLinks;
            part[14][18] = MazePart.Wand;
            part[14][19] = MazePart.GangRechtsLinks;
            part[14][20] = MazePart.Wand;
            part[14][21] = MazePart.Wand;
            part[14][22] = MazePart.Wand;
            part[14][23] = MazePart.GangRechtsLinks;
            part[14][24] = MazePart.Wand;
            part[14][25] = MazePart.GangRechtsLinks;
            part[14][26] = MazePart.Wand;
            part[14][27] = MazePart.GangRechtsLinks;
            part[14][28] = MazePart.Wand;
            part[14][29] = MazePart.Wand;
            part[14][30] = MazePart.Wand;
            part[14][31] = MazePart.GangRechtsLinks;
            part[14][32] = MazePart.Wand;
            part[14][33] = MazePart.Wand;
            part[14][34] = MazePart.Wand;
            part[14][35] = MazePart.GangRechtsLinks;
            part[14][36] = MazePart.Wand;
            part[14][37] = MazePart.GangRechtsLinks;
            part[14][38] = MazePart.Wand;
            part[14][39] = MazePart.Wand;
            part[14][40] = MazePart.Wand;
            part[14][41] = MazePart.GangRechtsLinks;
            part[14][42] = MazePart.Wand;
            part[14][43] = MazePart.GangRechtsLinks;
            part[14][44] = MazePart.Wand;
            part[14][45] = MazePart.Wand;
            part[14][46] = MazePart.Wand;
            part[14][47] = MazePart.GangRechtsLinks;
            part[14][48] = MazePart.Wand;
            part[14][49] = MazePart.GangRechtsLinks;
            part[14][50] = MazePart.Wand;

            //X16
            part[15] = new MazePart[51];
            part[15][0] = MazePart.Wand;
            part[15][1] = MazePart.GangRechtsLinks;
            part[15][2] = MazePart.Wand;
            part[15][3] = MazePart.GangRechtsLinks;
            part[15][4] = MazePart.Wand;
            part[15][5] = MazePart.KurveObenLinks;
            part[15][6] = MazePart.GangObenUnten;
            part[15][7] = MazePart.KurveUntenLinks;
            part[15][8] = MazePart.Wand;
            part[15][9] = MazePart.SackgasseUnten;
            part[15][10] = MazePart.GangObenUnten;
            part[15][11] = MazePart.TKreuzungRechts;
            part[15][12] = MazePart.GangObenUnten;
            part[15][13] = MazePart.TKreuzungUnten;
            part[15][14] = MazePart.Wand;
            part[15][15] = MazePart.KurveObenLinks;
            part[15][16] = MazePart.GangObenUnten;
            part[15][17] = MazePart.TKreuzungUnten;
            part[15][18] = MazePart.Wand;
            part[15][19] = MazePart.GangRechtsLinks;
            part[15][20] = MazePart.Wand;
            part[15][21] = MazePart.KurveUntenRechts;
            part[15][22] = MazePart.GangObenUnten;
            part[15][23] = MazePart.KurveUntenLinks;
            part[15][24] = MazePart.Wand;
            part[15][25] = MazePart.GangRechtsLinks;
            part[15][26] = MazePart.Wand;
            part[15][27] = MazePart.KurveObenLinks;
            part[15][28] = MazePart.GangObenUnten;
            part[15][29] = MazePart.GangObenUnten;
            part[15][30] = MazePart.GangObenUnten;
            part[15][31] = MazePart.TKreuzungUnten;
            part[15][32] = MazePart.Wand;
            part[15][33] = MazePart.SackgasseLinks;
            part[15][34] = MazePart.Wand;
            part[15][35] = MazePart.GangRechtsLinks;
            part[15][36] = MazePart.Wand;
            part[15][37] = MazePart.TKreuzungOben;
            part[15][38] = MazePart.GangObenUnten;
            part[15][39] = MazePart.SackgasseOben;
            part[15][40] = MazePart.Wand;
            part[15][41] = MazePart.KurveObenLinks;
            part[15][42] = MazePart.GangObenUnten;
            part[15][43] = MazePart.KurveUntenLinks;
            part[15][44] = MazePart.Wand;
            part[15][45] = MazePart.KurveObenRechts;
            part[15][46] = MazePart.GangObenUnten;
            part[15][47] = MazePart.TKreuzungUnten;
            part[15][48] = MazePart.Wand;
            part[15][49] = MazePart.GangRechtsLinks;
            part[15][50] = MazePart.Wand;

            //X17
            part[16] = new MazePart[51];
            part[16][0] = MazePart.Wand;
            part[16][1] = MazePart.GangRechtsLinks;
            part[16][2] = MazePart.Wand;
            part[16][3] = MazePart.GangRechtsLinks;
            part[16][4] = MazePart.Wand;
            part[16][5] = MazePart.Wand;
            part[16][6] = MazePart.Wand;
            part[16][7] = MazePart.Wand;
            part[16][8] = MazePart.Wand;
            part[16][9] = MazePart.Wand;
            part[16][10] = MazePart.Wand;
            part[16][11] = MazePart.GangRechtsLinks;
            part[16][12] = MazePart.Wand;
            part[16][13] = MazePart.GangRechtsLinks;
            part[16][14] = MazePart.Wand;
            part[16][15] = MazePart.Wand;
            part[16][16] = MazePart.Wand;
            part[16][17] = MazePart.GangRechtsLinks;
            part[16][18] = MazePart.Wand;
            part[16][19] = MazePart.GangRechtsLinks;
            part[16][20] = MazePart.Wand;
            part[16][21] = MazePart.GangRechtsLinks;
            part[16][22] = MazePart.Wand;
            part[16][23] = MazePart.Wand;
            part[16][24] = MazePart.Wand;
            part[16][25] = MazePart.GangRechtsLinks;
            part[16][26] = MazePart.Wand;
            part[16][27] = MazePart.Wand;
            part[16][28] = MazePart.Wand;
            part[16][29] = MazePart.Wand;
            part[16][30] = MazePart.Wand;
            part[16][31] = MazePart.GangRechtsLinks;
            part[16][32] = MazePart.Wand;
            part[16][33] = MazePart.GangRechtsLinks;
            part[16][34] = MazePart.Wand;
            part[16][35] = MazePart.GangRechtsLinks;
            part[16][36] = MazePart.Wand;
            part[16][37] = MazePart.GangRechtsLinks;
            part[16][38] = MazePart.Wand;
            part[16][39] = MazePart.Wand;
            part[16][40] = MazePart.Wand;
            part[16][41] = MazePart.Wand;
            part[16][42] = MazePart.Wand;
            part[16][43] = MazePart.Wand;
            part[16][44] = MazePart.Wand;
            part[16][45] = MazePart.GangRechtsLinks;
            part[16][46] = MazePart.Wand;
            part[16][47] = MazePart.GangRechtsLinks;
            part[16][48] = MazePart.Wand;
            part[16][49] = MazePart.GangRechtsLinks;
            part[16][50] = MazePart.Wand;

            //X18
            part[17] = new MazePart[51];
            part[17][0] = MazePart.Wand;
            part[17][1] = MazePart.GangRechtsLinks;
            part[17][2] = MazePart.Wand;
            part[17][3] = MazePart.KurveObenLinks;
            part[17][4] = MazePart.GangObenUnten;
            part[17][5] = MazePart.GangObenUnten;
            part[17][6] = MazePart.GangObenUnten;
            part[17][7] = MazePart.KurveUntenRechts;
            part[17][8] = MazePart.Wand;
            part[17][9] = MazePart.KurveObenRechts;
            part[17][10] = MazePart.GangObenUnten;
            part[17][11] = MazePart.KurveUntenLinks;
            part[17][12] = MazePart.Wand;
            part[17][13] = MazePart.GangRechtsLinks;
            part[17][14] = MazePart.Wand;
            part[17][15] = MazePart.SackgasseUnten;
            part[17][16] = MazePart.GangObenUnten;
            part[17][17] = MazePart.KurveUntenLinks;
            part[17][18] = MazePart.Wand;
            part[17][19] = MazePart.KurveObenLinks;
            part[17][20] = MazePart.GangObenUnten;
            part[17][21] = MazePart.TKreuzungLinks;
            part[17][22] = MazePart.GangObenUnten;
            part[17][23] = MazePart.KurveUntenRechts;
            part[17][24] = MazePart.Wand;
            part[17][25] = MazePart.KurveObenLinks;
            part[17][26] = MazePart.GangObenUnten;
            part[17][27] = MazePart.GangObenUnten;
            part[17][28] = MazePart.GangObenUnten;
            part[17][29] = MazePart.KurveUntenRechts;
            part[17][30] = MazePart.Wand;
            part[17][31] = MazePart.SackgasseRechts;
            part[17][32] = MazePart.Wand;
            part[17][33] = MazePart.TKreuzungOben;
            part[17][34] = MazePart.GangObenUnten;
            part[17][35] = MazePart.TKreuzungLinks;
            part[17][36] = MazePart.GangObenUnten;
            part[17][37] = MazePart.TKreuzungLinks;
            part[17][38] = MazePart.GangObenUnten;
            part[17][39] = MazePart.SackgasseOben;
            part[17][40] = MazePart.Wand;
            part[17][41] = MazePart.SackgasseUnten;
            part[17][42] = MazePart.GangObenUnten;
            part[17][43] = MazePart.TKreuzungRechts;
            part[17][44] = MazePart.GangObenUnten;
            part[17][45] = MazePart.KurveUntenLinks;
            part[17][46] = MazePart.Wand;
            part[17][47] = MazePart.GangRechtsLinks;
            part[17][48] = MazePart.Wand;
            part[17][49] = MazePart.GangRechtsLinks;
            part[17][50] = MazePart.Wand;

            //X19
            part[18] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 0 || i > 1 && i < 7 || i == 8 || i > 9 && i < 13 || i > 13 && i < 23 || i > 23 && i < 29 || i > 29 && i < 33 || i > 33 && i < 43 || i > 43 && i < 47 || i == 48 || i == 50)
                {
                    part[18][i] = MazePart.Wand;
                }
                else
                {
                    part[18][i] = MazePart.GangRechtsLinks;
                }
            }

            //X20
            part[19] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i > 2 && i < 5 || i == 8 || i == 12 || i > 15 && i < 21 || i == 24 || i == 26 || i == 32 || i > 35 && i < 41 || i == 42)
                {
                    part[19][i] = MazePart.GangObenUnten;
                }
                else if (i == 29 || i == 47 || i == 49)
                {
                    part[19][i] = MazePart.GangRechtsLinks;
                }
                else if (i == 1)
                {
                    part[19][i] = MazePart.TKreuzungOben;
                }
                else if (i == 25 || i == 41)
                {
                    part[19][i] = MazePart.TKreuzungRechts;
                }
                else if (i == 13 || i == 33)
                {
                    part[19][i] = MazePart.TKreuzungUnten;
                }
                else if (i == 11 || i == 15 || i == 35)
                {
                    part[19][i] = MazePart.KurveObenRechts;
                }
                else if (i == 21 || i == 27)
                {
                    part[19][i] = MazePart.KurveUntenRechts;
                }
                else if (i == 7 || i == 23)
                {
                    part[19][i] = MazePart.KurveObenLinks;
                }
                else if (i == 9 || i == 43)
                {
                    part[19][i] = MazePart.KurveUntenLinks;
                }
                else
                {
                    part[19][i] = MazePart.Wand;
                }

                part[19][45] = MazePart.SackgasseLinks;
            }

            int x = 20;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 5 || i == 11 || i == 13 || i == 15 || i == 21 || i == 25 || i == 27 || i == 29 || i == 33 || i == 35 || i == 41 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 21;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 3 || i == 6 || i == 10 || i == 20 || i == 24 || i == 30 || i == 36 || i == 38 || i == 44)
                {
                    part[x][i] = MazePart.GangObenUnten;
                }
                else if (i == 41 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else if (i == 1 || i == 5)
                {
                    part[x][i] = MazePart.TKreuzungOben;
                }
                else if (i == 37)
                {
                    part[x][i] = MazePart.TKreuzungRechts;
                }
                else if (i == 45)
                {
                    part[x][i] = MazePart.TKreuzungUnten;
                }
                else if (i == 9 || i == 19)
                {
                    part[x][i] = MazePart.KurveObenRechts;
                }
                else if (i == 31 || i == 39)
                {
                    part[x][i] = MazePart.KurveUntenRechts;
                }
                else if (i == 29 || i == 35)
                {
                    part[x][i] = MazePart.KurveObenLinks;
                }
                else if (i == 11 || i == 21 || i == 25)
                {
                    part[x][i] = MazePart.KurveUntenLinks;
                }
                else if (i == 23)
                {
                    part[x][i] = MazePart.SackgasseUnten;
                }
                else if (i == 13 || i == 27 || i == 33)
                {
                    part[x][i] = MazePart.SackgasseRechts;
                }
                else if (i == 17)
                {
                    part[x][i] = MazePart.SackgasseLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 22;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 5 || i == 7 || i == 9 || i == 15 || i == 17 || i == 19 || i == 31 || i == 37 || i == 39 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 23;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 4 || i == 10 || i == 14 || i == 18 || i > 23 && i < 27 || i == 30 || i == 34 || i == 36)
                {
                    part[x][i] = MazePart.GangObenUnten;
                }
                else if (i == 39 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else if (i == 35)
                {
                    part[x][i] = MazePart.TKreuzungRechts;
                }
                else if (i == 19 || i == 31)
                {
                    part[x][i] = MazePart.TKreuzungUnten;
                }
                else if (i == 3 || i == 23 || i == 33)
                {
                    part[x][i] = MazePart.KurveObenRechts;
                }
                else if (i == 11 || i == 27)
                {
                    part[x][i] = MazePart.KurveUntenRechts;
                }
                else if (i == 9 || i == 17)
                {
                    part[x][i] = MazePart.KurveObenLinks;
                }
                else if (i == 5 || i == 15 || i == 37)
                {
                    part[x][i] = MazePart.KurveUntenLinks;
                }
                else if (i == 1 || i == 7)
                {
                    part[x][i] = MazePart.SackgasseRechts;
                }
                else if (i == 21)
                {
                    part[x][i] = MazePart.SackgasseLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 24;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 3 || i == 11 || i == 13 || i == 19 || i == 21 || i == 23 || i == 27 || i == 31 || i == 33 || i == 35 || i == 39 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 25;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.SackgasseLinks;
            part[x][2] = MazePart.TKreuzungOben;
            part[x][3] = MazePart.GangObenUnten;
            part[x][4] = MazePart.KurveUntenRechts;
            part[x][5] = MazePart.Wand;
            part[x][6] = MazePart.KurveObenRechts;
            part[x][7] = MazePart.GangObenUnten;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.GangObenUnten;
            part[x][10] = MazePart.GangObenUnten;
            part[x][11] = MazePart.KurveUntenLinks;
            part[x][12] = MazePart.Wand;
            part[x][13] = MazePart.GangRechtsLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.KurveObenRechts;
            part[x][16] = MazePart.GangObenUnten;
            part[x][17] = MazePart.KurveUntenRechts;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.KurveObenLinks;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.TKreuzungLinks;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.SackgasseLinks;
            part[x][26] = MazePart.Wand;
            part[x][27] = MazePart.KurveObenLinks;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.KurveUntenRechts;
            part[x][30] = MazePart.Wand;
            part[x][31] = MazePart.KurveObenLinks;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.KurveUntenLinks;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenLinks;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenRechts;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.SackgasseRechts;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.GangRechtsLinks;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.GangRechtsLinks;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.GangRechtsLinks;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.GangRechtsLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 26;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 13 || i == 15 || i == 17 || i == 25 || i == 29 || i == 37 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 27;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.TKreuzungOben;
            part[x][2] = MazePart.GangObenUnten;
            part[x][3] = MazePart.KurveUntenLinks;
            part[x][4] = MazePart.Wand;
            part[x][5] = MazePart.GangRechtsLinks;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.TKreuzungOben;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.SackgasseOben;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.KurveObenRechts;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.KurveUntenLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.GangRechtsLinks;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.GangRechtsLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.KurveObenRechts;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.GangObenUnten;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenRechts;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.KurveObenLinks;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.TKreuzungRechts;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.TKreuzungLinks;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.GangObenUnten;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.KurveUntenRechts;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenRechts;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenLinks;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.KurveObenRechts;
            part[x][40] = MazePart.GangObenUnten;
            part[x][41] = MazePart.KurveUntenLinks;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.GangRechtsLinks;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.KurveObenLinks;
            part[x][46] = MazePart.GangObenUnten;
            part[x][47] = MazePart.KurveUntenLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 28;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 5 || i == 7 || i == 11 || i == 15 || i == 17 || i == 19 || i == 23 || i == 27 || i == 33 || i == 35 || i == 39 || i == 43 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 29;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.KurveObenRechts;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.KurveUntenLinks;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.KurveObenLinks;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.KurveUntenRechts;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.GangRechtsLinks;
            part[x][12] = MazePart.Wand;
            part[x][13] = MazePart.KurveObenRechts;
            part[x][14] = MazePart.GangObenUnten;
            part[x][15] = MazePart.KurveUntenLinks;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.GangRechtsLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.GangRechtsLinks;
            part[x][20] = MazePart.Wand;
            part[x][21] = MazePart.SackgasseLinks;
            part[x][22] = MazePart.Wand;
            part[x][23] = MazePart.KurveObenLinks;
            part[x][24] = MazePart.GangObenUnten;
            part[x][25] = MazePart.KurveUntenRechts;
            part[x][26] = MazePart.Wand;
            part[x][27] = MazePart.SackgasseRechts;
            part[x][28] = MazePart.Wand;
            part[x][29] = MazePart.SackgasseUnten;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.TKreuzungRechts;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.TKreuzungUnten;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.SackgasseRechts;
            part[x][36] = MazePart.Wand;
            part[x][37] = MazePart.KurveObenRechts;
            part[x][38] = MazePart.GangObenUnten;
            part[x][39] = MazePart.KurveUntenLinks;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.SackgasseLinks;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.GangRechtsLinks;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.SackgasseLinks;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.SackgasseLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 30;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 3 || i == 9 || i == 11 || i == 13 || i == 17 || i == 19 || i == 25 || i == 31 || i == 33 || i == 37 || i == 41 || i == 43 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 31;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.KurveObenLinks;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.TKreuzungRechts;
            part[x][6] = MazePart.GangObenUnten;
            part[x][7] = MazePart.GangObenUnten;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.KurveUntenLinks;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.KurveObenLinks;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.KurveUntenLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.SackgasseLinks;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.GangRechtsLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.KurveObenLinks;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.TKreuzungLinks;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenRechts;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.KurveObenLinks;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.GangObenUnten;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.KurveUntenRechts;
            part[x][30] = MazePart.Wand;
            part[x][31] = MazePart.SackgasseRechts;
            part[x][32] = MazePart.Wand;
            part[x][33] = MazePart.GangRechtsLinks;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenRechts;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenLinks;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.KurveObenRechts;
            part[x][40] = MazePart.GangObenUnten;
            part[x][41] = MazePart.TKreuzungLinks;
            part[x][42] = MazePart.GangObenUnten;
            part[x][43] = MazePart.KurveUntenLinks;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.TKreuzungOben;
            part[x][46] = MazePart.GangObenUnten;
            part[x][47] = MazePart.TKreuzungUnten;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 32;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 5 || i == 15 || i == 17 || i == 23 || i == 29 || i == 33 || i == 35 || i == 39 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 33;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.SackgasseLinks;
            part[x][4] = MazePart.Wand;
            part[x][5] = MazePart.GangRechtsLinks;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.SackgasseUnten;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.TKreuzungRechts;
            part[x][10] = MazePart.GangObenUnten;
            part[x][11] = MazePart.KurveUntenRechts;
            part[x][12] = MazePart.Wand;
            part[x][13] = MazePart.SackgasseUnten;
            part[x][14] = MazePart.GangObenUnten;
            part[x][15] = MazePart.TKreuzungUnten;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.GangRechtsLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.SackgasseLinks;
            part[x][20] = MazePart.Wand;
            part[x][21] = MazePart.SackgasseLinks;
            part[x][22] = MazePart.Wand;
            part[x][23] = MazePart.GangRechtsLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.KurveObenRechts;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.GangObenUnten;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.KurveUntenLinks;
            part[x][30] = MazePart.Wand;
            part[x][31] = MazePart.SackgasseUnten;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.TKreuzungLinks;
            part[x][34] = MazePart.GangObenUnten;
            part[x][35] = MazePart.KurveUntenLinks;
            part[x][36] = MazePart.Wand;
            part[x][37] = MazePart.KurveObenRechts;
            part[x][38] = MazePart.GangObenUnten;
            part[x][39] = MazePart.KurveUntenLinks;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.KurveObenRechts;
            part[x][42] = MazePart.GangObenUnten;
            part[x][43] = MazePart.GangObenUnten;
            part[x][44] = MazePart.GangObenUnten;
            part[x][45] = MazePart.KurveUntenLinks;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.GangRechtsLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 34;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 9 || i == 11 || i == 15 || i == 17 || i == 19 || i == 21 || i == 23 || i == 25 || i == 37 || i == 41 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 35;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.TKreuzungOben;
            part[x][2] = MazePart.GangObenUnten;
            part[x][3] = MazePart.KurveUntenLinks;
            part[x][4] = MazePart.Wand;
            part[x][5] = MazePart.KurveObenLinks;
            part[x][6] = MazePart.GangObenUnten;
            part[x][7] = MazePart.GangObenUnten;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.KurveUntenLinks;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.KurveObenLinks;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.TKreuzungRechts;
            part[x][14] = MazePart.GangObenUnten;
            part[x][15] = MazePart.KurveUntenLinks;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.GangRechtsLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.TKreuzungOben;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.TKreuzungUnten;
            part[x][22] = MazePart.Wand;
            part[x][23] = MazePart.GangRechtsLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.KurveObenLinks;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.GangObenUnten;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.GangObenUnten;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.GangObenUnten;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.KurveUntenRechts;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenRechts;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenLinks;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.SackgasseUnten;
            part[x][40] = MazePart.GangObenUnten;
            part[x][41] = MazePart.TKreuzungUnten;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.KurveObenRechts;
            part[x][44] = MazePart.GangObenUnten;
            part[x][45] = MazePart.KurveUntenRechts;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.GangRechtsLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 36;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 13 || i == 17 || i == 19 || i == 21 || i == 23 || i == 33 || i == 35 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 37;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.KurveObenRechts;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.KurveUntenRechts;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.KurveObenRechts;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.KurveUntenRechts;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.KurveObenRechts;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.KurveUntenLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.KurveObenRechts;
            part[x][16] = MazePart.GangObenUnten;
            part[x][17] = MazePart.KurveUntenLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.GangRechtsLinks;
            part[x][20] = MazePart.Wand;
            part[x][21] = MazePart.GangRechtsLinks;
            part[x][22] = MazePart.Wand;
            part[x][23] = MazePart.GangRechtsLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.SackgasseLinks;
            part[x][26] = MazePart.Wand;
            part[x][27] = MazePart.KurveObenRechts;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.GangObenUnten;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.KurveUntenRechts;
            part[x][32] = MazePart.Wand;
            part[x][33] = MazePart.GangRechtsLinks;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenLinks;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.GangObenUnten;
            part[x][38] = MazePart.GangObenUnten;
            part[x][39] = MazePart.KurveUntenRechts;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.GangRechtsLinks;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.GangRechtsLinks;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.GangRechtsLinks;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.GangRechtsLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 38;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 11 || i == 15 || i == 19 || i == 21 || i == 23 || i == 25 || i == 27 || i == 31 || i == 33 || i == 39 || i == 41 || i == 43 || i == 45 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 39;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.GangRechtsLinks;
            part[x][4] = MazePart.Wand;
            part[x][5] = MazePart.GangRechtsLinks;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.SackgasseRechts;
            part[x][8] = MazePart.Wand;
            part[x][9] = MazePart.TKreuzungOben;
            part[x][10] = MazePart.GangObenUnten;
            part[x][11] = MazePart.KurveUntenLinks;
            part[x][12] = MazePart.Wand;
            part[x][13] = MazePart.KurveObenRechts;
            part[x][14] = MazePart.GangObenUnten;
            part[x][15] = MazePart.TKreuzungUnten;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.SackgasseLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.GangRechtsLinks;
            part[x][20] = MazePart.Wand;
            part[x][21] = MazePart.GangRechtsLinks;
            part[x][22] = MazePart.Wand;
            part[x][23] = MazePart.GangRechtsLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.TKreuzungOben;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.KurveUntenLinks;
            part[x][28] = MazePart.Wand;
            part[x][29] = MazePart.KurveObenRechts;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.TKreuzungUnten;
            part[x][32] = MazePart.Wand;
            part[x][33] = MazePart.KurveObenLinks;
            part[x][34] = MazePart.GangObenUnten;
            part[x][35] = MazePart.KurveUntenRechts;
            part[x][36] = MazePart.Wand;
            part[x][37] = MazePart.SackgasseUnten;
            part[x][38] = MazePart.GangObenUnten;
            part[x][39] = MazePart.TKreuzungUnten;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.GangRechtsLinks;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.SackgasseRechts;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.TKreuzungOben;
            part[x][46] = MazePart.GangObenUnten;
            part[x][47] = MazePart.KurveUntenLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 40;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 3 || i == 5 || i == 9 || i == 13 || i == 15 || i == 17 || i == 19 || i == 21 || i == 23 || i == 25 || i == 29 || i == 35 || i == 39 || i == 41 || i == 45 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 41;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.GangRechtsLinks;
            part[x][4] = MazePart.Wand;
            part[x][5] = MazePart.KurveObenLinks;
            part[x][6] = MazePart.GangObenUnten;
            part[x][7] = MazePart.KurveUntenRechts;
            part[x][8] = MazePart.Wand;
            part[x][9] = MazePart.SackgasseRechts;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.KurveObenRechts;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.KurveUntenLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.TKreuzungOben;
            part[x][16] = MazePart.GangObenUnten;
            part[x][17] = MazePart.KurveUntenLinks;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.GangRechtsLinks;
            part[x][20] = MazePart.Wand;
            part[x][21] = MazePart.KurveObenLinks;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.KurveObenLinks;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.KurveUntenRechts;
            part[x][28] = MazePart.Wand;
            part[x][29] = MazePart.GangRechtsLinks;
            part[x][30] = MazePart.Wand;
            part[x][31] = MazePart.SackgasseRechts;
            part[x][32] = MazePart.Wand;
            part[x][33] = MazePart.SackgasseLinks;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenLinks;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenRechts;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.GangRechtsLinks;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.KurveObenLinks;
            part[x][42] = MazePart.GangObenUnten;
            part[x][43] = MazePart.KurveUntenRechts;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.TKreuzungOben;
            part[x][46] = MazePart.GangObenUnten;
            part[x][47] = MazePart.SackgasseOben;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 42;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 3 || i == 7 || i == 11 || i == 15 || i == 19 || i == 27 || i == 29 || i == 33 || i == 37 || i == 43 || i == 45 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 43;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.SackgasseRechts;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.KurveObenLinks;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.KurveUntenRechts;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.KurveObenLinks;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.KurveUntenRechts;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.GangRechtsLinks;
            part[x][12] = MazePart.Wand;
            part[x][13] = MazePart.KurveObenRechts;
            part[x][14] = MazePart.GangObenUnten;
            part[x][15] = MazePart.TKreuzungLinks;
            part[x][16] = MazePart.GangObenUnten;
            part[x][17] = MazePart.SackgasseOben;
            part[x][18] = MazePart.Wand;
            part[x][19] = MazePart.KurveObenLinks;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.GangObenUnten;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenRechts;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.SackgasseUnten;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.KurveUntenLinks;
            part[x][28] = MazePart.Wand;
            part[x][29] = MazePart.TKreuzungOben;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.KurveUntenRechts;
            part[x][32] = MazePart.Wand;
            part[x][33] = MazePart.GangRechtsLinks;
            part[x][34] = MazePart.GangObenUnten;
            part[x][35] = MazePart.SackgasseOben;
            part[x][36] = MazePart.Wand;
            part[x][37] = MazePart.GangRechtsLinks;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.KurveObenLinks;
            part[x][40] = MazePart.GangObenUnten;
            part[x][41] = MazePart.GangObenUnten;
            part[x][42] = MazePart.GangObenUnten;
            part[x][43] = MazePart.KurveUntenLinks;
            part[x][44] = MazePart.Wand;
            part[x][45] = MazePart.TKreuzungOben;
            part[x][46] = MazePart.GangObenUnten;
            part[x][47] = MazePart.SackgasseOben;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.GangRechtsLinks;
            part[x][50] = MazePart.Wand;

            x = 44;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 5 || i == 9 || i == 11 || i == 13 || i == 23 || i == 29 || i == 31 || i == 33 || i == 37 || i == 45 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 45;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.KurveObenRechts;
            part[x][2] = MazePart.GangObenUnten;
            part[x][3] = MazePart.GangObenUnten;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.TKreuzungUnten;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.KurveObenRechts;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.TKreuzungLinks;
            part[x][10] = MazePart.GangObenUnten;
            part[x][11] = MazePart.KurveUntenLinks;
            part[x][12] = MazePart.Wand;
            part[x][13] = MazePart.GangRechtsLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.KurveObenRechts;
            part[x][16] = MazePart.GangObenUnten;
            part[x][17] = MazePart.TKreuzungRechts;
            part[x][18] = MazePart.GangObenUnten;
            part[x][19] = MazePart.SackgasseOben;
            part[x][20] = MazePart.Wand;
            part[x][21] = MazePart.KurveObenRechts;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.KurveObenRechts;
            part[x][26] = MazePart.GangObenUnten;
            part[x][27] = MazePart.KurveUntenRechts;
            part[x][28] = MazePart.Wand;
            part[x][29] = MazePart.SackgasseRechts;
            part[x][30] = MazePart.Wand;
            part[x][31] = MazePart.KurveObenLinks;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.TKreuzungUnten;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenRechts;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenLinks;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.SackgasseUnten;
            part[x][40] = MazePart.GangObenUnten;
            part[x][41] = MazePart.TKreuzungRechts;
            part[x][42] = MazePart.GangObenUnten;
            part[x][43] = MazePart.TKreuzungRechts;
            part[x][44] = MazePart.GangObenUnten;
            part[x][45] = MazePart.KurveUntenLinks;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.KurveObenRechts;
            part[x][48] = MazePart.GangObenUnten;
            part[x][49] = MazePart.KurveUntenLinks;
            part[x][50] = MazePart.Wand;

            x = 46;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 5 || i == 7 || i == 13 || i == 15 || i == 17 || i == 21 || i == 25 || i == 27 || i == 33 || i == 41 || i == 43 || i == 47)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 47;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.GangRechtsLinks;
            part[x][2] = MazePart.Wand;
            part[x][3] = MazePart.SackgasseUnten;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.KurveUntenLinks;
            part[x][6] = MazePart.Wand;
            part[x][7] = MazePart.KurveObenLinks;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.KurveUntenLinks;
            part[x][10] = MazePart.Wand;
            part[x][11] = MazePart.SackgasseUnten;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.KurveUntenLinks;
            part[x][14] = MazePart.Wand;
            part[x][15] = MazePart.GangRechtsLinks;
            part[x][16] = MazePart.Wand;
            part[x][17] = MazePart.KurveObenLinks;
            part[x][18] = MazePart.GangObenUnten;
            part[x][19] = MazePart.GangObenUnten;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.KurveUntenLinks;
            part[x][22] = MazePart.Wand;
            part[x][23] = MazePart.KurveObenRechts;
            part[x][24] = MazePart.GangObenUnten;
            part[x][25] = MazePart.TKreuzungUnten;
            part[x][26] = MazePart.Wand;
            part[x][27] = MazePart.TKreuzungOben;
            part[x][28] = MazePart.GangObenUnten;
            part[x][29] = MazePart.GangObenUnten;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.KurveUntenRechts;
            part[x][32] = MazePart.Wand;
            part[x][33] = MazePart.GangRechtsLinks;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.GangRechtsLinks;
            part[x][36] = MazePart.Wand;
            part[x][37] = MazePart.KurveObenRechts;
            part[x][38] = MazePart.GangObenUnten;
            part[x][39] = MazePart.KurveUntenRechts;
            part[x][40] = MazePart.Wand;
            part[x][41] = MazePart.SackgasseRechts;
            part[x][42] = MazePart.Wand;
            part[x][43] = MazePart.KurveObenLinks;
            part[x][44] = MazePart.GangObenUnten;
            part[x][45] = MazePart.SackgasseOben;
            part[x][46] = MazePart.Wand;
            part[x][47] = MazePart.GangRechtsLinks;
            part[x][48] = MazePart.Wand;
            part[x][49] = MazePart.SackgasseLinks;
            part[x][50] = MazePart.Wand;

            x = 48;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1 || i == 15 || i == 23 || i == 25 || i == 27 || i == 31 || i == 33 || i == 35 || i == 37 || i == 39 || i == 47 || i == 49)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

            x = 49;
            part[x] = new MazePart[51];
            part[x][0] = MazePart.Wand;
            part[x][1] = MazePart.TKreuzungOben;
            part[x][2] = MazePart.GangObenUnten;
            part[x][3] = MazePart.GangObenUnten;
            part[x][4] = MazePart.GangObenUnten;
            part[x][5] = MazePart.GangObenUnten;
            part[x][6] = MazePart.GangObenUnten;
            part[x][7] = MazePart.GangObenUnten;
            part[x][8] = MazePart.GangObenUnten;
            part[x][9] = MazePart.GangObenUnten;
            part[x][10] = MazePart.GangObenUnten;
            part[x][11] = MazePart.GangObenUnten;
            part[x][12] = MazePart.GangObenUnten;
            part[x][13] = MazePart.GangObenUnten;
            part[x][14] = MazePart.GangObenUnten;
            part[x][15] = MazePart.TKreuzungLinks;
            part[x][16] = MazePart.GangObenUnten;
            part[x][17] = MazePart.GangObenUnten;
            part[x][18] = MazePart.GangObenUnten;
            part[x][19] = MazePart.GangObenUnten;
            part[x][20] = MazePart.GangObenUnten;
            part[x][21] = MazePart.GangObenUnten;
            part[x][22] = MazePart.GangObenUnten;
            part[x][23] = MazePart.KurveUntenLinks;
            part[x][24] = MazePart.Wand;
            part[x][25] = MazePart.SackgasseRechts;
            part[x][26] = MazePart.Wand;
            part[x][27] = MazePart.SackgasseRechts;
            part[x][28] = MazePart.Wand;
            part[x][29] = MazePart.SackgasseUnten;
            part[x][30] = MazePart.GangObenUnten;
            part[x][31] = MazePart.TKreuzungLinks;
            part[x][32] = MazePart.GangObenUnten;
            part[x][33] = MazePart.KurveUntenLinks;
            part[x][34] = MazePart.Wand;
            part[x][35] = MazePart.KurveObenLinks;
            part[x][36] = MazePart.GangObenUnten;
            part[x][37] = MazePart.KurveUntenLinks;
            part[x][38] = MazePart.Wand;
            part[x][39] = MazePart.KurveObenLinks;
            part[x][40] = MazePart.GangObenUnten;
            part[x][41] = MazePart.GangObenUnten;
            part[x][42] = MazePart.GangObenUnten;
            part[x][43] = MazePart.GangObenUnten;
            part[x][44] = MazePart.GangObenUnten;
            part[x][45] = MazePart.GangObenUnten;
            part[x][46] = MazePart.GangObenUnten;
            part[x][47] = MazePart.TKreuzungLinks;
            part[x][48] = MazePart.GangObenUnten;
            part[x][49] = MazePart.KurveUntenLinks;
            part[x][50] = MazePart.Wand;

            x = 50;
            part[x] = new MazePart[51];
            for (int i = 0; i < 50; i++)
            {
                if (i == 1)
                {
                    part[x][i] = MazePart.GangRechtsLinks;
                }
                else
                {
                    part[x][i] = MazePart.Wand;
                }
            }

        }
    }
}
