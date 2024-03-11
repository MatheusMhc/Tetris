using Tetris.business;
using Tetris.business.pieces;

namespace Tetris
{
    public partial class Form1 : Form
    {
        TetrisGame tetris = new TetrisGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tableLayoutPanel1.Width = tableLayoutPanel1.ColumnCount * 23;
            //tableLayoutPanel1.Height = tableLayoutPanel1.RowCount * 23;

            for (int i = 0; i < tetris.grid.GetLength(0); i++)
            {
                for (int j = 0; j < tetris.grid.GetLength(1); j++)
                {
                    Panel panel = new Panel();
                    panel.Margin = new Padding(0);
                    if (tetris.grid[i, j] == -1)
                    {
                        panel.BackColor = Color.Black;
                        tableLayoutPanel1.Controls.Add(panel, j, i);
                        continue;
                    }

                    tableLayoutPanel1.Controls.Add(panel, j, i);

                }
            }
        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tetris.piece == null)
            {
                tetris.piece = new IShape();
            }

            tetris.drawPiece(++a);

            for (int i = 1; i < tetris.grid.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < tetris.grid.GetLength(1) - 1; j++)
                {
                    if (tetris.grid[i, j] == 2)
                    {
                        tableLayoutPanel1.GetControlFromPosition(j, i).BackColor = tetris.piece.getColor();
                        continue;
                    }
                    tableLayoutPanel1.GetControlFromPosition(j, i).BackColor = new Label().BackColor;

                }
            }

            if (a == 7) tetris.piece.positionTwo();
        }
    }
}