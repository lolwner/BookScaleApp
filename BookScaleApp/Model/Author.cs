using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScaleApp.Model
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DateOfBirth { get; set; }
        public int? DateOfDeath { get; set; }
    }
}
