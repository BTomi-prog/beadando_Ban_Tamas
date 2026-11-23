using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnCall
{
    internal class RendszerGazda
    {
        public string Name { get; set; }

        public int Satisfaction { get; set; }

        public RendszerGazda(string name)
        {
            Name = name;
            Satisfaction = 80;
        }
    }
}
