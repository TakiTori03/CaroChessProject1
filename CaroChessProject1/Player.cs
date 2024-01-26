using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaroChessProject1
{
    public class Player
    {
        private string name;

        public string Name { get => name; set => name = value; } //ctrl + R + E Enter
        public Image Mark { get => mark; set => mark = value; }

        private Image mark;

        public Player(string name, Image mark)
        {
            this.Name = name;
            this.Mark = mark;
        }
    }
}
