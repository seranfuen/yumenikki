using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YumeNikki.Data
{
    public class Dream
    {
        public string Contents { get; set; }
        public int Id { get; set; }
        public DateTime DreamDate { get; set; }
        public DateTime DreamAddedDate { get; set; }
        public Dictionary<DreamCategory, List<DreamTag>> DreamCategoryTags { get; }
    }
}
