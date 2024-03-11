using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.business.pieces
{
    internal class IShape : PieceAbstract
    {        
        public IShape()
        {
            iPiece = new int[4, 4];
            color = Color.Blue;
            positionOne();
        }

        public override void positionOne()
        {
            /*
            [0][0][1][0]
            [0][0][1][0]
            [0][0][1][0]
            [0][0][1][0] */

            for(int i = 0; i < iPiece.GetLength(0); i++)
            {
                for(int j = 0; j < iPiece.GetLength(1); j++)
                {
                    if (j == 2)
                    {
                        iPiece[i, j] = 2;
                        continue;
                    }
                    
                    iPiece[i, j] = 0;
                }
            }
        }

        public override void positionTwo()
        {
            /*
            [0][0][0][0]
            [0][0][0][0]
            [1][1][1][1]
            [0][0][0][0] */

            for (int i = 0; i < iPiece.GetLength(0); i++)
            {
                for (int j = 0; j < iPiece.GetLength(1); j++)
                {
                    if (i == 2)
                    {
                        iPiece[i, j] = 2;
                        continue;
                    }

                    iPiece[i, j] = 0;
                }
            }
        }


        public override void positionThree()
        {
        }


        public override void positionFour()
        {

        }

    }
}
