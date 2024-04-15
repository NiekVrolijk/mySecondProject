using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesRock_5_4_2024
{
    internal class rock
    {
        private string name = "Rock"; //setter
        private string taste = "satly";

        public string Name //getter
        {
            get { return name; }
        }

        public string Taste
        {
            get { return taste; }
        }

        public rock()
        {
            name = "Rock";
        }

        public rock(string name)
        {
            this.name = name;
        }
    }
}
