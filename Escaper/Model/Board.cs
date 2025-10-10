using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaper.Model
{
    public class Board
    {
        public int Size { get; set; }
        public Player Player { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Mine> Mines { get; set; }

        public Board(int size)
        {
            Size = size;

            // A játékos a bal felső sarokban
            Player = new Player(new Position(size / 2, 0));

            // Két ellenfél a bal és jobb alsó sarokban
            Enemies = new List<Enemy>
            {
                new Enemy(new Position(0, size - 1)),
                new Enemy(new Position(size - 1, size - 1))
            };

            Mines = new List<Mine>();
        }

    }
}
