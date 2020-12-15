using System;
using System.Collections.Generic;
using System.Text;

namespace WebClient_APIRest141220
{
    class Planet
    {
        public string Name { get; set; }
        public int Rotation_period { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; }
        public List<string> Residents { get; set; }

        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
                
    }
}
