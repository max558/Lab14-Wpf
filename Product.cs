using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14___WpfApp
{
    public enum CategoryProducts
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string NameProduct { set; get; }
        public double PriceProduct { set; get; }
        public string ImagePathProduct { set; get; }
        public CategoryProducts CategoryProduct { set; get; }
        
    }
}
