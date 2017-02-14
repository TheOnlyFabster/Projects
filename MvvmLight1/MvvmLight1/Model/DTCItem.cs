using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLight1.Model
{
    public class DTCItem
    {

        public DTCItem()
        {
            SubItems = new List<DTCSubItem>();
        }

        public string Name { get; set; }

        public string Source { get; set; }

        public bool Expanded { get; set; }

        public List<DTCSubItem> SubItems {get; set;}
        
    }
}
