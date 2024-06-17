using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{

    public class Magia
        {
        public string Index { get; set; }
            public string Name { get; set; }
            public int Level { get; set; }
            public string Url { get; set; }
        }

    public class MagiaResponse
    {
        public int Count { get; set; }
        public List<MagiaResponse> Results { get; set; }

    }
}

