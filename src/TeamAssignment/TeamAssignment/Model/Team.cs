using System;
using System.Collections.Generic;
using System.Text;

namespace TeamAssignment.Model
{
    public class Team
    {
        public string Name { get; set; }
        public List<string> People { get; set; } = new List<string>();
    }
}
