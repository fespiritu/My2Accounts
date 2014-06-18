using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2AccountsInAGlance.Model
{
    public class WatchList
    {
        public WatchList()
        {
            Securities = new HashSet<Security>();

        }

        public int Id { get; set; }
        public string Title { get; set; }

        //Navigation
        public virtual ICollection<Security> Securities { get; set; }
    }
}
