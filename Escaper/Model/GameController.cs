using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaper.Model
{
    public class GameController : IGameController
    {
        private readonly Board board;
        public bool IsGameOver { get; private set; } = false;
        public bool PlayerWon { get; private set; } = false;

        public GameController(Board board) => this.board = board;

        public void MovePlayer(int dx, int dy)
        {
            if (IsGameOver) return;

            var newPos = new Position(board.Player.Pos.X + dx, board.Player.Pos.Y + dy);
            if (newPos.X < 0 || newPos.Y < 0 || newPos.X >= board.Size || newPos.Y >= board.Size) return;

            board.Player.Pos = newPos;
            CheckCollisions();
        }

        public void MoveEnemies()
        {
            foreach (var enemy in board.Enemies.Where(e => e.IsActive))
            {
                int dx = board.Player.Pos.X - enemy.Pos.X;
                int dy = board.Player.Pos.Y - enemy.Pos.Y;

                if (Math.Abs(dy) > Math.Abs(dx))
                    enemy.Pos = new Position(enemy.Pos.X, enemy.Pos.Y + Math.Sign(dy));
                else
                    enemy.Pos = new Position(enemy.Pos.X + Math.Sign(dx), enemy.Pos.Y);

                if (board.Mines.Any(m => m.Pos.Equals(enemy.Pos)))
                    enemy.IsActive = false;
            }

            CheckCollisions();
        }

        private void CheckCollisions()
        {
            if (board.Mines.Any(m => m.Pos.Equals(board.Player.Pos)))
            {
                IsGameOver = true;
                PlayerWon = false;
            }

            if (board.Enemies.Any(e => e.IsActive && e.Pos.Equals(board.Player.Pos)))
            {
                IsGameOver = true;
                PlayerWon = false;
            }

            if (board.Enemies.All(e => !e.IsActive))
            {
                IsGameOver = true;
                PlayerWon = true;
            }
        }

        public Board GetBoard() => board;
    }
}
