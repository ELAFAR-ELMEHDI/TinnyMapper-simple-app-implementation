using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyMapperShowCase.Models
{
    public class TBook
    {
        public int ID { get; set; }
        public int WriterID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
    }
    public class SBook
    {
        public int ID { get; set; }
        public int WriterID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
