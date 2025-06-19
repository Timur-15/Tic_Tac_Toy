using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toy
{
    class GameRenderer
    {
        private readonly DataGridView dataGridView;
        private readonly GameLogic gameLogic;

        public GameRenderer(DataGridView grid, GameLogic logic)
        {
            dataGridView = grid;
            gameLogic = logic;
            InitializeGrid();
        }

        // Инициализация сетки
        public void InitializeGrid()
        {
            dataGridView.ColumnCount = gameLogic.GetField().GetLength(0);
            dataGridView.RowCount = gameLogic.GetField().GetLength(1);
            dataGridView.Width = dataGridView.ColumnCount * dataGridView.Columns[0].Width + 5;
            dataGridView.Height = dataGridView.Width;
            UpdateGrid();
        }

        // Обновление отображения поля
        public void UpdateGrid()
        {
            var field = gameLogic.GetField();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    switch (field[row, col])
                    {
                        case 1:
                            dataGridView.Rows[row].Cells[col].Value = "x";
                            break;
                        case 2:
                            dataGridView.Rows[row].Cells[col].Value = "o";
                            break;
                        default:
                            dataGridView.Rows[row].Cells[col].Value = "";
                            break;
                    }
                }
            }
        }

        // Обновление текста хода
        public void UpdateTurnLabel(Label label)
        {
            label.Text = $"Ход: {gameLogic.CurrentPlayerName}";
        }
    }
}
