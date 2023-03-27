using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public Guid ID { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }
        public float Price { get; set; }
        public string Quality { get; set; }
        public DateTime? TakenSince { get; set; }

        public Book()
        {
            ID = Guid.NewGuid();
        }
    }
}
