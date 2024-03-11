using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.business.pieces
{
    internal interface Piece
    {
        int[,] getIPiece();

        Color getColor();

        void setIPiece(int[,] piece);

        void positionOne();

        void positionTwo();

    }
}
