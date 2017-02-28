using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookScaleApp.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }

    }
}
