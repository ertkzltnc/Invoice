using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Invoice.Entity
{
    public class City
    {
        public City()
        {
            this.countries = new HashSet<County>();
            
        }
        
        public int CityID { get; set; }
        
        public string Description { get; set; }

        public virtual ICollection<County> countries { get; set; }
       
    }
}
