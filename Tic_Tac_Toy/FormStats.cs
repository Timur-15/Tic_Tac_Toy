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
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
            LoadWinners();
        }



        private void FormStats_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxWinners_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadWinners()
        {
            listBoxWinners.Items.Clear();
            var winners = GameHistory.GetLastWinners();

            if (winners.Count == 0)
            {
                listBoxWinners.Items.Add("История игр пуста");
                return;
            }

            // Добавляем победителей в обратном порядке (новые сверху)
            for (int i = winners.Count - 1; i >= 0; i--)
            {
                listBoxWinners.Items.Add($"{winners[i]} - {DateTime.Now:dd.MM.yyyy}");
            }
        }
    }
}
