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
            Player = new Player { Pos = new Position(size / 2, 0) }; // player a felső sor közepén
            Enemies = new List<Enemy>
            {
                new Enemy { Pos = new Position(0, size - 1) },      // bal alsó sarok
                new Enemy { Pos = new Position(size - 1, size - 1) } // jobb alsó sarok
            };
            Mines = new List<Mine>();
        }
    }
}
