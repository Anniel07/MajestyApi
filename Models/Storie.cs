using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MajestyApi.Models
{
    public class Storie
    {
        public int ID { get; set; }
        public string Plot { get; set; }
        public string Writer { get; set; }
        public int Upvotes { get; set; }
    }
}
