using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// player x
namespace playerX
{
    public class player
    {
        private string name;

        public player(string name) {
            this.name = name;
        }

        public void SetName(string name) {
            this.name = name;
        }

        public string GetName() {
            return this.name;
        }
    }
}