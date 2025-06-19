using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toy
{
    class GameLogic
    {
        private int[,] field;
        private int turn = 1;
        private int countMove = 0;
        private readonly int size;
        private readonly string[] playerNames = { "крестиков", "ноликов" };

        public GameLogic(int size = 3)
        {
            this.size = size;
            field = new int[size, size];
        }

        public int CurrentPlayer => turn;
        public string CurrentPlayerName => playerNames[turn - 1];

        public bool MakeMove(int row, int col)
        {
            if (field[row, col] != 0)
                return false;

            field[row, col] = turn;
            countMove++;
            return true;
        }

        public bool CheckWin()
        {
            // Проверка строк и столбцов
            for (int i = 0; i < size; i++)
            {
                int rowCount = 0, colCount = 0;
                for (int j = 0; j < size; j++)
                {
                    if (field[i, j] == turn) rowCount++;
                    if (field[j, i] == turn) colCount++;
                }
                if (rowCount == size || colCount == size) return true;
            }

            // Проверка диагоналей
            int diag1 = 0, diag2 = 0;
            for (int i = 0; i < size; i++)
            {
                if (field[i, i] == turn) diag1++;
                if (field[i, size - 1 - i] == turn) diag2++;
            }
            return diag1 == size || diag2 == size;
        }

        public bool IsDraw() => countMove == size * size;

        public void NextTurn()
        {
            turn = turn % 2 + 1;
        }

        public void Reset()
        {
            field = new int[size, size];
            turn = 1;
            countMove = 0;
        }

        public int[,] GetField() => field;
    }
}
