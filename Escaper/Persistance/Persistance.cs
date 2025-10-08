using Escaper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Escaper.Persistance
{
    public class Persistance : IPersistence
    {
        public void SaveGame(Board board, string path)
        {
            var json = JsonSerializer.Serialize(board);
            File.WriteAllText(path, json);
        }

        public Board LoadGame(string path)
        {
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Board>(json);
        }
    }
}
