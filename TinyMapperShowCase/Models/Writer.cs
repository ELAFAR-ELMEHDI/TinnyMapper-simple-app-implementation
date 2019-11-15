using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyMapperShowCase.Models
{
    /**
     * this file containg both the definition of the sourses and targets objects that we will be mapping
     */
    public class TWriter
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Pays { get; set; }
        public IList<TBook> TBooks { get; set; }
    }
    public class SWriter
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Pays { get; set; }
        public IList<SBook> SBooks { get; set; }
    }
}
