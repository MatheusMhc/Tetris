using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris.business.pieces;

namespace Tetris.business
{
    internal class TetrisGame
    {
        public int[,] grid { get; set;}
        
        public Piece piece;

        private PositionPiece positionPiece = PositionPiece.ONE;

        public TetrisGame() {

            grid = new int[26, 12];


            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if(i==0 || j==0 || i == grid.GetLength(0)-1 || j == grid.GetLength(1)-1)
                    {
                        grid[i, j] = -1;
                        continue;
                    }
                    grid[i, j] = 0;
                }
            }

        }

        public void changePositionPieceToTheLeft()
        {
            switch(positionPiece)
            {
                case PositionPiece.ONE:
                    piece.positionTwo();
                    positionPiece = PositionPiece.TWO; 
                    break;
                case PositionPiece.TWO:
                    piece.positionOne();
                    positionPiece = PositionPiece.ONE;
                    break;
            }
        }

        public void drawPiece(int a)
        {
            clearPieceFromGrid();

            for (int i = 0; i < piece.getIPiece().GetLength(0); i++)
            {
                for (int j = 0; j < piece.getIPiece().GetLength(1); j++)
                {
                    if(piece.getIPiece()[i, j] != 0)
                    {
                        if(grid[a + i, j] == -1 && piece.getIPiece()[i, j] == 2)
                        {
                            MessageBox.Show("Test");
                            continue;
                        }
                        grid[a + i, j] = piece.getIPiece()[i, j];
                    }
                    
                }
            }
        }

        private void clearPieceFromGrid()
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 2)
                    {
                        grid[i, j] = 0;
                    }
                }
            }
        }
    }
}
