using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaper.Model
{
    public interface IGameController
    {
        bool IsGameOver { get; }
        bool PlayerWon { get; }

        void MovePlayer(int dx, int dy);
        void MoveEnemies();
        Board GetBoard();
    }
}
