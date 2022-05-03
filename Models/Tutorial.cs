using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MajestyApi.Models
{
    public class Tutorial
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
    }
}
