using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toy
{
    public partial class FormGame : Form
    {
        private readonly GameLogic gameLogic;
        private readonly GameRenderer gameRenderer;

        public FormGame()
        {
            InitializeComponent();
            gameLogic = new GameLogic(3);
            gameRenderer = new GameRenderer(dataGridViewGame, gameLogic);
            gameRenderer.UpdateTurnLabel(labelTurn);
        }

        private void dataGridViewGame_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (!gameLogic.MakeMove(e.RowIndex, e.ColumnIndex))
            {
                MessageBox.Show("Выберите пустую клетку!");
                return;
            }

            gameRenderer.UpdateGrid();

            if (gameLogic.CheckWin())
            {
                MessageBox.Show($"Победа {gameLogic.CurrentPlayerName}!");
                gameLogic.Reset();
                gameRenderer.UpdateGrid();
                gameRenderer.UpdateTurnLabel(labelTurn);
            }
            else if (gameLogic.IsDraw())
            {
                MessageBox.Show("Ничья!");
                gameLogic.Reset();
                gameRenderer.UpdateGrid();
                gameRenderer.UpdateTurnLabel(labelTurn);
            }
            else
            {
                gameLogic.NextTurn();
                gameRenderer.UpdateTurnLabel(labelTurn);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            gameLogic.Reset();
            gameRenderer.UpdateGrid();
            gameRenderer.UpdateTurnLabel(labelTurn);
        }


        private void FormGame_Load(object sender, EventArgs e)
        {
          
        }

       

        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormStats Stats = new FormStats();
            Stats.ShowDialog();
        }
    }
}
