using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris.business.pieces
{
    internal abstract class PieceAbstract : Piece
    {

        protected int[,] iPiece;

        protected Color color;

        public abstract void positionOne();

        public abstract void positionTwo();

        public abstract void positionThree();

        public abstract void positionFour();

        public int[,] getIPiece()
        {
            return iPiece;
        }

        public void setIPiece(int[,] iPiece)
        {
            this.iPiece = iPiece;
        }

        public Color getColor() { return this.color;  }
    }
}
