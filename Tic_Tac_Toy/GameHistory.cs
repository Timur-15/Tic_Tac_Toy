using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toy;

namespace Tic_Tac_Toy
{
    class GameHistory
    {
        private static List<string> winners = new List<string>();

        public static void AddWinner(string winnerName)
        {
            winners.Add(winnerName);
            // Оставляем только последние 10 записей
            if (winners.Count > 10)
                winners.RemoveAt(0);
        }

        public static List<string> GetLastWinners()
        {
            return winners;
        }
    }
}
