using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trang_Granville
{
    public class Outsourced : Part
    {
        private string companyName;
        public string CompanyName { get; set; }
        public Outsourced(int ID, string name, int inStock, decimal price, int min, int max, string companyName)
        {
            PartID = ID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;           
        }
    }
}
